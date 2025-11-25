using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BarangayanEMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);

            // Default active tab
            SetAuthTab(true);

            // Copy demo credentials
            lblDemoCredentials.Cursor = Cursors.Hand;
            lblDemoCredentials.Click += (s, e) =>
            {
                try
                {
                    Clipboard.SetText("Email: demo@barangayan.gov\nPassword: demo123");
                    MessageBox.Show("Demo credentials copied to clipboard.", "Copied",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Unable to copy to clipboard.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            // Tab buttons
            btnTabEmail.Click += (s, e) => SetAuthTab(true);
            btnTabQR.Click += (s, e) => SetAuthTab(false);

            // Forgot password
            linkForgot.LinkClicked += (s, e) =>
                MessageBox.Show("Forgot password flow goes here.", "Info");

            // Register
            linkRegister.LinkClicked += (s, e) =>
                MessageBox.Show("Registration flow goes here.", "Info");

            // Google sign-in
            btnGoogle.Click += (s, e) =>
                MessageBox.Show("Google sign-in flow not implemented yet.", "Info");

            // Sign in button
            btnSignIn.Click += BtnSignIn_Click;

            // Placeholder styling for textboxes already defined in designer events
            // set initial visual states (ensure textboxes background rectangles look good)
            ApplyInputBackgroundStyles();
        }

        private void ApplyInputBackgroundStyles()
        {
            // For any simple visual consistency, ensure the "backing" rounded panels show behind textboxes.
            // No operational changes required here; this is a helper in case you later animate / style.
        }

        private void SetAuthTab(bool emailActive)
        {
            btnTabEmail.BackColor = emailActive ? Color.White : Color.Transparent;
            btnTabEmail.ForeColor = emailActive ? Color.FromArgb(79, 0, 255) : Color.Gray;
            btnTabEmail.Font = new Font(btnTabEmail.Font, emailActive ? FontStyle.Bold : FontStyle.Regular);

            btnTabQR.BackColor = !emailActive ? Color.White : Color.Transparent;
            btnTabQR.ForeColor = !emailActive ? Color.FromArgb(79, 0, 255) : Color.Gray;
            btnTabQR.Font = new Font(btnTabQR.Font, !emailActive ? FontStyle.Bold : FontStyle.Regular);

            pnlEmailLogin.Visible = emailActive;
            pnlQRLogin.Visible = !emailActive;
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string pass = txtPassword.Text;

            if (string.IsNullOrEmpty(email) || email == "Enter your email or resident ID")
            {
                MessageBox.Show("Please enter your email or resident ID.", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrEmpty(pass) || pass == "Enter your password")
            {
                MessageBox.Show("Please enter your password.", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (email.Equals("demo@barangayan.gov", StringComparison.OrdinalIgnoreCase)
                && pass == "demo123")
            {
                MessageBox.Show("Welcome! Login successful.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // TODO: Navigate to dashboard form
                // new Dashboard().Show();
                // this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helper to load base64 into System.Drawing.Image (if you need it elsewhere)
        private Image LoadBase64Image(string base64)
        {
            if (string.IsNullOrEmpty(base64)) return null;

            int idx = base64.IndexOf("base64,", StringComparison.OrdinalIgnoreCase);
            string payload = idx >= 0 ? base64.Substring(idx + 7) : base64;

            byte[] bytes = Convert.FromBase64String(payload);
            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
