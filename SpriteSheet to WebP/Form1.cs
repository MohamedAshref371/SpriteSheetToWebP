using ImageMagick;
using System;

namespace SpriteSheet_to_WebP
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            int index = ProductVersion.IndexOf('.', ProductVersion.IndexOf('.') + 1);
            this.Text = this.Text + ProductVersion[..index];
            //compressionMode.SelectedIndex = 0;
            format.SelectedIndex = 0;
            resizeMode.SelectedIndex = 0;
        }

        string inputFolder = "", outputFolder = "";
        string[] pngFiles = [];
        private void OpenFolder_Click(object sender, EventArgs e)
        {
            folderBDialog.ShowNewFolderButton = false;
            if (folderBDialog.ShowDialog() == DialogResult.OK)
                inputFolder = folderBDialog.SelectedPath;
        }

        private void SaveFolder_Click(object sender, EventArgs e)
        {
            if (inputFolder == "")
            {
                MessageBox.Show("ﬁ„ » ÕœÌœ „Ã·œ ’Ê— √Ê—«ﬁ «·‹ ”»—«Ì  √Ê·«\nSelect the sprite-sheet images folder first", "Input folder not selected", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            if (!Directory.Exists(inputFolder))
            {
                MessageBox.Show("„Ã·œ ’Ê— √Ê—«ﬁ «·‹ ”»—«Ì  ·„ Ì⁄œ „ÊÃÊœ«\nThe sprite-sheet images folder no longer exists", "Input folder doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return;
            }

            pngFiles = Directory.GetFiles(inputFolder, "*.png", SearchOption.TopDirectoryOnly);
            if (pngFiles.Length == 0)
            {
                MessageBox.Show("„Ã·œ «·’Ê— «·„œŒ·… «·–Ì ﬁ„  » ÕœÌœÂ ›«—€\nThe input images folder you selected is empty", "Input folder is empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            folderBDialog.ShowNewFolderButton = true;
            if (folderBDialog.ShowDialog() == DialogResult.OK)
                outputFolder = folderBDialog.SelectedPath;
            else
                return;

            if (outputFolder == inputFolder)
            {
                MessageBox.Show("«Œ — „Ã·œ« „Œ ·›« ⁄‰ „Ã·œ ’Ê— √Ê—«ﬁ «·‹ ”»—«Ì \nSelect a folder different from the sprite-sheet images folder", "Input folder = output folder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (spritesNumberCheck.Checked)
            {
                cols = (int)frameWidth.Value;
                rows = (int)frameHeight.Value;
            }
            else
            {
                fWidth = (int)frameWidth.Value;
                fHeight = (int)frameHeight.Value;
            }

            outFWidth = outputFrameWidth.Value;
            outFHeight = outputFrameHeight.Value;

            animDelay = (uint)(frameDelay.Value / 10);
            qualityUint = (uint)quality.Value;

            progressBar.Value = 0;
            progressBar.Maximum = pngFiles.Length;

            foreach (string file in pngFiles)
            {
                Refresh(); Application.DoEvents();
                GetWebpFromSpriteSheet(file);
                progressBar.Value++;
            }

        }

        int cols, rows, fWidth, fHeight, animTicksPerSecond;
        uint newWidth, newHeight, animDelay, qualityUint;
        decimal outFWidth, outFHeight;

        private void GetWebpFromSpriteSheet(string file)
        {
            using MagickImage spriteSheet = new(file);

            if (spritesNumberCheck.Checked)
            {
                fWidth = (int)(spriteSheet.Width / cols);
                fHeight = (int)(spriteSheet.Height / rows);
            }
            else
            {
                cols = (int)(spriteSheet.Width / fWidth);
                rows = (int)(spriteSheet.Height / fHeight);
            }

            if (resizeMode.SelectedIndex != 0)
            {
                newWidth = (uint)(ratio.Checked ? outFWidth * fWidth : outFWidth);
                newHeight = (uint)(ratio.Checked ? outFHeight * fHeight : outFHeight);
            }

            MagickImageCollection animation = [];

            int index = 0, count = CheckLastEmptyFrames(spriteSheet);
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    MagickImage frame = new(spriteSheet);
                    frame.Crop(new MagickGeometry(x * fWidth, y * fHeight, (uint)fWidth, (uint)fHeight));

                    SetFrameSettings(frame);

                    animation.Add(frame);

                    index++;
                    if (index == count) break;
                }
            }

            animation[0].AnimationIterations = (uint)animationIterations.Value;

            string outputFilePath = Path.Combine(outputFolder, file.Split('\\').Last()[..^3]);
            if (format.SelectedIndex == 1)
            {
                animation.Optimize();
                animation.OptimizeTransparency();
                animation.Write(outputFilePath + "gif", MagickFormat.Gif);
            }
            else
                animation.Write(outputFilePath + "webp", MagickFormat.WebP);
        }

        void SetFrameSettings(MagickImage frame)
        {
            frame.ResetPage();

            if (resizeMode.SelectedIndex == 1)
                frame.Resize(newWidth, newHeight);
            else if (resizeMode.SelectedIndex == 2)
                frame.Scale(newWidth, newHeight);

            frame.AnimationDelay = animDelay;

            if (format.SelectedIndex == 1)
            {
                frame.Format = MagickFormat.Gif;
                frame.Depth = 8;
                frame.Quantize(new QuantizeSettings
                {
                    Colors = 256,
                    DitherMethod = DitherMethod.FloydSteinberg
                });
            }
            else
            {
                frame.Quality = qualityUint;
                if (losslessCheckBox.Checked)
                    frame.Settings.SetDefine(MagickFormat.WebP, "lossless", "true");
            }
        }

        int CheckLastEmptyFrames(MagickImage spriteSheet)
        {
            int count = rows * cols;
            for (int x = cols - 1; x > 0; x--)
            {
                MagickImage frame = new(spriteSheet);
                frame.Crop(new MagickGeometry(x * fWidth, (rows - 1) * fHeight, (uint)fWidth, (uint)fHeight));
                if (IsFrameEmpty(frame))
                    count--;
                else
                    break;
            }
            return count;
        }

        static bool IsFrameEmpty(MagickImage frame)
            => frame.Statistics().Composite().Mean == 0;

        private void FrameDelay_ValueChanged(object sender, EventArgs e)
        {
            fbs.Text = Math.Round(1000 / frameDelay.Value, 2).ToString();
        }

        private void ResizeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enable = resizeMode.SelectedIndex != 0;
            outputFrameWidth.Enabled = enable;
            outputFrameHeight.Enabled = enable;
        }

        private void SpritesNumberCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (spritesNumberCheck.Checked)
            {
                pix1Label.Visible = pix2Label.Visible = false;
                frameWidth.Minimum = frameHeight.Minimum = 1;
                frameWidth.Value = frameHeight.Value = 2;
                widthEnglishLabel.Text = "Columns Number :";
                heightEnglishLabel.Text = "Rows Number :";
                widthArabicLabel.Text = "⁄œœ «·√⁄„œ… :";
                heightArabicLabel.Text = "⁄œœ «·’›Ê› :";
                frameWidth.Location = new Point(frameWidth.Location.X + 30, frameWidth.Location.Y);
                frameHeight.Location = new Point(frameHeight.Location.X + 30, frameHeight.Location.Y);
            }
            else
            {
                pix1Label.Visible = pix2Label.Visible = true;
                frameWidth.Minimum = frameHeight.Minimum = 8;
                frameWidth.Value = frameHeight.Value = 240;
                widthEnglishLabel.Text = "Frame Width :";
                heightEnglishLabel.Text = "Frame Height :";
                widthArabicLabel.Text = "⁄—÷ «·≈ÿ«— :";
                heightArabicLabel.Text = "≈— ›«⁄ «·≈ÿ«— :";
                frameWidth.Location = new Point(frameWidth.Location.X - 30, frameWidth.Location.Y);
                frameHeight.Location = new Point(frameHeight.Location.X - 30, frameHeight.Location.Y);
            }
        }

        private void Ratio_CheckedChanged(object sender, EventArgs e)
        {
            pix3Label.Visible = pix4Label.Visible = !ratio.Checked;
            if (ratio.Checked)
            {
                outputFrameWidth.Minimum = outputFrameHeight.Minimum = 0.05M;
                outputFrameWidth.Maximum = outputFrameHeight.Maximum = 2M;
                outputFrameWidth.Increment = outputFrameHeight.Increment = 0.1M;
                outputFrameWidth.DecimalPlaces = outputFrameHeight.DecimalPlaces = 2;
                outputFrameWidth.Value = outputFrameHeight.Value = 0.5M;
                outputFrameWidth.Location = new Point(outputFrameWidth.Location.X + 20, outputFrameWidth.Location.Y);
                outputFrameHeight.Location = new Point(outputFrameHeight.Location.X + 20, outputFrameHeight.Location.Y);
            }
            else
            {
                outputFrameWidth.Minimum = outputFrameHeight.Minimum = 8M;
                outputFrameWidth.Maximum = outputFrameHeight.Maximum = 512M;
                outputFrameWidth.Increment = outputFrameHeight.Increment = 10M;
                outputFrameWidth.DecimalPlaces = outputFrameHeight.DecimalPlaces = 0;
                outputFrameWidth.Value = outputFrameHeight.Value = 120M;
                outputFrameWidth.Location = new Point(outputFrameWidth.Location.X - 20, outputFrameWidth.Location.Y);
                outputFrameHeight.Location = new Point(outputFrameHeight.Location.X - 20, outputFrameHeight.Location.Y);
            }
        }
    }
}
