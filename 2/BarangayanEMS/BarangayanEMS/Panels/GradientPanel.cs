using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BarangayanEMS
{
    public class GradientPanel : Panel
    {
        // ========== PROPERTIES ==========

        private Color _gradientColor1 = Color.FromArgb(248, 250, 252);   // Top / Left
        [Category("Appearance")]
        public Color GradientColor1
        {
            get => _gradientColor1;
            set { _gradientColor1 = value; Invalidate(); }
        }

        private Color _gradientColor2 = Color.FromArgb(224, 231, 255);   // Bottom / Right
        [Category("Appearance")]
        public Color GradientColor2
        {
            get => _gradientColor2;
            set { _gradientColor2 = value; Invalidate(); }
        }

        private float _angle = 90f; // Vertical by default (top → bottom)
        [Category("Appearance")]
        public float Angle
        {
            get => _angle;
            set { _angle = value; Invalidate(); }
        }

        private bool _smoothBlend = true;
        [Category("Appearance")]
        public bool UseSmoothBlend
        {
            get => _smoothBlend;
            set { _smoothBlend = value; Invalidate(); }
        }

        // ========== CONSTRUCTOR ==========

        public GradientPanel()
        {
            DoubleBuffered = true;  // avoid flicker
            ResizeRedraw = true;    // redraw when resized
        }

        // ========== PAINT ==========

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                _gradientColor1,
                _gradientColor2,
                _angle))
            {
                if (_smoothBlend)
                {
                    ColorBlend blend = new ColorBlend()
                    {
                        Colors = new[]
                        {
                            _gradientColor1,
                            Color.FromArgb(180, _gradientColor2),
                            _gradientColor2
                        },
                        Positions = new[] { 0f, 0.5f, 1f }
                    };
                    brush.InterpolationColors = blend;
                }

                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
