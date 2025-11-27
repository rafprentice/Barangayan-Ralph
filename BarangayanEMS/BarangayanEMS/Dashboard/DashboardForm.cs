using System;
using System.Drawing;
using System.Windows.Forms;

namespace BarangayanEMS
{
    public partial class DashboardForm : Form
    {
        // ROOT
        private GradientPanel pnlRoot;

        // LEFT SIDEBAR
        private Panel pnlSidebar;
        private IconPictureBox picSealSmall;
        private Label lblAppName;
        private Button btnNavDashboard;
        private Button btnNavResidents;
        private Button btnNavRequests;
        private Button btnNavReports;
        private Button btnNavSettings;
        private Button btnNavLogout;
        private Panel pnlNavHighlight;

        // TOP BAR
        private Panel pnlTopBar;
        private Label lblPageTitle;
        private TextBox txtSearch;
        private IconPictureBox iconSearch;
        private IconPictureBox iconUserAvatar;
        private Label lblUserName;

        // MAIN CONTENT
        private Panel pnlContent;

        // KPI CARDS (Row 1)
        private RoundedPanel cardResidents;
        private RoundedPanel cardRequests;
        private RoundedPanel cardCompleted;
        private RoundedPanel cardBudget;

        private Label lblResidentsTitle;
        private Label lblResidentsValue;
        private Label lblResidentsSub;

        private Label lblRequestsTitle;
        private Label lblRequestsValue;
        private Label lblRequestsSub;

        private Label lblCompletedTitle;
        private Label lblCompletedValue;
        private Label lblCompletedSub;

        private Label lblBudgetTitle;
        private Label lblBudgetValue;
        private Label lblBudgetSub;

        // ANALYTICS PANELS (Row 2)
        private RoundedPanel pnlChartRequests;
        private RoundedPanel pnlChartHeatmap;
        private RoundedPanel pnlRecentActivity;

        private Label lblRequestsChartTitle;
        private Label lblHeatmapTitle;
        private Label lblRecentTitle;

        // Simple custom chart panels
        private ChartPanel chartRequests;
        private ChartPanel chartHeatmap;

        private ListBox lstRecentActivity;

        // Timer for subtle “live” animation
        private Timer animTimer;
        private Random rnd = new Random();

       

      

        // -----------------------------
        // NAV HELPERS
        // -----------------------------
        private void ConfigureNavButton(Button btn, string text, int x, int y, int width, int height)
        {
            btn.Text = text;
            btn.Location = new Point(x, y);
            btn.Size = new Size(width, height);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.ForeColor = Color.FromArgb(156, 163, 175);
            btn.BackColor = Color.Transparent;
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Font = new Font("Segoe UI", 10f);
            btn.Padding = new Padding(12, 0, 0, 0);
            btn.Cursor = Cursors.Hand;
        }

        private void ActivateNav(Button btn)
        {
            // Move highlight
            this.pnlNavHighlight.Top = btn.Top;

            // Set text colors
            foreach (Control c in this.pnlSidebar.Controls)
            {
                if (c is Button b)
                {
                    b.ForeColor = Color.FromArgb(156, 163, 175);
                    b.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
                }
            }

            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI Semibold", 10f, FontStyle.Bold);

            // Change page title based on nav
            if (btn == btnNavDashboard) lblPageTitle.Text = "Dashboard Overview";
            else if (btn == btnNavResidents) lblPageTitle.Text = "Residents Registry";
            else if (btn == btnNavRequests) lblPageTitle.Text = "Service Requests";
            else if (btn == btnNavReports) lblPageTitle.Text = "Reports & Analytics";
            else if (btn == btnNavSettings) lblPageTitle.Text = "Settings";

            // You can later show/hide different panels per nav here.
        }

        private void BtnNavLogout_Click(object sender, EventArgs e)
        {
            // Simple logout logic: close dashboard and show login again
            this.Hide();
            using (var login = new LoginForm())
            {
                login.ShowDialog();
            }
            this.Close();
        }

