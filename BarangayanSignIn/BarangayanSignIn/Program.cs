using System;
using System.Windows.Forms;

namespace BarangayanSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Start the login form
            Application.Run(new Form1());
        }
    }
}
