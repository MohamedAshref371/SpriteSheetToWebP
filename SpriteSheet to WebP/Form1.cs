using ImageMagick;
using System;

namespace SpriteSheet_to_WebP
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            compressionMode.SelectedIndex = 0;
            resizeMode.SelectedIndex = 0;
        }

        string inputFolder = "", outputFolder = "";
        string[] pngFiles = [];
        private void OpenFolder_Click(object sender, EventArgs e)
        {
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

            if (folderBDialog.ShowDialog() == DialogResult.OK)
                outputFolder = folderBDialog.SelectedPath;

            if (outputFolder == inputFolder)
            {
                MessageBox.Show("«Œ — „Ã·œ« „Œ ·›« ⁄‰ „Ã·œ ’Ê— √Ê—«ﬁ «·‹ ”»—«Ì \nSelect a folder different from the sprite-sheet images folder", "Input folder = output folder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            fWidth = (int)frameWidth.Value;
            fHeight = (int)frameHeight.Value;

            foreach (string file in pngFiles)
                GetWebpFromSpriteSheet(file);

        }

        int fWidth, fHeight;

        private void GetWebpFromSpriteSheet(string file)
        {
            using MagickImage spriteSheet = new(file);

            int cols = (int)(spriteSheet.Width / fWidth);
            int rows = (int)(spriteSheet.Height / fHeight);
            MagickImageCollection animation = [];

            int index = 0, count = CheckLastEmptyFrames(spriteSheet, rows, cols);
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

            string animatedWebPPath = Path.Combine(outputFolder, file.Split('\\').Last()[..^3] + "webp");
            animation.Write(animatedWebPPath, MagickFormat.WebP);

        }

        void SetFrameSettings(MagickImage frame)
        {
            frame.ResetPage();

            if (resizeMode.SelectedIndex == 1)
                frame.Resize((uint)outputFrameWidth.Value, (uint)outputFrameHeight.Value);
            else if (resizeMode.SelectedIndex == 2)
                frame.Scale((uint)outputFrameWidth.Value, (uint)outputFrameHeight.Value);

            frame.AnimationDelay = (uint)animationDelay.Value;
            frame.Quality = (uint)quality.Value;

            if (compressionMode.SelectedIndex == 1)
            {
                frame.Settings.SetDefine(MagickFormat.WebP, "lossless", "true");
            }
            else if (compressionMode.SelectedIndex == 2)
            {
                frame.Settings.SetDefine(MagickFormat.WebP, "method", "6");
                frame.Settings.SetDefine(MagickFormat.WebP, "preprocessing", "2");
            }
        }

        int CheckLastEmptyFrames(MagickImage spriteSheet, int rows, int cols)
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

        private void AnimationDelay_ValueChanged(object sender, EventArgs e)
        {
            frameDelay.Text = (animationDelay.Value * 10).ToString();
            fbs.Text = Math.Round(100 / animationDelay.Value, 2).ToString();
        }

        private void ResizeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
           bool isEnabled = resizeMode.SelectedIndex != 0;
            outputFrameWidth.Enabled = isEnabled;
            outputFrameHeight.Enabled = isEnabled;
        }
    }
}
