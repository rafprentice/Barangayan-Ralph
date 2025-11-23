namespace BarangayanSystem
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label lblForgot;
        private System.Windows.Forms.Label lblDemo;
        private System.Windows.Forms.Button btnGoogle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.lblForgot = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnGoogle = new System.Windows.Forms.Button();
            this.lblDemo = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(1050, 650);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.White;

            // Left Purple Panel
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Width = 600;
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(102, 0, 204); // Purple
            this.Controls.Add(this.panelLeft);

            // Login Panel
            this.panelLogin.Width = 350;
            this.panelLogin.Height = 450;
            this.panelLogin.Left = 650;
            this.panelLogin.Top = 100;
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelLogin);

            UIStyles.ApplyRoundedCorners(panelLogin, 25);

            // Email
            this.txtEmail.Width = 300;
            this.txtEmail.Left = 20;
            this.txtEmail.Top = 50;

            // Password
            this.txtPassword.Width = 300;
            this.txtPassword.Left = 20;
            this.txtPassword.Top = 100;
            this.txtPassword.UseSystemPasswordChar = true;

            // Show Password Checkbox
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.Top = 130;
            this.chkShowPassword.Left = 20;
            this.chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;

            // Login Button
            this.btnLogin.Text = "Sign In";
            this.btnLogin.Width = 300;
            this.btnLogin.Top = 170;
            this.btnLogin.Left = 20;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(102, 0, 204);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Click += btnLogin_Click;

            // Google Sign-in
            this.btnGoogle.Text = "Sign in with Google";
            this.btnGoogle.Width = 300;
            this.btnGoogle.Top = 220;
            this.btnGoogle.Left = 20;
            this.btnGoogle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoogle.BackColor = System.Drawing.Color.White;

            // Demo Label
            this.lblDemo.Top = 300;
            this.lblDemo.Left = 20;
            this.lblDemo.Width = 300;
            this.lblDemo.Text = "Demo Account:\nEmail: demo@barangayan.gov\nPassword: demo123";
            this.lblDemo.ForeColor = System.Drawing.Color.Black;

            // Add Controls
            this.panelLogin.Controls.Add(txtEmail);
            this.panelLogin.Controls.Add(txtPassword);
            this.panelLogin.Controls.Add(chkShowPassword);
            this.panelLogin.Controls.Add(btnLogin);
            this.panelLogin.Controls.Add(btnGoogle);
            this.panelLogin.Controls.Add(lblDemo);

            this.ResumeLayout(false);
        }
    }
}
