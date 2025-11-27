using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BarangayanEMS
{
    public class FeatureCard : Panel
    {
        private IconPictureBox _icon = new IconPictureBox();
        private Label _title = new Label();
        private Label _subtitle = new Label();

        [Category("Custom")]
        public string IconBase64
        {
            get => _icon.Base64;
            set => _icon.Base64 = value;
        }

        [Category("Custom")]
        public string Title
        {
            get => _title.Text;
            set => _title.Text = value;
        }

        [Category("Custom")]
        public string Description
        {
            get => _subtitle.Text;
            set => _subtitle.Text = value;
        }

        public FeatureCard()
        {
            this.DoubleBuffered = true;
            this.BackColor = Color.White;
            this.Size = new Size(330, 95);
            this.Margin = new Padding(0, 12, 0, 0);
            this.Padding = new Padding(16);
            this.Cursor = Cursors.Hand;

            // ICON
            _icon.Size = new Size(36, 36);
            _icon.Location = new Point(12, 25);
            _icon.SizeMode = PictureBoxSizeMode.Zoom;
            _icon.AutoRound = false;
            this.Controls.Add(_icon);

            // TITLE
            _title.AutoSize = false;
            _title.Font = new Font("Segoe UI Semibold", 11F);
            _title.Location = new Point(60, 22);
            _title.Size = new Size(250, 24);
            this.Controls.Add(_title);

            // SUBTITLE
            _subtitle.AutoSize = false;
            _subtitle.Font = new Font("Segoe UI", 9F);
            _subtitle.ForeColor = Color.DimGray;
            _subtitle.Location = new Point(60, 48);
            _subtitle.Size = new Size(250, 24);
            this.Controls.Add(_subtitle);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (GraphicsPath path = new GraphicsPath())
            using (SolidBrush brush = new SolidBrush(Color.White))
            using (Pen border = new Pen(Color.FromArgb(220, 220, 225)))
            {
                Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
                int radius = 18;

                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                e.Graphics.FillPath(brush, path);

                // slight elegant shadow
                e.Graphics.DrawPath(border, path);
            }
        }
    }
}
    