using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BarangayanEMS
{
    public class RoundedPanel : Panel
    {
        [Category("Appearance")]
        public int CornerRadius { get; set; } = 16;

        [Category("Appearance")]
        public Color BorderColor { get; set; } = Color.Transparent;

        [Category("Shadow")]
        public int ShadowOffset { get; set; } = 6;

        [Category("Shadow")]
        public int ShadowAlpha { get; set; } = 40;

        public RoundedPanel()
        {
            this.DoubleBuffered = true;
            this.BackColor = Color.White;
            this.ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = this.ClientRectangle;

            // Draw shadow
            if (ShadowOffset > 0)
            {
                Rectangle shadowRect = new Rectangle(
                    rect.X + ShadowOffset,
                    rect.Y + ShadowOffset,
                    rect.Width - ShadowOffset,
                    rect.Height - ShadowOffset
                );

                using (GraphicsPath shadowPath = GetRoundedPath(shadowRect, CornerRadius))
                using (PathGradientBrush shadowBrush = new PathGradientBrush(shadowPath))
                {
                    shadowBrush.CenterColor = Color.FromArgb(ShadowAlpha, Color.Black);
                    shadowBrush.SurroundColors = new[] { Color.Transparent };

                    e.Graphics.FillPath(shadowBrush, shadowPath);
                }
            }

            // Main panel drawing
            using (GraphicsPath path = GetRoundedPath(rect, CornerRadius))
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                e.Graphics.FillPath(brush, path);

                if (BorderColor != Color.Transparent)
                {
                    using (Pen pen = new Pen(BorderColor, 1.2f))
                        e.Graphics.DrawPath(pen, path);
                }

                this.Region = new Region(path);
            }
        }

        private GraphicsPath GetRoundedPath(Rectangle r, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int d = radius * 2;

            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.Right - d, r.Y, d, d, 270, 90);
            path.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
            path.AddArc(r.X, r.Bottom - d, d, d, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}
