using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace BarangayanEMS
{
    public class IconPictureBox : PictureBox
    {
        private string _base64 = "";

        [Category("Appearance")]
        public string Base64
        {
            get => _base64;
            set
            {
                _base64 = value;
                LoadBase64Image();
            }
        }

        [Category("Appearance")]
        public Color Tint { get; set; } = Color.Transparent;

        [Category("Appearance")]
        public bool AutoRound { get; set; } = false;

        public IconPictureBox()
        {
            this.SizeMode = PictureBoxSizeMode.Zoom;
            this.DoubleBuffered = true;
        }

        private void LoadBase64Image()
        {
            if (string.IsNullOrWhiteSpace(_base64))
            {
                this.Image = null;
                return;
            }

            try
            {
                int idx = _base64.IndexOf("base64,", StringComparison.OrdinalIgnoreCase);
                string raw = idx >= 0 ? _base64.Substring(idx + 7) : _base64;

                byte[] bytes = Convert.FromBase64String(raw);

                using (var ms = new MemoryStream(bytes))
                {
                    Image img = Image.FromStream(ms);
                    this.Image = ApplyTint(img);
                }
            }
            catch
            {
                this.Image = null;
            }
        }

        private Image ApplyTint(Image original)
        {
            if (Tint == Color.Transparent)
                return original;

            Bitmap tinted = new Bitmap(original.Width, original.Height);

            using (Graphics g = Graphics.FromImage(tinted))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                ImageAttributes ia = new ImageAttributes();
                float r = Tint.R / 255f;
                float gC = Tint.G / 255f;
                float b = Tint.B / 255f;

                float[][] matrix =
                {
                    new float[]{r,0,0,0,0},
                    new float[]{0,gC,0,0,0},
                    new float[]{0,0,b,0,0},
                    new float[]{0,0,0,1,0},
                    new float[]{0,0,0,0,1}
                };

                ColorMatrix cm = new ColorMatrix(matrix);
                ia.SetColorMatrix(cm);

                g.DrawImage(original, new Rectangle(0, 0, original.Width, original.Height),
                    0, 0, original.Width, original.Height, GraphicsUnit.Pixel, ia);
            }

            return tinted;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if (AutoRound)
            {
                GraphicsPath gp = new GraphicsPath();
                gp.AddEllipse(this.ClientRectangle);
                this.Region = new Region(gp);
            }

            base.OnPaint(pe);
        }
    }
}
