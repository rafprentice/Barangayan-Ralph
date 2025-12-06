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
            this.SuspendLayout();
            // 
            // DashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(442, 261);
            this.Name = "DashboardForm";
            this.ResumeLayout(false);

            
        }

        #endregion
    }
}
