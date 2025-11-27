using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace BarangayanEMS
{
    partial class LoginForm
    {
        private IContainer components = null;

        // ROOT
        private GradientPanel pnlRoot;

        // LEFT BRAND PANEL
        private Panel pnlBrand;
        private IconPictureBox picSeal;
        private Label lblRepublic;
        private Label lblSystem;

        private FeatureCard cardSecure;
        private FeatureCard card247;
        private FeatureCard cardDigital;

        // RIGHT LOGIN CARD
        private RoundedPanel pnlLoginCard;

        private IconPictureBox picProfile;
        private Label lblWelcome;
        private Label lblWelcomeSub;

        // Tabs
        private Panel pnlTabs;
        private Label lblTabEmail;
        private Label lblTabQR;
        private Panel underlineEmail;
        private Panel underlineQR;

        // Email login
        private Panel pnlEmailWrapper;
        private Panel pnlEmailBox;
        private IconPictureBox iconUser;
        private TextBox txtEmail;

        private Panel pnlPasswordBox;
        private IconPictureBox iconLock;
        private TextBox txtPassword;

        private CheckBox chkRemember;
        private LinkLabel linkForgot;

        private Button btnSignIn;

        private Label lblOrContinue;
        private Panel pnlGoogleButton;
        private IconPictureBox iconGoogle;
        private Label lblGoogleText;

        // Demo account container
        private Panel pnlDemo;
        private IconPictureBox iconDemoTick;
        private Label lblDemoTitle;
        private Label lblDemoEmailCaption;
        private Label lblDemoEmailValue;
        private Label lblDemoPasswordCaption;
        private Label lblDemoPasswordValue;
        private LinkLabel linkDemoCopy;

        // Footer
        private LinkLabel linkCreateAccount;

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
            this.components = new System.ComponentModel.Container();

            this.pnlRoot = new GradientPanel();
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.picSeal = new BarangayanEMS.IconPictureBox();
            this.lblRepublic = new System.Windows.Forms.Label();
            this.lblSystem = new System.Windows.Forms.Label();
            this.cardSecure = new BarangayanEMS.FeatureCard();
            this.card247 = new BarangayanEMS.FeatureCard();
            this.cardDigital = new BarangayanEMS.FeatureCard();

            this.pnlLoginCard = new BarangayanEMS.RoundedPanel();
            this.picProfile = new BarangayanEMS.IconPictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblWelcomeSub = new System.Windows.Forms.Label();

            this.pnlTabs = new System.Windows.Forms.Panel();
            this.lblTabEmail = new System.Windows.Forms.Label();
            this.lblTabQR = new System.Windows.Forms.Label();
            this.underlineEmail = new System.Windows.Forms.Panel();
            this.underlineQR = new System.Windows.Forms.Panel();

            this.pnlEmailWrapper = new System.Windows.Forms.Panel();
            this.pnlEmailBox = new System.Windows.Forms.Panel();
            this.iconUser = new BarangayanEMS.IconPictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();

            this.pnlPasswordBox = new System.Windows.Forms.Panel();
            this.iconLock = new BarangayanEMS.IconPictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();

            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.linkForgot = new System.Windows.Forms.LinkLabel();

            this.btnSignIn = new System.Windows.Forms.Button();
            this.lblOrContinue = new System.Windows.Forms.Label();
            this.pnlGoogleButton = new System.Windows.Forms.Panel();
            this.iconGoogle = new BarangayanEMS.IconPictureBox();
            this.lblGoogleText = new System.Windows.Forms.Label();

            this.pnlDemo = new System.Windows.Forms.Panel();
            this.iconDemoTick = new BarangayanEMS.IconPictureBox();
            this.lblDemoTitle = new System.Windows.Forms.Label();
            this.lblDemoEmailCaption = new System.Windows.Forms.Label();
            this.lblDemoEmailValue = new System.Windows.Forms.Label();
            this.lblDemoPasswordCaption = new System.Windows.Forms.Label();
            this.lblDemoPasswordValue = new System.Windows.Forms.Label();
            this.linkDemoCopy = new System.Windows.Forms.LinkLabel();

            this.linkCreateAccount = new System.Windows.Forms.LinkLabel();

            // ---------------- SUSPEND LAYOUTS ----------------
            ((System.ComponentModel.ISupportInitialize)(this.picSeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconGoogle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDemoTick)).BeginInit();

            this.pnlRoot.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            this.pnlLoginCard.SuspendLayout();
            this.pnlTabs.SuspendLayout();
            this.pnlEmailWrapper.SuspendLayout();
            this.pnlEmailBox.SuspendLayout();
            this.pnlPasswordBox.SuspendLayout();
            this.pnlGoogleButton.SuspendLayout();
            this.pnlDemo.SuspendLayout();

            this.SuspendLayout();

            // ===================================================
            // FORM
            // ===================================================
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "LoginForm";
            this.Text = "Barangayan E-Management System - Login";
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackColor = System.Drawing.Color.White;

            // ===================================================
            // ROOT GRADIENT PANEL
            // ===================================================
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.Size = new System.Drawing.Size(1280, 720);
            this.pnlRoot.GradientColor1 = Color.FromArgb(102, 0, 255);   // blurple
            this.pnlRoot.GradientColor2 = Color.FromArgb(151, 46, 255);
            this.pnlRoot.Angle = 135F;

            // add brand + login
            this.pnlRoot.Controls.Add(this.pnlBrand);
            this.pnlRoot.Controls.Add(this.pnlLoginCard);

            // ===================================================
            // LEFT BRAND PANEL
            // ===================================================
            this.pnlBrand.BackColor = System.Drawing.Color.Transparent;
            this.pnlBrand.Location = new System.Drawing.Point(72, 70);
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Size = new System.Drawing.Size(420, 540);

            this.pnlBrand.Controls.Add(this.picSeal);
            this.pnlBrand.Controls.Add(this.lblRepublic);
            this.pnlBrand.Controls.Add(this.lblSystem);
            this.pnlBrand.Controls.Add(this.cardSecure);
            this.pnlBrand.Controls.Add(this.card247);
            this.pnlBrand.Controls.Add(this.cardDigital);

            // ---------------------------------------------------
            // Seal
            // ---------------------------------------------------
            this.picSeal.Location = new System.Drawing.Point(4, 4);
            this.picSeal.Name = "picSeal";
            this.picSeal.Size = new System.Drawing.Size(120, 120);
            this.picSeal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSeal.BackColor = Color.Transparent;
            this.picSeal.Base64 = Icons.Seal;

            // ---------------------------------------------------
            // Republic label
            // ---------------------------------------------------
            this.lblRepublic.AutoSize = true;
            this.lblRepublic.Location = new System.Drawing.Point(0, 148);
            this.lblRepublic.Name = "lblRepublic";
            this.lblRepublic.Text = "Republika ng Pilipinas";
            this.lblRepublic.ForeColor = Color.White;
            this.lblRepublic.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);

            // ---------------------------------------------------
            // System label
            // ---------------------------------------------------
            this.lblSystem.AutoSize = true;
            this.lblSystem.Location = new System.Drawing.Point(0, 198);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Text = "Barangayan E-Management System";
            this.lblSystem.ForeColor = Color.WhiteSmoke;
            this.lblSystem.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point, 0);

            // ---------------------------------------------------
            // Feature cards (Secure, 24/7, Digital)
            // ---------------------------------------------------
            // CARD: Secure & Reliable
            this.cardSecure.Location = new System.Drawing.Point(0, 260);
            this.cardSecure.Name = "cardSecure";
            this.cardSecure.Title = "Secure & Reliable";
            this.cardSecure.Description = "Your data is safe with us";
            this.cardSecure.IconBase64 = Icons.Shield; // use your shield icon
            this.cardSecure.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // CARD: 24/7 Access
            this.card247.Location = new System.Drawing.Point(0, 365);
            this.card247.Name = "card247";
            this.card247.Title = "24/7 Access";
            this.card247.Description = "Access anywhere, anytime";
            this.card247.IconBase64 = Icons.Check;  // your check icon
            this.card247.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // CARD: Digital Services
            this.cardDigital.Location = new System.Drawing.Point(0, 470);
            this.cardDigital.Name = "cardDigital";
            this.cardDigital.Title = "Digital Services";
            this.cardDigital.Description = "Submit requests online";
            this.cardDigital.IconBase64 = Icons.Digital; // your digital/network icon
            this.cardDigital.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // ===================================================
            // LOGIN CARD (RIGHT)
            // ===================================================
            this.pnlLoginCard.BackColor = Color.White;
            this.pnlLoginCard.CornerRadius = 22;
            this.pnlLoginCard.ShadowOffset = 10;
            this.pnlLoginCard.Location = new System.Drawing.Point(540, 95);
            this.pnlLoginCard.Name = "pnlLoginCard";
            this.pnlLoginCard.Size = new System.Drawing.Size(690, 520);

            this.pnlLoginCard.Controls.Add(this.picProfile);
            this.pnlLoginCard.Controls.Add(this.lblWelcome);
            this.pnlLoginCard.Controls.Add(this.lblWelcomeSub);
            this.pnlLoginCard.Controls.Add(this.pnlTabs);
            this.pnlLoginCard.Controls.Add(this.pnlEmailWrapper);
            this.pnlLoginCard.Controls.Add(this.chkRemember);
            this.pnlLoginCard.Controls.Add(this.linkForgot);
            this.pnlLoginCard.Controls.Add(this.btnSignIn);
            this.pnlLoginCard.Controls.Add(this.lblOrContinue);
            this.pnlLoginCard.Controls.Add(this.pnlGoogleButton);
            this.pnlLoginCard.Controls.Add(this.pnlDemo);
            this.pnlLoginCard.Controls.Add(this.linkCreateAccount);

            // ---------------------------------------------------
            // Profile icon
            // ---------------------------------------------------
            this.picProfile.Location = new System.Drawing.Point(620, 24);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(52, 52);
            this.picProfile.SizeMode = PictureBoxSizeMode.Zoom;
            this.picProfile.BackColor = Color.Transparent;
            
            // ---------------------------------------------------
            // Welcome texts
            // ---------------------------------------------------
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(32, 32);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Text = "Welcome Back";
            this.lblWelcome.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblWelcome.ForeColor = Color.Black;

            this.lblWelcomeSub.AutoSize = true;
            this.lblWelcomeSub.Location = new System.Drawing.Point(34, 68);
            this.lblWelcomeSub.Name = "lblWelcomeSub";
            this.lblWelcomeSub.Text = "Sign in to access your barangay services";
            this.lblWelcomeSub.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblWelcomeSub.ForeColor = Color.DimGray;

            // ---------------------------------------------------
            // Tabs
            // ---------------------------------------------------
            this.pnlTabs.Location = new System.Drawing.Point(32, 110);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(420, 44);

            this.pnlTabs.Controls.Add(this.lblTabEmail);
            this.pnlTabs.Controls.Add(this.lblTabQR);
            this.pnlTabs.Controls.Add(this.underlineEmail);
            this.pnlTabs.Controls.Add(this.underlineQR);

            // Email tab
            this.lblTabEmail.AutoSize = true;
            this.lblTabEmail.Location = new System.Drawing.Point(2, 0);
            this.lblTabEmail.Name = "lblTabEmail";
            this.lblTabEmail.Text = "Email / ID";
            this.lblTabEmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.lblTabEmail.ForeColor = Color.FromArgb(60, 60, 60);
            this.lblTabEmail.Cursor = Cursors.Hand;

            // QR tab
            this.lblTabQR.AutoSize = true;
            this.lblTabQR.Location = new System.Drawing.Point(120, 0);
            this.lblTabQR.Name = "lblTabQR";
            this.lblTabQR.Text = "QR Code";
            this.lblTabQR.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            this.lblTabQR.ForeColor = Color.DimGray;
            this.lblTabQR.Cursor = Cursors.Hand;

            // underline email
            this.underlineEmail.BackColor = Color.FromArgb(110, 0, 255);
            this.underlineEmail.Location = new System.Drawing.Point(0, 24);
            this.underlineEmail.Name = "underlineEmail";
            this.underlineEmail.Size = new System.Drawing.Size(80, 3);

            // underline qr (initially transparent)
            this.underlineQR.BackColor = Color.Transparent;
            this.underlineQR.Location = new System.Drawing.Point(118, 24);
            this.underlineQR.Name = "underlineQR";
            this.underlineQR.Size = new System.Drawing.Size(70, 3);

            // ---------------------------------------------------
            // Email wrapper
            // ---------------------------------------------------
            this.pnlEmailWrapper.Location = new System.Drawing.Point(32, 150);
            this.pnlEmailWrapper.Name = "pnlEmailWrapper";
            this.pnlEmailWrapper.Size = new System.Drawing.Size(626, 120);
            this.pnlEmailWrapper.Controls.Add(this.pnlEmailBox);
            this.pnlEmailWrapper.Controls.Add(this.pnlPasswordBox);

            // EMAIL BOX (panel with icon + textbox)
            this.pnlEmailBox.BackColor = Color.White;
            this.pnlEmailBox.Location = new System.Drawing.Point(0, 0);
            this.pnlEmailBox.Name = "pnlEmailBox";
            this.pnlEmailBox.Size = new System.Drawing.Size(626, 40);
            this.pnlEmailBox.BorderStyle = BorderStyle.FixedSingle;

            this.pnlEmailBox.Controls.Add(this.iconUser);
            this.pnlEmailBox.Controls.Add(this.txtEmail);

            // icon user
            this.iconUser.Location = new System.Drawing.Point(10, 7);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(24, 24);
            this.iconUser.SizeMode = PictureBoxSizeMode.Zoom;
            this.iconUser.Base64 = Icons.User;

            // txtEmail
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(44, 10);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(560, 18);
            this.txtEmail.Font = new Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = Color.FromArgb(60, 60, 60);
           

            // PASSWORD BOX
            this.pnlPasswordBox.BackColor = Color.White;
            this.pnlPasswordBox.Location = new System.Drawing.Point(0, 62);
            this.pnlPasswordBox.Name = "pnlPasswordBox";
            this.pnlPasswordBox.Size = new System.Drawing.Size(626, 40);
            this.pnlPasswordBox.BorderStyle = BorderStyle.FixedSingle;

            this.pnlPasswordBox.Controls.Add(this.iconLock);
            this.pnlPasswordBox.Controls.Add(this.txtPassword);

            // icon lock
            this.iconLock.Location = new System.Drawing.Point(10, 7);
            this.iconLock.Name = "iconLock";
            this.iconLock.Size = new System.Drawing.Size(24, 24);
            this.iconLock.SizeMode = PictureBoxSizeMode.Zoom;
            this.iconLock.Base64 = Icons.Lock;

            // txtPassword
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(44, 10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(560, 18);
            this.txtPassword.Font = new Font("Segoe UI", 10F);
            this.txtPassword.ForeColor = Color.FromArgb(60, 60, 60);
            this.txtPassword.PasswordChar = '●';
            

            // ---------------------------------------------------
            // Remember + Forgot
            // ---------------------------------------------------
            this.chkRemember.AutoSize = true;
            this.chkRemember.Location = new System.Drawing.Point(38, 278);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Text = "Remember me";
            this.chkRemember.Font = new Font("Segoe UI", 9.5F);
            this.chkRemember.ForeColor = Color.FromArgb(70, 70, 70);

            this.linkForgot.AutoSize = true;
            this.linkForgot.Location = new System.Drawing.Point(510, 280);
            this.linkForgot.Name = "linkForgot";
            this.linkForgot.Text = "Forgot password?";
            this.linkForgot.Font = new Font("Segoe UI", 9.5F);
            this.linkForgot.LinkColor = Color.FromArgb(64, 0, 255);
            this.linkForgot.ActiveLinkColor = Color.FromArgb(64, 0, 255);
            this.linkForgot.VisitedLinkColor = Color.FromArgb(64, 0, 255);

            // ---------------------------------------------------
            // SIGN IN BUTTON
            // ---------------------------------------------------
            this.btnSignIn.Location = new System.Drawing.Point(32, 310);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(626, 42);
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.Font = new Font("Segoe UI Semibold", 10.5F, FontStyle.Bold);
            this.btnSignIn.FlatStyle = FlatStyle.Flat;
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.BackColor = Color.FromArgb(102, 0, 255);
            this.btnSignIn.ForeColor = Color.White;

            // ---------------------------------------------------
            // "Or continue with"
            // ---------------------------------------------------
            this.lblOrContinue.AutoSize = true;
            this.lblOrContinue.Location = new System.Drawing.Point(320, 362);
            this.lblOrContinue.Name = "lblOrContinue";
            this.lblOrContinue.Text = "or continue with";
            this.lblOrContinue.Font = new Font("Segoe UI", 9F);
            this.lblOrContinue.ForeColor = Color.DimGray;

            // ---------------------------------------------------
            // GOOGLE BUTTON
            // ---------------------------------------------------
            this.pnlGoogleButton.Location = new System.Drawing.Point(32, 386);
            this.pnlGoogleButton.Name = "pnlGoogleButton";
            this.pnlGoogleButton.Size = new System.Drawing.Size(626, 40);
            this.pnlGoogleButton.BackColor = Color.White;
            this.pnlGoogleButton.BorderStyle = BorderStyle.FixedSingle;
            this.pnlGoogleButton.Cursor = Cursors.Hand;

            this.pnlGoogleButton.Controls.Add(this.iconGoogle);
            this.pnlGoogleButton.Controls.Add(this.lblGoogleText);

            // Google icon
            this.iconGoogle.Location = new System.Drawing.Point(228, 8);
            this.iconGoogle.Name = "iconGoogle";
            this.iconGoogle.Size = new System.Drawing.Size(22, 22);
            this.iconGoogle.SizeMode = PictureBoxSizeMode.Zoom;
            this.iconGoogle.Base64 = Icons.Google;

            // Google text
            this.lblGoogleText.AutoSize = true;
            this.lblGoogleText.Location = new System.Drawing.Point(256, 10);
            this.lblGoogleText.Name = "lblGoogleText";
            this.lblGoogleText.Text = "Sign in with Google";
            this.lblGoogleText.Font = new Font("Segoe UI", 9.5F);
            this.lblGoogleText.ForeColor = Color.Black;

            // ---------------------------------------------------
            // DEMO ACCOUNT PANEL
            // ---------------------------------------------------
            this.pnlDemo.Location = new System.Drawing.Point(32, 432);
            this.pnlDemo.Name = "pnlDemo";
            this.pnlDemo.Size = new System.Drawing.Size(626, 70);
            this.pnlDemo.BackColor = Color.FromArgb(245, 247, 255);
            this.pnlDemo.BorderStyle = BorderStyle.FixedSingle;

            this.pnlDemo.Controls.Add(this.iconDemoTick);
            this.pnlDemo.Controls.Add(this.lblDemoTitle);
            this.pnlDemo.Controls.Add(this.lblDemoEmailCaption);
            this.pnlDemo.Controls.Add(this.lblDemoEmailValue);
            this.pnlDemo.Controls.Add(this.lblDemoPasswordCaption);
            this.pnlDemo.Controls.Add(this.lblDemoPasswordValue);
            this.pnlDemo.Controls.Add(this.linkDemoCopy);

            // Demo tick icon
            this.iconDemoTick.Location = new System.Drawing.Point(12, 12);
            this.iconDemoTick.Name = "iconDemoTick";
            this.iconDemoTick.Size = new System.Drawing.Size(20, 20);
            this.iconDemoTick.SizeMode = PictureBoxSizeMode.Zoom;
            

            // Demo title
            this.lblDemoTitle.AutoSize = true;
            this.lblDemoTitle.Location = new System.Drawing.Point(38, 12);
            this.lblDemoTitle.Name = "lblDemoTitle";
            this.lblDemoTitle.Text = "Demo Account";
            this.lblDemoTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            this.lblDemoTitle.ForeColor = Color.FromArgb(76, 0, 255);

            // Email caption
            this.lblDemoEmailCaption.AutoSize = true;
            this.lblDemoEmailCaption.Location = new System.Drawing.Point(38, 34);
            this.lblDemoEmailCaption.Name = "lblDemoEmailCaption";
            this.lblDemoEmailCaption.Text = "Email:";
            this.lblDemoEmailCaption.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblDemoEmailCaption.ForeColor = Color.FromArgb(70, 70, 70);

            // Email value
            this.lblDemoEmailValue.AutoSize = true;
            this.lblDemoEmailValue.Location = new System.Drawing.Point(80, 34);
            this.lblDemoEmailValue.Name = "lblDemoEmailValue";
            this.lblDemoEmailValue.Text = "demo@barangayan.gov";
            this.lblDemoEmailValue.Font = new Font("Segoe UI", 9F);
            this.lblDemoEmailValue.ForeColor = Color.FromArgb(64, 0, 255);

            // Password caption
            this.lblDemoPasswordCaption.AutoSize = true;
            this.lblDemoPasswordCaption.Location = new System.Drawing.Point(270, 34);
            this.lblDemoPasswordCaption.Name = "lblDemoPasswordCaption";
            this.lblDemoPasswordCaption.Text = "Password:";
            this.lblDemoPasswordCaption.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.lblDemoPasswordCaption.ForeColor = Color.FromArgb(70, 70, 70);

            // Password value
            this.lblDemoPasswordValue.AutoSize = true;
            this.lblDemoPasswordValue.Location = new System.Drawing.Point(338, 34);
            this.lblDemoPasswordValue.Name = "lblDemoPasswordValue";
            this.lblDemoPasswordValue.Text = "demo123";
            this.lblDemoPasswordValue.Font = new Font("Segoe UI", 9F);
            this.lblDemoPasswordValue.ForeColor = Color.FromArgb(64, 0, 255);

            // Click to copy
            this.linkDemoCopy.AutoSize = true;
            this.linkDemoCopy.Location = new System.Drawing.Point(520, 14);
            this.linkDemoCopy.Name = "linkDemoCopy";
            this.linkDemoCopy.Text = "Click to copy";
            this.linkDemoCopy.Font = new Font("Segoe UI", 9F);
            this.linkDemoCopy.LinkColor = Color.FromArgb(76, 0, 255);
            this.linkDemoCopy.ActiveLinkColor = Color.FromArgb(76, 0, 255);
            this.linkDemoCopy.VisitedLinkColor = Color.FromArgb(76, 0, 255);
            this.linkDemoCopy.TextAlign = ContentAlignment.MiddleRight;

            // ---------------------------------------------------
            // Create Account link (bottom right)
            // ---------------------------------------------------
            this.linkCreateAccount.AutoSize = true;
            this.linkCreateAccount.Location = new System.Drawing.Point(574, 506);
            this.linkCreateAccount.Name = "linkCreateAccount";
            this.linkCreateAccount.Text = "Create Account";
            this.linkCreateAccount.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            this.linkCreateAccount.LinkColor = Color.FromArgb(76, 0, 255);
            this.linkCreateAccount.ActiveLinkColor = Color.FromArgb(76, 0, 255);
            this.linkCreateAccount.VisitedLinkColor = Color.FromArgb(76, 0, 255);

            // ===================================================
            // ROOT: add to form
            // ===================================================
            this.Controls.Add(this.pnlRoot);

            // ---------------- RESUME LAYOUTS ----------------
            ((System.ComponentModel.ISupportInitialize)(this.picSeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconGoogle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDemoTick)).EndInit();

            this.pnlDemo.ResumeLayout(false);
            this.pnlDemo.PerformLayout();
            this.pnlGoogleButton.ResumeLayout(false);
            this.pnlGoogleButton.PerformLayout();
            this.pnlPasswordBox.ResumeLayout(false);
            this.pnlPasswordBox.PerformLayout();
            this.pnlEmailBox.ResumeLayout(false);
            this.pnlEmailBox.PerformLayout();
            this.pnlEmailWrapper.ResumeLayout(false);
            this.pnlTabs.ResumeLayout(false);
            this.pnlTabs.PerformLayout();
            this.pnlLoginCard.ResumeLayout(false);
            this.pnlLoginCard.PerformLayout();
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            this.pnlRoot.ResumeLayout(false);

            this.ResumeLayout(false);
        }

        #endregion
    }
}
