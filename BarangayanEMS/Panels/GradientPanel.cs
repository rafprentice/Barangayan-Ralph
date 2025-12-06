using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BarangayanEMS
{
    public class GradientPanel : Panel
    {
        [Category("Appearance")]
        public Color GradientColor1 { get; set; } = Color.FromArgb(76, 0, 255);

        [Category("Appearance")]
        public Color GradientColor2 { get; set; } = Color.FromArgb(134, 2, 255);

        [Category("Appearance")]
        public float Angle { get; set; } = 220f;

        [Category("Appearance")]
        public bool UseSmoothBlend { get; set; } = true;

        public GradientPanel()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            Rectangle rect = this.ClientRectangle;
            if (rect.Width == 0 || rect.Height == 0)
                return;

            // Smooth gradient
            using (LinearGradientBrush brush = new LinearGradientBrush(rect, GradientColor1, GradientColor2, Angle))
            {
                if (UseSmoothBlend)
                {
                    ColorBlend cb = new ColorBlend(4);
                    cb.Positions = new[] { 0f, 0.3f, 0.7f, 1f };
                    cb.Colors = new[]
                    {
                        GradientColor1,
                        Color.FromArgb(150, GradientColor1),
                        Color.FromArgb(150, GradientColor2),
                        GradientColor2
                    };
                    brush.InterpolationColors = cb;
                }

                e.Graphics.FillRectangle(brush, rect);
            }
        }
    }
}
