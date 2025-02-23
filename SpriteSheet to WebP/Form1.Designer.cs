namespace SpriteSheet_to_WebP
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            openFolder = new Button();
            folderBDialog = new FolderBrowserDialog();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            saveFolder = new Button();
            label9 = new Label();
            label10 = new Label();
            frameWidth = new NumericUpDown();
            frameHeight = new NumericUpDown();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            animationDelay = new NumericUpDown();
            label15 = new Label();
            animationDelayLabel = new Label();
            label17 = new Label();
            animationIterations = new NumericUpDown();
            quality = new NumericUpDown();
            compressionMode = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)frameWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frameHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)animationDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)animationIterations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quality).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(322, 9);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(228, 21);
            label1.TabIndex = 0;
            label1.Text = "إختر مجلد ملفات الـ Sprite-Sheet :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(226, 21);
            label2.TabIndex = 1;
            label2.Text = "Select the Sprite-Sheets folder :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openFolder
            // 
            openFolder.FlatStyle = FlatStyle.Popup;
            openFolder.Font = new Font("Segoe UI", 12F);
            openFolder.Location = new Point(244, 5);
            openFolder.Name = "openFolder";
            openFolder.Size = new Size(72, 28);
            openFolder.TabIndex = 2;
            openFolder.Text = "...";
            openFolder.TextAlign = ContentAlignment.TopCenter;
            openFolder.UseVisualStyleBackColor = true;
            openFolder.Click += OpenFolder_Click;
            // 
            // folderBDialog
            // 
            folderBDialog.ShowNewFolderButton = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(114, 51);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 3;
            label3.Text = "Frame Width :";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(114, 79);
            label4.Name = "label4";
            label4.Size = new Size(111, 21);
            label4.TabIndex = 4;
            label4.Text = "Frame Height :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(239, 128);
            label5.Name = "label5";
            label5.Size = new Size(104, 21);
            label5.TabIndex = 5;
            label5.Text = "Frame Delay :";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(12, 171);
            label6.Name = "label6";
            label6.Size = new Size(158, 21);
            label6.TabIndex = 6;
            label6.Text = "Animation Iterations :";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(12, 261);
            label7.Name = "label7";
            label7.Size = new Size(153, 21);
            label7.TabIndex = 7;
            label7.Text = "Compression Mode :";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(12, 226);
            label8.Name = "label8";
            label8.Size = new Size(67, 21);
            label8.TabIndex = 8;
            label8.Text = "Quality :";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saveFolder
            // 
            saveFolder.FlatStyle = FlatStyle.Popup;
            saveFolder.Font = new Font("Segoe UI", 12F);
            saveFolder.Location = new Point(239, 314);
            saveFolder.Name = "saveFolder";
            saveFolder.Size = new Size(85, 28);
            saveFolder.TabIndex = 11;
            saveFolder.Text = "...";
            saveFolder.TextAlign = ContentAlignment.TopCenter;
            saveFolder.UseVisualStyleBackColor = true;
            saveFolder.Click += SaveFolder_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.Location = new Point(12, 318);
            label9.Name = "label9";
            label9.Size = new Size(221, 21);
            label9.TabIndex = 10;
            label9.Text = "Select the output webp folder :";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F);
            label10.Location = new Point(330, 318);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(220, 21);
            label10.TabIndex = 9;
            label10.Text = "إختر مجلد ملفات الـ webp الناتجة:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frameWidth
            // 
            frameWidth.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            frameWidth.Location = new Point(244, 51);
            frameWidth.Maximum = new decimal(new int[] { 512, 0, 0, 0 });
            frameWidth.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            frameWidth.Name = "frameWidth";
            frameWidth.Size = new Size(50, 23);
            frameWidth.TabIndex = 12;
            frameWidth.Value = new decimal(new int[] { 240, 0, 0, 0 });
            // 
            // frameHeight
            // 
            frameHeight.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            frameHeight.Location = new Point(244, 80);
            frameHeight.Maximum = new decimal(new int[] { 512, 0, 0, 0 });
            frameHeight.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            frameHeight.Name = "frameHeight";
            frameHeight.Size = new Size(50, 23);
            frameHeight.TabIndex = 13;
            frameHeight.Value = new decimal(new int[] { 240, 0, 0, 0 });
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F);
            label11.Location = new Point(346, 52);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.Yes;
            label11.Size = new Size(94, 21);
            label11.TabIndex = 14;
            label11.Text = "عرض الإطار :";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F);
            label12.Location = new Point(347, 79);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.Yes;
            label12.Size = new Size(93, 21);
            label12.TabIndex = 15;
            label12.Text = "إرتفاع الإطار :";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(295, 56);
            label13.Name = "label13";
            label13.Size = new Size(37, 15);
            label13.TabIndex = 16;
            label13.Text = "pixels";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(295, 84);
            label14.Name = "label14";
            label14.Size = new Size(37, 15);
            label14.TabIndex = 17;
            label14.Text = "pixels";
            // 
            // animationDelay
            // 
            animationDelay.Location = new Point(150, 128);
            animationDelay.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            animationDelay.Name = "animationDelay";
            animationDelay.Size = new Size(56, 23);
            animationDelay.TabIndex = 18;
            animationDelay.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(377, 134);
            label15.Name = "label15";
            label15.Size = new Size(23, 15);
            label15.TabIndex = 19;
            label15.Text = "ms";
            // 
            // animationDelayLabel
            // 
            animationDelayLabel.AutoSize = true;
            animationDelayLabel.Font = new Font("Segoe UI", 12F);
            animationDelayLabel.Location = new Point(12, 126);
            animationDelayLabel.Name = "animationDelayLabel";
            animationDelayLabel.Size = new Size(132, 21);
            animationDelayLabel.TabIndex = 20;
            animationDelayLabel.Text = "Animation Delay :";
            animationDelayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F);
            label17.Location = new Point(446, 128);
            label17.Name = "label17";
            label17.Size = new Size(43, 21);
            label17.TabIndex = 21;
            label17.Text = "FBS :";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // animationIterations
            // 
            animationIterations.Location = new Point(176, 171);
            animationIterations.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            animationIterations.Name = "animationIterations";
            animationIterations.Size = new Size(56, 23);
            animationIterations.TabIndex = 22;
            // 
            // quality
            // 
            quality.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            quality.Location = new Point(85, 224);
            quality.Minimum = new decimal(new int[] { 60, 0, 0, 0 });
            quality.Name = "quality";
            quality.Size = new Size(56, 23);
            quality.TabIndex = 23;
            quality.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // compressionMode
            // 
            compressionMode.DropDownStyle = ComboBoxStyle.DropDownList;
            compressionMode.FormattingEnabled = true;
            compressionMode.Items.AddRange(new object[] { "default   بدون ضغط", "lossless   بدون فقد", "lossy   ضغط بجودة محسنة" });
            compressionMode.Location = new Point(196, 259);
            compressionMode.Name = "compressionMode";
            compressionMode.Size = new Size(163, 23);
            compressionMode.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 360);
            Controls.Add(compressionMode);
            Controls.Add(quality);
            Controls.Add(animationIterations);
            Controls.Add(label17);
            Controls.Add(animationDelayLabel);
            Controls.Add(animationDelay);
            Controls.Add(label14);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(frameHeight);
            Controls.Add(frameWidth);
            Controls.Add(saveFolder);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(openFolder);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label13);
            Controls.Add(label15);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Convert Sprite Sheet Image To Animated WebP Image v1.0";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)frameWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)frameHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)animationDelay).EndInit();
            ((System.ComponentModel.ISupportInitialize)animationIterations).EndInit();
            ((System.ComponentModel.ISupportInitialize)quality).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button openFolder;
        private FolderBrowserDialog folderBDialog;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button saveFolder;
        private Label label9;
        private Label label10;
        private NumericUpDown frameWidth;
        private NumericUpDown frameHeight;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private NumericUpDown animationDelay;
        private Label label15;
        private Label animationDelayLabel;
        private Label label17;
        private NumericUpDown animationIterations;
        private NumericUpDown quality;
        private ComboBox compressionMode;
    }
}
