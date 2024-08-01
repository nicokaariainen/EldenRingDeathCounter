using System.Drawing.Imaging;
using System.Text.Json;
using Tesseract;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace EldenRingDeathCounter
{
    public partial class DeathCounter : Form
    {
        private bool _deathCountingEnabled = false;
        private SaveData _saveData;
        private readonly string _saveFileName = "deaths.json";

        public DeathCounter()
        {
            InitializeComponent();
        }

        private void DeathCounter_Load(object sender, EventArgs e)
        {
            if (!File.Exists(_saveFileName))
            {
                var file = File.Create(_saveFileName);
                file.Dispose();
                Thread.Sleep(200);
            }
            using (var r = new StreamReader(_saveFileName))
            {
                string json = r.ReadToEnd();
                try
                {
                    var saveData = JsonSerializer.Deserialize<SaveData>(json);
                    _saveData = saveData;
                } 
                catch(Exception ex)
                {
                    MessageBox.Show($"Reading save file failed. Reverting save data to default.");
                    _saveData = new SaveData()
                    {
                        DeathCount = 0,
                        LastDeathDate = DateTime.MinValue,
                    };
                }
            }
            label1.Text = _saveData.DeathCount.ToString();
            SaveDeaths();
        }

        private void addDeathButton_Click(object sender, EventArgs e)
        {
            AddDeath();
        }

        private void removeDeathButton_Click(object sender, EventArgs e)
        {
            if (_saveData.DeathCount > 0)
                _saveData.DeathCount -= 1;
            label1.Text = _saveData.DeathCount.ToString();
            SaveDeaths();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void startDeathCounterButton_Click_1(object sender, EventArgs e)
        {
            if (_deathCountingEnabled)
            {
                _deathCountingEnabled = false;
                startDeathCounterButton.Text = "START";
                startDeathCounterButton.ForeColor = Color.MediumSeaGreen;
            }
            else
            {
                _deathCountingEnabled = true;
                startDeathCounterButton.Text = "STOP";
                startDeathCounterButton.ForeColor = Color.Red;
                CountDeaths();
            }
        }

        private async void CountDeaths()
        {
            while (_deathCountingEnabled)
            {
                var imagePaths = CaptureScreens();
                var processedImagePaths = PreProcessImages(imagePaths);
                foreach (var path in processedImagePaths)
                {
                    await ReadYouDied(path);
                }
                System.Windows.Forms.Application.DoEvents();
                await Task.Delay(500);
            }
        }

        private static string[] PreProcessImages(string[] paths)
        {
            var processedImagePaths = new string[paths.Length];
            for (int i = 0; i < paths.Length; i++)
            {
                var img = CvInvoke.Imread(paths[i], ImreadModes.AnyColor);

                // Convert to HSV from RGB for detecting the color red
                CvInvoke.CvtColor(img, img, ColorConversion.Rgb2Hsv);

                // Create mask from red color and apply (should pick out only the "you died" text to the mask)
                using var mask = Mat.Zeros(img.Rows, img.Cols, img.Depth, img.NumberOfChannels);
                CvInvoke.InRange(img, new ScalarArray(new MCvScalar(115, 70, 70)), new ScalarArray(new MCvScalar(130, 255, 255)), mask);
                using var output = Mat.Zeros(img.Rows, img.Cols, img.Depth, img.NumberOfChannels);
                CvInvoke.BitwiseAnd(img, img, output, mask);
                img = output;

                // Convert back to RGB
                CvInvoke.CvtColor(img, img, ColorConversion.Hsv2Rgb);

                // Raise contrast for easier edge detection and better separate colors
                CvInvoke.AddWeighted(img, 3, img, 0, 0, img);

                // Posterization filter for reduced noise
                CvInvoke.PyrMeanShiftFiltering(img, img, 5, 10, 1, new MCvTermCriteria(5, 1));

                // Canny edge detection
                using var destImage = Mat.Zeros(img.Rows, img.Cols, img.Depth, img.NumberOfChannels);
                CvInvoke.Canny(img, destImage, 50, 50);

                // Commented out contour drawing but don't want to get rid of it

                //CvInvoke.GaussianBlur(destImage, destImage, Size.Empty, 0.5, 0);
                //var contours = new VectorOfVectorOfPoint();
                //var heirarchy = new Mat();
                //CvInvoke.FindContours(destImage, contours, heirarchy, RetrType.List, ChainApproxMethod.ChainApproxSimple);
                //for (var j = 0; j < contours.Size; j++)
                //{
                //    if (CvInvoke.ContourArea(contours[j]) > 50)
                //    {
                //        CvInvoke.DrawContours(destImage, contours, j, new MCvScalar(255, 255, 255), -1);
                //    }
                //}

                // Invert colors because the text detection works best with black text on white background
                CvInvoke.BitwiseNot(destImage, destImage);

                destImage.Save($"processed{i}.jpg");
                processedImagePaths[i] = $"processed{i}.jpg";
                img.Dispose();
            }

            return processedImagePaths;
        }

        private static string[] CaptureScreens()
        {
            const float screenshotWidthPercentage = 0.25f;
            const float screenshotHeightPercentage = 0.12f;
            const float youDiedWidthFromScreenWidth = 0.38f;
            const float youDiedHeightFromScreenHeight = 0.45f;

            var imagePaths = new string[Screen.AllScreens.Length];
            for (var i = 0; i < Screen.AllScreens.Length; i++)
            {
                // TODO Capture whole screen to save the moment of death
                using var captureBitmap = new Bitmap(
                    Convert.ToInt32(Screen.AllScreens[i].Bounds.Width * screenshotWidthPercentage),
                    Convert.ToInt32(Screen.AllScreens[i].Bounds.Height * screenshotHeightPercentage), PixelFormat.Format32bppArgb);
                var captureRectangle = Screen.AllScreens[i].Bounds;
                captureRectangle.Width = Convert.ToInt32(Screen.AllScreens[i].Bounds.Width * screenshotWidthPercentage);
                captureRectangle.Height = Convert.ToInt32(Screen.AllScreens[i].Bounds.Height * screenshotHeightPercentage);
                using var captureGraphics = Graphics.FromImage(captureBitmap);
                captureGraphics.CopyFromScreen(captureRectangle.Left + Convert.ToInt32(Screen.AllScreens[i].Bounds.Width * youDiedWidthFromScreenWidth), captureRectangle.Top + Convert.ToInt32(Screen.AllScreens[i].Bounds.Height * youDiedHeightFromScreenHeight), 0, 0, captureRectangle.Size);
                captureBitmap.Save($"screen{i}.jpg", System.Drawing.Imaging.ImageFormat.Png);
                imagePaths[i] = $"screen{i}.jpg";
            }

            return imagePaths;
        }

        private async Task ReadYouDied(string path)
        {
            using (var engine = new TesseractEngine("tessdata", "eng", EngineMode.Default))
            {
                using (var img = Pix.LoadFromFile(path))
                {
                    using (var result = engine.Process(img))
                    {
                        var text = result.GetText();
                        Console.WriteLine(text);
                        readTextLabel.Text = text;
                        Console.WriteLine("Mean confidence: {0}", result.GetMeanConfidence());
                        if (text.ToLower().Contains("died") || text.ToLower().Contains("you"))
                        {
                            // Add death and wait 10s to avoid duplicates
                            AddDeath();
                            await Task.Delay(10000);
                        }
                    }
                    
                }

            }
        }

        private void AddDeath()
        {
            _saveData.DeathCount++;
            label1.Text = _saveData.DeathCount.ToString();
            _saveData.LastDeathDate = DateTime.UtcNow;
            SaveDeaths();
            // TODO: save to file
        }

        private void SaveDeaths()
        {
            var jsonString = JsonSerializer.Serialize(_saveData);
            File.WriteAllText(_saveFileName, jsonString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaptureScreens();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PreProcessImages(new []{"screen0.jpg"});
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            await ReadYouDied("processed0.jpg");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
