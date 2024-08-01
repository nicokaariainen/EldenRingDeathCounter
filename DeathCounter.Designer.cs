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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addDeathButton = new System.Windows.Forms.Button();
            this.removeDeathButton = new System.Windows.Forms.Button();
            this.startDeathCounterButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.readTextLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Garamond", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 124);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 124);
            this.panel1.TabIndex = 1;
            // 
            // addDeathButton
            // 
            this.addDeathButton.BackColor = System.Drawing.Color.DimGray;
            this.addDeathButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addDeathButton.Font = new System.Drawing.Font("Garamond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDeathButton.ForeColor = System.Drawing.Color.LightGray;
            this.addDeathButton.Location = new System.Drawing.Point(-1, 3);
            this.addDeathButton.Name = "addDeathButton";
            this.addDeathButton.Size = new System.Drawing.Size(92, 75);
            this.addDeathButton.TabIndex = 2;
            this.addDeathButton.Text = "+";
            this.addDeathButton.UseCompatibleTextRendering = true;
            this.addDeathButton.UseVisualStyleBackColor = false;
            this.addDeathButton.Click += new System.EventHandler(this.addDeathButton_Click);
            // 
            // removeDeathButton
            // 
            this.removeDeathButton.BackColor = System.Drawing.Color.DimGray;
            this.removeDeathButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.removeDeathButton.Font = new System.Drawing.Font("Garamond", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeDeathButton.ForeColor = System.Drawing.Color.LightGray;
            this.removeDeathButton.Location = new System.Drawing.Point(106, 3);
            this.removeDeathButton.Name = "removeDeathButton";
            this.removeDeathButton.Size = new System.Drawing.Size(93, 75);
            this.removeDeathButton.TabIndex = 3;
            this.removeDeathButton.Text = "–";
            this.removeDeathButton.UseCompatibleTextRendering = true;
            this.removeDeathButton.UseVisualStyleBackColor = false;
            this.removeDeathButton.Click += new System.EventHandler(this.removeDeathButton_Click);
            // 
            // startDeathCounterButton
            // 
            this.startDeathCounterButton.BackColor = System.Drawing.Color.DimGray;
            this.startDeathCounterButton.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDeathCounterButton.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.startDeathCounterButton.Location = new System.Drawing.Point(17, 277);
            this.startDeathCounterButton.Name = "startDeathCounterButton";
            this.startDeathCounterButton.Size = new System.Drawing.Size(199, 76);
            this.startDeathCounterButton.TabIndex = 4;
            this.startDeathCounterButton.Text = "START";
            this.startDeathCounterButton.UseCompatibleTextRendering = true;
            this.startDeathCounterButton.UseVisualStyleBackColor = false;
            this.startDeathCounterButton.Click += new System.EventHandler(this.startDeathCounterButton_Click_1);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(17, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Take screenshot";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(34, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Preprocess";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(35, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Read text";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // readTextLabel
            // 
            this.readTextLabel.AutoSize = true;
            this.readTextLabel.Location = new System.Drawing.Point(163, 398);
            this.readTextLabel.Name = "readTextLabel";
            this.readTextLabel.Size = new System.Drawing.Size(35, 13);
            this.readTextLabel.TabIndex = 8;
            this.readTextLabel.Text = "label2";
            this.readTextLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.removeDeathButton);
            this.panel2.Controls.Add(this.addDeathButton);
            this.panel2.Location = new System.Drawing.Point(18, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(199, 78);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 54);
            this.label2.TabIndex = 10;
            this.label2.Text = "DEATHS";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 54);
            this.label3.TabIndex = 10;
            this.label3.Text = "DEATHS";
            this.label3.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // DeathCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(235, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.readTextLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.startDeathCounterButton);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DeathCounter";
            this.Text = "Elden Ring Death Counter";
            this.Load += new System.EventHandler(this.DeathCounter_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