        // -----------------------------
        // KPI / ANALYTICS HELPERS
        // -----------------------------
        private void ConfigureKpiCard(RoundedPanel card, string title,
            out Label lblTitle, out Label lblValue, out Label lblSub)
        {
            card.CornerRadius = 16;
            card.ShadowOffset = 8;
            card.BackColor = Color.White;
            card.Padding = new Padding(14);
            card.ForeColor = Color.Black;

            lblTitle = new Label();
            lblTitle.AutoSize = true;
            lblTitle.Text = title;
            lblTitle.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
            lblTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblTitle.Location = new Point(14, 14);

            lblValue = new Label();
            lblValue.AutoSize = true;
            lblValue.Text = "0";
            lblValue.Font = new Font("Segoe UI Semibold", 20f, FontStyle.Bold);
            lblValue.ForeColor = Color.FromArgb(15, 23, 42);
            lblValue.Location = new Point(12, 36);

            lblSub = new Label();
            lblSub.AutoSize = true;
            lblSub.Text = "+0 today";
            lblSub.Font = new Font("Segoe UI", 9f);
            lblSub.ForeColor = Color.FromArgb(34, 197, 94);
            lblSub.Location = new Point(14, 70);

            card.Controls.Add(lblTitle);
            card.Controls.Add(lblValue);
            card.Controls.Add(lblSub);
        }

        private void ConfigureAnalyticsPanel(RoundedPanel panel, out Label lblTitle, string title)
        {
            panel.CornerRadius = 18;
            panel.ShadowOffset = 10;
            panel.BackColor = Color.White;
            panel.Padding = new Padding(16);

            lblTitle = new Label();
            lblTitle.AutoSize = true;
            lblTitle.Text = title;
            lblTitle.Font = new Font("Segoe UI Semibold", 10.5f, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 64, 175);
            lblTitle.Location = new Point(16, 14);

            panel.Controls.Add(lblTitle);
        }

        // -----------------------------
        // DEMO DATA + ANIMATION
        // -----------------------------
        private void InitializeFakeData()
        {
            lblResidentsValue.Text = "4,382";
            lblResidentsSub.Text = "+32 new this week";

            lblRequestsValue.Text = "127";
            lblRequestsSub.Text = "18 urgent";

            lblCompletedValue.Text = "56";
            lblCompletedSub.Text = "Today completed";

            lblBudgetValue.Text = "72%";
            lblBudgetSub.Text = "of annual budget";

            lstRecentActivity.Items.Clear();
            lstRecentActivity.Items.Add("• New resident registered: Juan Dela Cruz");
            lstRecentActivity.Items.Add("• Barangay clearance approved for #BRGY-2041");
            lstRecentActivity.Items.Add("• Incident report submitted from Zone 3");
            lstRecentActivity.Items.Add("• Permit request scheduled for review");
            lstRecentActivity.Items.Add("• 3 new online inquiries from residents");

            // Seed some chart data
            chartRequests.DataPoints = new int[] { 22, 30, 18, 40, 35, 45, 38 };
            chartHeatmap.DataPoints = new int[] { 5, 12, 8, 15, 20, 10, 6 };
        }

        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            // Light fake “live” updates
            int deltaResidents = rnd.Next(-2, 5);
            int deltaRequests = rnd.Next(-5, 6);
            int deltaCompleted = rnd.Next(0, 6);

            // Residents
            int residents = ParseIntSafe(lblResidentsValue.Text);
            residents = Math.Max(0, residents + deltaResidents);
            lblResidentsValue.Text = residents.ToString("N0");
            lblResidentsSub.Text = (deltaResidents >= 0 ? "+" : "") + deltaResidents + " since refresh";

            // Requests
            int requests = ParseIntSafe(lblRequestsValue.Text);
            requests = Math.Max(0, requests + deltaRequests);
            lblRequestsValue.Text = requests.ToString("N0");
            lblRequestsSub.Text = (deltaRequests >= 0 ? "+" : "") + deltaRequests + " open";

            // Completed
            int completed = ParseIntSafe(lblCompletedValue.Text);
            completed = Math.Max(0, completed + deltaCompleted);
            lblCompletedValue.Text = completed.ToString("N0");
            lblCompletedSub.Text = deltaCompleted + " new closed";

            // Chart wiggle
            chartRequests.RandomizeSlightly();
            chartHeatmap.RandomizeSlightly();
            chartRequests.Invalidate();
            chartHeatmap.Invalidate();
        }

