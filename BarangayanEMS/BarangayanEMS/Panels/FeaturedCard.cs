using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BarangayanEMS
{
    public class FeatureCard : Panel
    {
        private IconPictureBox _icon;
        private Label _lblTitle;
        private Label _lblDescription;

        // ===================== PROPERTIES =====================

        private string _iconBase64;
        [Category("Appearance")]
        public string IconBase64
        {
            get => _iconBase64;
            set
            {
                _iconBase64 = value;
                if (_icon != null) _icon.Base64 = value;
            }
        }

        private string _title = "Title";
        [Category("Appearance")]
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                if (_lblTitle != null) _lblTitle.Text = value;
            }
        }

        private string _description = "Description text";
        [Category("Appearance")]
        public string Description
        {
            get => _description;
            set
            {
                _description = value;
                if (_lblDescription != null) _lblDescription.Text = value;
            }
        }

        private Color _cardBackColor = Color.FromArgb(255, 255, 255);
        [Category("Appearance")]
        public Color CardBackColor
        {
            get => _cardBackColor;
            set { _cardBackColor = value; Invalidate(); }
        }

        private Color _borderColor = Color.FromArgb(235, 235, 255);
        [Category("Appearance")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        private int _cornerRadius = 12;
        [Category("Appearance")]
        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = value; Invalidate(); }
        }

        private bool _isHovered = false;

        // ===================== CONSTRUCTOR =====================

        public FeatureCard()
        {
            DoubleBuffered = true;
            Size = new Size(360, 92);
            BackColor = Color.Transparent;

            CreateChildControls();

            Cursor = Cursors.Hand;

            // hover events
            MouseEnter += (s, e) => { _isHovered = true; Invalidate(); };
            MouseLeave += (s, e) => { _isHovered = false; Invalidate(); };
        }

        // ===================== UI CREATION =====================

        private void CreateChildControls()
        {
            // ICON
            _icon = new IconPictureBox
            {
                Size = new Size(36, 36),
                Location = new Point(18, 28),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Transparent
            };
            Controls.Add(_icon);

            // TITLE
            _lblTitle = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI Semibold", 11.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(40, 40, 40),
                Location = new Point(68, 16),
                Text = _title
            };
            Controls.Add(_lblTitle);

            // DESCRIPTION
            _lblDescription = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(110, 110, 110),
                Location = new Point(69, 44),
                Text = _description
            };
            Controls.Add(_lblDescription);
        }

        // ===================== PAINT EVENT =====================

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            using (GraphicsPath path = GetRoundedPath(rect, _cornerRadius))
            using (SolidBrush brush = new SolidBrush(_cardBackColor))
            using (Pen border = new Pen(_borderColor, 1))
            {
                e.Graphics.FillPath(brush, path);
                e.Graphics.DrawPath(border, path);
            }

            // Hover shadow
            if (_isHovered)
            {
                using (SolidBrush sb = new SolidBrush(Color.FromArgb(20, 0, 0, 0)))
                    e.Graphics.FillRectangle(sb, rect);
            }
        }

        // ===================== HELPERS =====================

        private GraphicsPath GetRoundedPath(Rectangle r, int radius)
        {
            int d = radius * 2;
            GraphicsPath path = new GraphicsPath();

            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}
