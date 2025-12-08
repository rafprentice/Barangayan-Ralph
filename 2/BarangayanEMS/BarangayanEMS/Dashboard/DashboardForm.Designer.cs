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
        private Panel pnlContentHost;   // where you can later add user controls / extra pages

        // Sidebar controls
        private PictureBox picSeal;
        private Label lblRepublic;
        private Label lblSystem;
        private Panel navDashboard;
        private Panel navServices;
        private Panel navRequirements;
        private Panel navFeedback;
        private Panel navAbout;
        private Label lblNavDashboard;
        private Label lblNavServices;
        private Label lblNavRequirements;
        private Label lblNavFeedback;
        private Label lblNavAbout;

        // Top bar
        private Label lblMainTitle;
        private Label lblMainSubtitle;
        private RoundedPanel pnlSearch;
        private PictureBox iconSearch;
        private TextBox txtSearch;
        private PictureBox picUserAvatar;

        // Metric cards top row
        private RoundedPanel cardPopulation;
        private RoundedPanel cardAnnouncements;
        private RoundedPanel cardPending;
        private Label lblPopTitle;
        private Label lblPopValue;
        private Label lblAnnTitle;
        private Label lblAnnValue;
        private Label lblPendingTitle;
        private Label lblPendingValue;

        // Second row cards
        private RoundedPanel cardDocumentRequests;
        private RoundedPanel cardBlotterReports;
        private Label lblDocTitle;
        private Label lblDocSub;
        private Label lblBlotterTitle;
        private Label lblBlotterSub;

        /// <summary>
        /// Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.pnlRoot = new BarangayanEMS.GradientPanel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlContentHost = new System.Windows.Forms.Panel();
            this.cardPopulation = new BarangayanEMS.RoundedPanel();
            this.lblPopTitle = new System.Windows.Forms.Label();
            this.lblPopValue = new System.Windows.Forms.Label();
            this.cardAnnouncements = new BarangayanEMS.RoundedPanel();
            this.lblAnnTitle = new System.Windows.Forms.Label();
            this.lblAnnValue = new System.Windows.Forms.Label();
            this.cardPending = new BarangayanEMS.RoundedPanel();
            this.lblPendingTitle = new System.Windows.Forms.Label();
            this.lblPendingValue = new System.Windows.Forms.Label();
            this.cardDocumentRequests = new BarangayanEMS.RoundedPanel();
            this.lblDocTitle = new System.Windows.Forms.Label();
            this.lblDocSub = new System.Windows.Forms.Label();
            this.lblDocValue = new System.Windows.Forms.Label();
            this.cardBlotterReports = new BarangayanEMS.RoundedPanel();
            this.lblBlotterTitle = new System.Windows.Forms.Label();
            this.lblBlotterSub = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblMainTitle = new System.Windows.Forms.Label();
            this.lblMainSubtitle = new System.Windows.Forms.Label();
            this.pnlSearch = new BarangayanEMS.RoundedPanel();
            this.iconSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.picUserAvatar = new System.Windows.Forms.PictureBox();
            this.pnlSidebar = new BarangayanEMS.GradientPanel();
            this.navAbout = new System.Windows.Forms.Panel();
            this.lblNavAbout = new System.Windows.Forms.Label();
            this.navFeedback = new System.Windows.Forms.Panel();
            this.lblNavFeedback = new System.Windows.Forms.Label();
            this.navRequirements = new System.Windows.Forms.Panel();
            this.lblNavRequirements = new System.Windows.Forms.Label();
            this.navServices = new System.Windows.Forms.Panel();
            this.lblNavServices = new System.Windows.Forms.Label();
            this.navDashboard = new System.Windows.Forms.Panel();
            this.lblNavDashboard = new System.Windows.Forms.Label();
            this.lblSystem = new System.Windows.Forms.Label();
            this.lblRepublic = new System.Windows.Forms.Label();
            this.picSeal = new System.Windows.Forms.PictureBox();
            this.pnlRoot.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlContentHost.SuspendLayout();
            this.cardPopulation.SuspendLayout();
            this.cardAnnouncements.SuspendLayout();
            this.cardPending.SuspendLayout();
            this.cardDocumentRequests.SuspendLayout();
            this.cardBlotterReports.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.navAbout.SuspendLayout();
            this.navFeedback.SuspendLayout();
            this.navRequirements.SuspendLayout();
            this.navServices.SuspendLayout();
            this.navDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRoot
            // 
            this.pnlRoot.Angle = 135F;
            this.pnlRoot.Controls.Add(this.pnlMain);
            this.pnlRoot.Controls.Add(this.pnlSidebar);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(87)))), ((int)(((byte)(255)))));
            this.pnlRoot.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(84)))), ((int)(((byte)(255)))));
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.Size = new System.Drawing.Size(1280, 720);
            this.pnlRoot.TabIndex = 0;
            this.pnlRoot.UseSmoothBlend = true;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.pnlContentHost);
            this.pnlMain.Controls.Add(this.pnlTop);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(230, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(16);
            this.pnlMain.Size = new System.Drawing.Size(1050, 720);
            this.pnlMain.TabIndex = 1;
            // 
            // pnlContentHost
            // 
            this.pnlContentHost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
            this.pnlContentHost.Controls.Add(this.cardPopulation);
            this.pnlContentHost.Controls.Add(this.cardAnnouncements);
            this.pnlContentHost.Controls.Add(this.cardPending);
            this.pnlContentHost.Controls.Add(this.cardDocumentRequests);
            this.pnlContentHost.Controls.Add(this.cardBlotterReports);
            this.pnlContentHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContentHost.Location = new System.Drawing.Point(16, 96);
            this.pnlContentHost.Name = "pnlContentHost";
            this.pnlContentHost.Size = new System.Drawing.Size(1018, 608);
            this.pnlContentHost.TabIndex = 1;
            // 
            // cardPopulation
            // 
            this.cardPopulation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(109)))), ((int)(((byte)(242)))));
            this.cardPopulation.BorderColor = System.Drawing.Color.Transparent;
            this.cardPopulation.Controls.Add(this.lblPopTitle);
            this.cardPopulation.Controls.Add(this.lblPopValue);
            this.cardPopulation.CornerRadius = 18;
            this.cardPopulation.Location = new System.Drawing.Point(24, 12);
            this.cardPopulation.Name = "cardPopulation";
            this.cardPopulation.ShadowAlpha = 25;
            this.cardPopulation.ShadowOffset = 4;
            this.cardPopulation.Size = new System.Drawing.Size(210, 110);
            this.cardPopulation.TabIndex = 1;
            // 
            // lblPopTitle
            // 
            this.lblPopTitle.AutoSize = true;
            this.lblPopTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPopTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPopTitle.ForeColor = System.Drawing.Color.White;
            this.lblPopTitle.Location = new System.Drawing.Point(16, 16);
            this.lblPopTitle.Name = "lblPopTitle";
            this.lblPopTitle.Size = new System.Drawing.Size(102, 17);
            this.lblPopTitle.TabIndex = 0;
            this.lblPopTitle.Text = "Total Population";
            // 
            // lblPopValue
            // 
            this.lblPopValue.AutoSize = true;
            this.lblPopValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPopValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblPopValue.ForeColor = System.Drawing.Color.White;
            this.lblPopValue.Location = new System.Drawing.Point(16, 42);
            this.lblPopValue.Name = "lblPopValue";
            this.lblPopValue.Size = new System.Drawing.Size(115, 37);
            this.lblPopValue.TabIndex = 1;
            this.lblPopValue.Text = "204,500";
            // 
            // cardAnnouncements
            // 
            this.cardAnnouncements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(214)))));
            this.cardAnnouncements.BorderColor = System.Drawing.Color.Transparent;
            this.cardAnnouncements.Controls.Add(this.lblAnnTitle);
            this.cardAnnouncements.Controls.Add(this.lblAnnValue);
            this.cardAnnouncements.CornerRadius = 18;
            this.cardAnnouncements.Location = new System.Drawing.Point(263, 12);
            this.cardAnnouncements.Name = "cardAnnouncements";
            this.cardAnnouncements.ShadowAlpha = 25;
            this.cardAnnouncements.ShadowOffset = 4;
            this.cardAnnouncements.Size = new System.Drawing.Size(180, 110);
            this.cardAnnouncements.TabIndex = 2;
            // 
            // lblAnnTitle
            // 
            this.lblAnnTitle.AutoSize = true;
            this.lblAnnTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAnnTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblAnnTitle.ForeColor = System.Drawing.Color.White;
            this.lblAnnTitle.Location = new System.Drawing.Point(16, 16);
            this.lblAnnTitle.Name = "lblAnnTitle";
            this.lblAnnTitle.Size = new System.Drawing.Size(100, 17);
            this.lblAnnTitle.TabIndex = 0;
            this.lblAnnTitle.Text = "Announcements";
            // 
            // lblAnnValue
            // 
            this.lblAnnValue.AutoSize = true;
            this.lblAnnValue.BackColor = System.Drawing.Color.Transparent;
            this.lblAnnValue.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblAnnValue.ForeColor = System.Drawing.Color.White;
            this.lblAnnValue.Location = new System.Drawing.Point(16, 42);
            this.lblAnnValue.Name = "lblAnnValue";
            this.lblAnnValue.Size = new System.Drawing.Size(32, 37);
            this.lblAnnValue.TabIndex = 1;
            this.lblAnnValue.Text = "5";
            // 
            // cardPending
            // 
            this.cardPending.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(84)))), ((int)(((byte)(245)))));
            this.cardPending.BorderColor = System.Drawing.Color.Transparent;
            this.cardPending.Controls.Add(this.lblPendingTitle);
            this.cardPending.CornerRadius = 18;
            this.cardPending.Location = new System.Drawing.Point(487, 12);
            this.cardPending.Name = "cardPending";
            this.cardPending.ShadowAlpha = 25;
            this.cardPending.ShadowOffset = 4;
            this.cardPending.Size = new System.Drawing.Size(180, 110);
            this.cardPending.TabIndex = 3;
            this.cardPending.Paint += new System.Windows.Forms.PaintEventHandler(this.cardPending_Paint);
            // 
            // lblPendingTitle
            // 
            this.lblPendingTitle.AutoSize = true;
            this.lblPendingTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblPendingTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPendingTitle.ForeColor = System.Drawing.Color.White;
            this.lblPendingTitle.Location = new System.Drawing.Point(16, 16);
            this.lblPendingTitle.Name = "lblPendingTitle";
            this.lblPendingTitle.Size = new System.Drawing.Size(112, 17);
            this.lblPendingTitle.TabIndex = 0;
            this.lblPendingTitle.Text = "Pending Requests";
            // 
            // lblPendingValue
            // 
            this.lblPendingValue.AutoSize = true;
            this.lblPendingValue.BackColor = System.Drawing.Color.Transparent;
            this.lblPendingValue.Font = new System.Drawing.Font("Segoe UI Semibold", 28F);
            this.lblPendingValue.ForeColor = System.Drawing.Color.White;
            this.lblPendingValue.Location = new System.Drawing.Point(22, 110);
            this.lblPendingValue.Name = "lblPendingValue";
            this.lblPendingValue.Size = new System.Drawing.Size(43, 51);
            this.lblPendingValue.TabIndex = 1;
            this.lblPendingValue.Text = "0";
            this.lblPendingValue.Click += new System.EventHandler(this.CardChild_ClickForward);
            // 
            // cardDocumentRequests
            // 
            this.cardDocumentRequests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(153)))), ((int)(((byte)(89)))));
            this.cardDocumentRequests.BorderColor = System.Drawing.Color.Transparent;
            this.cardDocumentRequests.Controls.Add(this.lblDocTitle);
            this.cardDocumentRequests.Controls.Add(this.lblDocSub);
            this.cardDocumentRequests.Controls.Add(this.lblDocValue);
            this.cardDocumentRequests.CornerRadius = 20;
            this.cardDocumentRequests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardDocumentRequests.Location = new System.Drawing.Point(43, 328);
            this.cardDocumentRequests.Name = "cardDocumentRequests";
            this.cardDocumentRequests.ShadowAlpha = 30;
            this.cardDocumentRequests.ShadowOffset = 6;
            this.cardDocumentRequests.Size = new System.Drawing.Size(251, 191);
            this.cardDocumentRequests.TabIndex = 4;
            this.cardDocumentRequests.Click += new System.EventHandler(this.cardDocumentRequests_Click);
            // 
            // lblDocTitle
            // 
            this.lblDocTitle.AutoSize = true;
            this.lblDocTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblDocTitle.ForeColor = System.Drawing.Color.White;
            this.lblDocTitle.Location = new System.Drawing.Point(18, 20);
            this.lblDocTitle.Name = "lblDocTitle";
            this.lblDocTitle.Size = new System.Drawing.Size(183, 25);
            this.lblDocTitle.TabIndex = 0;
            this.lblDocTitle.Text = "Document Requests";
            this.lblDocTitle.Click += new System.EventHandler(this.CardChild_ClickForward);
            // 
            // lblDocSub
            // 
            this.lblDocSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDocSub.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDocSub.Location = new System.Drawing.Point(18, 55);
            this.lblDocSub.Name = "lblDocSub";
            this.lblDocSub.Size = new System.Drawing.Size(209, 42);
            this.lblDocSub.TabIndex = 1;
            this.lblDocSub.Text = "Process barangay clearance, residency, indigency and other documents.";
            this.lblDocSub.Click += new System.EventHandler(this.CardChild_ClickForward);
            // 
            // lblDocValue
            // 
            this.lblDocValue.Font = new System.Drawing.Font("Segoe UI Semibold", 28F);
            this.lblDocValue.ForeColor = System.Drawing.Color.White;
            this.lblDocValue.Location = new System.Drawing.Point(25, 110);
            this.lblDocValue.Name = "lblDocValue";
            this.lblDocValue.Size = new System.Drawing.Size(42, 51);
            this.lblDocValue.TabIndex = 2;
            this.lblDocValue.Text = "0";
            this.lblDocValue.Click += new System.EventHandler(this.CardChild_ClickForward);
            // 
            // cardBlotterReports
            // 
            this.cardBlotterReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(105)))), ((int)(((byte)(60)))));
            this.cardBlotterReports.BorderColor = System.Drawing.Color.Transparent;
            this.cardBlotterReports.Controls.Add(this.lblBlotterTitle);
            this.cardBlotterReports.Controls.Add(this.lblBlotterSub);
            this.cardBlotterReports.Controls.Add(this.lblPendingValue);
            this.cardBlotterReports.CornerRadius = 20;
            this.cardBlotterReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardBlotterReports.Location = new System.Drawing.Point(308, 328);
            this.cardBlotterReports.Name = "cardBlotterReports";
            this.cardBlotterReports.ShadowAlpha = 30;
            this.cardBlotterReports.ShadowOffset = 6;
            this.cardBlotterReports.Size = new System.Drawing.Size(230, 191);
            this.cardBlotterReports.TabIndex = 5;
            this.cardBlotterReports.Click += new System.EventHandler(this.cardBlotterReports_Click);
            // 
            // lblBlotterTitle
            // 
            this.lblBlotterTitle.AutoSize = true;
            this.lblBlotterTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblBlotterTitle.ForeColor = System.Drawing.Color.White;
            this.lblBlotterTitle.Location = new System.Drawing.Point(18, 20);
            this.lblBlotterTitle.Name = "lblBlotterTitle";
            this.lblBlotterTitle.Size = new System.Drawing.Size(123, 21);
            this.lblBlotterTitle.TabIndex = 0;
            this.lblBlotterTitle.Text = "Blotter Reports";
            this.lblBlotterTitle.Click += new System.EventHandler(this.CardChild_ClickForward);
            // 
            // lblBlotterSub
            // 
            this.lblBlotterSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBlotterSub.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBlotterSub.Location = new System.Drawing.Point(20, 55);
            this.lblBlotterSub.Name = "lblBlotterSub";
            this.lblBlotterSub.Size = new System.Drawing.Size(191, 42);
            this.lblBlotterSub.TabIndex = 1;
            this.lblBlotterSub.Text = "View and manage blotter incident reports submitted by residents.";
            this.lblBlotterSub.Click += new System.EventHandler(this.CardChild_ClickForward);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.lblMainTitle);
            this.pnlTop.Controls.Add(this.lblMainSubtitle);
            this.pnlTop.Controls.Add(this.pnlSearch);
            this.pnlTop.Controls.Add(this.picUserAvatar);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(16, 16);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(8, 8, 16, 8);
            this.pnlTop.Size = new System.Drawing.Size(1018, 80);
            this.pnlTop.TabIndex = 2;
            // 
            // lblMainTitle
            // 
            this.lblMainTitle.AutoSize = true;
            this.lblMainTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.lblMainTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.lblMainTitle.Location = new System.Drawing.Point(16, 14);
            this.lblMainTitle.Name = "lblMainTitle";
            this.lblMainTitle.Size = new System.Drawing.Size(235, 32);
            this.lblMainTitle.TabIndex = 0;
            this.lblMainTitle.Text = "Welcome back, User";
            // 
            // lblMainSubtitle
            // 
            this.lblMainSubtitle.AutoSize = true;
            this.lblMainSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMainSubtitle.ForeColor = System.Drawing.Color.DimGray;
            this.lblMainSubtitle.Location = new System.Drawing.Point(16, 43);
            this.lblMainSubtitle.Name = "lblMainSubtitle";
            this.lblMainSubtitle.Size = new System.Drawing.Size(186, 15);
            this.lblMainSubtitle.TabIndex = 1;
            this.lblMainSubtitle.Text = "Digital Local Government Services";
            // 
            // pnlSearch
            // 
            this.pnlSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.pnlSearch.BorderColor = System.Drawing.Color.Transparent;
            this.pnlSearch.Controls.Add(this.iconSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.CornerRadius = 18;
            this.pnlSearch.Location = new System.Drawing.Point(1398, 20);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.ShadowAlpha = 10;
            this.pnlSearch.ShadowOffset = 2;
            this.pnlSearch.Size = new System.Drawing.Size(370, 36);
            this.pnlSearch.TabIndex = 2;
            // 
            // iconSearch
            // 
            this.iconSearch.BackColor = System.Drawing.Color.Transparent;
            this.iconSearch.Location = new System.Drawing.Point(12, 9);
            this.iconSearch.Name = "iconSearch";
            this.iconSearch.Size = new System.Drawing.Size(16, 16);
            this.iconSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconSearch.TabIndex = 0;
            this.iconSearch.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(40, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(320, 16);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search";
            // 
            // picUserAvatar
            // 
            this.picUserAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picUserAvatar.BackColor = System.Drawing.Color.Silver;
            this.picUserAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picUserAvatar.Location = new System.Drawing.Point(1786, 18);
            this.picUserAvatar.Name = "picUserAvatar";
            this.picUserAvatar.Size = new System.Drawing.Size(40, 40);
            this.picUserAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUserAvatar.TabIndex = 3;
            this.picUserAvatar.TabStop = false;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Angle = 90F;
            this.pnlSidebar.Controls.Add(this.navAbout);
            this.pnlSidebar.Controls.Add(this.navFeedback);
            this.pnlSidebar.Controls.Add(this.navRequirements);
            this.pnlSidebar.Controls.Add(this.navServices);
            this.pnlSidebar.Controls.Add(this.navDashboard);
            this.pnlSidebar.Controls.Add(this.lblSystem);
            this.pnlSidebar.Controls.Add(this.lblRepublic);
            this.pnlSidebar.Controls.Add(this.picSeal);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlSidebar.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Padding = new System.Windows.Forms.Padding(16, 24, 16, 16);
            this.pnlSidebar.Size = new System.Drawing.Size(230, 720);
            this.pnlSidebar.TabIndex = 0;
            this.pnlSidebar.UseSmoothBlend = true;
            // 
            // navAbout
            // 
            this.navAbout.BackColor = System.Drawing.Color.Transparent;
            this.navAbout.Controls.Add(this.lblNavAbout);
            this.navAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navAbout.Location = new System.Drawing.Point(18, 345);
            this.navAbout.Name = "navAbout";
            this.navAbout.Size = new System.Drawing.Size(190, 36);
            this.navAbout.TabIndex = 0;
            // 
            // lblNavAbout
            // 
            this.lblNavAbout.AutoSize = true;
            this.lblNavAbout.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNavAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblNavAbout.Location = new System.Drawing.Point(12, 10);
            this.lblNavAbout.Name = "lblNavAbout";
            this.lblNavAbout.Size = new System.Drawing.Size(62, 17);
            this.lblNavAbout.TabIndex = 0;
            this.lblNavAbout.Text = "About Us";
            // 
            // navFeedback
            // 
            this.navFeedback.BackColor = System.Drawing.Color.Transparent;
            this.navFeedback.Controls.Add(this.lblNavFeedback);
            this.navFeedback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navFeedback.Location = new System.Drawing.Point(18, 301);
            this.navFeedback.Name = "navFeedback";
            this.navFeedback.Size = new System.Drawing.Size(190, 36);
            this.navFeedback.TabIndex = 1;
            // 
            // lblNavFeedback
            // 
            this.lblNavFeedback.AutoSize = true;
            this.lblNavFeedback.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNavFeedback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblNavFeedback.Location = new System.Drawing.Point(12, 10);
            this.lblNavFeedback.Name = "lblNavFeedback";
            this.lblNavFeedback.Size = new System.Drawing.Size(63, 17);
            this.lblNavFeedback.TabIndex = 0;
            this.lblNavFeedback.Text = "Feedback";
            // 
            // navRequirements
            // 
            this.navRequirements.BackColor = System.Drawing.Color.Transparent;
            this.navRequirements.Controls.Add(this.lblNavRequirements);
            this.navRequirements.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navRequirements.Location = new System.Drawing.Point(18, 251);
            this.navRequirements.Name = "navRequirements";
            this.navRequirements.Size = new System.Drawing.Size(190, 36);
            this.navRequirements.TabIndex = 2;
            // 
            // lblNavRequirements
            // 
            this.lblNavRequirements.AutoSize = true;
            this.lblNavRequirements.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNavRequirements.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblNavRequirements.Location = new System.Drawing.Point(12, 10);
            this.lblNavRequirements.Name = "lblNavRequirements";
            this.lblNavRequirements.Size = new System.Drawing.Size(88, 17);
            this.lblNavRequirements.TabIndex = 0;
            this.lblNavRequirements.Text = "Requirements";
            // 
            // navServices
            // 
            this.navServices.BackColor = System.Drawing.Color.Transparent;
            this.navServices.Controls.Add(this.lblNavServices);
            this.navServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navServices.Location = new System.Drawing.Point(18, 209);
            this.navServices.Name = "navServices";
            this.navServices.Size = new System.Drawing.Size(190, 36);
            this.navServices.TabIndex = 3;
            // 
            // lblNavServices
            // 
            this.lblNavServices.AutoSize = true;
            this.lblNavServices.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblNavServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblNavServices.Location = new System.Drawing.Point(12, 10);
            this.lblNavServices.Name = "lblNavServices";
            this.lblNavServices.Size = new System.Drawing.Size(55, 17);
            this.lblNavServices.TabIndex = 0;
            this.lblNavServices.Text = "Services";
            // 
            // navDashboard
            // 
            this.navDashboard.BackColor = System.Drawing.Color.White;
            this.navDashboard.Controls.Add(this.lblNavDashboard);
            this.navDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navDashboard.Location = new System.Drawing.Point(18, 167);
            this.navDashboard.Name = "navDashboard";
            this.navDashboard.Size = new System.Drawing.Size(190, 36);
            this.navDashboard.TabIndex = 4;
            // 
            // lblNavDashboard
            // 
            this.lblNavDashboard.AutoSize = true;
            this.lblNavDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblNavDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
            this.lblNavDashboard.Location = new System.Drawing.Point(12, 10);
            this.lblNavDashboard.Name = "lblNavDashboard";
            this.lblNavDashboard.Size = new System.Drawing.Size(74, 17);
            this.lblNavDashboard.TabIndex = 0;
            this.lblNavDashboard.Text = "Dashboard";
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.lblSystem.Location = new System.Drawing.Point(3, 121);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(229, 19);
            this.lblSystem.TabIndex = 5;
            this.lblSystem.Text = "Barangayan E-Management System";
            this.lblSystem.Click += new System.EventHandler(this.lblSystem_Click);
            // 
            // lblRepublic
            // 
            this.lblRepublic.AutoSize = true;
            this.lblRepublic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRepublic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblRepublic.Location = new System.Drawing.Point(47, 99);
            this.lblRepublic.Name = "lblRepublic";
            this.lblRepublic.Size = new System.Drawing.Size(123, 15);
            this.lblRepublic.TabIndex = 6;
            this.lblRepublic.Text = "Republika ng Pilipinas";
            this.lblRepublic.Click += new System.EventHandler(this.lblRepublic_Click);
            // 
            // picSeal
            // 
            this.picSeal.BackColor = System.Drawing.Color.LightGray;
            this.picSeal.Image = ((System.Drawing.Image)(resources.GetObject("picSeal.Image")));
            this.picSeal.Location = new System.Drawing.Point(70, 10);
            this.picSeal.Name = "picSeal";
            this.picSeal.Size = new System.Drawing.Size(80, 80);
            this.picSeal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSeal.TabIndex = 7;
            this.picSeal.TabStop = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlRoot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.pnlRoot.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlContentHost.ResumeLayout(false);
            this.cardPopulation.ResumeLayout(false);
            this.cardPopulation.PerformLayout();
            this.cardAnnouncements.ResumeLayout(false);
            this.cardAnnouncements.PerformLayout();
            this.cardPending.ResumeLayout(false);
            this.cardPending.PerformLayout();
            this.cardDocumentRequests.ResumeLayout(false);
            this.cardDocumentRequests.PerformLayout();
            this.cardBlotterReports.ResumeLayout(false);
            this.cardBlotterReports.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUserAvatar)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.navAbout.ResumeLayout(false);
            this.navAbout.PerformLayout();
            this.navFeedback.ResumeLayout(false);
            this.navFeedback.PerformLayout();
            this.navRequirements.ResumeLayout(false);
            this.navRequirements.PerformLayout();
            this.navServices.ResumeLayout(false);
            this.navServices.PerformLayout();
            this.navDashboard.ResumeLayout(false);
            this.navDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblDocValue;
    }
}
