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
        private Label lblWelcome;
        private Label lblWelcomeSub;
        private RoundedPanel pnlCreateAccount;
        private Label lblCreateHeader;
        private Label lblQrComingSoon;
        
        private Button btnCreateAccount;
        private Label lblCreateAccountTitle;

        // Tabs

        private Panel pnlTabs;
        private Label lblTabEmail;
        private Panel underlineEmail;
        private Panel underlineQR;
        private Label lblTabQR;
        private Label lblQR;




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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pnlRoot = new BarangayanEMS.GradientPanel();
            this.pnlBrand = new System.Windows.Forms.Panel();
            this.picSeal = new BarangayanEMS.IconPictureBox();
            this.lblRepublic = new System.Windows.Forms.Label();
            this.cardDigital = new BarangayanEMS.FeatureCard();
            this.lblSystem = new System.Windows.Forms.Label();
            this.cardSecure = new BarangayanEMS.FeatureCard();
            this.card247 = new BarangayanEMS.FeatureCard();
            this.pnlLoginCard = new BarangayanEMS.RoundedPanel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblWelcomeSub = new System.Windows.Forms.Label();
            this.pnlTabs = new System.Windows.Forms.Panel();
            this.lblTabEmail = new System.Windows.Forms.Label();
            this.underlineEmail = new System.Windows.Forms.Panel();
            this.underlineQR = new System.Windows.Forms.Panel();
            this.lblTabQR = new System.Windows.Forms.Label();
            this.lblQR = new System.Windows.Forms.Label();
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
            this.iconQRLarge = new BarangayanEMS.IconPictureBox();
            this.lblQrComingSoon = new System.Windows.Forms.Label();
            this.pnlCreateAccount = new BarangayanEMS.RoundedPanel();
            this.pnlRoot.SuspendLayout();
            this.pnlBrand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeal)).BeginInit();
            this.pnlLoginCard.SuspendLayout();
            this.pnlTabs.SuspendLayout();
            this.pnlEmailWrapper.SuspendLayout();
            this.pnlEmailBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            this.pnlPasswordBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLock)).BeginInit();
            this.pnlGoogleButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconGoogle)).BeginInit();
            this.pnlDemo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDemoTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconQRLarge)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlRoot
            // 
            this.pnlRoot.Angle = 135F;
            this.pnlRoot.Controls.Add(this.pnlBrand);
            this.pnlRoot.Controls.Add(this.pnlLoginCard);
            this.pnlRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRoot.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.pnlRoot.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(46)))), ((int)(((byte)(255)))));
            this.pnlRoot.Location = new System.Drawing.Point(0, 0);
            this.pnlRoot.Name = "pnlRoot";
            this.pnlRoot.Size = new System.Drawing.Size(1280, 720);
            this.pnlRoot.TabIndex = 0;
            this.pnlRoot.UseSmoothBlend = true;
            // 
            // pnlBrand
            // 
            this.pnlBrand.BackColor = System.Drawing.Color.Transparent;
            this.pnlBrand.Controls.Add(this.picSeal);
            this.pnlBrand.Controls.Add(this.lblRepublic);
            this.pnlBrand.Controls.Add(this.cardDigital);
            this.pnlBrand.Controls.Add(this.lblSystem);
            this.pnlBrand.Controls.Add(this.cardSecure);
            this.pnlBrand.Controls.Add(this.card247);
            this.pnlBrand.Location = new System.Drawing.Point(72, 70);
            this.pnlBrand.Name = "pnlBrand";
            this.pnlBrand.Size = new System.Drawing.Size(420, 540);
            this.pnlBrand.TabIndex = 0;
            // 
            // picSeal
            // 
            this.picSeal.AutoRound = false;
            this.picSeal.BackColor = System.Drawing.Color.Transparent;
            this.picSeal.Base64 = resources.GetString("picSeal.Base64");
            this.picSeal.Image = ((System.Drawing.Image)(resources.GetObject("picSeal.Image")));
            this.picSeal.Location = new System.Drawing.Point(111, 2);
            this.picSeal.Name = "picSeal";
            this.picSeal.Size = new System.Drawing.Size(166, 142);
            this.picSeal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSeal.TabIndex = 0;
            this.picSeal.TabStop = false;
            this.picSeal.Tint = System.Drawing.Color.Transparent;
            // 
            // lblRepublic
            // 
            this.lblRepublic.AutoSize = true;
            this.lblRepublic.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRepublic.ForeColor = System.Drawing.Color.White;
            this.lblRepublic.Location = new System.Drawing.Point(9, 148);
            this.lblRepublic.Name = "lblRepublic";
            this.lblRepublic.Size = new System.Drawing.Size(339, 45);
            this.lblRepublic.TabIndex = 1;
            this.lblRepublic.Text = "Republika ng Pilipinas";
            // 
            // cardDigital
            // 
            this.cardDigital.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardDigital.BackColor = System.Drawing.Color.Transparent;
            this.cardDigital.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cardDigital.CardBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardDigital.CornerRadius = 12;
            this.cardDigital.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardDigital.Description = "Submit requests online";
            this.cardDigital.IconBase64 = resources.GetString("cardDigital.IconBase64");
            this.cardDigital.Location = new System.Drawing.Point(24, 445);
            this.cardDigital.Name = "cardDigital";
            this.cardDigital.Size = new System.Drawing.Size(339, 92);
            this.cardDigital.TabIndex = 5;
            this.cardDigital.Title = "Digital Services";
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSystem.Location = new System.Drawing.Point(14, 198);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(292, 25);
            this.lblSystem.TabIndex = 2;
            this.lblSystem.Text = "Barangayan E-Management System";
            // 
            // cardSecure
            // 
            this.cardSecure.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardSecure.BackColor = System.Drawing.Color.Transparent;
            this.cardSecure.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cardSecure.CardBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardSecure.CornerRadius = 12;
            this.cardSecure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cardSecure.Description = "Your data is safe with us";
            this.cardSecure.IconBase64 = resources.GetString("cardSecure.IconBase64");
            this.cardSecure.Location = new System.Drawing.Point(27, 237);
            this.cardSecure.Name = "cardSecure";
            this.cardSecure.Size = new System.Drawing.Size(336, 85);
            this.cardSecure.TabIndex = 3;
            this.cardSecure.Title = "Secure & Reliable";
            // 
            // card247
            // 
            this.card247.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.card247.BackColor = System.Drawing.Color.Transparent;
            this.card247.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.card247.CardBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.card247.CornerRadius = 12;
            this.card247.Cursor = System.Windows.Forms.Cursors.Hand;
            this.card247.Description = "Access anywhere, anytime";
            this.card247.IconBase64 = resources.GetString("card247.IconBase64");
            this.card247.Location = new System.Drawing.Point(25, 336);
            this.card247.Name = "card247";
            this.card247.Size = new System.Drawing.Size(339, 92);
            this.card247.TabIndex = 4;
            this.card247.Title = "24/7 Access";
            // 
            // pnlLoginCard
            // 
            this.pnlLoginCard.BackColor = System.Drawing.Color.White;
            this.pnlLoginCard.BorderColor = System.Drawing.Color.Transparent;
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
            this.pnlLoginCard.Controls.Add(this.iconQRLarge);
            this.pnlLoginCard.Controls.Add(this.lblQrComingSoon);
            this.pnlLoginCard.CornerRadius = 22;
            this.pnlLoginCard.Location = new System.Drawing.Point(540, 95);
            this.pnlLoginCard.Name = "pnlLoginCard";
            this.pnlLoginCard.ShadowAlpha = 40;
            this.pnlLoginCard.ShadowOffset = 10;
            this.pnlLoginCard.Size = new System.Drawing.Size(690, 529);
            this.pnlLoginCard.TabIndex = 1;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Black;
            this.lblWelcome.Location = new System.Drawing.Point(32, 32);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(194, 37);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome Back";
            // 
            // lblWelcomeSub
            // 
            this.lblWelcomeSub.AutoSize = true;
            this.lblWelcomeSub.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeSub.ForeColor = System.Drawing.Color.DimGray;
            this.lblWelcomeSub.Location = new System.Drawing.Point(34, 68);
            this.lblWelcomeSub.Name = "lblWelcomeSub";
            this.lblWelcomeSub.Size = new System.Drawing.Size(253, 19);
            this.lblWelcomeSub.TabIndex = 2;
            this.lblWelcomeSub.Text = "Sign in to access your barangay services";
            // 
            // pnlTabs
            // 
            this.pnlTabs.Controls.Add(this.lblTabEmail);
            this.pnlTabs.Controls.Add(this.underlineEmail);
            this.pnlTabs.Controls.Add(this.underlineQR);
            this.pnlTabs.Controls.Add(this.lblTabQR);
            this.pnlTabs.Controls.Add(this.lblQR);
            this.pnlTabs.Location = new System.Drawing.Point(32, 110);
            this.pnlTabs.Name = "pnlTabs";
            this.pnlTabs.Size = new System.Drawing.Size(420, 34);
            this.pnlTabs.TabIndex = 3;
            // 
            // lblTabEmail
            // 
            this.lblTabEmail.AutoSize = true;
            this.lblTabEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTabEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.lblTabEmail.Location = new System.Drawing.Point(2, 4);
            this.lblTabEmail.Name = "lblTabEmail";
            this.lblTabEmail.Size = new System.Drawing.Size(71, 19);
            this.lblTabEmail.TabIndex = 0;
            this.lblTabEmail.Text = "Email / ID";
            // 
            // underlineEmail
            // 
            this.underlineEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.underlineEmail.Location = new System.Drawing.Point(0, 24);
            this.underlineEmail.Name = "underlineEmail";
            this.underlineEmail.Size = new System.Drawing.Size(80, 3);
            this.underlineEmail.TabIndex = 2;
            // 
            // underlineQR
            // 
            this.underlineQR.BackColor = System.Drawing.Color.Transparent;
            this.underlineQR.Location = new System.Drawing.Point(118, 24);
            this.underlineQR.Name = "underlineQR";
            this.underlineQR.Size = new System.Drawing.Size(70, 3);
            this.underlineQR.TabIndex = 3;
            // 
            // lblTabQR
            // 
            this.lblTabQR.AutoSize = true;
            this.lblTabQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTabQR.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTabQR.ForeColor = System.Drawing.Color.DimGray;
            this.lblTabQR.Location = new System.Drawing.Point(120, 4);
            this.lblTabQR.Name = "lblTabQR";
            this.lblTabQR.Size = new System.Drawing.Size(64, 19);
            this.lblTabQR.TabIndex = 4;
            this.lblTabQR.Text = "QR Code";
            // 
            // lblQR
            // 
            this.lblQR.AutoSize = true;
            this.lblQR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQR.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblQR.ForeColor = System.Drawing.Color.DimGray;
            this.lblQR.Location = new System.Drawing.Point(120, 4);
            this.lblQR.Name = "lblQR";
            this.lblQR.Size = new System.Drawing.Size(64, 19);
            this.lblQR.TabIndex = 5;
            this.lblQR.Text = "QR Code";
            // 
            // pnlEmailWrapper
            // 
            this.pnlEmailWrapper.Controls.Add(this.pnlEmailBox);
            this.pnlEmailWrapper.Controls.Add(this.pnlPasswordBox);
            this.pnlEmailWrapper.Location = new System.Drawing.Point(31, 150);
            this.pnlEmailWrapper.Name = "pnlEmailWrapper";
            this.pnlEmailWrapper.Size = new System.Drawing.Size(627, 120);
            this.pnlEmailWrapper.TabIndex = 4;
            // 
            // pnlEmailBox
            // 
            this.pnlEmailBox.BackColor = System.Drawing.Color.White;
            this.pnlEmailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlEmailBox.Controls.Add(this.iconUser);
            this.pnlEmailBox.Controls.Add(this.txtEmail);
            this.pnlEmailBox.Location = new System.Drawing.Point(0, 0);
            this.pnlEmailBox.Name = "pnlEmailBox";
            this.pnlEmailBox.Size = new System.Drawing.Size(626, 40);
            this.pnlEmailBox.TabIndex = 0;
            // 
            // iconUser
            // 
            this.iconUser.AutoRound = false;
            this.iconUser.Base64 = resources.GetString("iconUser.Base64");
            this.iconUser.Image = ((System.Drawing.Image)(resources.GetObject("iconUser.Image")));
            this.iconUser.Location = new System.Drawing.Point(11, 3);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(23, 36);
            this.iconUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconUser.TabIndex = 0;
            this.iconUser.TabStop = false;
            this.iconUser.Tint = System.Drawing.Color.Transparent;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtEmail.Location = new System.Drawing.Point(44, 10);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(560, 18);
            this.txtEmail.TabIndex = 1;
            // 
            // pnlPasswordBox
            // 
            this.pnlPasswordBox.BackColor = System.Drawing.Color.White;
            this.pnlPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPasswordBox.Controls.Add(this.iconLock);
            this.pnlPasswordBox.Controls.Add(this.txtPassword);
            this.pnlPasswordBox.Location = new System.Drawing.Point(0, 62);
            this.pnlPasswordBox.Name = "pnlPasswordBox";
            this.pnlPasswordBox.Size = new System.Drawing.Size(626, 40);
            this.pnlPasswordBox.TabIndex = 1;
            // 
            // iconLock
            // 
            this.iconLock.AutoRound = false;
            this.iconLock.Base64 = resources.GetString("iconLock.Base64");
            this.iconLock.Image = ((System.Drawing.Image)(resources.GetObject("iconLock.Image")));
            this.iconLock.Location = new System.Drawing.Point(10, 7);
            this.iconLock.Name = "iconLock";
            this.iconLock.Size = new System.Drawing.Size(24, 24);
            this.iconLock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconLock.TabIndex = 0;
            this.iconLock.TabStop = false;
            this.iconLock.Tint = System.Drawing.Color.Transparent;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtPassword.Location = new System.Drawing.Point(44, 10);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(560, 18);
            this.txtPassword.TabIndex = 1;
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.chkRemember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.chkRemember.Location = new System.Drawing.Point(38, 278);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(113, 21);
            this.chkRemember.TabIndex = 5;
            this.chkRemember.Text = "Remember me";
            // 
            // linkForgot
            // 
            this.linkForgot.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.linkForgot.AutoSize = true;
            this.linkForgot.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.linkForgot.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.linkForgot.Location = new System.Drawing.Point(510, 280);
            this.linkForgot.Name = "linkForgot";
            this.linkForgot.Size = new System.Drawing.Size(114, 17);
            this.linkForgot.TabIndex = 6;
            this.linkForgot.TabStop = true;
            this.linkForgot.Text = "Forgot password?";
            this.linkForgot.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(32, 310);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(626, 42);
            this.btnSignIn.TabIndex = 7;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            // 
            // lblOrContinue
            // 
            this.lblOrContinue.AutoSize = true;
            this.lblOrContinue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOrContinue.ForeColor = System.Drawing.Color.DimGray;
            this.lblOrContinue.Location = new System.Drawing.Point(294, 360);
            this.lblOrContinue.Name = "lblOrContinue";
            this.lblOrContinue.Size = new System.Drawing.Size(94, 15);
            this.lblOrContinue.TabIndex = 8;
            this.lblOrContinue.Text = "or continue with";
            this.lblOrContinue.Click += new System.EventHandler(this.lblOrContinue_Click);
            // 
            // pnlGoogleButton
            // 
            this.pnlGoogleButton.BackColor = System.Drawing.Color.White;
            this.pnlGoogleButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGoogleButton.Controls.Add(this.iconGoogle);
            this.pnlGoogleButton.Controls.Add(this.lblGoogleText);
            this.pnlGoogleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlGoogleButton.Location = new System.Drawing.Point(32, 386);
            this.pnlGoogleButton.Name = "pnlGoogleButton";
            this.pnlGoogleButton.Size = new System.Drawing.Size(626, 40);
            this.pnlGoogleButton.TabIndex = 9;
            // 
            // iconGoogle
            // 
            this.iconGoogle.AutoRound = false;
            this.iconGoogle.Base64 = resources.GetString("iconGoogle.Base64");
            this.iconGoogle.Image = ((System.Drawing.Image)(resources.GetObject("iconGoogle.Image")));
            this.iconGoogle.Location = new System.Drawing.Point(228, 8);
            this.iconGoogle.Name = "iconGoogle";
            this.iconGoogle.Size = new System.Drawing.Size(22, 22);
            this.iconGoogle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconGoogle.TabIndex = 0;
            this.iconGoogle.TabStop = false;
            this.iconGoogle.Tint = System.Drawing.Color.Transparent;
            // 
            // lblGoogleText
            // 
            this.lblGoogleText.AutoSize = true;
            this.lblGoogleText.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblGoogleText.ForeColor = System.Drawing.Color.Black;
            this.lblGoogleText.Location = new System.Drawing.Point(256, 10);
            this.lblGoogleText.Name = "lblGoogleText";
            this.lblGoogleText.Size = new System.Drawing.Size(121, 17);
            this.lblGoogleText.TabIndex = 1;
            this.lblGoogleText.Text = "Sign in with Google";
            // 
            // pnlDemo
            // 
            this.pnlDemo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.pnlDemo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDemo.Controls.Add(this.iconDemoTick);
            this.pnlDemo.Controls.Add(this.lblDemoTitle);
            this.pnlDemo.Controls.Add(this.lblDemoEmailCaption);
            this.pnlDemo.Controls.Add(this.lblDemoEmailValue);
            this.pnlDemo.Controls.Add(this.lblDemoPasswordCaption);
            this.pnlDemo.Controls.Add(this.lblDemoPasswordValue);
            this.pnlDemo.Controls.Add(this.linkDemoCopy);
            this.pnlDemo.Controls.Add(this.linkCreateAccount);
            this.pnlDemo.Location = new System.Drawing.Point(32, 432);
            this.pnlDemo.Name = "pnlDemo";
            this.pnlDemo.Size = new System.Drawing.Size(626, 70);
            this.pnlDemo.TabIndex = 10;
            // 
            // iconDemoTick
            // 
            this.iconDemoTick.AutoRound = false;
            this.iconDemoTick.Base64 = "";
            this.iconDemoTick.Image = ((System.Drawing.Image)(resources.GetObject("iconDemoTick.Image")));
            this.iconDemoTick.Location = new System.Drawing.Point(13, 13);
            this.iconDemoTick.Name = "iconDemoTick";
            this.iconDemoTick.Size = new System.Drawing.Size(20, 18);
            this.iconDemoTick.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconDemoTick.TabIndex = 0;
            this.iconDemoTick.TabStop = false;
            this.iconDemoTick.Tint = System.Drawing.Color.Transparent;
            // 
            // lblDemoTitle
            // 
            this.lblDemoTitle.AutoSize = true;
            this.lblDemoTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDemoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lblDemoTitle.Location = new System.Drawing.Point(38, 12);
            this.lblDemoTitle.Name = "lblDemoTitle";
            this.lblDemoTitle.Size = new System.Drawing.Size(102, 19);
            this.lblDemoTitle.TabIndex = 1;
            this.lblDemoTitle.Text = "Demo Account";
            // 
            // lblDemoEmailCaption
            // 
            this.lblDemoEmailCaption.AutoSize = true;
            this.lblDemoEmailCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDemoEmailCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblDemoEmailCaption.Location = new System.Drawing.Point(38, 34);
            this.lblDemoEmailCaption.Name = "lblDemoEmailCaption";
            this.lblDemoEmailCaption.Size = new System.Drawing.Size(39, 15);
            this.lblDemoEmailCaption.TabIndex = 2;
            this.lblDemoEmailCaption.Text = "Email:";
            // 
            // lblDemoEmailValue
            // 
            this.lblDemoEmailValue.AutoSize = true;
            this.lblDemoEmailValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDemoEmailValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lblDemoEmailValue.Location = new System.Drawing.Point(80, 34);
            this.lblDemoEmailValue.Name = "lblDemoEmailValue";
            this.lblDemoEmailValue.Size = new System.Drawing.Size(134, 15);
            this.lblDemoEmailValue.TabIndex = 3;
            this.lblDemoEmailValue.Text = "demo@barangayan.gov";
            // 
            // lblDemoPasswordCaption
            // 
            this.lblDemoPasswordCaption.AutoSize = true;
            this.lblDemoPasswordCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDemoPasswordCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.lblDemoPasswordCaption.Location = new System.Drawing.Point(270, 34);
            this.lblDemoPasswordCaption.Name = "lblDemoPasswordCaption";
            this.lblDemoPasswordCaption.Size = new System.Drawing.Size(62, 15);
            this.lblDemoPasswordCaption.TabIndex = 4;
            this.lblDemoPasswordCaption.Text = "Password:";
            // 
            // lblDemoPasswordValue
            // 
            this.lblDemoPasswordValue.AutoSize = true;
            this.lblDemoPasswordValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDemoPasswordValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lblDemoPasswordValue.Location = new System.Drawing.Point(338, 34);
            this.lblDemoPasswordValue.Name = "lblDemoPasswordValue";
            this.lblDemoPasswordValue.Size = new System.Drawing.Size(56, 15);
            this.lblDemoPasswordValue.TabIndex = 5;
            this.lblDemoPasswordValue.Text = "demo123";
            // 
            // linkDemoCopy
            // 
            this.linkDemoCopy.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.linkDemoCopy.AutoSize = true;
            this.linkDemoCopy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.linkDemoCopy.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.linkDemoCopy.Location = new System.Drawing.Point(520, 14);
            this.linkDemoCopy.Name = "linkDemoCopy";
            this.linkDemoCopy.Size = new System.Drawing.Size(76, 15);
            this.linkDemoCopy.TabIndex = 6;
            this.linkDemoCopy.TabStop = true;
            this.linkDemoCopy.Text = "Click to copy";
            this.linkDemoCopy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.linkDemoCopy.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            // 
            // linkCreateAccount
            // 
            this.linkCreateAccount.Location = new System.Drawing.Point(0, 0);
            this.linkCreateAccount.Name = "linkCreateAccount";
            this.linkCreateAccount.Size = new System.Drawing.Size(100, 23);
            this.linkCreateAccount.TabIndex = 7;
            // 
            // iconQRLarge
            // 
            this.iconQRLarge.AutoRound = false;
            this.iconQRLarge.BackColor = System.Drawing.Color.Transparent;
            this.iconQRLarge.Base64 = "";
            this.iconQRLarge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconQRLarge.Location = new System.Drawing.Point(480, 110);
            this.iconQRLarge.Name = "iconQRLarge";
            this.iconQRLarge.Size = new System.Drawing.Size(160, 160);
            this.iconQRLarge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconQRLarge.TabIndex = 11;
            this.iconQRLarge.TabStop = false;
            this.iconQRLarge.Tint = System.Drawing.Color.Transparent;
            this.iconQRLarge.Click += new System.EventHandler(this.IconQRLarge_Click);
            // 
            // lblQrComingSoon
            // 
            this.lblQrComingSoon.AutoSize = true;
            this.lblQrComingSoon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblQrComingSoon.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Underline);
            this.lblQrComingSoon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.lblQrComingSoon.Location = new System.Drawing.Point(495, 275);
            this.lblQrComingSoon.Name = "lblQrComingSoon";
            this.lblQrComingSoon.Size = new System.Drawing.Size(0, 17);
            this.lblQrComingSoon.TabIndex = 12;
            this.lblQrComingSoon.Click += new System.EventHandler(this.IconQRLarge_Click);
            // 
            // pnlCreateAccount
            // 
            this.pnlCreateAccount.BackColor = System.Drawing.Color.White;
            this.pnlCreateAccount.BorderColor = System.Drawing.Color.Transparent;
            this.pnlCreateAccount.CornerRadius = 16;
            this.pnlCreateAccount.Location = new System.Drawing.Point(0, 0);
            this.pnlCreateAccount.Name = "pnlCreateAccount";
            this.pnlCreateAccount.ShadowAlpha = 40;
            this.pnlCreateAccount.ShadowOffset = 6;
            this.pnlCreateAccount.Size = new System.Drawing.Size(200, 100);
            this.pnlCreateAccount.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlRoot);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barangayan E-Management System - Login";
            this.pnlRoot.ResumeLayout(false);
            this.pnlBrand.ResumeLayout(false);
            this.pnlBrand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSeal)).EndInit();
            this.pnlLoginCard.ResumeLayout(false);
            this.pnlLoginCard.PerformLayout();
            this.pnlTabs.ResumeLayout(false);
            this.pnlTabs.PerformLayout();
            this.pnlEmailWrapper.ResumeLayout(false);
            this.pnlEmailBox.ResumeLayout(false);
            this.pnlEmailBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            this.pnlPasswordBox.ResumeLayout(false);
            this.pnlPasswordBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconLock)).EndInit();
            this.pnlGoogleButton.ResumeLayout(false);
            this.pnlGoogleButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconGoogle)).EndInit();
            this.pnlDemo.ResumeLayout(false);
            this.pnlDemo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconDemoTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconQRLarge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion  
    }
}
