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
            frameDelay = new Label();
            animationDelayLabel = new Label();
            label17 = new Label();
            animationIterations = new NumericUpDown();
            quality = new NumericUpDown();
            compressionMode = new ComboBox();
            label16 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            fbs = new Label();
            label15 = new Label();
            label21 = new Label();
            label22 = new Label();
            outputFrameHeight = new NumericUpDown();
            outputFrameWidth = new NumericUpDown();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            resizeMode = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)frameWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frameHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)animationDelay).BeginInit();
            ((System.ComponentModel.ISupportInitialize)animationIterations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)quality).BeginInit();
            ((System.ComponentModel.ISupportInitialize)outputFrameHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)outputFrameWidth).BeginInit();
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
            label5.Location = new Point(247, 128);
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
            label6.Location = new Point(100, 174);
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
            label7.Location = new Point(50, 275);
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
            label8.Location = new Point(191, 235);
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
            saveFolder.Location = new Point(243, 422);
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
            label9.Location = new Point(16, 426);
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
            label10.Location = new Point(334, 426);
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
            animationDelay.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            animationDelay.Name = "animationDelay";
            animationDelay.Size = new Size(56, 23);
            animationDelay.TabIndex = 18;
            animationDelay.Value = new decimal(new int[] { 3, 0, 0, 0 });
            animationDelay.ValueChanged += AnimationDelay_ValueChanged;
            // 
            // frameDelay
            // 
            frameDelay.AutoSize = true;
            frameDelay.Font = new Font("Segoe UI", 10F);
            frameDelay.Location = new Point(357, 130);
            frameDelay.Name = "frameDelay";
            frameDelay.Size = new Size(47, 19);
            frameDelay.TabIndex = 19;
            frameDelay.Text = "30 ms";
            // 
            // animationDelayLabel
            // 
            animationDelayLabel.AutoSize = true;
            animationDelayLabel.Font = new Font("Segoe UI", 12F);
            animationDelayLabel.Location = new Point(12, 127);
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
            label17.Location = new Point(456, 125);
            label17.Name = "label17";
            label17.Size = new Size(43, 21);
            label17.TabIndex = 21;
            label17.Text = "FBS :";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // animationIterations
            // 
            animationIterations.Location = new Point(264, 174);
            animationIterations.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            animationIterations.Name = "animationIterations";
            animationIterations.Size = new Size(56, 23);
            animationIterations.TabIndex = 22;
            // 
            // quality
            // 
            quality.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            quality.Location = new Point(263, 235);
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
            compressionMode.Location = new Point(209, 273);
            compressionMode.Name = "compressionMode";
            compressionMode.Size = new Size(163, 23);
            compressionMode.TabIndex = 24;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F);
            label16.Location = new Point(378, 275);
            label16.Name = "label16";
            label16.RightToLeft = RightToLeft.Yes;
            label16.Size = new Size(110, 21);
            label16.TabIndex = 25;
            label16.Text = "طريقة الضغط :";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F);
            label18.Location = new Point(326, 235);
            label18.Name = "label18";
            label18.RightToLeft = RightToLeft.Yes;
            label18.Size = new Size(59, 21);
            label18.TabIndex = 26;
            label18.Text = "الجودة :";
            label18.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F);
            label19.Location = new Point(326, 174);
            label19.Name = "label19";
            label19.RightToLeft = RightToLeft.Yes;
            label19.Size = new Size(136, 21);
            label19.TabIndex = 27;
            label19.Text = "عدد تكرار الأنيمشن :";
            label19.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 12F);
            label20.Location = new Point(87, 199);
            label20.Name = "label20";
            label20.RightToLeft = RightToLeft.Yes;
            label20.Size = new Size(402, 21);
            label20.TabIndex = 28;
            label20.Text = "ولكن صفر تعني إلى ما لا نهاية          But zero means infinity";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fbs
            // 
            fbs.AutoSize = true;
            fbs.Font = new Font("Segoe UI", 12F);
            fbs.Location = new Point(505, 125);
            fbs.Name = "fbs";
            fbs.Size = new Size(28, 21);
            fbs.TabIndex = 29;
            fbs.Text = "33";
            fbs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(295, 390);
            label15.Name = "label15";
            label15.Size = new Size(37, 15);
            label15.TabIndex = 37;
            label15.Text = "pixels";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F);
            label21.Location = new Point(347, 385);
            label21.Name = "label21";
            label21.RightToLeft = RightToLeft.Yes;
            label21.Size = new Size(129, 21);
            label21.TabIndex = 35;
            label21.Text = "إرتفاع الإطار الناتج :";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 12F);
            label22.Location = new Point(346, 358);
            label22.Name = "label22";
            label22.RightToLeft = RightToLeft.Yes;
            label22.Size = new Size(130, 21);
            label22.TabIndex = 34;
            label22.Text = "عرض الإطار الناتج :";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // outputFrameHeight
            // 
            outputFrameHeight.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            outputFrameHeight.Location = new Point(244, 386);
            outputFrameHeight.Maximum = new decimal(new int[] { 512, 0, 0, 0 });
            outputFrameHeight.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            outputFrameHeight.Name = "outputFrameHeight";
            outputFrameHeight.Size = new Size(50, 23);
            outputFrameHeight.TabIndex = 33;
            outputFrameHeight.Value = new decimal(new int[] { 240, 0, 0, 0 });
            // 
            // outputFrameWidth
            // 
            outputFrameWidth.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            outputFrameWidth.Location = new Point(244, 357);
            outputFrameWidth.Maximum = new decimal(new int[] { 512, 0, 0, 0 });
            outputFrameWidth.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            outputFrameWidth.Name = "outputFrameWidth";
            outputFrameWidth.Size = new Size(50, 23);
            outputFrameWidth.TabIndex = 32;
            outputFrameWidth.Value = new decimal(new int[] { 240, 0, 0, 0 });
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.Location = new Point(74, 385);
            label23.Name = "label23";
            label23.Size = new Size(164, 21);
            label23.TabIndex = 31;
            label23.Text = "Output Frame Height :";
            label23.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 12F);
            label24.Location = new Point(74, 357);
            label24.Name = "label24";
            label24.Size = new Size(160, 21);
            label24.TabIndex = 30;
            label24.Text = "Output Frame Width :";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(295, 362);
            label25.Name = "label25";
            label25.Size = new Size(37, 15);
            label25.TabIndex = 36;
            label25.Text = "pixels";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F);
            label26.Location = new Point(4, 321);
            label26.Name = "label26";
            label26.Size = new Size(282, 21);
            label26.TabIndex = 38;
            label26.Text = "Change the size of the resulting image :";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 12F);
            label27.Location = new Point(384, 321);
            label27.Name = "label27";
            label27.RightToLeft = RightToLeft.Yes;
            label27.Size = new Size(174, 21);
            label27.TabIndex = 39;
            label27.Text = "تغيير حجم الصورة الناتجة :";
            // 
            // resizeMode
            // 
            resizeMode.DropDownStyle = ComboBoxStyle.DropDownList;
            resizeMode.FormattingEnabled = true;
            resizeMode.Items.AddRange(new object[] { "No   لا", "Resize   أفضل", "Scale   أسرع" });
            resizeMode.Location = new Point(283, 321);
            resizeMode.Name = "resizeMode";
            resizeMode.Size = new Size(102, 23);
            resizeMode.TabIndex = 40;
            resizeMode.SelectedIndexChanged += ResizeMode_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 462);
            Controls.Add(resizeMode);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(label15);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(outputFrameHeight);
            Controls.Add(outputFrameWidth);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(label25);
            Controls.Add(fbs);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label16);
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
            Controls.Add(frameDelay);
            Controls.Add(label20);
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
            ((System.ComponentModel.ISupportInitialize)outputFrameHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)outputFrameWidth).EndInit();
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
        private Label frameDelay;
        private Label animationDelayLabel;
        private Label label17;
        private NumericUpDown animationIterations;
        private NumericUpDown quality;
        private ComboBox compressionMode;
        private Label label16;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label fbs;
        private Label label15;
        private Label label21;
        private Label label22;
        private NumericUpDown outputFrameHeight;
        private NumericUpDown outputFrameWidth;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private ComboBox resizeMode;
    }
}
