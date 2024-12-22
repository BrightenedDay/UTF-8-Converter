namespace UTF8_Converter
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            roundedButton2 = new RoundedButton();
            roundedButton3 = new RoundedButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(4, 402);
            label1.Name = "label1";
            label1.Size = new Size(357, 25);
            label1.TabIndex = 2;
            label1.Text = "Please select file...";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.arrow_down;
            pictureBox1.Location = new Point(119, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // roundedButton2
            // 
            roundedButton2.BackColor = Color.FromArgb(243, 243, 243);
            roundedButton2.BorderColor = Color.Black;
            roundedButton2.BorderRadius = 20;
            roundedButton2.BorderSize = 1;
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.ForeColor = Color.Black;
            roundedButton2.HoverColor = Color.LightGray;
            roundedButton2.Location = new Point(123, 29);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.PressedColor = Color.DarkGray;
            roundedButton2.ReturnColor = Color.FromArgb(243, 243, 243);
            roundedButton2.Size = new Size(114, 50);
            roundedButton2.TabIndex = 4;
            roundedButton2.Text = "Select file to convert";
            roundedButton2.UseVisualStyleBackColor = false;
            roundedButton2.Click += roundedButton1_Click;
            // 
            // roundedButton3
            // 
            roundedButton3.BackColor = Color.FromArgb(243, 243, 243);
            roundedButton3.BorderColor = Color.Black;
            roundedButton3.BorderRadius = 20;
            roundedButton3.BorderSize = 1;
            roundedButton3.FlatAppearance.BorderSize = 0;
            roundedButton3.FlatStyle = FlatStyle.Flat;
            roundedButton3.ForeColor = Color.Black;
            roundedButton3.HoverColor = Color.LightGray;
            roundedButton3.Location = new Point(123, 235);
            roundedButton3.Name = "roundedButton3";
            roundedButton3.PressedColor = Color.DarkGray;
            roundedButton3.ReturnColor = Color.FromArgb(243, 243, 243);
            roundedButton3.Size = new Size(114, 50);
            roundedButton3.TabIndex = 5;
            roundedButton3.Text = "Convert";
            roundedButton3.UseVisualStyleBackColor = false;
            roundedButton3.Click += convertButton_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 243);
            ClientSize = new Size(365, 450);
            Controls.Add(roundedButton3);
            Controls.Add(roundedButton2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UTF-8 Converter";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private RoundedButton roundedButton2;
        private RoundedButton roundedButton3;
    }
}
