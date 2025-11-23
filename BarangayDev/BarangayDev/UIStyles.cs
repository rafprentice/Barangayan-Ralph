using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BarangayanSystem
{
    public class UIStyles
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int left, int top, int right, int bottom,
            int width, int height);

        public static void ApplyRoundedCorners(Control ctrl, int radius)
        {
            ctrl.Region = System.Drawing.Region.FromHrgn(
                CreateRoundRectRgn(0, 0, ctrl.Width, ctrl.Height, radius, radius)
            );
        }
    }
}
