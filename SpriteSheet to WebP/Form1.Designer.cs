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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            openFolder = new Button();
            folderBDialog = new FolderBrowserDialog();
            widthEnglishLabel = new Label();
            heightEnglishLabel = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            saveFolder = new Button();
            label9 = new Label();
            label10 = new Label();
            frameWidth = new NumericUpDown();
            frameHeight = new NumericUpDown();
            widthArabicLabel = new Label();
            heightArabicLabel = new Label();
            pix1Label = new Label();
            pix2Label = new Label();
            frameDelay = new NumericUpDown();
            msLabel = new Label();
            frameDelayLabel = new Label();
            label17 = new Label();
            animationIterations = new NumericUpDown();
            quality = new NumericUpDown();
            compressionMode = new ComboBox();
            label16 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            fbs = new Label();
            pix4Label = new Label();
            label21 = new Label();
            label22 = new Label();
            outputFrameHeight = new NumericUpDown();
            outputFrameWidth = new NumericUpDown();
            label23 = new Label();
            label24 = new Label();
            pix3Label = new Label();
            label26 = new Label();
            label27 = new Label();
            resizeMode = new ComboBox();
            losslessCheckBox = new CheckBox();
            label28 = new Label();
            label29 = new Label();
            progressBar = new ProgressBar();
            format = new ComboBox();
            label30 = new Label();
            spritesNumberCheck = new CheckBox();
            ratio = new CheckBox();
            totalTimeCheck = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)frameWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frameHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)frameDelay).BeginInit();
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
            label1.Location = new Point(334, 9);
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
            label2.Location = new Point(17, 9);
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
            openFolder.Location = new Point(253, 5);
            openFolder.Name = "openFolder";
            openFolder.Size = new Size(72, 28);
            openFolder.TabIndex = 2;
            openFolder.Text = "...";
            openFolder.TextAlign = ContentAlignment.TopCenter;
            openFolder.UseVisualStyleBackColor = true;
            openFolder.Click += OpenFolder_Click;
            // 
            // widthEnglishLabel
            // 
            widthEnglishLabel.AutoSize = true;
            widthEnglishLabel.Font = new Font("Segoe UI", 12F);
            widthEnglishLabel.ForeColor = Color.FromArgb(64, 64, 0);
            widthEnglishLabel.Location = new Point(60, 53);
            widthEnglishLabel.Name = "widthEnglishLabel";
            widthEnglishLabel.Size = new Size(107, 21);
            widthEnglishLabel.TabIndex = 3;
            widthEnglishLabel.Text = "Frame Width :";
            widthEnglishLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // heightEnglishLabel
            // 
            heightEnglishLabel.AutoSize = true;
            heightEnglishLabel.Font = new Font("Segoe UI", 12F);
            heightEnglishLabel.ForeColor = Color.FromArgb(64, 64, 0);
            heightEnglishLabel.Location = new Point(60, 81);
            heightEnglishLabel.Name = "heightEnglishLabel";
            heightEnglishLabel.Size = new Size(111, 21);
            heightEnglishLabel.TabIndex = 4;
            heightEnglishLabel.Text = "Frame Height :";
            heightEnglishLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.FromArgb(64, 0, 0);
            label6.Location = new Point(109, 174);
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
            label7.Location = new Point(57, 276);
            label7.Name = "label7";
            label7.Size = new Size(153, 21);
            label7.TabIndex = 7;
            label7.Text = "Compression Mode :";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(350, 244);
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
            saveFolder.Location = new Point(253, 471);
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
            label9.Location = new Point(19, 475);
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
            label10.Location = new Point(347, 475);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.Yes;
            label10.Size = new Size(220, 21);
            label10.TabIndex = 9;
            label10.Text = "إختر مجلد ملفات الـ webp الناتجة:";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frameWidth
            // 
            frameWidth.ForeColor = Color.FromArgb(64, 64, 0);
            frameWidth.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            frameWidth.Location = new Point(190, 53);
            frameWidth.Maximum = new decimal(new int[] { 512, 0, 0, 0 });
            frameWidth.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            frameWidth.Name = "frameWidth";
            frameWidth.Size = new Size(50, 23);
            frameWidth.TabIndex = 12;
            frameWidth.Value = new decimal(new int[] { 240, 0, 0, 0 });
            // 
            // frameHeight
            // 
            frameHeight.ForeColor = Color.FromArgb(64, 64, 0);
            frameHeight.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            frameHeight.Location = new Point(190, 82);
            frameHeight.Maximum = new decimal(new int[] { 512, 0, 0, 0 });
            frameHeight.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            frameHeight.Name = "frameHeight";
            frameHeight.Size = new Size(50, 23);
            frameHeight.TabIndex = 13;
            frameHeight.Value = new decimal(new int[] { 240, 0, 0, 0 });
            // 
            // widthArabicLabel
            // 
            widthArabicLabel.AutoSize = true;
            widthArabicLabel.Font = new Font("Segoe UI", 12F);
            widthArabicLabel.ForeColor = Color.FromArgb(64, 64, 0);
            widthArabicLabel.Location = new Point(292, 54);
            widthArabicLabel.Name = "widthArabicLabel";
            widthArabicLabel.RightToLeft = RightToLeft.Yes;
            widthArabicLabel.Size = new Size(94, 21);
            widthArabicLabel.TabIndex = 14;
            widthArabicLabel.Text = "عرض الإطار :";
            widthArabicLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // heightArabicLabel
            // 
            heightArabicLabel.AutoSize = true;
            heightArabicLabel.Font = new Font("Segoe UI", 12F);
            heightArabicLabel.ForeColor = Color.FromArgb(64, 64, 0);
            heightArabicLabel.Location = new Point(291, 81);
            heightArabicLabel.Name = "heightArabicLabel";
            heightArabicLabel.RightToLeft = RightToLeft.Yes;
            heightArabicLabel.Size = new Size(93, 21);
            heightArabicLabel.TabIndex = 15;
            heightArabicLabel.Text = "إرتفاع الإطار :";
            heightArabicLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pix1Label
            // 
            pix1Label.AutoSize = true;
            pix1Label.ForeColor = Color.FromArgb(64, 64, 0);
            pix1Label.Location = new Point(241, 58);
            pix1Label.Name = "pix1Label";
            pix1Label.Size = new Size(37, 15);
            pix1Label.TabIndex = 16;
            pix1Label.Text = "pixels";
            // 
            // pix2Label
            // 
            pix2Label.AutoSize = true;
            pix2Label.ForeColor = Color.FromArgb(64, 64, 0);
            pix2Label.Location = new Point(241, 86);
            pix2Label.Name = "pix2Label";
            pix2Label.Size = new Size(37, 15);
            pix2Label.TabIndex = 17;
            pix2Label.Text = "pixels";
            // 
            // frameDelay
            // 
            frameDelay.ForeColor = Color.FromArgb(0, 64, 64);
            frameDelay.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            frameDelay.Location = new Point(246, 134);
            frameDelay.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            frameDelay.Minimum = new decimal(new int[] { 20, 0, 0, 0 });
            frameDelay.Name = "frameDelay";
            frameDelay.Size = new Size(56, 23);
            frameDelay.TabIndex = 18;
            frameDelay.Value = new decimal(new int[] { 30, 0, 0, 0 });
            frameDelay.ValueChanged += FrameDelay_ValueChanged;
            // 
            // msLabel
            // 
            msLabel.AutoSize = true;
            msLabel.Font = new Font("Segoe UI", 12F);
            msLabel.ForeColor = Color.FromArgb(0, 64, 64);
            msLabel.Location = new Point(308, 136);
            msLabel.Name = "msLabel";
            msLabel.Size = new Size(31, 21);
            msLabel.TabIndex = 19;
            msLabel.Text = "ms";
            // 
            // frameDelayLabel
            // 
            frameDelayLabel.AutoSize = true;
            frameDelayLabel.Font = new Font("Segoe UI", 12F);
            frameDelayLabel.ForeColor = Color.FromArgb(0, 64, 64);
            frameDelayLabel.Location = new Point(136, 133);
            frameDelayLabel.Name = "frameDelayLabel";
            frameDelayLabel.Size = new Size(104, 21);
            frameDelayLabel.TabIndex = 20;
            frameDelayLabel.Text = "Frame Delay :";
            frameDelayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F);
            label17.ForeColor = Color.FromArgb(0, 64, 64);
            label17.Location = new Point(369, 136);
            label17.Name = "label17";
            label17.Size = new Size(43, 21);
            label17.TabIndex = 21;
            label17.Text = "FBS :";
            label17.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // animationIterations
            // 
            animationIterations.ForeColor = Color.FromArgb(64, 0, 0);
            animationIterations.Location = new Point(273, 174);
            animationIterations.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            animationIterations.Name = "animationIterations";
            animationIterations.Size = new Size(56, 23);
            animationIterations.TabIndex = 22;
            // 
            // quality
            // 
            quality.ForeColor = Color.Navy;
            quality.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            quality.Location = new Point(423, 244);
            quality.Name = "quality";
            quality.Size = new Size(56, 23);
            quality.TabIndex = 23;
            // 
            // compressionMode
            // 
            compressionMode.DropDownStyle = ComboBoxStyle.DropDownList;
            compressionMode.FormattingEnabled = true;
            compressionMode.Items.AddRange(new object[] { "default   = quality", "lossless   بدون فقد", "lossy   ضغط بجودة محسنة" });
            compressionMode.Location = new Point(216, 274);
            compressionMode.Name = "compressionMode";
            compressionMode.Size = new Size(163, 23);
            compressionMode.TabIndex = 24;
            compressionMode.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 12F);
            label16.Location = new Point(385, 276);
            label16.Name = "label16";
            label16.RightToLeft = RightToLeft.Yes;
            label16.Size = new Size(110, 21);
            label16.TabIndex = 25;
            label16.Text = "طريقة الضغط :";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            label16.Visible = false;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 12F);
            label18.ForeColor = Color.Navy;
            label18.Location = new Point(486, 244);
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
            label19.ForeColor = Color.FromArgb(64, 0, 0);
            label19.Location = new Point(335, 174);
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
            label20.ForeColor = Color.FromArgb(64, 0, 0);
            label20.Location = new Point(96, 199);
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
            fbs.ForeColor = Color.FromArgb(0, 64, 64);
            fbs.Location = new Point(418, 136);
            fbs.Name = "fbs";
            fbs.Size = new Size(49, 21);
            fbs.TabIndex = 29;
            fbs.Text = "33.33";
            fbs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pix4Label
            // 
            pix4Label.AutoSize = true;
            pix4Label.ForeColor = Color.FromArgb(0, 64, 0);
            pix4Label.Location = new Point(262, 402);
            pix4Label.Name = "pix4Label";
            pix4Label.Size = new Size(37, 15);
            pix4Label.TabIndex = 37;
            pix4Label.Text = "pixels";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F);
            label21.ForeColor = Color.FromArgb(0, 64, 0);
            label21.Location = new Point(314, 397);
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
            label22.ForeColor = Color.FromArgb(0, 64, 0);
            label22.Location = new Point(313, 370);
            label22.Name = "label22";
            label22.RightToLeft = RightToLeft.Yes;
            label22.Size = new Size(130, 21);
            label22.TabIndex = 34;
            label22.Text = "عرض الإطار الناتج :";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // outputFrameHeight
            // 
            outputFrameHeight.ForeColor = Color.FromArgb(0, 64, 0);
            outputFrameHeight.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            outputFrameHeight.Location = new Point(211, 398);
            outputFrameHeight.Maximum = new decimal(new int[] { 512, 0, 0, 0 });
            outputFrameHeight.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            outputFrameHeight.Name = "outputFrameHeight";
            outputFrameHeight.Size = new Size(50, 23);
            outputFrameHeight.TabIndex = 33;
            outputFrameHeight.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // outputFrameWidth
            // 
            outputFrameWidth.ForeColor = Color.FromArgb(0, 64, 0);
            outputFrameWidth.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            outputFrameWidth.Location = new Point(211, 369);
            outputFrameWidth.Maximum = new decimal(new int[] { 512, 0, 0, 0 });
            outputFrameWidth.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            outputFrameWidth.Name = "outputFrameWidth";
            outputFrameWidth.Size = new Size(50, 23);
            outputFrameWidth.TabIndex = 32;
            outputFrameWidth.Value = new decimal(new int[] { 120, 0, 0, 0 });
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 12F);
            label23.ForeColor = Color.FromArgb(0, 64, 0);
            label23.Location = new Point(41, 397);
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
            label24.ForeColor = Color.FromArgb(0, 64, 0);
            label24.Location = new Point(41, 369);
            label24.Name = "label24";
            label24.Size = new Size(160, 21);
            label24.TabIndex = 30;
            label24.Text = "Output Frame Width :";
            label24.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pix3Label
            // 
            pix3Label.AutoSize = true;
            pix3Label.ForeColor = Color.FromArgb(0, 64, 0);
            pix3Label.Location = new Point(262, 374);
            pix3Label.Name = "pix3Label";
            pix3Label.Size = new Size(37, 15);
            pix3Label.TabIndex = 36;
            pix3Label.Text = "pixels";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 12F);
            label26.ForeColor = Color.FromArgb(0, 64, 0);
            label26.Location = new Point(13, 333);
            label26.Name = "label26";
            label26.Size = new Size(282, 21);
            label26.TabIndex = 38;
            label26.Text = "Change the size of the resulting image :";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 12F);
            label27.ForeColor = Color.FromArgb(0, 64, 0);
            label27.Location = new Point(393, 333);
            label27.Name = "label27";
            label27.RightToLeft = RightToLeft.Yes;
            label27.Size = new Size(174, 21);
            label27.TabIndex = 39;
            label27.Text = "تغيير حجم الصورة الناتجة :";
            // 
            // resizeMode
            // 
            resizeMode.DropDownStyle = ComboBoxStyle.DropDownList;
            resizeMode.ForeColor = Color.FromArgb(0, 64, 0);
            resizeMode.FormattingEnabled = true;
            resizeMode.Items.AddRange(new object[] { "No   لا", "Resize   أفضل", "Scale   أسرع" });
            resizeMode.Location = new Point(292, 333);
            resizeMode.Name = "resizeMode";
            resizeMode.Size = new Size(102, 23);
            resizeMode.TabIndex = 40;
            resizeMode.SelectedIndexChanged += ResizeMode_SelectedIndexChanged;
            // 
            // losslessCheckBox
            // 
            losslessCheckBox.AutoSize = true;
            losslessCheckBox.Checked = true;
            losslessCheckBox.CheckState = CheckState.Checked;
            losslessCheckBox.Font = new Font("Segoe UI", 12F);
            losslessCheckBox.ForeColor = Color.Navy;
            losslessCheckBox.Location = new Point(70, 244);
            losslessCheckBox.Name = "losslessCheckBox";
            losslessCheckBox.RightToLeft = RightToLeft.Yes;
            losslessCheckBox.Size = new Size(156, 25);
            losslessCheckBox.TabIndex = 41;
            losslessCheckBox.Text = "lossless - بدون فقد";
            losslessCheckBox.TextAlign = ContentAlignment.MiddleCenter;
            losslessCheckBox.UseVisualStyleBackColor = true;
            // 
            // label28
            // 
            label28.Font = new Font("Segoe UI", 12F);
            label28.ForeColor = Color.FromArgb(64, 0, 64);
            label28.Location = new Point(244, 263);
            label28.Name = "label28";
            label28.RightToLeft = RightToLeft.Yes;
            label28.Size = new Size(341, 53);
            label28.TabIndex = 42;
            label28.Text = "يمكنك تعيين الجودة=صفر وتفعيل خيار \"بدون فقد\" للحصول على افضل جودة ممكنة مع اقل حجم";
            label28.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            label29.Font = new Font("Segoe UI", 12F);
            label29.ForeColor = Color.FromArgb(64, 0, 64);
            label29.Location = new Point(-4, 263);
            label29.Name = "label29";
            label29.Size = new Size(244, 53);
            label29.TabIndex = 43;
            label29.Text = "Set quality=0 and ✔lossless to get best quality and lowest size";
            label29.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            progressBar.AccessibleDescription = "";
            progressBar.AccessibleName = "";
            progressBar.Location = new Point(12, 437);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(497, 23);
            progressBar.TabIndex = 44;
            // 
            // format
            // 
            format.DropDownStyle = ComboBoxStyle.DropDownList;
            format.FormattingEnabled = true;
            format.Items.AddRange(new object[] { "WebP", "Gif" });
            format.Location = new Point(514, 437);
            format.Name = "format";
            format.Size = new Size(65, 23);
            format.TabIndex = 45;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 12F);
            label30.ForeColor = Color.FromArgb(0, 0, 192);
            label30.Location = new Point(229, 245);
            label30.Name = "label30";
            label30.Size = new Size(123, 21);
            label30.TabIndex = 47;
            label30.Text = "<- webp فقط ->";
            // 
            // spritesNumberCheck
            // 
            spritesNumberCheck.AutoSize = true;
            spritesNumberCheck.Font = new Font("Segoe UI", 12F);
            spritesNumberCheck.ForeColor = Color.FromArgb(64, 64, 0);
            spritesNumberCheck.Location = new Point(420, 69);
            spritesNumberCheck.Name = "spritesNumberCheck";
            spritesNumberCheck.RightToLeft = RightToLeft.Yes;
            spritesNumberCheck.Size = new Size(128, 25);
            spritesNumberCheck.TabIndex = 48;
            spritesNumberCheck.Text = "بعدد ال sprites";
            spritesNumberCheck.TextAlign = ContentAlignment.MiddleCenter;
            spritesNumberCheck.UseVisualStyleBackColor = true;
            spritesNumberCheck.CheckedChanged += SpritesNumberCheck_CheckedChanged;
            // 
            // ratio
            // 
            ratio.AutoSize = true;
            ratio.Font = new Font("Segoe UI", 12F);
            ratio.ForeColor = Color.FromArgb(0, 64, 0);
            ratio.Location = new Point(457, 383);
            ratio.Name = "ratio";
            ratio.RightToLeft = RightToLeft.Yes;
            ratio.Size = new Size(74, 25);
            ratio.TabIndex = 49;
            ratio.Text = "بالنسبة";
            ratio.TextAlign = ContentAlignment.MiddleCenter;
            ratio.UseVisualStyleBackColor = true;
            ratio.CheckedChanged += Ratio_CheckedChanged;
            // 
            // totalTimeCheck
            // 
            totalTimeCheck.AutoSize = true;
            totalTimeCheck.Font = new Font("Segoe UI", 12F);
            totalTimeCheck.ForeColor = Color.FromArgb(0, 64, 64);
            totalTimeCheck.Location = new Point(41, 133);
            totalTimeCheck.Name = "totalTimeCheck";
            totalTimeCheck.RightToLeft = RightToLeft.Yes;
            totalTimeCheck.Size = new Size(131, 25);
            totalTimeCheck.TabIndex = 50;
            totalTimeCheck.Text = "بالوقت الإجمالي";
            totalTimeCheck.TextAlign = ContentAlignment.MiddleCenter;
            totalTimeCheck.UseVisualStyleBackColor = true;
            totalTimeCheck.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 511);
            Controls.Add(totalTimeCheck);
            Controls.Add(ratio);
            Controls.Add(spritesNumberCheck);
            Controls.Add(label30);
            Controls.Add(losslessCheckBox);
            Controls.Add(label18);
            Controls.Add(quality);
            Controls.Add(format);
            Controls.Add(progressBar);
            Controls.Add(label8);
            Controls.Add(resizeMode);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(pix4Label);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(outputFrameHeight);
            Controls.Add(outputFrameWidth);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(pix3Label);
            Controls.Add(fbs);
            Controls.Add(label19);
            Controls.Add(animationIterations);
            Controls.Add(label17);
            Controls.Add(frameDelayLabel);
            Controls.Add(frameDelay);
            Controls.Add(pix2Label);
            Controls.Add(heightArabicLabel);
            Controls.Add(widthArabicLabel);
            Controls.Add(frameHeight);
            Controls.Add(frameWidth);
            Controls.Add(saveFolder);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(heightEnglishLabel);
            Controls.Add(widthEnglishLabel);
            Controls.Add(openFolder);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pix1Label);
            Controls.Add(msLabel);
            Controls.Add(label20);
            Controls.Add(label29);
            Controls.Add(label7);
            Controls.Add(label28);
            Controls.Add(compressionMode);
            Controls.Add(label16);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Convert Sprite Sheet Image To Animated WebP Image v";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)frameWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)frameHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)frameDelay).EndInit();
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
        private Label widthEnglishLabel;
        private Label heightEnglishLabel;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button saveFolder;
        private Label label9;
        private Label label10;
        private NumericUpDown frameWidth;
        private NumericUpDown frameHeight;
        private Label widthArabicLabel;
        private Label heightArabicLabel;
        private Label pix1Label;
        private Label pix2Label;
        private NumericUpDown frameDelay;
        private Label msLabel;
        private Label frameDelayLabel;
        private Label label17;
        private NumericUpDown animationIterations;
        private NumericUpDown quality;
        private ComboBox compressionMode;
        private Label label16;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label fbs;
        private Label pix4Label;
        private Label label21;
        private Label label22;
        private NumericUpDown outputFrameHeight;
        private NumericUpDown outputFrameWidth;
        private Label label23;
        private Label label24;
        private Label pix3Label;
        private Label label26;
        private Label label27;
        private ComboBox resizeMode;
        private CheckBox losslessCheckBox;
        private Label label28;
        private Label label29;
        private ProgressBar progressBar;
        private ComboBox format;
        private Label label30;
        private CheckBox spritesNumberCheck;
        private CheckBox ratio;
        private CheckBox totalTimeCheck;
    }
}
