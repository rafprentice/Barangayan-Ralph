using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BarangayanEMS
{
    public partial class DashboardForm : Form
    {
        // ---------- PAGE ENUM ----------
        private enum DashboardPage
        {
            Dashboard,
            Services,
            Requirements,
            Feedback,
            About
        }

        // ---------- NAVIGATION STATE ----------
        private readonly Dictionary<Panel, DashboardPage> _navMap =
            new Dictionary<Panel, DashboardPage>();

        private Panel _activeNavPanel;
        private DashboardPage _activePage = DashboardPage.Dashboard;

        // Host where pages will slide in/out
        private Panel _contentHost;

        // Pages (created only here, not in Designer)
        private Panel _pageDashboard;
        private Panel _pageServices;
        private Panel _pageRequirements;
        private Panel _pageFeedback;
        private Panel _pageAbout;

        // ---------- SLIDE ANIMATION ----------
        private Timer _slideTimer;
        private Control _slideFrom;
        private Control _slideTo;
        private int _slideStep;
        private const int SlideSteps = 18;

        public DashboardForm(string userName = "Juan")
        {
            InitializeComponent();        // Designer builds base layout

            ResolveCoreControls();        // find pnlContentHost
            BuildPages(userName);         // create “pages” inside host
            SetupNavigation();            // hook sidebar nav
            SetupSearchBox();             // placeholder behavior
            SetupSlideTimer();            // page slide animation

            ShowPage(DashboardPage.Dashboard, immediate: true);
        }

        // =========================================================
        //  FIND EXISTING DESIGNER CONTROLS BY NAME
        // =========================================================
        private void ResolveCoreControls()
        {
            _contentHost = FindPanel("pnlContentHost");

            // basic fallback (should not happen if Designer is correct)
            if (_contentHost == null)
            {
                _contentHost = new Panel
                {
                    Dock = DockStyle.Fill,
                    BackColor = Color.White
                };
                this.Controls.Add(_contentHost);
            }
        }

        private Panel FindPanel(string name)
        {
            Control[] found = this.Controls.Find(name, true);
            return (found.Length > 0) ? found[0] as Panel : null;
        }

        private TextBox FindTextBox(string name)
        {
            Control[] found = this.Controls.Find(name, true);
            return (found.Length > 0) ? found[0] as TextBox : null;
        }

        // =========================================================
        //  BUILD DASHBOARD PAGES (ONLY IN THIS FILE)
        // =========================================================
        private void BuildPages(string userName)
        {
            _contentHost.Controls.Clear();

            // ----- DASHBOARD PAGE -----
            _pageDashboard = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(246, 247, 255)
            };

            // Big welcome text inside the content area
            Label lblWelcome = new Label
            {
                AutoSize = true,
                Text = $"Welcome back, {userName}",
                Font = new Font("Segoe UI Semibold", 22f),
                ForeColor = Color.FromArgb(32, 32, 32),
                Location = new Point(24, 24)
            };

            Label lblSub = new Label
            {
                AutoSize = true,
                Text = "Sign in to access your barangay services",
                Font = new Font("Segoe UI", 10.5f),
                ForeColor = Color.DimGray,
                Location = new Point(26, 60)
            };

            _pageDashboard.Controls.Add(lblWelcome);
            _pageDashboard.Controls.Add(lblSub);

            // ===== METRIC CARDS (TOP ROW) =====
            // positions tuned to resemble the reference UI
            _pageDashboard.Controls.Add(CreateMetricCard(
                "👥 Total Population",
                "204,500",
                Color.FromArgb(77, 109, 242),
                new Point(32, 110)
            ));

            _pageDashboard.Controls.Add(CreateMetricCard(
                "📣 Announcements",
                "5",
                Color.FromArgb(0, 168, 214),
                new Point(330, 110)
            ));

            _pageDashboard.Controls.Add(CreateMetricCard(
                "🕒 Pending Requests",
                "0",
                Color.FromArgb(130, 84, 245),
                new Point(628, 110)
            ));

            // ===== LARGE CARDS (SECOND ROW) =====
            // DOCUMENT REQUESTS
            Panel cardDoc = new Panel
            {
                Size = new Size(268, 190),
                Location = new Point(32, 260),
                BackColor = Color.FromArgb(63, 153, 89),
                Cursor = Cursors.Hand
            };
            cardDoc.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rect = new Rectangle(0, 0, cardDoc.Width - 1, cardDoc.Height - 1);
                using (GraphicsPath path = RoundedRect(rect, 22))
                using (SolidBrush brush = new SolidBrush(cardDoc.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            };
            cardDoc.Click += cardDocumentRequests_Click;

            Label docTitle = new Label
            {
                AutoSize = true,
                Text = "📄 Document Requests",
                Font = new Font("Segoe UI Semibold", 13f),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Location = new Point(22, 18)
            };
            docTitle.Click += CardChild_ClickForward;

            Label docValue = new Label
            {
                AutoSize = true,
                Text = "0",
                Font = new Font("Segoe UI Semibold", 32f),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Location = new Point(26, 60)
            };
            docValue.Click += CardChild_ClickForward;

            Label docSub = new Label
            {
                AutoSize = true,
                Text = "Total processed",
                Font = new Font("Segoe UI", 9.5f),
                ForeColor = Color.WhiteSmoke,
                BackColor = Color.Transparent,
                Location = new Point(26, 140)
            };
            docSub.Click += CardChild_ClickForward;

            cardDoc.Controls.Add(docTitle);
            cardDoc.Controls.Add(docValue);
            cardDoc.Controls.Add(docSub);
            _pageDashboard.Controls.Add(cardDoc);

            // BLOTTER REPORTS
            Panel cardBlotter = new Panel
            {
                Size = new Size(268, 190),
                Location = new Point(320, 260),
                BackColor = Color.FromArgb(160, 105, 60),
                Cursor = Cursors.Hand
            };
            cardBlotter.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rect = new Rectangle(0, 0, cardBlotter.Width - 1, cardBlotter.Height - 1);
                using (GraphicsPath path = RoundedRect(rect, 22))
                using (SolidBrush brush = new SolidBrush(cardBlotter.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
            };
            cardBlotter.Click += cardBlotterReports_Click;

            Label blotterTitle = new Label
            {
                AutoSize = true,
                Text = "🛡 Blotter Reports",
                Font = new Font("Segoe UI Semibold", 13f),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Location = new Point(22, 18)
            };
            blotterTitle.Click += CardChild_ClickForward;

            Label blotterCount = new Label
            {
                AutoSize = true,
                Text = "0",                        // your value here
                Font = new Font("Segoe UI Semibold", 32f),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
                Location = new Point(26, 60)       // adjust as needed for center
            };

            blotterCount.Click += CardChild_ClickForward;
            cardBlotter.Controls.Add(blotterCount);

            Label blotterValue = new Label
            {
                AutoSize = true,
                Text = "1 pending",
                Font = new Font("Segoe UI", 10f),
                ForeColor = Color.WhiteSmoke,
                BackColor = Color.Transparent,
                Location = new Point(26, 140)
            };
            blotterValue.Click += CardChild_ClickForward;

            cardBlotter.Controls.Add(blotterTitle);
            cardBlotter.Controls.Add(blotterValue);
            _pageDashboard.Controls.Add(cardBlotter);

            // ===== LATEST UPDATES SECTION (RIGHT SIDE) =====
            int updatesX = 620;
            int updatesY = 230;

            Label lblUpdates = new Label
            {
                AutoSize = true,
                Text = "Latest Updates",
                Font = new Font("Segoe UI Semibold", 12f),
                ForeColor = Color.FromArgb(32, 32, 32),
                Location = new Point(updatesX, updatesY)
            };
            _pageDashboard.Controls.Add(lblUpdates);

            _pageDashboard.Controls.Add(CreateUpdateCard(
                "Community event scheduled",
                "A clean up drive is scheduled this Saturday at the main park area.",
                "2 days ago",
                new Point(updatesX, updatesY + 28)));

            _pageDashboard.Controls.Add(CreateUpdateCard(
                "Road maintenance on Main St.",
                "Expect temporary closures and detours on Main Street next week.",
                "5 days ago",
                new Point(updatesX, updatesY + 98)));

            _pageDashboard.Controls.Add(CreateUpdateCard(
                "Vaccination drive this week",
                "A vaccination drive will be held in the barangay hall for eligible residents.",
                "1 week ago",
                new Point(updatesX, updatesY + 168)));

            // ----- OTHER PAGES (PLACEHOLDERS) -----
            _pageServices = CreatePlaceholderPage("Services", Color.FromArgb(98, 78, 255));
            _pageRequirements = CreatePlaceholderPage("Requirements", Color.FromArgb(16, 185, 129));
            _pageFeedback = CreatePlaceholderPage("Feedback", Color.FromArgb(245, 158, 11));
            _pageAbout = CreatePlaceholderPage("About Barangayan EMS", Color.FromArgb(139, 92, 246));

            _contentHost.Controls.Add(_pageDashboard);
            _contentHost.Controls.Add(_pageServices);
            _contentHost.Controls.Add(_pageRequirements);
            _contentHost.Controls.Add(_pageFeedback);
            _contentHost.Controls.Add(_pageAbout);
        }

        // =========================================================
        //  CARD CREATION HELPERS
        // =========================================================
        private Panel CreateMetricCard(string title, string value, Color color, Point location)
        {
            Panel card = new Panel
            {
                Size = new Size(260, 120),
                Location = location,
                BackColor = Color.Transparent
            };

            card.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rect = new Rectangle(0, 0, card.Width - 1, card.Height - 1);
                using (GraphicsPath path = RoundedRect(rect, 18))
                using (LinearGradientBrush brush = new LinearGradientBrush(
                           rect,
                           color,
                           ControlPaint.Light(color, 0.1f),
                           0f))
                {
                    e.Graphics.FillPath(brush, path);
                }
            };

            Label lblTitle = new Label
            {
                AutoSize = true,
                Text = title,
                Font = new Font("Segoe UI", 9.5f),
                ForeColor = Color.White,
                Location = new Point(18, 16),
                BackColor = Color.Transparent
            };

            Label lblValue = new Label
            {
                AutoSize = true,
                Text = value,
                Font = new Font("Segoe UI Semibold", 22f),
                ForeColor = Color.White,
                Location = new Point(18, 46),
                BackColor = Color.Transparent
            };

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);
            return card;
        }

        private Panel CreateUpdateCard(string title, string body, string age, Point location)
        {
            Panel card = new Panel
            {
                Size = new Size(330, 64),
                Location = location,
                BackColor = Color.White
            };

            card.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rect = new Rectangle(0, 0, card.Width - 1, card.Height - 1);
                using (GraphicsPath path = RoundedRect(rect, 14))
                using (SolidBrush brush = new SolidBrush(Color.White))
                using (Pen pen = new Pen(Color.FromArgb(228, 231, 255)))
                {
                    e.Graphics.FillPath(brush, path);
                    e.Graphics.DrawPath(pen, path);
                }
            };

            Label lblTitle = new Label
            {
                AutoSize = true,
                Text = title,
                Font = new Font("Segoe UI Semibold", 10.5f),
                ForeColor = Color.FromArgb(32, 32, 32),
                Location = new Point(18, 8),
                BackColor = Color.Transparent
            };

            Label lblBody = new Label
            {
                AutoSize = false,
                Text = body,
                Font = new Font("Segoe UI", 8.9f),
                ForeColor = Color.DimGray,
                Location = new Point(18, 26),
                Size = new Size(230, 32),
                BackColor = Color.Transparent
            };

            Label lblAge = new Label
            {
                AutoSize = true,
                Text = age,
                Font = new Font("Segoe UI", 8.5f),
                ForeColor = Color.Gray,
                BackColor = Color.Transparent,
                Location = new Point(card.Width - 80, 8),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblBody);
            card.Controls.Add(lblAge);
            return card;
        }

        private Panel CreatePlaceholderPage(string title, Color accent)
        {
            Panel page = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(246, 247, 255),
                Visible = false
            };

            Label lblTitle = new Label
            {
                AutoSize = true,
                Text = title,
                Font = new Font("Segoe UI Semibold", 20f),
                ForeColor = accent,
                Location = new Point(24, 24)
            };

            Label lblBody = new Label
            {
                AutoSize = true,
                Text = "Page content coming soon. This is a placeholder section.",
                Font = new Font("Segoe UI", 10f),
                ForeColor = Color.DimGray,
                Location = new Point(26, 60)
            };

            page.Controls.Add(lblTitle);
            page.Controls.Add(lblBody);
            return page;
        }

        private GraphicsPath RoundedRect(Rectangle rect, int radius)
        {
            int d = radius * 2;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        // =========================================================
        //  NAVIGATION: WIRE SIDEBAR PANELS TO PAGES
        // =========================================================
        private void SetupNavigation()
        {
            RegisterNavPanel("navDashboard", DashboardPage.Dashboard);
            RegisterNavPanel("navServices", DashboardPage.Services);
            RegisterNavPanel("navRequirements", DashboardPage.Requirements);
            RegisterNavPanel("navFeedback", DashboardPage.Feedback);
            RegisterNavPanel("navAbout", DashboardPage.About);
        }

        private void RegisterNavPanel(string panelName, DashboardPage page)
        {
            Panel nav = FindPanel(panelName);
            if (nav == null) return;

            if (_navMap.ContainsKey(nav)) return;
            _navMap.Add(nav, page);

            nav.Cursor = Cursors.Hand;
            nav.MouseEnter += (s, e) => Nav_MouseEnter(nav);
            nav.MouseLeave += (s, e) => Nav_MouseLeave(nav);
            nav.Click += Nav_Click;

            foreach (Control child in nav.Controls)
            {
                child.Cursor = Cursors.Hand;
                child.MouseEnter += (s, e) => Nav_MouseEnter(nav);
                child.MouseLeave += (s, e) => Nav_MouseLeave(nav);
                child.Click += Nav_Click;
            }

            if (_activeNavPanel == null && page == DashboardPage.Dashboard)
            {
                SetNavActive(nav, true);
                _activeNavPanel = nav;
            }
        }

        private void Nav_MouseEnter(Panel nav)
        {
            if (nav == _activeNavPanel) return;
            nav.BackColor = Color.FromArgb(230, 240, 255);
        }

        private void Nav_MouseLeave(Panel nav)
        {
            if (nav == _activeNavPanel) return;
            nav.BackColor = Color.Transparent;
        }

        private void SetNavActive(Panel nav, bool active)
        {
            if (nav == null) return;
            nav.BackColor = active ? Color.White : Color.Transparent;
        }

        private void Nav_Click(object sender, EventArgs e)
        {
            Panel nav = sender as Panel;
            if (nav == null && sender is Control c)
                nav = c.Parent as Panel;

            if (nav == null || !_navMap.ContainsKey(nav))
                return;

            DashboardPage target = _navMap[nav];
            if (target == _activePage)
                return;

            SetNavActive(_activeNavPanel, false);
            SetNavActive(nav, true);
            _activeNavPanel = nav;

            ShowPage(target, immediate: false);
        }

        // =========================================================
        //  SEARCH BOX PLACEHOLDER
        // =========================================================
        private void SetupSearchBox()
        {
            TextBox txtSearch = FindTextBox("txtSearch");
            if (txtSearch == null) return;

            const string placeholder = "Search";
            txtSearch.ForeColor = Color.Gray;

            txtSearch.GotFocus += (s, e) =>
            {
                if (txtSearch.Text == placeholder)
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = Color.FromArgb(32, 32, 32);
                }
            };

            txtSearch.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.Text = placeholder;
                    txtSearch.ForeColor = Color.Gray;
                }
            };

            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = placeholder;
                txtSearch.ForeColor = Color.Gray;
            }
        }

        // =========================================================
        //  SLIDE ANIMATION BETWEEN PAGES
        // =========================================================
        private void SetupSlideTimer()
        {
            _slideTimer = new Timer { Interval = 16 };
            _slideTimer.Tick += SlideTimer_Tick;
        }

        private void ShowPage(DashboardPage page, bool immediate)
        {
            Control newPage = PageFromEnum(page);
            if (newPage == null || _contentHost == null) return;

            _activePage = page;

            if (immediate)
            {
                foreach (Control c in _contentHost.Controls)
                    c.Visible = (c == newPage);

                newPage.Location = new Point(0, 0);
                _slideFrom = newPage;
                return;
            }

            StartSlideAnimation(newPage);
        }

        private Control PageFromEnum(DashboardPage page)
        {
            switch (page)
            {
                case DashboardPage.Dashboard: return _pageDashboard;
                case DashboardPage.Services: return _pageServices;
                case DashboardPage.Requirements: return _pageRequirements;
                case DashboardPage.Feedback: return _pageFeedback;
                case DashboardPage.About: return _pageAbout;
                default: return _pageDashboard;
            }
        }

        private void StartSlideAnimation(Control newPage)
        {
            if (_slideTimer == null || _contentHost == null)
                return;

            if (_slideTimer.Enabled)
                _slideTimer.Stop();

            Control current = null;
            foreach (Control c in _contentHost.Controls)
            {
                if (c.Visible) { current = c; break; }
            }

            _slideFrom = current;
            _slideTo = newPage;
            _slideStep = 0;

            _slideTo.Visible = true;
            _slideTo.BringToFront();
            _slideTo.Location = new Point(_contentHost.Width, 0);

            if (_slideFrom != null)
                _slideFrom.BringToFront();

            _slideTimer.Start();
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            if (_slideFrom == null || _slideTo == null || _contentHost == null)
            {
                _slideTimer.Stop();
                return;
            }

            _slideStep++;
            float t = _slideStep / (float)SlideSteps;
            if (t > 1f) t = 1f;

            int offset = (int)(_contentHost.Width * (1f - t));

            _slideTo.Location = new Point(offset, 0);
            _slideFrom.Location = new Point(offset - _contentHost.Width, 0);

            if (_slideStep >= SlideSteps)
            {
                _slideTimer.Stop();
                _slideTo.Location = new Point(0, 0);
                _slideFrom.Visible = false;

                _slideFrom = _slideTo;
                _slideTo = null;
            }
        }

        // =========================================================
        //  CARD CLICK HANDLERS
        // =========================================================
        private void cardDocumentRequests_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Document request management will be available in a future version.",
                "Coming Soon",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void cardBlotterReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Blotter reports management will be available in a future version.",
                "Coming Soon",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void CardChild_ClickForward(object sender, EventArgs e)
        {
            if (sender is Control child && child.Parent != null)
            {
                this.InvokeOnClick(child.Parent, EventArgs.Empty);
            }
        }

        // =========================================================
        //  DESIGNER-EVENT STUBS (required by Designer)
        // =========================================================
        private void lblSystem_Click(object sender, EventArgs e)
        {
            // optional: show "About system"
        }

        private void lblRepublic_Click(object sender, EventArgs e)
        {
            // optional: link to website
        }

        private void navServices_Paint(object sender, PaintEventArgs e)
        {
            // no custom painting; keep empty to satisfy Designer
        }

        private void cardPending_Paint(object sender, PaintEventArgs e)
        {
            // legacy stub; not used with runtime metric cards
        }

        private void lblDocValue_Click(object sender, EventArgs e)
        {
            // legacy stub
        }

        private void cardBlotterReports_Paint(object sender, PaintEventArgs e)
        {
            // legacy stub
        }
    }
}
