namespace EldenRingDeathCounter
{
    partial class DeathCounter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            addDeathButton = new Button();
            removeDeathButton = new Button();
            startDeathCounterButton = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            readTextLabel = new Label();
            panel2 = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Garamond", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(3, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(229, 143);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 73);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(233, 143);
            panel1.TabIndex = 1;
            // 
            // addDeathButton
            // 
            addDeathButton.BackColor = Color.DimGray;
            addDeathButton.BackgroundImageLayout = ImageLayout.Center;
            addDeathButton.Font = new Font("Garamond", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addDeathButton.ForeColor = Color.LightGray;
            addDeathButton.Location = new Point(-1, 3);
            addDeathButton.Margin = new Padding(4, 3, 4, 3);
            addDeathButton.Name = "addDeathButton";
            addDeathButton.Size = new Size(107, 87);
            addDeathButton.TabIndex = 2;
            addDeathButton.Text = "+";
            addDeathButton.UseCompatibleTextRendering = true;
            addDeathButton.UseVisualStyleBackColor = false;
            addDeathButton.Click += addDeathButton_Click;
            // 
            // removeDeathButton
            // 
            removeDeathButton.BackColor = Color.DimGray;
            removeDeathButton.BackgroundImageLayout = ImageLayout.None;
            removeDeathButton.Font = new Font("Garamond", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            removeDeathButton.ForeColor = Color.LightGray;
            removeDeathButton.Location = new Point(124, 3);
            removeDeathButton.Margin = new Padding(4, 3, 4, 3);
            removeDeathButton.Name = "removeDeathButton";
            removeDeathButton.Size = new Size(108, 87);
            removeDeathButton.TabIndex = 3;
            removeDeathButton.Text = "–";
            removeDeathButton.UseCompatibleTextRendering = true;
            removeDeathButton.UseVisualStyleBackColor = false;
            removeDeathButton.Click += removeDeathButton_Click;
            // 
            // startDeathCounterButton
            // 
            startDeathCounterButton.BackColor = Color.DimGray;
            startDeathCounterButton.Font = new Font("Garamond", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            startDeathCounterButton.ForeColor = Color.MediumSeaGreen;
            startDeathCounterButton.Location = new Point(20, 320);
            startDeathCounterButton.Margin = new Padding(4, 3, 4, 3);
            startDeathCounterButton.Name = "startDeathCounterButton";
            startDeathCounterButton.Size = new Size(232, 88);
            startDeathCounterButton.TabIndex = 4;
            startDeathCounterButton.Text = "START";
            startDeathCounterButton.UseCompatibleTextRendering = true;
            startDeathCounterButton.UseVisualStyleBackColor = false;
            startDeathCounterButton.Click += startDeathCounterButton_Click_1;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(20, 414);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(134, 27);
            button1.TabIndex = 5;
            button1.Text = "Take screenshot";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(40, 479);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(88, 27);
            button2.TabIndex = 6;
            button2.Text = "Preprocess";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(41, 448);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(88, 27);
            button3.TabIndex = 7;
            button3.Text = "Read text";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // readTextLabel
            // 
            readTextLabel.AutoSize = true;
            readTextLabel.Location = new Point(190, 459);
            readTextLabel.Margin = new Padding(4, 0, 4, 0);
            readTextLabel.Name = "readTextLabel";
            readTextLabel.Size = new Size(38, 15);
            readTextLabel.TabIndex = 8;
            readTextLabel.Text = "label2";
            readTextLabel.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(removeDeathButton);
            panel2.Controls.Add(addDeathButton);
            panel2.Location = new Point(21, 223);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(232, 90);
            panel2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Garamond", 42F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(15, 9);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(247, 73);
            label3.TabIndex = 10;
            label3.Text = "DEATHS";
            label3.UseCompatibleTextRendering = true;
            label3.Click += label2_Click_1;
            // 
            // DeathCounter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(274, 519);
            Controls.Add(panel2);
            Controls.Add(readTextLabel);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(startDeathCounterButton);
            Controls.Add(panel1);
            Controls.Add(label3);
            ForeColor = SystemColors.ControlLightLight;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "DeathCounter";
            Text = "Elden Ring Death Counter";
            Load += DeathCounter_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addDeathButton;
        private System.Windows.Forms.Button removeDeathButton;
        private System.Windows.Forms.Button startDeathCounterButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label readTextLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}