        private int ParseIntSafe(string text)
        {
            // Remove commas etc.
            string numeric = text.Replace(",", "").Replace("%", "").Trim();
            int value;
            if (!int.TryParse(numeric, out value))
                value = 0;
            return value;
        }
    }

    // -----------------------------------------
    // SIMPLE DRAWN CHART PANEL
    // -----------------------------------------
    public enum ChartMode
    {
        Line,
        Heatmap
    }

    public class ChartPanel : Panel
    {
        public int[] DataPoints { get; set; } = new int[0];
        public Color ChartColor { get; set; } = Color.FromArgb(79, 70, 229);
        public Color ChartSecondaryColor { get; set; } = Color.FromArgb(129, 140, 248);
        public ChartMode Mode { get; set; } = ChartMode.Line;
        private Random rnd = new Random();

        public ChartPanel()
        {
            this.DoubleBuffered = true;
            this.BackColor = Color.White;
            this.Padding = new Padding(16, 28, 16, 16);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(
                this.Padding.Left,
                this.Padding.Top,
                this.Width - this.Padding.Left - this.Padding.Right,
                this.Height - this.Padding.Top - this.Padding.Bottom);

            if (rect.Width <= 0 || rect.Height <= 0)
                return;

            using (var bgBrush = new SolidBrush(Color.FromArgb(248, 250, 252)))
            {
                g.FillRectangle(bgBrush, rect);
            }

            if (DataPoints == null || DataPoints.Length == 0)
                return;

            if (Mode == ChartMode.Line)
            {
                DrawLineChart(g, rect);
            }
            else
            {
                DrawHeatmap(g, rect);
            }
        }

        private void DrawLineChart(Graphics g, Rectangle rect)
        {
            int count = DataPoints.Length;
            if (count < 2) return;

            int max = 1;
            for (int i = 0; i < count; i++)
                if (DataPoints[i] > max) max = DataPoints[i];

            float stepX = (float)rect.Width / (count - 1);
            PointF[] points = new PointF[count];

            for (int i = 0; i < count; i++)
            {
                float x = rect.Left + i * stepX;
                float y = rect.Bottom - (DataPoints[i] / (float)max) * (rect.Height - 10);
                points[i] = new PointF(x, y);
            }

            // Fill under line
            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddLines(points);
                path.AddLine(points[count - 1].X, rect.Bottom, points[0].X, rect.Bottom);
                path.CloseFigure();
                using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                    rect,
                    ChartSecondaryColor,
                    Color.Transparent,
                    90f))
                {
                    g.FillPath(brush, path);
                }
            }

            // Line
            using (var pen = new Pen(ChartColor, 2.5f))
            {
                g.DrawLines(pen, points);
            }

            // Points
            using (var brush = new SolidBrush(ChartColor))
            {
                foreach (var p in points)
                {
                    g.FillEllipse(brush, p.X - 3, p.Y - 3, 6, 6);
                }
            }
        }

        private void DrawHeatmap(Graphics g, Rectangle rect)
        {
            int count = DataPoints.Length;
            int cols = count;
            if (cols <= 0) return;

            int cellWidth = rect.Width / cols;
            int cellHeight = rect.Height / 3;

            int max = 1;
            for (int i = 0; i < count; i++)
                if (DataPoints[i] > max) max = DataPoints[i];

            for (int c = 0; c < cols; c++)
            {
                float intensity = DataPoints[c] / (float)max;
                intensity = Math.Min(1f, Math.Max(0.1f, intensity));

                Color baseColor = ChartColor;
                Color cellColor = Color.FromArgb(
                    (int)(40 + 180 * intensity),
                    baseColor.R,
                    baseColor.G,
                    baseColor.B);

                for (int r = 0; r < 3; r++)
                {
                    Rectangle cell = new Rectangle(
                        rect.Left + c * cellWidth + 2,
                        rect.Top + r * cellHeight + 2,
                        cellWidth - 4,
                        cellHeight - 4);

                    using (var b = new SolidBrush(cellColor))
                    {
                        g.FillRectangle(b, cell);
                    }
                }
            }
        }

        public void RandomizeSlightly()
        {
            if (DataPoints == null || DataPoints.Length == 0)
                return;

            for (int i = 0; i < DataPoints.Length; i++)
            {
                int delta = rnd.Next(-3, 4);
                int newVal = DataPoints[i] + delta;
                if (newVal < 0) newVal = 0;
                DataPoints[i] = newVal;
            }
        }
    }
}
