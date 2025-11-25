using System;
using System.Drawing;
using System.Windows.Forms;

namespace BarangayanEMS
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        // core panels
        private GradientPanel pnlBackground;    // full multi-layer gradient background
        private Panel pnlLeftColumn;            // left column content container
        private RoundedPanel pnlRightCard;      // white login card

        // left column content
        private IconPictureBox picSeal;
        private Label lblCountryTitle;
        private Label lblAppTitle;
        private RoundedPanel pnlFeatureCard1;
        private RoundedPanel pnlFeatureCard2;
        private RoundedPanel pnlFeatureCard3;
        private IconPictureBox picShield;
        private IconPictureBox picCheck;
        private IconPictureBox picDigital;

        // right card content
        private Label lblWelcome;
        private Label lblSub;
        private IconPictureBox picUserIcon;

        // tabs
        private Button btnTabEmail;
        private Button btnTabQR;

        // login inputs and containers
        private Panel pnlEmailLogin;
        private Panel pnlQRLogin;

        private RoundedPanel pnlEmailInput;
        private IconPictureBox picEmailIcon;
        private TextBox txtEmail;

        private RoundedPanel pnlPasswordInput;
        private IconPictureBox picPasswordIcon;
        private TextBox txtPassword;

        private CheckBox chkRemember;
        private LinkLabel linkForgot;
        private Button btnSignIn;

        // social / footer
        private Label lblDividerText;
        private Button btnGoogle;
        private IconPictureBox picGoogleIcon;
        private Label lblDemoCredentials;
        private LinkLabel linkRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SuspendLayout();

            // FORM
            this.ClientSize = new Size(1366, 768);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Barangayan E-Management System - Login";
            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.BackColor = Color.White;

            //
            // pnlBackground (full multi-layer gradient)
            //
            pnlBackground = new GradientPanel()
            {
                Dock = DockStyle.Fill,
                GradientColor1 = Color.FromArgb(72, 3, 255),   // deep purple
                GradientColor2 = Color.FromArgb(134, 36, 255), // violet
                Angle = 240f,
                UseSmoothBlend = true
            };
            this.Controls.Add(pnlBackground);

            //
            // Overlay: left column container (visually sits on top of gradient)
            // We use a panel so the gradient remains across the whole window but content stays aligned left.
            //
            pnlLeftColumn = new Panel()
            {
                Width = (int)(this.ClientSize.Width * 0.42),
                Dock = DockStyle.Left,
                BackColor = Color.Transparent
            };
            pnlBackground.Controls.Add(pnlLeftColumn);

            // SEAL (top-left)
            picSeal = new IconPictureBox()
            {
                Base64 = Icons.Seal,
                Size = new Size(96, 96),
                Location = new Point(48, 36),
                SizeMode = PictureBoxSizeMode.Zoom,
                AutoRound = true
            };
            pnlLeftColumn.Controls.Add(picSeal);

            // TITLES
            lblCountryTitle = new Label()
            {
                Text = "Republika ng Pilipinas",
                Font = new Font("Segoe UI", 28F, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Location = new Point(48, 150)
            };
            pnlLeftColumn.Controls.Add(lblCountryTitle);

            lblAppTitle = new Label()
            {
                Text = "Barangayan E-Management System",
                Font = new Font("Segoe UI", 12F, FontStyle.Regular),
                ForeColor = Color.FromArgb(245, 245, 255),
                AutoSize = true,
                Location = new Point(48, 200)
            };
            pnlLeftColumn.Controls.Add(lblAppTitle);

            // FEATURE CARD 1
            pnlFeatureCard1 = new RoundedPanel()
            {
                Size = new Size(360, 86),
                Location = new Point(48, 280),
                BackColor = Color.White,
                BorderColor = Color.FromArgb(235, 235, 235),
                CornerRadius = 12,
                ShadowOffset = 6,
                ShadowAlpha = 18,
                Padding = new Padding(12)
            };
            picShield = new IconPictureBox()
            {
                Base64 = Icons.Shield,
                Size = new Size(36, 36),
                Location = new Point(14, 24),
                SizeMode = PictureBoxSizeMode.Zoom,
                Tint = Color.FromArgb(80, 0, 255)
            };
            pnlFeatureCard1.Controls.Add(picShield);
            var lblF1 = new Label() { Text = "Secure Reliable", Font = new Font("Segoe UI", 10F, FontStyle.Bold), Location = new Point(64, 18), AutoSize = true };
            var lblF1D = new Label() { Text = "Your data is safe with us", Font = new Font("Segoe UI", 9F), Location = new Point(64, 38), AutoSize = true, ForeColor = Color.Gray };
            pnlFeatureCard1.Controls.Add(lblF1);
            pnlFeatureCard1.Controls.Add(lblF1D);
            pnlLeftColumn.Controls.Add(pnlFeatureCard1);

            // FEATURE CARD 2
            pnlFeatureCard2 = new RoundedPanel()
            {
                Size = new Size(360, 86),
                Location = new Point(48, 382),
                BackColor = Color.White,
                BorderColor = Color.FromArgb(235, 235, 235),
                CornerRadius = 12,
                ShadowOffset = 6,
                ShadowAlpha = 18,
                Padding = new Padding(12)
            };
            picCheck = new IconPictureBox()
            {
                Base64 = Icons.Check,
                Size = new Size(36, 36),
                Location = new Point(14, 24),
                SizeMode = PictureBoxSizeMode.Zoom,
                Tint = Color.FromArgb(80, 0, 255)
            };
            pnlFeatureCard2.Controls.Add(picCheck);
            var lblF2 = new Label() { Text = "24/7 Access", Font = new Font("Segoe UI", 10F, FontStyle.Bold), Location = new Point(64, 18), AutoSize = true };
            var lblF2D = new Label() { Text = "Access anywhere, anytime", Font = new Font("Segoe UI", 9F), Location = new Point(64, 38), AutoSize = true, ForeColor = Color.Gray };
            pnlFeatureCard2.Controls.Add(lblF2);
            pnlFeatureCard2.Controls.Add(lblF2D);
            pnlLeftColumn.Controls.Add(pnlFeatureCard2);

            // FEATURE CARD 3
            pnlFeatureCard3 = new RoundedPanel()
            {
                Size = new Size(360, 86),
                Location = new Point(48, 484),
                BackColor = Color.White,
                BorderColor = Color.FromArgb(235, 235, 235),
                CornerRadius = 12,
                ShadowOffset = 6,
                ShadowAlpha = 18,
                Padding = new Padding(12)
            };
            picDigital = new IconPictureBox()
            {
                Base64 = Icons.Digital,
                Size = new Size(36, 36),
                Location = new Point(14, 24),
                SizeMode = PictureBoxSizeMode.Zoom,
                Tint = Color.FromArgb(80, 0, 255)
            };
            pnlFeatureCard3.Controls.Add(picDigital);
            var lblF3 = new Label() { Text = "Digital Services", Font = new Font("Segoe UI", 10F, FontStyle.Bold), Location = new Point(64, 18), AutoSize = true };
            var lblF3D = new Label() { Text = "Submit requests online", Font = new Font("Segoe UI", 9F), Location = new Point(64, 38), AutoSize = true, ForeColor = Color.Gray };
            pnlFeatureCard3.Controls.Add(lblF3);
            pnlFeatureCard3.Controls.Add(lblF3D);
            pnlLeftColumn.Controls.Add(pnlFeatureCard3);

            //
            // RIGHT white card (centered, with subtle inner purple tint on top edge)
            //
            int cardWidth = 640;
            int cardHeight = 540;
            pnlRightCard = new RoundedPanel()
            {
                Size = new Size(cardWidth, cardHeight),
                BackColor = Color.White,
                BorderColor = Color.FromArgb(235, 235, 235),
                CornerRadius = 18,
                ShadowOffset = 10,
                ShadowAlpha = 28,
                Padding = new Padding(28)
            };
            // Place the card centered horizontally in remaining space and vertically centered
            pnlRightCard.Left = pnlLeftColumn.Right + (this.ClientSize.Width - pnlLeftColumn.Width - cardWidth) / 2;
            pnlRightCard.Top = (this.ClientSize.Height - cardHeight) / 2;
            pnlBackground.Controls.Add(pnlRightCard);
            pnlRightCard.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // header text
            lblWelcome = new Label()
            {
                Text = "Welcome Back",
                Font = new Font("Segoe UI", 26F, FontStyle.Bold),
                ForeColor = Color.FromArgb(33, 33, 33),
                AutoSize = true,
                Location = new Point(28, 8)
            };
            pnlRightCard.Controls.Add(lblWelcome);

            // decorative user icon (top-right of the card)
            picUserIcon = new IconPictureBox()
            {
                Base64 = Icons.User,
                Size = new Size(60, 60),
                Location = new Point(pnlRightCard.Width - 88, 12),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                AutoRound = true,
                Tint = Color.FromArgb(0, 200, 160)
            };
            pnlRightCard.Controls.Add(picUserIcon);

            // subtitle
            lblSub = new Label()
            {
                Text = "Sign in to access your barangay services",
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(28, 62)
            };
            pnlRightCard.Controls.Add(lblSub);

            // tabs: Email / QR
            btnTabEmail = new Button()
            {
                Text = "Email / ID",
                FlatStyle = FlatStyle.Flat,
                Location = new Point(28, 108),
                Size = new Size(140, 36),
                BackColor = Color.White,
                FlatAppearance = { BorderSize = 0 },
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            pnlRightCard.Controls.Add(btnTabEmail);

            btnTabQR = new Button()
            {
                Text = "QR Code",
                FlatStyle = FlatStyle.Flat,
                Location = new Point(180, 108),
                Size = new Size(140, 36),
                BackColor = Color.Transparent,
                FlatAppearance = { BorderSize = 0 },
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                Cursor = Cursors.Hand
            };
            pnlRightCard.Controls.Add(btnTabQR);

            // PANEL: email login container
            pnlEmailLogin = new Panel()
            {
                Location = new Point(28, 156),
                Size = new Size(pnlRightCard.Width - 56, 310),
                BackColor = Color.Transparent,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            // Email input container: rounded border with icon at left
            pnlEmailInput = new RoundedPanel()
            {
                Size = new Size(pnlEmailLogin.Width, 48),
                Location = new Point(0, 0),
                BackColor = Color.FromArgb(250, 250, 250),
                BorderColor = Color.FromArgb(230, 230, 230),
                CornerRadius = 10,
                ShadowOffset = 0,
                Padding = new Padding(10),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            picEmailIcon = new IconPictureBox()
            {
                Base64 = Icons.Mail,
                Size = new Size(22, 22),
                Location = new Point(14, 13),
                Tint = Color.Gray,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            pnlEmailInput.Controls.Add(picEmailIcon);
            txtEmail = new TextBox()
            {
                Text = "Enter your email or resident ID",
                ForeColor = Color.Gray,
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(250, 250, 250),
                Font = new Font("Segoe UI", 10F),
                Location = new Point(52, 12),
                Width = pnlEmailInput.Width - 64,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            // placeholder behavior handled in LoginForm.cs (your logic)
            pnlEmailInput.Controls.Add(txtEmail);
            pnlEmailLogin.Controls.Add(pnlEmailInput);

            // Password input container
            pnlPasswordInput = new RoundedPanel()
            {
                Size = new Size(pnlEmailLogin.Width, 48),
                Location = new Point(0, 64),
                BackColor = Color.FromArgb(250, 250, 250),
                BorderColor = Color.FromArgb(230, 230, 230),
                CornerRadius = 10,
                ShadowOffset = 0,
                Padding = new Padding(10),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            picPasswordIcon = new IconPictureBox()
            {
                Base64 = Icons.Lock,
                Size = new Size(22, 22),
                Location = new Point(14, 13),
                Tint = Color.Gray,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            pnlPasswordInput.Controls.Add(picPasswordIcon);
            txtPassword = new TextBox()
            {
                Text = "Enter your password",
                ForeColor = Color.Gray,
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(250, 250, 250),
                Font = new Font("Segoe UI", 10F),
                Location = new Point(52, 12),
                Width = pnlPasswordInput.Width - 64,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                UseSystemPasswordChar = false // placeholder visible until focus; LoginForm.cs toggles on focus
            };
            pnlPasswordInput.Controls.Add(txtPassword);
            pnlEmailLogin.Controls.Add(pnlPasswordInput);

            // remember + forgot
            chkRemember = new CheckBox()
            {
                Text = "Remember me",
                Location = new Point(2, 124),
                AutoSize = true
            };
            pnlEmailLogin.Controls.Add(chkRemember);

            linkForgot = new LinkLabel()
            {
                Text = "Forgot password?",
                Location = new Point(120, 124),
                AutoSize = true
            };
            pnlEmailLogin.Controls.Add(linkForgot);

            // Sign In button (full width)
            btnSignIn = new Button()
            {
                Text = "Sign In",
                BackColor = Color.FromArgb(79, 0, 255),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Size = new Size(pnlEmailLogin.Width, 48),
                Location = new Point(0, 156),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            pnlEmailLogin.Controls.Add(btnSignIn);

            // Divider and social
            lblDividerText = new Label()
            {
                Text = "Or continue with",
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point((pnlEmailLogin.Width / 2) - 60, 216)
            };
            pnlEmailLogin.Controls.Add(lblDividerText);

            btnGoogle = new Button()
            {
                Text = "  Sign in with Google",
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 1 },
                Size = new Size(pnlEmailLogin.Width, 44),
                Location = new Point(0, 244),
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            pnlEmailLogin.Controls.Add(btnGoogle);

            picGoogleIcon = new IconPictureBox()
            {
                Base64 = Icons.Google,
                Size = new Size(20, 20),
                Location = new Point(12, 252),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            pnlEmailLogin.Controls.Add(picGoogleIcon);

            // attach email panel into card
            pnlRightCard.Controls.Add(pnlEmailLogin);

            // QR Panel (placeholder)
            pnlQRLogin = new Panel()
            {
                Location = pnlEmailLogin.Location,
                Size = pnlEmailLogin.Size,
                Visible = false
            };
            var lblQR = new Label() { Text = "Scan your QR code to sign in", Location = new Point(12, 12), AutoSize = true };
            pnlQRLogin.Controls.Add(lblQR);
            var picQR = new IconPictureBox() { Base64 = Icons.QR, Size = new Size(160, 160), Location = new Point((pnlQRLogin.Width - 160) / 2, 36), SizeMode = PictureBoxSizeMode.Zoom };
            pnlQRLogin.Controls.Add(picQR);
            pnlRightCard.Controls.Add(pnlQRLogin);

            // footer: demo creds + register
            lblDemoCredentials = new Label()
            {
                Text = "Demo: demo@barangayan.gov / demo123 (click to copy)",
                ForeColor = Color.Gray,
                AutoSize = true,
                Location = new Point(6, pnlRightCard.Height - 42),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left
            };
            pnlRightCard.Controls.Add(lblDemoCredentials);

            linkRegister = new LinkLabel()
            {
                Text = "Create Account",
                AutoSize = true,
                Location = new Point(pnlRightCard.Width - 140, pnlRightCard.Height - 42),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right
            };
            pnlRightCard.Controls.Add(linkRegister);

            //
            // Add event wiring that must exist in Designer so LoginForm.cs handlers can rely on these controls.
            // The actual placeholder behavior, masking on focus, and sign-in logic remain inside LoginForm.cs.
            //
            btnTabEmail.Click += (s, e) => { SetAuthTab(true); };
            btnTabQR.Click += (s, e) => { SetAuthTab(false); };

            // Ensure textboxes show placeholder and then mask the password on focus (LoginForm.cs already wires but in case not present)
            txtEmail.GotFocus += (s, e) =>
            {
                if (txtEmail.Text == "Enter your email or resident ID")
                {
                    txtEmail.Text = "";
                    txtEmail.ForeColor = Color.Black;
                }
            };
            txtEmail.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    txtEmail.Text = "Enter your email or resident ID";
                    txtEmail.ForeColor = Color.Gray;
                }
            };

            txtPassword.GotFocus += (s, e) =>
            {
                if (txtPassword.Text == "Enter your password")
                {
                    txtPassword.Text = "";
                    txtPassword.ForeColor = Color.Black;
                    txtPassword.UseSystemPasswordChar = true;
                }
            };
            txtPassword.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    txtPassword.UseSystemPasswordChar = false;
                    txtPassword.Text = "Enter your password";
                    txtPassword.ForeColor = Color.Gray;
                }
            };

            // Sign-in click - kept simple here; full logic in LoginForm.cs will still run if wired there.
            btnSignIn.Click += (s, e) => BtnSignIn_Click(s, e);

            // Google placeholder
            btnGoogle.Click += (s, e) => MessageBox.Show("Google Sign-in not implemented here.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Demo copy
            lblDemoCredentials.Click += (s, e) =>
            {
                try { Clipboard.SetText("demo@barangayan.gov:demo123"); MessageBox.Show("Demo credentials copied.", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                catch { /* ignore */ }
            };

            // Form resize handler -> responsive adjustments
            this.Resize += (s, e) =>
            {
                // Recalculate left column width (keeps ~42% visually)
                pnlLeftColumn.Width = Math.Max(360, (int)(this.ClientSize.Width * 0.42));
                // center card in remaining area
                int remaining = this.ClientSize.Width - pnlLeftColumn.Width;
                pnlRightCard.Left = pnlLeftColumn.Width + Math.Max(32, (remaining - pnlRightCard.Width) / 2);
                pnlRightCard.Top = Math.Max(28, (this.ClientSize.Height - pnlRightCard.Height) / 2);

                // stretch inner inputs
                pnlEmailLogin.Width = Math.Max(420, pnlRightCard.ClientSize.Width - 56);
                pnlEmailInput.Width = pnlEmailLogin.Width;
                pnlPasswordInput.Width = pnlEmailLogin.Width;
                txtEmail.Width = pnlEmailInput.Width - 64;
                txtPassword.Width = pnlPasswordInput.Width - 64;

                // update positions for footer links inside the card
                linkRegister.Left = pnlRightCard.Width - linkRegister.Width - 20;
                lblDemoCredentials.Top = pnlRightCard.Height - 44;
                linkRegister.Top = pnlRightCard.Height - 44;

                // reposition user icon inside card
                picUserIcon.Left = pnlRightCard.Width - picUserIcon.Width - 28;
            };

            // Finalize
            this.ResumeLayout(false);
        }

        // Expose SetAuthTab so Designer-wired handlers can call it (LoginForm.cs also defines it)
        private void SetAuthTab(bool emailActive)
        {
            // Minimal visual change here — actual visibility of panels is important.
            if (pnlEmailLogin != null && pnlQRLogin != null)
            {
                pnlEmailLogin.Visible = emailActive;
                pnlQRLogin.Visible = !emailActive;
            }

            if (btnTabEmail != null && btnTabQR != null)
            {
                btnTabEmail.BackColor = emailActive ? Color.White : Color.Transparent;
                btnTabEmail.ForeColor = emailActive ? Color.FromArgb(79, 0, 255) : Color.Gray;
                btnTabQR.BackColor = !emailActive ? Color.White : Color.Transparent;
                btnTabQR.ForeColor = !emailActive ? Color.FromArgb(79, 0, 255) : Color.Gray;
            }
        }

        // Designer helper stub so BtnSignIn_Click compile reference exists if not present in LoginForm.cs
        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            // If real handler exists in LoginForm.cs it will be used; this is a fallback to avoid compile errors.
            string email = txtEmail?.Text ?? "";
            string pass = txtPassword?.Text ?? "";
            if (string.IsNullOrWhiteSpace(email) || email == "Enter your email or resident ID")
            {
                MessageBox.Show("Please enter your email or resident ID.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail?.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(pass) || pass == "Enter your password")
            {
                MessageBox.Show("Please enter your password.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword?.Focus();
                return;
            }

            // Example: do not store plain passwords. If you want to persist credentials use hashing (PBKDF2/bcrypt) on server-side.
            MessageBox.Show("Sign-in logic placeholder. Integrate your authentication flow here.", "Sign In", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
