using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BarangayanEMS
{
    partial class DashboardForm
    {
        private IContainer components = null;

        private GradientPanel pnlRoot;
        private GradientPanel pnlSidebar;
        private Panel pnlMain;
        private Panel pnlTop;
        private Panel pnlContentHost;

        // Sidebar
        private PictureBox picSeal;
        private Label lblRepublic;
        private Label lblSystem;
        private Panel navDashboard;
        private Panel navServices;
        private Panel navRequirements;
        private Panel navFeedback;
        private Panel navAbout;
        private Label lblNavDashboardIcon;
        private Label lblNavDashboard;
        private Label lblNavServicesIcon;
        private Label lblNavServices;
        private Label lblNavRequirementsIcon;
        private Label lblNavRequirements;
        private Label lblNavFeedbackIcon;
        private Label lblNavFeedback;
        private Label lblNavAboutIcon;
        private Label lblNavAbout;

        // Top bar
        private Label lblMainTitle;
        private Label lblMainSubtitle;
        private RoundedPanel pnlSearch;
        private Label lblSearchIcon;
        private TextBox txtSearch;
        private PictureBox picUserAvatar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));

            this.pnlRoot = new GradientPanel();
            this.pnlSidebar = new GradientPanel();
            this.navDashboard = new Panel();
            this.lblNavDashboardIcon = new Label();
            this.lblNavDashboard = new Label();
            this.navServices = new Panel();
            this.lblNavServicesIcon = new Label();
            this.lblNavServices = new Label();
            this.navRequirements = new Panel();
            this.lblNavRequirementsIcon = new Label();
            this.lblNavRequirements = new Label();
            this.navFeedback = new Panel();
            this.lblNavFeedbackIcon = new Label();
            this.lblNavFeedback = new Label();
            this.navAbout = new Panel();
            this.lblNavAboutIcon = new Label();
            this.lblNavAbout = new Label();
            this.lblSystem = new Label();
            this.lblRepublic = new Label();
            this.picSeal = new PictureBox();

            this.pnlMain = new Panel();
            this.pnlTop = new Panel();
            this.lblMainTitle = new Label();
            this.lblMainSubtitle = new Label();
            this.pnlSearch = new RoundedPanel();
            this.lblSearchIcon = new Label();
            this.txtSearch = new TextBox();
            this.picUserAvatar = new PictureBox();
            this.pnlContentHost = new Panel();

            // ==================== pnlRoot ====================
            this.pnlRoot.Dock = DockStyle.Fill;
            this.pnlRoot.Angle = 135F;
            this.pnlRoot.GradientColor1 = Color.FromArgb(120, 87, 255);
            this.pnlRoot.GradientColor2 = Color.FromArgb(189, 84, 255);
            this.pnlRoot.UseSmoothBlend = true;
            this.pnlRoot.Controls.Add(this.pnlMain);
            this.pnlRoot.Controls.Add(this.pnlSidebar);

            // ==================== Sidebar ====================
            this.pnlSidebar.Dock = DockStyle.Left;
            this.pnlSidebar.Width = 230;
            this.pnlSidebar.Padding = new Padding(16, 24, 16, 16);
            this.pnlSidebar.Angle = 90F;
            this.pnlSidebar.GradientColor1 = Color.FromArgb(248, 250, 252);
            this.pnlSidebar.GradientColor2 = Color.FromArgb(224, 231, 255);
            this.pnlSidebar.UseSmoothBlend = true;

            // Seal
            this.picSeal.Image = (Image)resources.GetObject("picSeal.Image");
            this.picSeal.Location = new Point(70, 10);
            this.picSeal.Size = new Size(80, 80);
            this.picSeal.SizeMode = PictureBoxSizeMode.Zoom;
            this.picSeal.BackColor = Color.Transparent;

            // Republic
            this.lblRepublic.AutoSize = true;
            this.lblRepublic.Text = "Republika ng Pilipinas";
            this.lblRepublic.Location = new Point(47, 99);
            this.lblRepublic.Font = new Font("Segoe UI", 9F);
            this.lblRepublic.ForeColor = Color.FromArgb(75, 85, 99);
            this.lblRepublic.Click += new EventHandler(this.lblRepublic_Click);

            // System name
            this.lblSystem.AutoSize = true;
            this.lblSystem.Text = "Barangayan E-Management System";
            this.lblSystem.Location = new Point(3, 121);
            this.lblSystem.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            this.lblSystem.ForeColor = Color.FromArgb(55, 65, 81);
            this.lblSystem.Click += new EventHandler(this.lblSystem_Click);

            // ---- navDashboard ----
            ConfigureNavPanel(this.navDashboard, 167);
            this.navDashboard.BackColor = Color.White; // active by default
            this.lblNavDashboardIcon.Text = "🏠";
            ConfigureNavIconLabel(this.lblNavDashboardIcon);
            this.lblNavDashboard.Text = "Dashboard";
            ConfigureNavTextLabel(this.lblNavDashboard, bold: true);
            this.navDashboard.Controls.Add(this.lblNavDashboardIcon);
            this.navDashboard.Controls.Add(this.lblNavDashboard);

            // ---- navServices ----
            ConfigureNavPanel(this.navServices, 209);
            this.navServices.Paint += new PaintEventHandler(this.navServices_Paint);
            this.lblNavServicesIcon.Text = "🛠";
            ConfigureNavIconLabel(this.lblNavServicesIcon);
            this.lblNavServices.Text = "Services";
            ConfigureNavTextLabel(this.lblNavServices);
            this.navServices.Controls.Add(this.lblNavServicesIcon);
            this.navServices.Controls.Add(this.lblNavServices);

            // ---- navRequirements ----
            ConfigureNavPanel(this.navRequirements, 251);
            this.lblNavRequirementsIcon.Text = "📋";
            ConfigureNavIconLabel(this.lblNavRequirementsIcon);
            this.lblNavRequirements.Text = "Requirements";
            ConfigureNavTextLabel(this.lblNavRequirements);
            this.navRequirements.Controls.Add(this.lblNavRequirementsIcon);
            this.navRequirements.Controls.Add(this.lblNavRequirements);

            // ---- navFeedback ----
            ConfigureNavPanel(this.navFeedback, 301);
            this.lblNavFeedbackIcon.Text = "💬";
            ConfigureNavIconLabel(this.lblNavFeedbackIcon);
            this.lblNavFeedback.Text = "Feedback";
            ConfigureNavTextLabel(this.lblNavFeedback);
            this.navFeedback.Controls.Add(this.lblNavFeedbackIcon);
            this.navFeedback.Controls.Add(this.lblNavFeedback);

            // ---- navAbout ----
            ConfigureNavPanel(this.navAbout, 345);
            this.lblNavAboutIcon.Text = "ℹ";
            ConfigureNavIconLabel(this.lblNavAboutIcon);
            this.lblNavAbout.Text = "About Us";
            ConfigureNavTextLabel(this.lblNavAbout);
            this.navAbout.Controls.Add(this.lblNavAboutIcon);
            this.navAbout.Controls.Add(this.lblNavAbout);

            this.pnlSidebar.Controls.Add(this.navAbout);
            this.pnlSidebar.Controls.Add(this.navFeedback);
            this.pnlSidebar.Controls.Add(this.navRequirements);
            this.pnlSidebar.Controls.Add(this.navServices);
            this.pnlSidebar.Controls.Add(this.navDashboard);
            this.pnlSidebar.Controls.Add(this.lblSystem);
            this.pnlSidebar.Controls.Add(this.lblRepublic);
            this.pnlSidebar.Controls.Add(this.picSeal);

            // ==================== Main panel ====================
            this.pnlMain.Dock = DockStyle.Fill;
            this.pnlMain.Padding = new Padding(16);
            this.pnlMain.BackColor = Color.Transparent;
            this.pnlMain.Controls.Add(this.pnlContentHost);
            this.pnlMain.Controls.Add(this.pnlTop);

            // ==================== Top bar ====================
            this.pnlTop.Dock = DockStyle.Top;
            this.pnlTop.Height = 80;
            this.pnlTop.Padding = new Padding(8, 8, 16, 8);
            this.pnlTop.BackColor = Color.White;
            this.pnlTop.Controls.Add(this.lblMainTitle);
            this.pnlTop.Controls.Add(this.lblMainSubtitle);
            this.pnlTop.Controls.Add(this.pnlSearch);
            this.pnlTop.Controls.Add(this.picUserAvatar);

            // Title
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Text = "Welcome back, User";
            this.lblMainTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            this.lblMainTitle.ForeColor = Color.FromArgb(40, 40, 40);
            this.lblMainTitle.Location = new Point(16, 14);

            // Subtitle
            this.lblMainSubtitle.AutoSize = true;
            this.lblMainSubtitle.Text = "Digital Local Government Services";
            this.lblMainSubtitle.Font = new Font("Segoe UI", 9F);
            this.lblMainSubtitle.ForeColor = Color.DimGray;
            this.lblMainSubtitle.Location = new Point(16, 43);

            // Search panel
            this.pnlSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.pnlSearch.BackColor = Color.FromArgb(245, 246, 255);
            this.pnlSearch.BorderColor = Color.Transparent;
            this.pnlSearch.CornerRadius = 18;
            this.pnlSearch.ShadowAlpha = 10;
            this.pnlSearch.ShadowOffset = 2;
            this.pnlSearch.Size = new Size(320, 36);
            this.pnlSearch.Location = new Point(1018 - 340, 20);
            this.pnlSearch.Controls.Add(this.lblSearchIcon);
            this.pnlSearch.Controls.Add(this.txtSearch);

            // Search icon (emoji)
            this.lblSearchIcon.AutoSize = true;
            this.lblSearchIcon.Text = "🔍";
            this.lblSearchIcon.Font = new Font("Segoe UI Emoji", 10F);
            this.lblSearchIcon.Location = new Point(12, 9);
            this.lblSearchIcon.BackColor = Color.Transparent;

            // Search textbox
            this.txtSearch.BorderStyle = BorderStyle.None;
            this.txtSearch.Font = new Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = Color.Gray;
            this.txtSearch.Location = new Point(36, 10);
            this.txtSearch.Width = 260;
            this.txtSearch.Text = "Search";

            // User avatar (placeholder)
            this.picUserAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.picUserAvatar.Size = new Size(40, 40);
            this.picUserAvatar.Location = new Point(1018 - 60, 18);
            this.picUserAvatar.BackColor = Color.Silver;
            this.picUserAvatar.BorderStyle = BorderStyle.FixedSingle;
            this.picUserAvatar.SizeMode = PictureBoxSizeMode.Zoom;

            // ==================== Content host ====================
            this.pnlContentHost.Dock = DockStyle.Fill;
            this.pnlContentHost.BackColor = Color.FromArgb(250, 250, 255);
            this.pnlContentHost.Location = new Point(16, 96);
            this.pnlContentHost.Name = "pnlContentHost";

            // ==================== Form ====================
            this.AutoScaleMode = AutoScaleMode.None;
            this.ClientSize = new Size(1280, 720);
            this.Controls.Add(this.pnlRoot);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
        }

        // Helper for nav panels
        private void ConfigureNavPanel(Panel nav, int top)
        {
            nav.Size = new Size(190, 36);
            nav.Location = new Point(18, top);
            nav.BackColor = Color.Transparent;
            nav.Cursor = Cursors.Hand;
        }

        private void ConfigureNavIconLabel(Label lbl)
        {
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI Emoji", 11F);
            lbl.Location = new Point(12, 8);
            lbl.BackColor = Color.Transparent;
        }

        private void ConfigureNavTextLabel(Label lbl, bool bold = false)
        {
            lbl.AutoSize = true;
            lbl.Font = new Font("Segoe UI", 9.5f,
                bold ? FontStyle.Bold : FontStyle.Regular);
            lbl.Location = new Point(38, 10);
            lbl.ForeColor = bold
                ? Color.FromArgb(79, 70, 229)
                : Color.FromArgb(55, 65, 81);
            lbl.BackColor = Color.Transparent;
        }
    }
}
