using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BarangayanEMS
{
    public class RoundedPanel : Panel
    {
        // ========== CUSTOM PROPERTIES ==========

        private int _cornerRadius = 20;
        [Category("Appearance")]
        public int CornerRadius
        {
            get => _cornerRadius;
            set { _cornerRadius = value; Invalidate(); }
        }

        private Color _borderColor = Color.Transparent;
        [Category("Appearance")]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        private int _shadowOffset = 0;
        [Category("Shadow")]
        public int ShadowOffset
        {
            get => _shadowOffset;
            set { _shadowOffset = value; Invalidate(); }
        }

        private int _shadowAlpha = 0;
        [Category("Shadow")]
        public int ShadowAlpha
        {
            get => _shadowAlpha;
            set { _shadowAlpha = value; Invalidate(); }
        }

        public RoundedPanel()
        {
            DoubleBuffered = true;        // Reduce flicker
            BackColor = Color.White;
            ForeColor = Color.Black;
        }

        // ========== DRAWING MAGIC ==========

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            using (GraphicsPath path = GetRoundPath(rect, _cornerRadius))
            using (SolidBrush brush = new SolidBrush(BackColor))
            using (Pen pen = new Pen(_borderColor, 1))
            {
                // --- SHADOW ---
                if (_shadowAlpha > 0)
                {
                    using (SolidBrush shadow = new SolidBrush(Color.FromArgb(_shadowAlpha, 0, 0, 0)))
                    {
                        Rectangle shadowRect = new Rectangle(
                            rect.X + _shadowOffset,
                            rect.Y + _shadowOffset,
                            rect.Width,
                            rect.Height);

                        using (GraphicsPath shadowPath = GetRoundPath(shadowRect, _cornerRadius))
                        {
                            e.Graphics.FillPath(shadow, shadowPath);
                        }
                    }
                }

                // --- PANEL CORE ---
                e.Graphics.FillPath(brush, path);
                if (_borderColor != Color.Transparent)
                    e.Graphics.DrawPath(pen, path);
            }
        }

        // Rounded rectangle builder
        private GraphicsPath GetRoundPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();

            return path;
        }
    }
}
