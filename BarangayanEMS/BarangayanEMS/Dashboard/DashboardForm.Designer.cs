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

        // Sidebar
        private IconPictureBox picSeal;
        private Label lblRepublic;
        private Label lblSystem;
        private Panel pnlNavDashboard;
        private Panel pnlNavServices;
        private Panel pnlNavBlotter;
        private Panel pnlNavMap;
        private Panel pnlNavAbout;
        private Label lblNavDashboard;
        private Label lblNavServices;
        private Label lblNavBlotter;
        private Label lblNavMap;
        private Label lblNavAbout;
        private RoundedPanel pnlSidebarProfile;
        private Label lblSidebarProfileText;

        // Main top bar
        private Label lblMainTitle;
        private Label lblMainSubtitle;
        private RoundedPanel pnlSearch;
        private PictureBox iconSearch;
        private TextBox txtSearch;
        private IconPictureBox picUserAvatar;

        // Stats cards
        private RoundedPanel cardResidents;
        private RoundedPanel cardPending;
        private RoundedPanel cardAnnouncements;
        private Label lblResidentsTitle;
        private Label lblResidentsCount;
        private Label lblPendingTitle;
        private Label lblPendingCount;
        private Label lblAnnTitle;
        private Label lblAnnCount;

        // Quick services
        private Label lblQuickServices;
        private RoundedPanel quickDocRequest;
        private RoundedPanel quickOnlinePayments;
        private RoundedPanel quickReportIssues;
        private RoundedPanel quickViewMap;
        private Label lblQuickDocTitle;
        private Label lblQuickDocSub;
        private Label lblQuickPayTitle;
        private Label lblQuickPaySub;
        private Label lblQuickReportTitle;
        private Label lblQuickReportSub;
        private Label lblQuickMapTitle;
        private Label lblQuickMapSub;

        // Latest updates
        private Label lblLatestUpdates;
        private RoundedPanel update1;
        private RoundedPanel update2;
        private RoundedPanel update3;
        private Label lblUpdate1Title;
        private Label lblUpdate1Body;
        private Label lblUpdate1Time;
        private Label lblUpdate2Title;
        private Label lblUpdate2Body;
        private Label lblUpdate2Time;
        private Label lblUpdate3Title;
        private Label lblUpdate3Body;
        private Label lblUpdate3Time;

        /// <summary>
        /// Clean up
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new Container();

            this.pnlRoot = new GradientPanel();
            this.pnlSidebar = new GradientPanel();
            this.pnlMain = new Panel();

            this.picSeal = new IconPictureBox();
            this.lblRepublic = new Label();
            this.lblSystem = new Label();

            this.pnlNavDashboard = new Panel();
            this.pnlNavServices = new Panel();
            this.pnlNavBlotter = new Panel();
            this.pnlNavMap = new Panel();
            this.pnlNavAbout = new Panel();
            this.lblNavDashboard = new Label();
            this.lblNavServices = new Label();
            this.lblNavBlotter = new Label();
            this.lblNavMap = new Label();
            this.lblNavAbout = new Label();

            this.pnlSidebarProfile = new RoundedPanel();
            this.lblSidebarProfileText = new Label();

            this.lblMainTitle = new Label();
            this.lblMainSubtitle = new Label();
            this.pnlSearch = new RoundedPanel();
            this.iconSearch = new PictureBox();
            this.txtSearch = new TextBox();
            this.picUserAvatar = new IconPictureBox();

            this.cardResidents = new RoundedPanel();
            this.cardPending = new RoundedPanel();
            this.cardAnnouncements = new RoundedPanel();
            this.lblResidentsTitle = new Label();
            this.lblResidentsCount = new Label();
            this.lblPendingTitle = new Label();
            this.lblPendingCount = new Label();
            this.lblAnnTitle = new Label();
            this.lblAnnCount = new Label();

            this.lblQuickServices = new Label();
            this.quickDocRequest = new RoundedPanel();
            this.quickOnlinePayments = new RoundedPanel();
            this.quickReportIssues = new RoundedPanel();
            this.quickViewMap = new RoundedPanel();
            this.lblQuickDocTitle = new Label();
            this.lblQuickDocSub = new Label();
            this.lblQuickPayTitle = new Label();
            this.lblQuickPaySub = new Label();
            this.lblQuickReportTitle = new Label();
            this.lblQuickReportSub = new Label();
            this.lblQuickMapTitle = new Label();
            this.lblQuickMapSub = new Label();

            this.lblLatestUpdates = new Label();
            this.update1 = new RoundedPanel();
            this.update2 = new RoundedPanel();
            this.update3 = new RoundedPanel();
            this.lblUpdate1Title = new Label();
            this.lblUpdate1Body = new Label();
            this.lblUpdate1Time = new Label();
            this.lblUpdate2Title = new Label();
            this.lblUpdate2Body = new Label();
            this.lblUpdate2Time = new Label();
            this.lblUpdate3Title = new Label();
            this.lblUpdate3Body = new Label();
            this.lblUpdate3Time = new Label();

            ((ISupportInitialize)(this.picSeal)).BeginInit();
            ((ISupportInitialize)(this.picUserAvatar)).BeginInit();
            ((ISupportInitialize)(this.iconSearch)).BeginInit();

            this.pnlRoot.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();

            this.pnlNavDashboard.SuspendLayout();
            this.pnlNavServices.SuspendLayout();
            this.pnlNavBlotter.SuspendLayout();
            this.pnlNavMap.SuspendLayout();
            this.pnlNavAbout.SuspendLayout();
            this.pnlSidebarProfile.SuspendLayout();

            this.cardResidents.SuspendLayout();
            this.cardPending.SuspendLayout();
            this.cardAnnouncements.SuspendLayout();

            this.quickDocRequest.SuspendLayout();
            this.quickOnlinePayments.SuspendLayout();
            this.quickReportIssues.SuspendLayout();
            this.quickViewMap.SuspendLayout();

            this.update1.SuspendLayout();
            this.update2.SuspendLayout();
            this.update3.SuspendLayout();

            this.SuspendLayout();

            // ======================================================
            // FORM
            // ======================================================
            this.AutoScaleMode = AutoScaleMode.None;
            this.ClientSize = new Size(1280, 720);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.Text = "Barangayan E-Management System - Dashboard";

            // ======================================================
            // ROOT GRADIENT
            // ======================================================
            this.pnlRoot.Dock = DockStyle.Fill;
            this.pnlRoot.GradientColor1 = Color.FromArgb(24, 78, 148);   // deep blue top
            this.pnlRoot.GradientColor2 = Color.FromArgb(103, 34, 190);  // purple bottom
            this.pnlRoot.Angle = 90F;
            this.pnlRoot.Name = "pnlRoot";

            // Add sidebar & main
            this.pnlRoot.Controls.Add(this.pnlMain);
            this.pnlRoot.Controls.Add(this.pnlSidebar);

            // ======================================================
            // SIDEBAR
            // ======================================================
            this.pnlSidebar.Width = 260;
            this.pnlSidebar.Dock = DockStyle.Left;
            this.pnlSidebar.GradientColor1 = Color.FromArgb(50, 8, 95);
            this.pnlSidebar.GradientColor2 = Color.FromArgb(111, 22, 210);
            this.pnlSidebar.Angle = 90F;
            this.pnlSidebar.Name = "pnlSidebar";

            // Seal
            this.picSeal.Location = new Point(30, 26);
            this.picSeal.Size = new Size(120, 120);
            this.picSeal.SizeMode = PictureBoxSizeMode.Zoom;
            this.picSeal.BackColor = Color.Transparent;
            this.picSeal.Base64 = Icons.Seal;
            this.pnlSidebar.Controls.Add(this.picSeal);

            // Republic label
            this.lblRepublic.AutoSize = true;
            this.lblRepublic.Text = "Republika ng Pilipinas";
            this.lblRepublic.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            this.lblRepublic.ForeColor = Color.White;
            this.lblRepublic.Location = new Point(30, 155);
            this.pnlSidebar.Controls.Add(this.lblRepublic);

            // System label (2 lines)
            this.lblSystem.AutoSize = true;
            this.lblSystem.Text = "Barangayan E-Management\r\nSystem";
            this.lblSystem.Font = new Font("Segoe UI", 10F);
            this.lblSystem.ForeColor = Color.Gainsboro;
            this.lblSystem.Location = new Point(30, 188);
            this.pnlSidebar.Controls.Add(this.lblSystem);

            // ---------- NAV PANELS ----------
            int navTop = 250;
            int navHeight = 44;
            int navGap = 6;
            int navLeft = 18;
            int navWidth = 224;

            // Dashboard
            this.pnlNavDashboard.BackColor = Color.FromArgb(102, 0, 255);
            this.pnlNavDashboard.Location = new Point(navLeft, navTop);
            this.pnlNavDashboard.Size = new Size(navWidth, navHeight);
            this.pnlNavDashboard.Cursor = Cursors.Hand;

            this.lblNavDashboard.AutoSize = false;
            this.lblNavDashboard.Dock = DockStyle.Fill;
            this.lblNavDashboard.TextAlign = ContentAlignment.MiddleLeft;
            this.lblNavDashboard.Padding = new Padding(16, 0, 0, 0);
            this.lblNavDashboard.Text = "Dashboard";
            this.lblNavDashboard.ForeColor = Color.White;
            this.lblNavDashboard.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);

            this.pnlNavDashboard.Controls.Add(this.lblNavDashboard);
            this.pnlSidebar.Controls.Add(this.pnlNavDashboard);

            // Services
            navTop += navHeight + navGap;
            this.pnlNavServices.BackColor = Color.Transparent;
            this.pnlNavServices.Location = new Point(navLeft, navTop);
            this.pnlNavServices.Size = new Size(navWidth, navHeight);
            this.pnlNavServices.Cursor = Cursors.Hand;

            this.lblNavServices.AutoSize = false;
            this.lblNavServices.Dock = DockStyle.Fill;
            this.lblNavServices.TextAlign = ContentAlignment.MiddleLeft;
            this.lblNavServices.Padding = new Padding(16, 0, 0, 0);
            this.lblNavServices.Text = "Services";
            this.lblNavServices.ForeColor = Color.WhiteSmoke;
            this.lblNavServices.Font = new Font("Segoe UI", 10F);

            this.pnlNavServices.Controls.Add(this.lblNavServices);
            this.pnlSidebar.Controls.Add(this.pnlNavServices);

            // Blotter
            navTop += navHeight + navGap;
            this.pnlNavBlotter.BackColor = Color.Transparent;
            this.pnlNavBlotter.Location = new Point(navLeft, navTop);
            this.pnlNavBlotter.Size = new Size(navWidth, navHeight);
            this.pnlNavBlotter.Cursor = Cursors.Hand;

            this.lblNavBlotter.AutoSize = false;
            this.lblNavBlotter.Dock = DockStyle.Fill;
            this.lblNavBlotter.TextAlign = ContentAlignment.MiddleLeft;
            this.lblNavBlotter.Padding = new Padding(16, 0, 0, 0);
            this.lblNavBlotter.Text = "Blotter";
            this.lblNavBlotter.ForeColor = Color.WhiteSmoke;
            this.lblNavBlotter.Font = new Font("Segoe UI", 10F);

            this.pnlNavBlotter.Controls.Add(this.lblNavBlotter);
            this.pnlSidebar.Controls.Add(this.pnlNavBlotter);

            // Map
            navTop += navHeight + navGap;
            this.pnlNavMap.BackColor = Color.Transparent;
            this.pnlNavMap.Location = new Point(navLeft, navTop);
            this.pnlNavMap.Size = new Size(navWidth, navHeight);
            this.pnlNavMap.Cursor = Cursors.Hand;

            this.lblNavMap.AutoSize = false;
            this.lblNavMap.Dock = DockStyle.Fill;
            this.lblNavMap.TextAlign = ContentAlignment.MiddleLeft;
            this.lblNavMap.Padding = new Padding(16, 0, 0, 0);
            this.lblNavMap.Text = "Map";
            this.lblNavMap.ForeColor = Color.WhiteSmoke;
            this.lblNavMap.Font = new Font("Segoe UI", 10F);

            this.pnlNavMap.Controls.Add(this.lblNavMap);
            this.pnlSidebar.Controls.Add(this.pnlNavMap);

            // About
            navTop += navHeight + navGap;
            this.pnlNavAbout.BackColor = Color.Transparent;
            this.pnlNavAbout.Location = new Point(navLeft, navTop);
            this.pnlNavAbout.Size = new Size(navWidth, navHeight);
            this.pnlNavAbout.Cursor = Cursors.Hand;

            this.lblNavAbout.AutoSize = false;
            this.lblNavAbout.Dock = DockStyle.Fill;
            this.lblNavAbout.TextAlign = ContentAlignment.MiddleLeft;
            this.lblNavAbout.Padding = new Padding(16, 0, 0, 0);
            this.lblNavAbout.Text = "About";
            this.lblNavAbout.ForeColor = Color.WhiteSmoke;
            this.lblNavAbout.Font = new Font("Segoe UI", 10F);

            this.pnlNavAbout.Controls.Add(this.lblNavAbout);
            this.pnlSidebar.Controls.Add(this.pnlNavAbout);

            // Sidebar profile button (bottom)
            this.pnlSidebarProfile.CornerRadius = 24;
            this.pnlSidebarProfile.ShadowOffset = 0;
            this.pnlSidebarProfile.BackColor = Color.Transparent;
            this.pnlSidebarProfile.BorderStyle = BorderStyle.FixedSingle;
            this.pnlSidebarProfile.Size = new Size(60, 60);
            this.pnlSidebarProfile.Location = new Point(100, 630);
            this.pnlSidebarProfile.Cursor = Cursors.Hand;

            this.lblSidebarProfileText.Dock = DockStyle.Fill;
            this.lblSidebarProfileText.TextAlign = ContentAlignment.MiddleCenter;
            this.lblSidebarProfileText.ForeColor = Color.White;
            this.lblSidebarProfileText.Font = new Font("Segoe UI", 18F);
            this.lblSidebarProfileText.Text = "👤";

            this.pnlSidebarProfile.Controls.Add(this.lblSidebarProfileText);
            this.pnlSidebar.Controls.Add(this.pnlSidebarProfile);

            // ======================================================
            // MAIN PANEL (right area)
            // ======================================================
            this.pnlMain.Dock = DockStyle.Fill;
            this.pnlMain.BackColor = Color.FromArgb(246, 249, 255);
            this.pnlMain.Padding = new Padding(24, 20, 24, 24);
            this.pnlMain.Name = "pnlMain";

            // ----- Title -----
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Text = "Welcome back, Juan";
            this.lblMainTitle.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            this.lblMainTitle.ForeColor = Color.FromArgb(35, 35, 35);
            this.lblMainTitle.Location = new Point(16, 16);

            this.lblMainSubtitle.AutoSize = true;
            this.lblMainSubtitle.Text = "Sign in to access your barangay services";
            this.lblMainSubtitle.Font = new Font("Segoe UI", 10F);
            this.lblMainSubtitle.ForeColor = Color.DimGray;
            this.lblMainSubtitle.Location = new Point(18, 55);

            // ----- Search box -----
            this.pnlSearch.CornerRadius = 18;
            this.pnlSearch.ShadowOffset = 0;
            this.pnlSearch.BackColor = Color.White;
            this.pnlSearch.Size = new Size(280, 34);
            this.pnlSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.pnlSearch.Location = new Point(this.pnlMain.Width - 320, 24);
            this.pnlSearch.Name = "pnlSearch";

            this.iconSearch.Size = new Size(18, 18);
            this.iconSearch.Location = new Point(10, 8);
            this.iconSearch.SizeMode = PictureBoxSizeMode.Zoom;
            this.iconSearch.Image = SystemIcons.Information.ToBitmap(); // placeholder icon

            this.txtSearch.BorderStyle = BorderStyle.None;
            this.txtSearch.Location = new Point(34, 8);
            this.txtSearch.Width = 230;
            this.txtSearch.Font = new Font("Segoe UI", 9.5F);
            this.txtSearch.ForeColor = Color.Gray;
            this.txtSearch.Text = "Search";

            this.pnlSearch.Controls.Add(this.iconSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);

            // User avatar (top right)
            this.picUserAvatar.Size = new Size(44, 44);
            this.picUserAvatar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.picUserAvatar.Location = new Point(this.pnlMain.Width - 60, 20);
            this.picUserAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            this.picUserAvatar.Base64 = Icons.Profile;
            this.picUserAvatar.BackColor = Color.Transparent;

            // Add dynamic reposition on resize
            this.pnlMain.Resize += (s, e) =>
            {
                pnlSearch.Location = new Point(pnlMain.Width - 320, 24);
                picUserAvatar.Location = new Point(pnlMain.Width - 60, 20);
            };

            // ======================================================
            // STATS CARDS
            // ======================================================
            int statsTop = 96;
            int statsHeight = 110;
            int statsWidth = 260;
            int statsGap = 18;

            // Residents
            this.cardResidents.CornerRadius = 18;
            this.cardResidents.ShadowOffset = 4;
            this.cardResidents.BackColor = Color.FromArgb(64, 90, 255);
            this.cardResidents.Location = new Point(20, statsTop);
            this.cardResidents.Size = new Size(statsWidth, statsHeight);
            this.cardResidents.Name = "cardResidents";

            this.lblResidentsTitle.AutoSize = true;
            this.lblResidentsTitle.Text = "Registered Residents";
            this.lblResidentsTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            this.lblResidentsTitle.ForeColor = Color.White;
            this.lblResidentsTitle.Location = new Point(18, 18);

            this.lblResidentsCount.AutoSize = true;
            this.lblResidentsCount.Text = "12,540";
            this.lblResidentsCount.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold);
            this.lblResidentsCount.ForeColor = Color.White;
            this.lblResidentsCount.Location = new Point(16, 46);

            this.cardResidents.Controls.Add(this.lblResidentsTitle);
            this.cardResidents.Controls.Add(this.lblResidentsCount);

            // Pending
            this.cardPending.CornerRadius = 18;
            this.cardPending.ShadowOffset = 4;
            this.cardPending.BackColor = Color.FromArgb(126, 53, 255);
            this.cardPending.Location = new Point(20 + statsWidth + statsGap, statsTop);
            this.cardPending.Size = new Size(statsWidth, statsHeight);

            this.lblPendingTitle.AutoSize = true;
            this.lblPendingTitle.Text = "Pending Requests";
            this.lblPendingTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            this.lblPendingTitle.ForeColor = Color.White;
            this.lblPendingTitle.Location = new Point(18, 18);

            this.lblPendingCount.AutoSize = true;
            this.lblPendingCount.Text = "85";
            this.lblPendingCount.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold);
            this.lblPendingCount.ForeColor = Color.White;
            this.lblPendingCount.Location = new Point(16, 46);

            this.cardPending.Controls.Add(this.lblPendingTitle);
            this.cardPending.Controls.Add(this.lblPendingCount);

            // Announcements
            this.cardAnnouncements.CornerRadius = 18;
            this.cardAnnouncements.ShadowOffset = 4;
            this.cardAnnouncements.BackColor = Color.FromArgb(0, 173, 196);
            this.cardAnnouncements.Location = new Point(20 + (statsWidth + statsGap) * 2, statsTop);
            this.cardAnnouncements.Size = new Size(statsWidth, statsHeight);

            this.lblAnnTitle.AutoSize = true;
            this.lblAnnTitle.Text = "Announcements";
            this.lblAnnTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            this.lblAnnTitle.ForeColor = Color.White;
            this.lblAnnTitle.Location = new Point(18, 18);

            this.lblAnnCount.AutoSize = true;
            this.lblAnnCount.Text = "5";
            this.lblAnnCount.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold);
            this.lblAnnCount.ForeColor = Color.White;
            this.lblAnnCount.Location = new Point(16, 46);

            this.cardAnnouncements.Controls.Add(this.lblAnnTitle);
            this.cardAnnouncements.Controls.Add(this.lblAnnCount);

            // ======================================================
            // QUICK SERVICES
            // ======================================================
            this.lblQuickServices.AutoSize = true;
            this.lblQuickServices.Text = "Quick Services";
            this.lblQuickServices.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            this.lblQuickServices.ForeColor = Color.FromArgb(40, 40, 40);
            this.lblQuickServices.Location = new Point(24, statsTop + statsHeight + 20);

            int qsTop = statsTop + statsHeight + 48;
            int qsHeight = 80;
            int qsWidth = 190;
            int qsGap = 14;

            // Document Request
            this.quickDocRequest.CornerRadius = 14;
            this.quickDocRequest.ShadowOffset = 2;
            this.quickDocRequest.BackColor = Color.FromArgb(15, 35, 90);
            this.quickDocRequest.Location = new Point(20, qsTop);
            this.quickDocRequest.Size = new Size(qsWidth, qsHeight);
            this.quickDocRequest.Cursor = Cursors.Hand;

            this.lblQuickDocTitle.AutoSize = true;
            this.lblQuickDocTitle.Text = "Document\r\nRequest";
            this.lblQuickDocTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            this.lblQuickDocTitle.ForeColor = Color.White;
            this.lblQuickDocTitle.Location = new Point(18, 16);

            this.lblQuickDocSub.AutoSize = true;
            this.lblQuickDocSub.Text = "Apply online";
            this.lblQuickDocSub.Font = new Font("Segoe UI", 8.5F);
            this.lblQuickDocSub.ForeColor = Color.Gainsboro;
            this.lblQuickDocSub.Location = new Point(18, 52);

            this.quickDocRequest.Controls.Add(this.lblQuickDocTitle);
            this.quickDocRequest.Controls.Add(this.lblQuickDocSub);

            // Online Payments
            this.quickOnlinePayments.CornerRadius = 14;
            this.quickOnlinePayments.ShadowOffset = 2;
            this.quickOnlinePayments.BackColor = Color.FromArgb(109, 46, 220);
            this.quickOnlinePayments.Location = new Point(20 + qsWidth + qsGap, qsTop);
            this.quickOnlinePayments.Size = new Size(qsWidth, qsHeight);
            this.quickOnlinePayments.Cursor = Cursors.Hand;

            this.lblQuickPayTitle.AutoSize = true;
            this.lblQuickPayTitle.Text = "Online\r\nPayments";
            this.lblQuickPayTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            this.lblQuickPayTitle.ForeColor = Color.White;
            this.lblQuickPayTitle.Location = new Point(18, 16);

            this.lblQuickPaySub.AutoSize = true;
            this.lblQuickPaySub.Text = "Pay dues easily";
            this.lblQuickPaySub.Font = new Font("Segoe UI", 8.5F);
            this.lblQuickPaySub.ForeColor = Color.Gainsboro;
            this.lblQuickPaySub.Location = new Point(18, 52);

            this.quickOnlinePayments.Controls.Add(this.lblQuickPayTitle);
            this.quickOnlinePayments.Controls.Add(this.lblQuickPaySub);

            // Report Issues
            this.quickReportIssues.CornerRadius = 14;
            this.quickReportIssues.ShadowOffset = 2;
            this.quickReportIssues.BackColor = Color.FromArgb(240, 121, 40);
            this.quickReportIssues.Location = new Point(20 + (qsWidth + qsGap) * 2, qsTop);
            this.quickReportIssues.Size = new Size(qsWidth, qsHeight);
            this.quickReportIssues.Cursor = Cursors.Hand;

            this.lblQuickReportTitle.AutoSize = true;
            this.lblQuickReportTitle.Text = "Report\r\nissues";
            this.lblQuickReportTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            this.lblQuickReportTitle.ForeColor = Color.White;
            this.lblQuickReportTitle.Location = new Point(18, 16);

            this.lblQuickReportSub.AutoSize = true;
            this.lblQuickReportSub.Text = "Let us know";
            this.lblQuickReportSub.Font = new Font("Segoe UI", 8.5F);
            this.lblQuickReportSub.ForeColor = Color.WhiteSmoke;
            this.lblQuickReportSub.Location = new Point(18, 52);

            this.quickReportIssues.Controls.Add(this.lblQuickReportTitle);
            this.quickReportIssues.Controls.Add(this.lblQuickReportSub);

            // View Map
            this.quickViewMap.CornerRadius = 14;
            this.quickViewMap.ShadowOffset = 2;
            this.quickViewMap.BackColor = Color.FromArgb(65, 115, 250);
            this.quickViewMap.Location = new Point(20, qsTop + qsHeight + 14);
            this.quickViewMap.Size = new Size(qsWidth, qsHeight);
            this.quickViewMap.Cursor = Cursors.Hand;

            this.lblQuickMapTitle.AutoSize = true;
            this.lblQuickMapTitle.Text = "View Map";
            this.lblQuickMapTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            this.lblQuickMapTitle.ForeColor = Color.White;
            this.lblQuickMapTitle.Location = new Point(18, 18);

            this.lblQuickMapSub.AutoSize = true;
            this.lblQuickMapSub.Text = "Locate services";
            this.lblQuickMapSub.Font = new Font("Segoe UI", 8.5F);
            this.lblQuickMapSub.ForeColor = Color.WhiteSmoke;
            this.lblQuickMapSub.Location = new Point(18, 48);

            this.quickViewMap.Controls.Add(this.lblQuickMapTitle);
            this.quickViewMap.Controls.Add(this.lblQuickMapSub);

            // ======================================================
            // LATEST UPDATES
            // ======================================================
            this.lblLatestUpdates.AutoSize = true;
            this.lblLatestUpdates.Text = "Latest Updates";
            this.lblLatestUpdates.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            this.lblLatestUpdates.ForeColor = Color.FromArgb(40, 40, 40);
            this.lblLatestUpdates.Location = new Point(20 + (qsWidth + qsGap) * 2 + qsWidth + 50, statsTop + statsHeight + 20);

            int upLeft = 20 + (qsWidth + qsGap) * 2 + qsWidth + 50;
            int upTop = statsTop + statsHeight + 52;
            int upWidth = 360;
            int upHeight = 84;
            int upGap = 10;

            // Update 1
            this.update1.CornerRadius = 14;
            this.update1.ShadowOffset = 2;
            this.update1.BackColor = Color.White;
            this.update1.Location = new Point(upLeft, upTop);
            this.update1.Size = new Size(upWidth, upHeight);

            this.lblUpdate1Title.AutoSize = true;
            this.lblUpdate1Title.Text = "Community event scheduled";
            this.lblUpdate1Title.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            this.lblUpdate1Title.ForeColor = Color.FromArgb(40, 40, 40);
            this.lblUpdate1Title.Location = new Point(18, 10);

            this.lblUpdate1Body.AutoSize = true;
            this.lblUpdate1Body.Text = "A clean up drive is scheduled this\r\nSaturday at the main park area.";
            this.lblUpdate1Body.Font = new Font("Segoe UI", 8.8F);
            this.lblUpdate1Body.ForeColor = Color.DimGray;
            this.lblUpdate1Body.Location = new Point(18, 32);

            this.lblUpdate1Time.AutoSize = true;
            this.lblUpdate1Time.Text = "2 days ago";
            this.lblUpdate1Time.Font = new Font("Segoe UI", 8.2F);
            this.lblUpdate1Time.ForeColor = Color.Gray;
            this.lblUpdate1Time.Location = new Point(upWidth - 80, 12);

            this.update1.Controls.Add(this.lblUpdate1Title);
            this.update1.Controls.Add(this.lblUpdate1Body);
            this.update1.Controls.Add(this.lblUpdate1Time);

            // Update 2
            upTop += upHeight + upGap;
            this.update2.CornerRadius = 14;
            this.update2.ShadowOffset = 2;
            this.update2.BackColor = Color.White;
            this.update2.Location = new Point(upLeft, upTop);
            this.update2.Size = new Size(upWidth, upHeight);

            this.lblUpdate2Title.AutoSize = true;
            this.lblUpdate2Title.Text = "Road maintenance on Main St.";
            this.lblUpdate2Title.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            this.lblUpdate2Title.ForeColor = Color.FromArgb(40, 40, 40);
            this.lblUpdate2Title.Location = new Point(18, 10);

            this.lblUpdate2Body.AutoSize = true;
            this.lblUpdate2Body.Text = "Expect temporary closures and\r\ndefours on Main Street next week.";
            this.lblUpdate2Body.Font = new Font("Segoe UI", 8.8F);
            this.lblUpdate2Body.ForeColor = Color.DimGray;
            this.lblUpdate2Body.Location = new Point(18, 32);

            this.lblUpdate2Time.AutoSize = true;
            this.lblUpdate2Time.Text = "5 days ago";
            this.lblUpdate2Time.Font = new Font("Segoe UI", 8.2F);
            this.lblUpdate2Time.ForeColor = Color.Gray;
            this.lblUpdate2Time.Location = new Point(upWidth - 80, 12);

            this.update2.Controls.Add(this.lblUpdate2Title);
            this.update2.Controls.Add(this.lblUpdate2Body);
            this.update2.Controls.Add(this.lblUpdate2Time);

            // Update 3
            upTop += upHeight + upGap;
            this.update3.CornerRadius = 14;
            this.update3.ShadowOffset = 2;
            this.update3.BackColor = Color.White;
            this.update3.Location = new Point(upLeft, upTop);
            this.update3.Size = new Size(upWidth, upHeight);

            this.lblUpdate3Title.AutoSize = true;
            this.lblUpdate3Title.Text = "Vaccination drive this week";
            this.lblUpdate3Title.Font = new Font("Segoe UI Semibold", 9.8F, FontStyle.Bold);
            this.lblUpdate3Title.ForeColor = Color.FromArgb(40, 40, 40);
            this.lblUpdate3Title.Location = new Point(18, 10);

            this.lblUpdate3Body.AutoSize = true;
            this.lblUpdate3Body.Text = "A vaccination drive will be held in\r\nthe barangay hall for eligible resi.";
            this.lblUpdate3Body.Font = new Font("Segoe UI", 8.8F);
            this.lblUpdate3Body.ForeColor = Color.DimGray;
            this.lblUpdate3Body.Location = new Point(18, 32);

            this.lblUpdate3Time.AutoSize = true;
            this.lblUpdate3Time.Text = "1 week ago";
            this.lblUpdate3Time.Font = new Font("Segoe UI", 8.2F);
            this.lblUpdate3Time.ForeColor = Color.Gray;
            this.lblUpdate3Time.Location = new Point(upWidth - 80, 12);

            this.update3.Controls.Add(this.lblUpdate3Title);
            this.update3.Controls.Add(this.lblUpdate3Body);
            this.update3.Controls.Add(this.lblUpdate3Time);

            // ======================================================
            // MAIN: ADD CONTROLS
            // ======================================================
            this.pnlMain.Controls.Add(this.lblMainTitle);
            this.pnlMain.Controls.Add(this.lblMainSubtitle);
            this.pnlMain.Controls.Add(this.pnlSearch);
            this.pnlMain.Controls.Add(this.picUserAvatar);

            this.pnlMain.Controls.Add(this.cardResidents);
            this.pnlMain.Controls.Add(this.cardPending);
            this.pnlMain.Controls.Add(this.cardAnnouncements);

            this.pnlMain.Controls.Add(this.lblQuickServices);
            this.pnlMain.Controls.Add(this.quickDocRequest);
            this.pnlMain.Controls.Add(this.quickOnlinePayments);
            this.pnlMain.Controls.Add(this.quickReportIssues);
            this.pnlMain.Controls.Add(this.quickViewMap);

            this.pnlMain.Controls.Add(this.lblLatestUpdates);
            this.pnlMain.Controls.Add(this.update1);
            this.pnlMain.Controls.Add(this.update2);
            this.pnlMain.Controls.Add(this.update3);

            // ======================================================
            // FORM: ADD ROOT
            // ======================================================
            this.Controls.Add(this.pnlRoot);

            ((ISupportInitialize)(this.picSeal)).EndInit();
            ((ISupportInitialize)(this.picUserAvatar)).EndInit();
            ((ISupportInitialize)(this.iconSearch)).EndInit();

            this.pnlRoot.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlNavDashboard.ResumeLayout(false);
            this.pnlNavServices.ResumeLayout(false);
            this.pnlNavBlotter.ResumeLayout(false);
            this.pnlNavMap.ResumeLayout(false);
            this.pnlNavAbout.ResumeLayout(false);
            this.pnlSidebarProfile.ResumeLayout(false);

            this.cardResidents.ResumeLayout(false);
            this.cardResidents.PerformLayout();
            this.cardPending.ResumeLayout(false);
            this.cardPending.PerformLayout();
            this.cardAnnouncements.ResumeLayout(false);
            this.cardAnnouncements.PerformLayout();

            this.quickDocRequest.ResumeLayout(false);
            this.quickDocRequest.PerformLayout();
            this.quickOnlinePayments.ResumeLayout(false);
            this.quickOnlinePayments.PerformLayout();
            this.quickReportIssues.ResumeLayout(false);
            this.quickReportIssues.PerformLayout();
            this.quickViewMap.ResumeLayout(false);
            this.quickViewMap.PerformLayout();

            this.update1.ResumeLayout(false);
            this.update1.PerformLayout();
            this.update2.ResumeLayout(false);
            this.update2.PerformLayout();
            this.update3.ResumeLayout(false);
            this.update3.PerformLayout();

            this.ResumeLayout(false);
        }

        #endregion
    }
}
