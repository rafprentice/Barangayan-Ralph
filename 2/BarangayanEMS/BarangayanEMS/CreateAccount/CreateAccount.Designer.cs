// ============================================================
// CreateAccountForm.Designer.cs — Clean UI + Proper Padding
// ============================================================
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BarangayanEMS
{
    partial class CreateAccountForm
    {
        private IContainer components = null;

        // ROOT
        private GradientPanel pnlRoot;
        private RoundedPanel pnlCard;
        private Label lblTitle;

        // LEFT – PERSONAL
        private RoundedPanel pnlPersonal;
        private Label lblPersonalIcon;
        private Label lblPersonalHeader;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblMiddleName;
        private TextBox txtMiddleName;
        private Label lblSuffix;
        private TextBox txtSuffix;
        private Label lblBirthDate;
        private DateTimePicker dtBirthDate;
        private Label lblGender;
        private ComboBox cbGender;
        private Label lblContact;
        private ComboBox cbCountryCode;
        private TextBox txtContact;
        private Label lblAddress;
        private TextBox txtAddress;

        // RIGHT – SECURITY
        private RoundedPanel pnlSecurity;
        private Label lblSecurityIcon;
        private Label lblSecurityHeader;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirm;
        private TextBox txtConfirm;
        private CheckBox chkTerms;

        // BOTTOM
        private Button btnCreate;
        private Label lblHaveAccount;
        private LinkLabel linkSignIn;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.pnlCard = new RoundedPanel();
            this.lblTitle = new Label();

            this.pnlPersonal = new RoundedPanel();
            this.lblPersonalIcon = new Label();
            this.lblPersonalHeader = new Label();
            this.lblFirstName = new Label();
            this.txtFirstName = new TextBox();
            this.lblLastName = new Label();
            this.txtLastName = new TextBox();
            this.lblMiddleName = new Label();
            this.txtMiddleName = new TextBox();
            this.lblSuffix = new Label();
            this.txtSuffix = new TextBox();
            this.lblBirthDate = new Label();
            this.dtBirthDate = new DateTimePicker();
            this.lblGender = new Label();
            this.cbGender = new ComboBox();
            this.lblContact = new Label();
            this.cbCountryCode = new ComboBox();
            this.txtContact = new TextBox();
            this.lblAddress = new Label();
            this.txtAddress = new TextBox();

            this.pnlSecurity = new RoundedPanel();
            this.lblSecurityIcon = new Label();
            this.lblSecurityHeader = new Label();
            this.lblEmail = new Label();
            this.txtEmail = new TextBox();
            this.lblPassword = new Label();
            this.txtPassword = new TextBox();
            this.lblConfirm = new Label();
            this.txtConfirm = new TextBox();
            this.chkTerms = new CheckBox();

            this.btnCreate = new Button();
            this.lblHaveAccount = new Label();
            this.linkSignIn = new LinkLabel();

            this.pnlRoot.SuspendLayout();
            this.pnlCard.SuspendLayout();
            this.pnlPersonal.SuspendLayout();
            this.pnlSecurity.SuspendLayout();
            this.SuspendLayout();

            // =========================================================
            // ROOT GRADIENT PANEL
            // =========================================================
            this.pnlRoot.Dock = DockStyle.Fill;
            this.pnlRoot.GradientColor1 = Color.FromArgb(102, 0, 255);
            this.pnlRoot.GradientColor2 = Color.FromArgb(151, 46, 255);
            this.pnlRoot.Angle = 135f;
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.TabIndex = 0;

            // =========================================================
            // TITLE
            // =========================================================
            this.lblTitle.Text = "Create Account";
            this.lblTitle.Font = new Font("Segoe UI Semibold", 32F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Dock = DockStyle.Top;
            this.lblTitle.Height = 90;
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitle.BackColor = Color.Transparent;

            // =========================================================
            // MAIN CARD
            // =========================================================
            this.pnlCard.BackColor = Color.White;
            this.pnlCard.CornerRadius = 28;
            this.pnlCard.BorderColor = Color.Transparent;
            this.pnlCard.Size = new Size(900, 520);
            this.pnlCard.Location = new Point((1280 - 900) / 2, 110);
            this.pnlCard.ShadowAlpha = 40;
            this.pnlCard.ShadowOffset = 10;
            this.pnlCard.Padding = new Padding(32, 32, 32, 24);

            // =========================================================
            // PERSONAL PANEL (LEFT)
            // =========================================================
            this.pnlPersonal.BackColor = Color.White;
            this.pnlPersonal.CornerRadius = 20;
            this.pnlPersonal.BorderColor = Color.FromArgb(235, 235, 255);
            this.pnlPersonal.Size = new Size(410, 360);
            this.pnlPersonal.Location = new Point(24, 24);
            this.pnlPersonal.Padding = new Padding(20);
            this.pnlPersonal.Name = "pnlPersonal";

            // icon
            this.lblPersonalIcon.AutoSize = true;
            this.lblPersonalIcon.Font = new Font("Segoe UI Emoji", 18F);
            this.lblPersonalIcon.Location = new Point(15, 8);
            this.lblPersonalIcon.Text = "👤";

            // header
            this.lblPersonalHeader.AutoSize = true;
            this.lblPersonalHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            this.lblPersonalHeader.Location = new Point(63, 16);
            this.lblPersonalHeader.Text = "Personal Information";

            int px1 = 32;
            int px2 = 215;
            int py = 60;

            // First Name
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new Font("Segoe UI", 9F);
            this.lblFirstName.Location = new Point(px1, py);
            this.lblFirstName.Text = "First Name";

            this.txtFirstName.Font = new Font("Segoe UI", 9.5F);
            this.txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            this.txtFirstName.Location = new Point(px1, py + 18);
            this.txtFirstName.Size = new Size(160, 24);
            this.txtFirstName.Name = "txtFirstName";

            // Last Name
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new Font("Segoe UI", 9F);
            this.lblLastName.Location = new Point(px2, py);
            this.lblLastName.Text = "Last Name";

            this.txtLastName.Font = new Font("Segoe UI", 9.5F);
            this.txtLastName.BorderStyle = BorderStyle.FixedSingle;
            this.txtLastName.Location = new Point(px2, py + 18);
            this.txtLastName.Size = new Size(160, 24);
            this.txtLastName.Name = "txtLastName";

            // Middle + Suffix
            py += 56;
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.Font = new Font("Segoe UI", 9F);
            this.lblMiddleName.Location = new Point(px1, py);
            this.lblMiddleName.Text = "Middle Name";

            this.txtMiddleName.Font = new Font("Segoe UI", 9.5F);
            this.txtMiddleName.BorderStyle = BorderStyle.FixedSingle;
            this.txtMiddleName.Location = new Point(px1, py + 18);
            this.txtMiddleName.Size = new Size(160, 24);

            this.lblSuffix.AutoSize = true;
            this.lblSuffix.Font = new Font("Segoe UI", 9F);
            this.lblSuffix.Location = new Point(px2, py);
            this.lblSuffix.Text = "Suffix";

            this.txtSuffix.Font = new Font("Segoe UI", 9.5F);
            this.txtSuffix.BorderStyle = BorderStyle.FixedSingle;
            this.txtSuffix.Location = new Point(px2, py + 18);
            this.txtSuffix.Size = new Size(160, 24);

            // Birthdate + Gender
            py += 56;
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Font = new Font("Segoe UI", 9F);
            this.lblBirthDate.Location = new Point(px1, py);
            this.lblBirthDate.Text = "Birth Date";

            this.dtBirthDate.Font = new Font("Segoe UI", 9F);
            this.dtBirthDate.Format = DateTimePickerFormat.Short;
            this.dtBirthDate.Location = new Point(px1, py + 18);
            this.dtBirthDate.Size = new Size(160, 23);

            this.lblGender.AutoSize = true;
            this.lblGender.Font = new Font("Segoe UI", 9F);
            this.lblGender.Location = new Point(px2, py);
            this.lblGender.Text = "Gender";

            this.cbGender.Font = new Font("Segoe UI", 9F);
            this.cbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbGender.Items.AddRange(new object[] { "Male", "Female" });
            this.cbGender.Location = new Point(px2, py + 18);
            this.cbGender.Size = new Size(160, 23);

            // Contact
            py += 56;
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new Font("Segoe UI", 9F);
            this.lblContact.Location = new Point(px1, py);
            this.lblContact.Text = "Contact Number";

            this.cbCountryCode.Font = new Font("Segoe UI", 9F);
            this.cbCountryCode.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbCountryCode.Items.Add("+63");
            this.cbCountryCode.SelectedIndex = 0;
            this.cbCountryCode.Location = new Point(px1, py + 18);
            this.cbCountryCode.Size = new Size(60, 23);

            this.txtContact.Font = new Font("Segoe UI", 9.5F);
            this.txtContact.BorderStyle = BorderStyle.FixedSingle;
            this.txtContact.Location = new Point(px1 + 70, py + 18);
            this.txtContact.Size = new Size(250, 24);

            // Address
            py += 56;
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new Font("Segoe UI", 9F);
            this.lblAddress.Location = new Point(px1, py);
            this.lblAddress.Text = "Complete Address";

            this.txtAddress.Font = new Font("Segoe UI", 9.5F);
            this.txtAddress.BorderStyle = BorderStyle.FixedSingle;
            this.txtAddress.Location = new Point(px1, py + 18);
            this.txtAddress.Size = new Size(330, 24);

            // Add controls to personal panel
            this.pnlPersonal.Controls.Add(this.lblPersonalIcon);
            this.pnlPersonal.Controls.Add(this.lblPersonalHeader);
            this.pnlPersonal.Controls.Add(this.lblFirstName);
            this.pnlPersonal.Controls.Add(this.txtFirstName);
            this.pnlPersonal.Controls.Add(this.lblLastName);
            this.pnlPersonal.Controls.Add(this.txtLastName);
            this.pnlPersonal.Controls.Add(this.lblMiddleName);
            this.pnlPersonal.Controls.Add(this.txtMiddleName);
            this.pnlPersonal.Controls.Add(this.lblSuffix);
            this.pnlPersonal.Controls.Add(this.txtSuffix);
            this.pnlPersonal.Controls.Add(this.lblBirthDate);
            this.pnlPersonal.Controls.Add(this.dtBirthDate);
            this.pnlPersonal.Controls.Add(this.lblGender);
            this.pnlPersonal.Controls.Add(this.cbGender);
            this.pnlPersonal.Controls.Add(this.lblContact);
            this.pnlPersonal.Controls.Add(this.cbCountryCode);
            this.pnlPersonal.Controls.Add(this.txtContact);
            this.pnlPersonal.Controls.Add(this.lblAddress);
            this.pnlPersonal.Controls.Add(this.txtAddress);

            // =========================================================
            // SECURITY PANEL (RIGHT)
            // =========================================================
            this.pnlSecurity.BackColor = Color.White;
            this.pnlSecurity.CornerRadius = 20;
            this.pnlSecurity.BorderColor = Color.FromArgb(235, 235, 255);
            this.pnlSecurity.Size = new Size(410, 360);
            this.pnlSecurity.Location = new Point(450, 24);
            this.pnlSecurity.Padding = new Padding(20);
            this.pnlSecurity.Name = "pnlSecurity";

            // icon + header
            this.lblSecurityIcon.AutoSize = true;
            this.lblSecurityIcon.Font = new Font("Segoe UI Emoji", 18F);
            this.lblSecurityIcon.Location = new Point(18, 10);
            this.lblSecurityIcon.Text = "🔒";

            this.lblSecurityHeader.AutoSize = true;
            this.lblSecurityHeader.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            this.lblSecurityHeader.Location = new Point(63, 16);
            this.lblSecurityHeader.Text = "Account Security";

            int sx = 32;
            int sy = 60;

            // Email
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new Font("Segoe UI", 9F);
            this.lblEmail.Location = new Point(sx, sy);
            this.lblEmail.Text = "Email Address";

            this.txtEmail.Font = new Font("Segoe UI", 9.5F);
            this.txtEmail.BorderStyle = BorderStyle.FixedSingle;
            this.txtEmail.Location = new Point(sx, sy + 18);
            this.txtEmail.Size = new Size(340, 24);
            this.txtEmail.Name = "txtEmail";

            // Password
            sy += 56;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new Font("Segoe UI", 9F);
            this.lblPassword.Location = new Point(sx, sy);
            this.lblPassword.Text = "Password";

            this.txtPassword.Font = new Font("Segoe UI", 9.5F);
            this.txtPassword.BorderStyle = BorderStyle.FixedSingle;
            this.txtPassword.Location = new Point(sx, sy + 18);
            this.txtPassword.Size = new Size(340, 24);
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Name = "txtPassword";

            // Confirm Password
            sy += 56;
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Font = new Font("Segoe UI", 9F);
            this.lblConfirm.Location = new Point(sx, sy);
            this.lblConfirm.Text = "Confirm Password";

            this.txtConfirm.Font = new Font("Segoe UI", 9.5F);
            this.txtConfirm.BorderStyle = BorderStyle.FixedSingle;
            this.txtConfirm.Location = new Point(sx, sy + 18);
            this.txtConfirm.Size = new Size(340, 24);
            this.txtConfirm.PasswordChar = '●';
            this.txtConfirm.Name = "txtConfirm";

            // Terms checkbox
            sy += 56;
            this.chkTerms.AutoSize = true;
            this.chkTerms.Font = new Font("Segoe UI", 9F);
            this.chkTerms.Location = new Point(sx, sy);
            this.chkTerms.Text = "I agree to the terms and conditions to prove our Terms and Conditions.";
            this.chkTerms.Name = "chkTerms";

            // Add controls to security panel
            this.pnlSecurity.Controls.Add(this.lblSecurityIcon);
            this.pnlSecurity.Controls.Add(this.lblSecurityHeader);
            this.pnlSecurity.Controls.Add(this.lblEmail);
            this.pnlSecurity.Controls.Add(this.txtEmail);
            this.pnlSecurity.Controls.Add(this.lblPassword);
            this.pnlSecurity.Controls.Add(this.txtPassword);
            this.pnlSecurity.Controls.Add(this.lblConfirm);
            this.pnlSecurity.Controls.Add(this.txtConfirm);
            this.pnlSecurity.Controls.Add(this.chkTerms);

            // =========================================================
            // BOTTOM BUTTON + SIGN IN
            // =========================================================
            this.btnCreate.Text = "Create Account";
            this.btnCreate.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            this.btnCreate.BackColor = Color.FromArgb(102, 0, 255);
            this.btnCreate.ForeColor = Color.White;
            this.btnCreate.FlatStyle = FlatStyle.Flat;
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.Size = new Size(280, 44);
            this.btnCreate.Location = new Point((900 - 280) / 2, 405);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);

            this.lblHaveAccount.AutoSize = true;
            this.lblHaveAccount.Font = new Font("Segoe UI", 9F);
            this.lblHaveAccount.ForeColor = Color.FromArgb(90, 90, 90);
            this.lblHaveAccount.Location = new Point(310, 455);
            this.lblHaveAccount.Text = "Already have an account?";

            this.linkSignIn.AutoSize = true;
            this.linkSignIn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.linkSignIn.LinkColor = Color.FromArgb(80, 0, 200);
            this.linkSignIn.Location = new Point(470, 455);
            this.linkSignIn.Text = "Sign in";
            this.linkSignIn.Name = "linkSignIn";
            this.linkSignIn.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkSignIn_LinkClicked);

            // =========================================================
            // ADD TO CARD & ROOT
            // =========================================================
            this.pnlCard.Controls.Add(this.pnlPersonal);
            this.pnlCard.Controls.Add(this.pnlSecurity);
            this.pnlCard.Controls.Add(this.btnCreate);
            this.pnlCard.Controls.Add(this.lblHaveAccount);
            this.pnlCard.Controls.Add(this.linkSignIn);

            this.pnlRoot.Controls.Add(this.pnlCard);
            this.pnlRoot.Controls.Add(this.lblTitle);

            this.Controls.Add(this.pnlRoot);

            // =========================================================
            // FORM SETTINGS
            // =========================================================
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1280, 720);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Name = "CreateAccountForm";
            this.Text = "Create Account";

            this.pnlRoot.ResumeLayout(false);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            this.pnlPersonal.ResumeLayout(false);
            this.pnlPersonal.PerformLayout();
            this.pnlSecurity.ResumeLayout(false);
            this.pnlSecurity.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
