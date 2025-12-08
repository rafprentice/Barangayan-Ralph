using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BarangayanEMS
{
    public class RoundedTextBox : TextBox
    {
        public int BorderRadius { get; set; } = 12;
        public Color BorderColor { get; set; } = Color.FromArgb(220, 220, 220);

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.BorderStyle = BorderStyle.None;
            this.BackColor = Color.White;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == 0x000F) // WM_PAINT
                DrawBorder();
        }

        private void DrawBorder()
        {
            using (Graphics g = CreateGraphics())
            using (Pen pen = new Pen(BorderColor, 1.2f))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
                g.DrawArc(pen, rect.X, rect.Y, BorderRadius, BorderRadius, 180, 90);
                g.DrawArc(pen, rect.Right - BorderRadius, rect.Y, BorderRadius, BorderRadius, 270, 90);
                g.DrawArc(pen, rect.Right - BorderRadius, rect.Bottom - BorderRadius, BorderRadius, BorderRadius, 0, 90);
                g.DrawArc(pen, rect.X, rect.Bottom - BorderRadius, BorderRadius, BorderRadius, 90, 90);
                g.DrawRectangle(pen, rect);
            }
        }
    }
}
