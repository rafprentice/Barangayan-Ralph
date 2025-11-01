using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace BarangayanSystem
{
    // RoundedPanel helper
    public class RoundedPanel : Panel
    {
        public int CornerRadius { get; set; } = 18;
        public RoundedPanel() { DoubleBuffered = true; }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle r = new Rectangle(0, 0, Width - 1, Height - 1);
            using (GraphicsPath gp = RoundedRect(r, CornerRadius))
            {
                this.Region = new Region(gp);
                using (var brush = new SolidBrush(this.BackColor))
                {
                    e.Graphics.FillPath(brush, gp);
                }
            }
        }
        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int d = radius * 2;
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            gp.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            gp.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            gp.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            gp.CloseFigure();
            return gp;
        }
    }

    // PlaceholderTextBox
    public class PlaceholderTextBox : TextBox
    {
        public string Placeholder { get; set; } = "";
        private bool showingPlaceholder = true;

        public PlaceholderTextBox()
        {
            ForeColor = Color.Gray;
            GotFocus += RemovePlaceholder;
            LostFocus += SetPlaceholder;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            SetPlaceholder(null, null);
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (showingPlaceholder)
            {
                Text = "";
                ForeColor = SystemColors.ControlText;
                showingPlaceholder = false;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Text))
            {
                showingPlaceholder = true;
                Text = Placeholder;
                ForeColor = Color.Gray;
            }
        }

        public bool IsShowingPlaceholder => showingPlaceholder;
    }

    public partial class Form1 : Form
    {
        // dragging
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        // fade-in
        private Timer fadeTimer;

        // highlight slide animation
        private Timer slideTimer;
        private int highlightTargetX = 12;
        private Panel highlightPanel;
        private int slideSpeed = 18; // pixels per tick

        // sign-in glow
        private Timer glowTimer;
        private int glowStep = 0;
        private Button btnSignInRef;

        public Form1()
        {
            InitializeCustom();
            BuildLayout();
        }

        private void InitializeCustom()
        {
            this.Text = "Barangayan - Login";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true;
            this.Size = new Size(1100, 700);
            this.MinimumSize = new Size(900, 600);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Opacity = 0;

            // paint gradient background (kept as gradient purple)
            this.Paint += (s, e) =>
            {
                using (var brush = new LinearGradientBrush(this.ClientRectangle,
                    Color.FromArgb(99, 30, 208), Color.FromArgb(134, 65, 255), 45f))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }
            };

            // fade-in ~0.8s
            fadeTimer = new Timer { Interval = 16 }; // ~60fps
            int fadeTicks = 50; // 50 * 16ms = 800ms
            int currentTick = 0;
            fadeTimer.Tick += (s, e) =>
            {
                currentTick++;
                this.Opacity = Math.Min(1.0, (double)currentTick / fadeTicks);
                if (currentTick >= fadeTicks) fadeTimer.Stop();
            };
            this.Load += (s, e) => fadeTimer.Start();

            // slide timer for highlight
            slideTimer = new Timer { Interval = 12 };
            slideTimer.Tick += SlideTimer_Tick;

            // glow timer for sign-in hover (smooth pulsing)
            glowTimer = new Timer { Interval = 40 };
            glowTimer.Tick += GlowTimer_Tick;
        }

        private void BuildLayout()
        {
            // ---- TOP BAR (draggable) ----
            var topBar = new Panel
            {
                Dock = DockStyle.Top,
                Height = 40,
                BackColor = Color.FromArgb(70, 20, 140)
            };
            this.Controls.Add(topBar);

            var lblTopTitle = new Label
            {
                Text = "Barangayan System",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(14, 10),
                AutoSize = true
            };
            topBar.Controls.Add(lblTopTitle);

            var btnMin = new Button
            {
                Text = "—",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                Size = new Size(40, 40),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            btnMin.FlatAppearance.BorderSize = 0;
            btnMin.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
            topBar.Controls.Add(btnMin);

            var btnClose = new Button
            {
                Text = "×",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Size = new Size(40, 40),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                ForeColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => this.Close();
            topBar.Controls.Add(btnClose);

            // set positions after adding to parent
            btnClose.Location = new Point(this.ClientSize.Width - btnClose.Width - 8, 0);
            btnMin.Location = new Point(btnClose.Left - btnMin.Width - 6, 0);
            this.Resize += (s, e) =>
            {
                btnClose.Location = new Point(this.ClientSize.Width - btnClose.Width - 8, 0);
                btnMin.Location = new Point(btnClose.Left - btnMin.Width - 6, 0);
            };

            // dragging events
            topBar.MouseDown += (s, e) => { dragging = true; dragCursorPoint = Cursor.Position; dragFormPoint = this.Location; };
            topBar.MouseMove += (s, e) => { if (dragging) this.Location = Point.Add(dragFormPoint, new Size(Point.Subtract(Cursor.Position, new Size(dragCursorPoint)))); };
            topBar.MouseUp += (s, e) => dragging = false;

            // ---- LEFT PANEL (purple) ----
            var leftPanel = new Panel
            {
                Size = new Size(520, this.ClientSize.Height - topBar.Height),
                Location = new Point(0, topBar.Bottom),
                BackColor = Color.Transparent,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left
            };
            this.Controls.Add(leftPanel);

            // logo / titles
            var logoBox = new PictureBox
            {
                Size = new Size(96, 96),
                Location = new Point(48, 48),
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.Transparent,
                Image = LoadImageSafe("barangay_logo.png")
            };
            leftPanel.Controls.Add(logoBox);

            leftPanel.Controls.Add(new Label
            {
                Text = "REPUBLIKA NG PILIPINAS",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.FromArgb(220, Color.White),
                Location = new Point(168, 36),
                AutoSize = true
            });

            leftPanel.Controls.Add(new Label
            {
                Text = "Barangayan",
                Font = new Font("Segoe UI", 28, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(168, 56),
                AutoSize = true
            });

            leftPanel.Controls.Add(new Label
            {
                Text = "E Management System",
                Font = new Font("Segoe UI", 11, FontStyle.Regular),
                ForeColor = Color.WhiteSmoke,
                Location = new Point(170, 106),
                AutoSize = true
            });

            // decorative crosses
            leftPanel.Paint += (s, e) =>
            {
                using (var pen = new Pen(Color.FromArgb(18, Color.White), 1))
                {
                    for (int x = 20; x < leftPanel.Width; x += 36)
                        for (int y = 20; y < leftPanel.Height; y += 36)
                        {
                            e.Graphics.DrawLine(pen, x - 4, y, x + 4, y);
                            e.Graphics.DrawLine(pen, x, y - 4, x, y + 4);
                        }
                }
            };

            // feature cards with soft shadow
            CreateFeatureCard(leftPanel, "🛡️ Secure & Reliable",
                "Your data is protected with enterprise-grade security and encryption", 180);
            CreateFeatureCard(leftPanel, "⏰ 24/7 Access",
                "Access barangay services anytime, anywhere from any device", 300);
            CreateFeatureCard(leftPanel, "👤 Digital Services",
                "Document requests, payments, and community features all in one place", 420);

            // ---- RIGHT (login) ----
            var rightPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.Transparent,
                Padding = new Padding(28)
            };
            Controls.Add(rightPanel);
            rightPanel.BringToFront();

            // soft shadow (subtle gradient)
            var shadow = new Panel
            {
                Size = new Size(480, 620),
                Location = new Point(520, 95),
                BackColor = Color.Transparent
            };
            shadow.Paint += (s, e) =>
            {
                // radial-like soft shadow using multiple rectangles
                for (int i = 0; i < 10; i++)
                {
                    int alpha = 16 - i; if (alpha < 0) alpha = 0;
                    var rect = new Rectangle(5 + i, 5 + i, 470 - i * 2, 610 - i * 2);
                    using (var brush = new SolidBrush(Color.FromArgb(alpha * 8, 0, 0, 0)))
                        e.Graphics.FillRectangle(brush, rect);
                }
            };
            rightPanel.Controls.Add(shadow);

            var loginCard = new RoundedPanel
            {
                Size = new Size(460, 600),
                Location = new Point(515, 90),
                BackColor = Color.White,
                CornerRadius = 18
            };
            rightPanel.Controls.Add(loginCard);

            // welcome
            loginCard.Controls.Add(new Label
            {
                Text = "Welcome Back",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                Location = new Point(130, 20),
                AutoSize = true
            });
            loginCard.Controls.Add(new Label
            {
                Text = "Sign in to access your barangay services",
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.Gray,
                Location = new Point(120, 58),
                AutoSize = true
            });

            // --- Pill-style tab bar (rounded) ---
            var pill = new RoundedPanel
            {
                Size = new Size(380, 44),
                Location = new Point(40, 100),
                BackColor = Color.FromArgb(245, 245, 245),
                CornerRadius = 22
            };
            loginCard.Controls.Add(pill);

            var tabEmail = new Label
            {
                Text = "Email / ID",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.FromArgb(90, 90, 90),
                Location = new Point(28, 12),
                AutoSize = true,
                Cursor = Cursors.Hand
            };
            var tabQR = new Label
            {
                Text = "QR Code",
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                ForeColor = Color.FromArgb(140, 140, 140),
                Location = new Point(160, 12),
                AutoSize = true,
                Cursor = Cursors.Hand
            };
            pill.Controls.Add(tabEmail);
            pill.Controls.Add(tabQR);

            // highlight (animated)
            highlightPanel = new Panel
            {
                Size = new Size(100, 36),
                Location = new Point(12, 4),
                BackColor = Color.FromArgb(99, 30, 208)
            };
            // rounded corners for highlight via parent paint
            pill.Controls.Add(highlightPanel);
            highlightPanel.BringToFront();

            // overlay labels above highlight so text remains readable
            tabEmail.BringToFront();
            tabQR.BringToFront();

            // Tab click behavior (visual only) — Option B
            tabEmail.Click += (s, e) =>
            {
                AnimateHighlightTo(12);
                tabEmail.ForeColor = Color.White;
                tabQR.ForeColor = Color.FromArgb(140, 140, 140);
                tabEmail.Font = new Font(tabEmail.Font, FontStyle.Bold);
                tabQR.Font = new Font(tabQR.Font, FontStyle.Regular);
            };
            tabQR.Click += (s, e) =>
            {
                AnimateHighlightTo(tabQR.Left - 8);
                tabQR.ForeColor = Color.White;
                tabEmail.ForeColor = Color.FromArgb(140, 140, 140);
                tabQR.Font = new Font(tabQR.Font, FontStyle.Bold);
                tabEmail.Font = new Font(tabEmail.Font, FontStyle.Regular);
            };

            // initial active

            tabEmail.PerformClick();

            // --- Inputs ---
            var emailPanel = CreateInputPanel("email.png", "Enter your email or resident ID", new Point(40, 160), out PlaceholderTextBox txtEmail);
            loginCard.Controls.Add(emailPanel);

            var passPanel = CreateInputPanel("lock.png", "Enter your password", new Point(40, 220), out PlaceholderTextBox txtPassword);
            txtPassword.UseSystemPasswordChar = true;
            loginCard.Controls.Add(passPanel);

            var btnShow = new Button
            {
                Text = "👁",
                FlatStyle = FlatStyle.Flat,
                Size = new Size(44, 36),
                Location = new Point(416, 220),
                BackColor = Color.White
            };
            btnShow.FlatAppearance.BorderSize = 0;
            btnShow.Click += (s, e) => txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            loginCard.Controls.Add(btnShow);

            var chkRemember = new CheckBox
            {
                Text = "Remember me",
                Location = new Point(40, 278),
                AutoSize = true,
                Font = new Font("Segoe UI", 9)
            };
            loginCard.Controls.Add(chkRemember);

            var linkForgot = new LinkLabel
            {
                Text = "Forgot Password?",
                Location = new Point(350, 278),
                AutoSize = true,
                LinkColor = Color.FromArgb(99, 30, 208)
            };
            linkForgot.Click += (s, e) => MessageBox.Show("Forgot password flow not implemented in demo.");
            loginCard.Controls.Add(linkForgot);

            // Sign In (with hover glow)
            var btnSignIn = new Button
            {
                Text = "Sign In",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(99, 30, 208),
                Size = new Size(380, 48),
                Location = new Point(40, 310),
                FlatStyle = FlatStyle.Flat
            };
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.MouseEnter += (s, e) =>
            {
                // start glow
                btnSignInRef = btnSignIn;
                glowStep = 0;
                glowTimer.Start();
            };
            btnSignIn.MouseLeave += (s, e) =>
            {
                glowTimer.Stop();
                btnSignInRef = null;
                btnSignIn.BackColor = Color.FromArgb(99, 30, 208);
            };
            btnSignIn.Click += (s, e) =>
            {
                string email = txtEmail.IsShowingPlaceholder ? "" : txtEmail.Text.Trim();
                string pw = txtPassword.IsShowingPlaceholder ? "" : txtPassword.Text.Trim();
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(pw))
                {
                    MessageBox.Show("Please enter your email and password.", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (email.Equals("demo@barangayan.gov", StringComparison.OrdinalIgnoreCase) && pw == "demo123")
                    MessageBox.Show("Demo login successful! (Dashboard not implemented)", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Invalid credentials (demo)", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            loginCard.Controls.Add(btnSignIn);

            // store reference for glow
            // btnSignInRef assigned on MouseEnter

            // Divider + Google
            loginCard.Controls.Add(new Label
            {
                Text = "Or continue with",
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.Gray,
                Location = new Point(200, 370),
                AutoSize = true
            });

            var btnGoogle = new Button
            {
                Text = "   Sign in with Google",
                Font = new Font("Segoe UI", 10),
                Size = new Size(380, 42),
                Location = new Point(40, 391),
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                TextAlign = ContentAlignment.MiddleLeft,
                Image = LoadImageSafe("google.png")
            };
            btnGoogle.FlatAppearance.BorderColor = Color.LightGray;
            btnGoogle.FlatAppearance.BorderSize = 1;
            btnGoogle.MouseEnter += (s, e) => btnGoogle.BackColor = Color.FromArgb(245, 245, 245);
            btnGoogle.MouseLeave += (s, e) => btnGoogle.BackColor = Color.White;
            loginCard.Controls.Add(btnGoogle);

            // Demo box
            var demoBox = new RoundedPanel
            {
                Size = new Size(380, 80),
                Location = new Point(40, 445),
                BackColor = Color.FromArgb(240, 245, 255),
                CornerRadius = 10
            };
            loginCard.Controls.Add(demoBox);
            demoBox.Controls.Add(new Label
            {
                Text = "Demo Account",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Location = new Point(12, 10),
                AutoSize = true
            });
            demoBox.Controls.Add(new Label
            {
                Text = "Email: demo@barangayan.gov\nPassword: demo123",
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.DimGray,
                Location = new Point(12, 30),
                AutoSize = true
            });

            loginCard.Controls.Add(new Label
            {
                Text = "Need help? Contact support@barangayan.gov or (032) 123-4567",
                Font = new Font("Segoe UI", 8),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(40, 540)
            });

            // resizing behavior: keep login card right-shifted
            this.Resize += (s, e) =>
            {
                int cardX = Math.Max(520, (this.ClientSize.Width - loginCard.Width) / 2 + 40);
                loginCard.Location = new Point(cardX, loginCard.Location.Y);
                shadow.Location = new Point(loginCard.Left + 6, loginCard.Top + 6);
            };
        }

        // Animate highlight to a target X position inside pill
        private void AnimateHighlightTo(int targetX)
        {
            highlightTargetX = targetX;
            if (!slideTimer.Enabled) slideTimer.Start();
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            if (highlightPanel == null) { slideTimer.Stop(); return; }
            int currentX = highlightPanel.Left;
            if (currentX == highlightTargetX) { slideTimer.Stop(); return; }
            int dir = (highlightTargetX > currentX) ? 1 : -1;
            int next = currentX + dir * slideSpeed;
            if ((dir > 0 && next > highlightTargetX) || (dir < 0 && next < highlightTargetX))
                next = highlightTargetX;
            highlightPanel.Left = next;
            // smooth width interpolation (optional): no change here, keep constant
            highlightPanel.Invalidate();
        }

        private void GlowTimer_Tick(object sender, EventArgs e)
        {
            if (btnSignInRef == null) { glowTimer.Stop(); return; }
            // pulse between base and lighter color
            glowStep = (glowStep + 1) % 40;
            double t = Math.Sin(glowStep * Math.PI / 40) * 0.15 + 0.85; // 0.7..1.0
            int r = (int)(99 * t);
            int g = (int)(30 * t);
            int b = (int)(208 * t);
            btnSignInRef.BackColor = Color.FromArgb(r, g, b);
        }

        // Input panel helper
        private Panel CreateInputPanel(string iconFile, string placeholder, Point location, out PlaceholderTextBox textBox)
        {
            var panel = new Panel
            {
                Size = new Size(380, 40),
                Location = location,
                BackColor = Color.FromArgb(245, 245, 245)
            };

            var icon = new PictureBox
            {
                Size = new Size(20, 20),
                Location = new Point(12, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = LoadImageSafe(iconFile)
            };
            panel.Controls.Add(icon);

            textBox = new PlaceholderTextBox
            {
                BorderStyle = BorderStyle.None,
                Location = new Point(44, 10),
                Width = 320,
                Font = new Font("Segoe UI", 10),
                BackColor = panel.BackColor,
                Placeholder = placeholder
            };
            panel.Controls.Add(textBox);

            panel.Paint += (s, e) =>
            {
                using (var pen = new Pen(Color.FromArgb(220, Color.LightGray)))
                {
                    e.Graphics.DrawRectangle(pen, 0, 0, panel.Width - 1, panel.Height - 1);
                }
            };

            return panel;
        }

        // safe image loader
        private Image LoadImageSafe(string fileName)
        {
            try
            {
                string exe = AppDomain.CurrentDomain.BaseDirectory;
                string path = Path.Combine(exe, fileName);
                if (File.Exists(path)) return Image.FromFile(path);
            }
            catch { }
            return null;
        }

        // feature card creator with soft shadow
        private void CreateFeatureCard(Control parent, string title, string desc, int top)
        {
            // shadow panel slightly offset
            var shadow = new Panel
            {
                Size = new Size(408, 106),
                Location = new Point(52, top + 4),
                BackColor = Color.Transparent
            };
            shadow.Paint += (s, e) =>
            {
                using (var b = new SolidBrush(Color.FromArgb(36, 0, 0, 0)))
                {
                    e.Graphics.FillRoundedRectangle(b, new Rectangle(6, 6, 396, 94), 14);
                }
            };
            parent.Controls.Add(shadow);
            shadow.BringToFront();

            // main card
            var card = new RoundedPanel
            {
                Size = new Size(400, 100),
                Location = new Point(56, top),
                BackColor = Color.FromArgb(120, 80, 230, 255),
                CornerRadius = 14
            };
            parent.Controls.Add(card);

            var lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI Semibold", 14, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(16, 14),
                AutoSize = true
            };
            card.Controls.Add(lblTitle);

            var lblDesc = new Label
            {
                Text = desc,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.WhiteSmoke,
                Location = new Point(16, 44),
                AutoSize = false,
                Width = card.Width - 32,
                Height = 40
            };
            card.Controls.Add(lblDesc);

            card.MouseEnter += (s, e) => card.BackColor = Color.FromArgb(160, 100, 180, 255);
            card.MouseLeave += (s, e) => card.BackColor = Color.FromArgb(120, 80, 230, 255);
        }
    }

    // extension to draw rounded rect for shadow panel (small helper)
    internal static class GraphicsExtensions
    {
        public static void FillRoundedRectangle(this Graphics g, Brush b, Rectangle rect, int radius)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int d = radius * 2;
                path.AddArc(rect.X, rect.Y, d, d, 180, 90);
                path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
                path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
                path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);
                path.CloseFigure();
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.FillPath(b, path);
            }
        }
    }
}
