using ImageMagick;
using System;

namespace SpriteSheet_to_WebP
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {
            //compressionMode.SelectedIndex = 0;
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

            fWidth = (int)frameWidth.Value;
            fHeight = (int)frameHeight.Value;
            outFWidth = (uint)outputFrameWidth.Value;
            outFHeight = (uint)outputFrameHeight.Value;
            animDelay = (uint)animationDelay.Value;
            qualityUint = (uint)quality.Value;

            progressBar.Value = 0;
            progressBar.Maximum = pngFiles.Length;
            Refresh(); Application.DoEvents();

            foreach (string file in pngFiles)
            {
                GetWebpFromSpriteSheet(file);
                progressBar.Value++;
                Refresh(); Application.DoEvents();
            }
            
        }

        int fWidth, fHeight;
        uint outFWidth, outFHeight, animDelay, qualityUint;

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
                frame.Resize(outFWidth, outFHeight);
            else if (resizeMode.SelectedIndex == 2)
                frame.Scale(outFWidth, outFHeight);

            frame.AnimationDelay = animDelay;
            frame.Quality = qualityUint;

            if (losslessCheckBox.Checked && quality.Value != 100)
                frame.Settings.SetDefine(MagickFormat.WebP, "lossless", "true");
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
            frameDelay.Text = (animationDelay.Value * 10).ToString() + " ms";
            fbs.Text = Math.Round(100 / animationDelay.Value, 2).ToString();
        }

        private void ResizeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enable = resizeMode.SelectedIndex != 0;
            outputFrameWidth.Enabled = enable;
            outputFrameHeight.Enabled = enable;
        }

        private void Quality_ValueChanged(object sender, EventArgs e)
            => losslessCheckBox.Enabled = quality.Value != 100;
        
    }
}
