using System.Windows.Forms;

namespace BarangayanSystem
{
    partial class HomeForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel panelHeader;
        private Panel panelQuick;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelQuick = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(153)))));
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 200);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1418, 160);
            this.panelHeader.TabIndex = 0;
            // 
            // panelQuick
            // 
            this.panelQuick.BackColor = System.Drawing.Color.White;
            this.panelQuick.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuick.Location = new System.Drawing.Point(0, 0);
            this.panelQuick.Name = "panelQuick";
            this.panelQuick.Size = new System.Drawing.Size(1418, 200);
            this.panelQuick.TabIndex = 1;
            // 
            // HomeForm
            // 
            this.ClientSize = new System.Drawing.Size(1418, 720);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelQuick);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barangayan E Management System";
            this.ResumeLayout(false);

        }
    }
}
