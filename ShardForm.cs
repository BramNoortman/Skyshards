using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SkyShards
{
    public partial class ShardForm : Form
    {
        private Label infoLabel;
        private PictureBox shardPicture;
        private Image loadedImage; // instance-owned image (form is responsible for disposing)

        public ShardForm()
        {
            Text = "Shard Viewer";
            ClientSize = new Size(520, 260); // make room by default

            infoLabel = new Label
            {
                AutoSize = false,
                TextAlign = ContentAlignment.TopLeft,
                Font = new Font("Segoe UI", 10)
            };

            shardPicture = new PictureBox
            {
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.None, // <-- hide the border lines
            };

            Controls.Add(infoLabel);
            Controls.Add(shardPicture);

            // Arrange controls and set anchors so layout adapts to resizing
            UpdateLayout();
            this.Resize += (s, e) => UpdateLayout();

            infoLabel.Text = GetShardInfo();

            // Load image from Shards.ImagePath into this form's PictureBox
            LoadShardImageIntoUI();

            // Ensure we free the loaded image when the form closes
            this.FormClosed += ShardForm_FormClosed;
        }

        private void UpdateLayout()
        {
            const int margin = 10;
            const int picWidth = 180;
            const int picHeight = 180;

            // position picture on the right with margin
            shardPicture.Size = new Size(picWidth, picHeight);
            shardPicture.Left = Math.Max(margin, ClientSize.Width - picWidth - margin);
            shardPicture.Top = margin;
            shardPicture.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // info label fills remaining left area
            infoLabel.Left = margin;
            infoLabel.Top = margin;
            infoLabel.Width = Math.Max(100, shardPicture.Left - margin * 2);
            infoLabel.Height = Math.Max(80, ClientSize.Height - margin * 2);
            infoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
        }

        private void LoadShardImageIntoUI()
        {
            // If already loaded, assign and return
            if (loadedImage != null)
            {
                shardPicture.Image = loadedImage;
                return;
            }

            // No path -> nothing to load
            if (string.IsNullOrEmpty(Shards.ImagePath) || !File.Exists(Shards.ImagePath))
            {
                shardPicture.Image = null;
                return;
            }

            // Load and clone image to avoid file lock; store in instance field for disposal
            try
            {
                using (var fs = new FileStream(Shards.ImagePath, FileMode.Open, FileAccess.Read))
                using (var temp = Image.FromStream(fs))
                {
                    loadedImage = (Image)temp.Clone();
                }

                shardPicture.Image = loadedImage;
            }
            catch
            {
                loadedImage?.Dispose();
                loadedImage = null;
                shardPicture.Image = null;
            }
        }

        private void ShardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (loadedImage != null)
            {
                shardPicture.Image = null;
                loadedImage.Dispose();
                loadedImage = null;
            }
        }

        private string GetShardInfo()
        {
            return
                $"Name: {Shards.Name}\r\n" +
                $"Rarity: {Shards.Rarity}\r\n" +
                $"Family: {Shards.family}\r\n" +
                $"Type: {Shards.Type}\r\n" +
                $"Level: {Shards.Level}\r\n" +
                $"Effect: {Shards.Effect}\r\n" +
                $"CanFuse: {Shards.CanFuse}\r\n" +
                $"IsEnabled: {Shards.isenabled}";
        }
    }
}
