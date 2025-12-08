using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BarangayanEMS
{
    public partial class LoginForm : Form
    {
        // -------------------- CONSTANTS / FIELDS --------------------

        private enum LoginTab
        {
            Email = 0,
            QR = 1
        }

        private const string PlaceholderEmail = "Enter your email or resident ID";
        private const string PlaceholderPassword = "Enter your password";

        private readonly Color PrimaryColor = Color.FromArgb(102, 0, 255);
        private readonly Color PrimaryHoverColor = Color.FromArgb(85, 0, 220);
        private readonly Color GoogleHoverColor = Color.FromArgb(245, 245, 245);
        private readonly Color CardBorderColor = Color.FromArgb(214, 219, 255);

        
        private IconPictureBox iconQRLarge;
        
      
        

        private ToolTip tooltip;
        private LoginTab _currentTab;

        // ------------- WIN32 for dragging borderless form ----------

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        // ------------------------- CTOR -----------------------------

        public LoginForm()
        {
            InitializeComponent();
            EnableDoubleBuffering();
            InitializeRuntimeUI();
            WireEvents();
            SwitchTab(LoginTab.Email);
        }

        private void EnableDoubleBuffering()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.UserPaint, true);
            UpdateStyles();
        }

        // ----------------- RUNTIME UI SETUP ------------------------

        private void InitializeRuntimeUI()
        {
            tooltip = new ToolTip
            {
                IsBalloon = true,
                UseFading = true,
                UseAnimation = true,
                AutoPopDelay = 3000,
                InitialDelay = 400,
                ReshowDelay = 250
            };

            // Primary sign-in button
            btnSignIn.BackColor = PrimaryColor;
            btnSignIn.ForeColor = Color.White;
            btnSignIn.FlatStyle = FlatStyle.Flat;
            btnSignIn.FlatAppearance.BorderSize = 0;
            btnSignIn.Cursor = Cursors.Hand;

            // Google button container
            pnlGoogleButton.BackColor = Color.White;
            pnlGoogleButton.BorderStyle = BorderStyle.FixedSingle;

            // Demo panel – light card with border
            pnlDemo.BackColor = Color.FromArgb(245, 247, 255);
            pnlDemo.Paint += (s, e) =>
            {
                using (var pen = new Pen(CardBorderColor))
                {
                    var rect = new Rectangle(0, 0, pnlDemo.Width - 1, pnlDemo.Height - 1);
                    e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    e.Graphics.DrawRectangle(pen, rect);
                }
            };

            // Feature cards – just ensure white background (they are already rounded in Designer)
            cardSecure.BackColor = Color.White;
            card247.BackColor = Color.White;
            cardDigital.BackColor = Color.White;

            // Manual placeholders (since .NET 4.8 has no PlaceholderText)
            SetupPlaceholder(txtEmail, PlaceholderEmail);
            SetupPlaceholder(txtPassword, PlaceholderPassword, isPassword: true);

            // Tooltips
            tooltip.SetToolTip(linkDemoCopy, "Copy demo credentials");
            tooltip.SetToolTip(pnlDemo, "Click to fill demo credentials");
        }

        private void IconQRLarge_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "This feature is to be added soon.",
                "QR Login Coming Soon",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }


        // ------------------- EVENT WIRING --------------------------

        private void WireEvents()
        {
            // Tabs
            lblTabQR.Click += (s, e) => {
                IconQRLarge_Click(s, e); // Show popup
                                         // SwitchTab(LoginTab.QR); // REMOVE this if QR login is not yet available
            };

            // Create account
            linkCreateAccount.LinkClicked += (s, e) =>
            {
                CreateAccountForm create = new CreateAccountForm();
                create.Show();
                this.Hide(); // Hides the login
            };


            lblTabEmail.MouseEnter += (s, e) => lblTabEmail.ForeColor = PrimaryColor;
            lblTabEmail.MouseLeave += (s, e) =>
            {
                if (_currentTab != LoginTab.Email)
                    lblTabEmail.ForeColor = Color.DimGray;
            };

            lblTabQR.MouseEnter += (s, e) => lblTabQR.ForeColor = PrimaryColor;
            lblTabQR.MouseLeave += (s, e) =>
            {
                if (_currentTab != LoginTab.QR)
                    lblTabQR.ForeColor = Color.DimGray;
            };

            // Drag area for borderless form
            pnlRoot.MouseDown += DragWindow_MouseDown;
            pnlLoginCard.MouseDown += DragWindow_MouseDown;
            lblWelcome.MouseDown += DragWindow_MouseDown;
            lblWelcomeSub.MouseDown += DragWindow_MouseDown;

            // Sign in button
            btnSignIn.MouseEnter += (s, e) => btnSignIn.BackColor = PrimaryHoverColor;
            btnSignIn.MouseLeave += (s, e) => btnSignIn.BackColor = PrimaryColor;
            btnSignIn.Click += BtnSignIn_Click;

            // Google button (panel + inner controls)
            pnlGoogleButton.MouseEnter += (s, e) => pnlGoogleButton.BackColor = GoogleHoverColor;
            pnlGoogleButton.MouseLeave += (s, e) => pnlGoogleButton.BackColor = Color.White;
            pnlGoogleButton.Click += GoogleSignIn_Click;
            lblGoogleText.Click += GoogleSignIn_Click;
            iconGoogle.Click += GoogleSignIn_Click;

            // Demo account – click anywhere fills & copies
            pnlDemo.Click += DemoClick_FillAndCopy;
            iconDemoTick.Click += DemoClick_FillAndCopy;
            lblDemoTitle.Click += DemoClick_FillAndCopy;
            lblDemoEmailCaption.Click += DemoClick_FillAndCopy;
            lblDemoEmailValue.Click += DemoClick_FillAndCopy;
            lblDemoPasswordCaption.Click += DemoClick_FillAndCopy;
            lblDemoPasswordValue.Click += DemoClick_FillAndCopy;
            linkDemoCopy.Click += DemoClick_FillAndCopy;


            // ---- CREATE ACCOUNT LINK ----
            Label lblNoAccount = new Label()
            {
                AutoSize = true,
                Text = "Don't have an account?",
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(100, 100, 100),
                Location = new Point(260, 510)
            };
            this.pnlLoginCard.Controls.Add(lblNoAccount);

            LinkLabel linkCreateAcc = new LinkLabel()
            {
                AutoSize = true,
                Text = "Create Account",
                Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold),
                LinkColor = Color.FromArgb(80, 0, 200),
                Location = new Point(390, 510),
                Cursor = Cursors.Hand
            };
            linkCreateAcc.Click += (s, e) =>
            {
                CreateAccountForm reg = new CreateAccountForm();
                reg.Show();
                this.Hide();
            };
            this.pnlLoginCard.Controls.Add(linkCreateAcc);


            // Create account
            linkCreateAccount.LinkClicked += (s, e) =>
            {
                MessageBox.Show(
                    "Account registration screen will be implemented here.",
                    "Create Account",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            };

            // Forgot password
            linkForgot.LinkClicked += (s, e) =>
            {
                MessageBox.Show(
                    "Forgot password flow will be implemented here.",
                    "Forgot Password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            };
        }

        // ----------------- PLACEHOLDER LOGIC -----------------------

        private class PlaceholderInfo
        {
            public string Text;
            public bool IsPassword;
        }

        private void SetupPlaceholder(TextBox txt, string placeholder, bool isPassword = false)
        {
            txt.Tag = new PlaceholderInfo
            {
                Text = placeholder,
                IsPassword = isPassword
            };

            txt.ForeColor = Color.Gray;
            txt.Text = placeholder;

            txt.GotFocus += TextBox_GotFocus;
            txt.LostFocus += TextBox_LostFocus;
        }

        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            if (sender is TextBox txt && txt.Tag is PlaceholderInfo info)
            {
                if (txt.Text == info.Text)
                {
                    txt.Text = string.Empty;
                    txt.ForeColor = Color.FromArgb(40, 40, 40);
                    if (info.IsPassword)
                        txt.PasswordChar = '●';
                }
            }
        }

        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            if (sender is TextBox txt && txt.Tag is PlaceholderInfo info)
            {
                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    txt.Text = info.Text;
                    txt.ForeColor = Color.Gray;
                    if (info.IsPassword)
                        txt.PasswordChar = '\0';
                }
            }
        }

        // ------------------ TAB SWITCHING --------------------------

        private void SwitchTab(LoginTab tab)
        {
            _currentTab = tab;

            bool isEmail = tab == LoginTab.Email;

            pnlEmailWrapper.Visible = isEmail;
            chkRemember.Visible = isEmail;
            linkForgot.Visible = isEmail;
            btnSignIn.Visible = isEmail;
            lblOrContinue.Visible = isEmail;
            pnlGoogleButton.Visible = isEmail;
            pnlDemo.Visible = isEmail;

           

            if (isEmail)
            {
                lblTabEmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
                lblTabQR.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

                lblTabEmail.ForeColor = Color.FromArgb(40, 40, 40);
                lblTabQR.ForeColor = Color.DimGray;

                underlineEmail.BackColor = PrimaryColor;
                underlineQR.BackColor = Color.Transparent;
            }
            else
            {
                lblTabQR.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
                lblTabEmail.Font = new Font("Segoe UI", 10F, FontStyle.Regular);

                lblTabQR.ForeColor = Color.FromArgb(40, 40, 40);
                lblTabEmail.ForeColor = Color.DimGray;

                underlineQR.BackColor = PrimaryColor;
                underlineEmail.BackColor = Color.Transparent;
            }
        }

        // -------------------- BUTTON HANDLERS ----------------------

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string pass = txtPassword.Text.Trim();

            // Validate email
            if (string.IsNullOrWhiteSpace(email) || email == "Enter your email or resident ID")
            {
                MessageBox.Show("Please enter your email or resident ID.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // Validate password
            if (string.IsNullOrWhiteSpace(pass) || pass == "Enter your password")
            {
                MessageBox.Show("Please enter your password.", "Missing Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // ---- DEMO ACCOUNT LOGIN ----
            if (email.Equals("demo@barangayan.gov", StringComparison.OrdinalIgnoreCase) && pass == "demo123")
            {
                // Optional success message
                // MessageBox.Show("Login Successful!", "Welcome",
                //     MessageBoxButtons.OK, MessageBoxIcon.Information);

                // OPEN DASHBOARD
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();      // show dashboard
                this.Hide();           // hide login form
            }
            else
            {
                MessageBox.Show("Invalid credentials.", "Authentication Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private static string GetActualText(TextBox txt, string placeholder)
        {
            return (txt.Text == placeholder) ? string.Empty : txt.Text.Trim();
        }

        private void GoogleSignIn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Google OAuth sign-in will be integrated here.\nRight now this is just a UI demo.",
                "Google Sign-In",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void DemoClick_FillAndCopy(object sender, EventArgs e)
        {
            const string demoEmail = "demo@barangayan.gov";
            const string demoPassword = "demo123";

            SetTextBoxValue(txtEmail, PlaceholderEmail, demoEmail, isPassword: false);
            SetTextBoxValue(txtPassword, PlaceholderPassword, demoPassword, isPassword: true);

            try
            {
                Clipboard.SetText($"{demoEmail} / {demoPassword}");
                tooltip.Show("Demo credentials copied!", pnlDemo, pnlDemo.Width - 130, 5, 2000);
            }
            catch
            {
                // Clipboard might fail in some environments – ignore.
            }

            pnlDemo.BackColor = Color.FromArgb(238, 241, 255);
            var timer = new Timer { Interval = 350 };
            timer.Tick += (s2, e2) =>
            {
                timer.Stop();
                timer.Dispose();
                pnlDemo.BackColor = Color.FromArgb(245, 247, 255);
            };
            timer.Start();
        }

        private void SetTextBoxValue(TextBox txt, string placeholder, string value, bool isPassword)
        {
            txt.ForeColor = Color.FromArgb(40, 40, 40);
            txt.Text = value;

            if (txt.Tag is PlaceholderInfo info)
                info.IsPassword = isPassword;

            if (isPassword)
                txt.PasswordChar = '●';
        }

        // --------------------- DRAG WINDOW -------------------------

        private void DragWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void lblOrContinue_Click(object sender, EventArgs e)
        {

        }
       
}
}
