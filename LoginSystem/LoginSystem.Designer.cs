namespace LoginSystem
{
    partial class LoginSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSystem));
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.textBox_AccountName = new System.Windows.Forms.TextBox();
            this.pictureBox_SteamLogo = new System.Windows.Forms.PictureBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_Steam = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_AccountName = new System.Windows.Forms.Label();
            this.label_QRCode = new System.Windows.Forms.Label();
            this.pictureBox_QRCode = new System.Windows.Forms.PictureBox();
            this.cuiButton_SignIn = new CuoreUI.Controls.cuiButton();
            this.cuiFormRounder_LoginSystem = new CuoreUI.Components.cuiFormRounder();
            this.cuiCheckbox_RememberMe = new CuoreUI.Controls.cuiCheckbox();
            this.cuiGradientBorder_Background = new CuoreUI.Controls.cuiGradientBorder();
            this.cuiBorder_QRCode = new CuoreUI.Controls.cuiBorder();
            this.cuiControlBlur1 = new CuoreUI.Components.cuiControlBlur(this.components);
            this.button_CantSignIn = new System.Windows.Forms.Button();
            this.button_CreateAccount = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SteamLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QRCode)).BeginInit();
            this.cuiBorder_QRCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Title
            // 
            this.Panel_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.Panel_Title.Controls.Add(this.button_Exit);
            this.Panel_Title.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Title.Location = new System.Drawing.Point(0, 0);
            this.Panel_Title.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_Title.Name = "Panel_Title";
            this.Panel_Title.Size = new System.Drawing.Size(937, 40);
            this.Panel_Title.TabIndex = 1;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.button_Exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Exit.FlatAppearance.BorderSize = 0;
            this.button_Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button_Exit.Image = ((System.Drawing.Image)(resources.GetObject("button_Exit.Image")));
            this.button_Exit.Location = new System.Drawing.Point(894, 0);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(0);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(43, 40);
            this.button_Exit.TabIndex = 1;
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // textBox_AccountName
            // 
            this.textBox_AccountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.textBox_AccountName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_AccountName.Font = new System.Drawing.Font("SansSerif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBox_AccountName.ForeColor = System.Drawing.Color.White;
            this.textBox_AccountName.Location = new System.Drawing.Point(48, 148);
            this.textBox_AccountName.Name = "textBox_AccountName";
            this.textBox_AccountName.Size = new System.Drawing.Size(515, 49);
            this.textBox_AccountName.TabIndex = 2;
            // 
            // pictureBox_SteamLogo
            // 
            this.pictureBox_SteamLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_SteamLogo.Image")));
            this.pictureBox_SteamLogo.Location = new System.Drawing.Point(48, 33);
            this.pictureBox_SteamLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox_SteamLogo.Name = "pictureBox_SteamLogo";
            this.pictureBox_SteamLogo.Size = new System.Drawing.Size(90, 90);
            this.pictureBox_SteamLogo.TabIndex = 3;
            this.pictureBox_SteamLogo.TabStop = false;
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Password.Font = new System.Drawing.Font("SansSerif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBox_Password.ForeColor = System.Drawing.Color.White;
            this.textBox_Password.Location = new System.Drawing.Point(48, 238);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(515, 49);
            this.textBox_Password.TabIndex = 4;
            // 
            // label_Steam
            // 
            this.label_Steam.AutoSize = true;
            this.label_Steam.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Steam.ForeColor = System.Drawing.Color.White;
            this.label_Steam.Location = new System.Drawing.Point(120, 42);
            this.label_Steam.Name = "label_Steam";
            this.label_Steam.Size = new System.Drawing.Size(131, 45);
            this.label_Steam.TabIndex = 5;
            this.label_Steam.Text = "STEAM";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.label_Password.Location = new System.Drawing.Point(45, 213);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(86, 19);
            this.label_Password.TabIndex = 6;
            this.label_Password.Text = "PASSWORD";
            // 
            // label_AccountName
            // 
            this.label_AccountName.AutoSize = true;
            this.label_AccountName.Font = new System.Drawing.Font("Segoe UI Variable Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AccountName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_AccountName.Location = new System.Drawing.Point(45, 122);
            this.label_AccountName.Name = "label_AccountName";
            this.label_AccountName.Size = new System.Drawing.Size(217, 19);
            this.label_AccountName.TabIndex = 7;
            this.label_AccountName.Text = "SIGN IN WITH ACCOUNT NAME";
            // 
            // label_QRCode
            // 
            this.label_QRCode.AutoSize = true;
            this.label_QRCode.Font = new System.Drawing.Font("Segoe UI Variable Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_QRCode.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_QRCode.Location = new System.Drawing.Point(615, 119);
            this.label_QRCode.Name = "label_QRCode";
            this.label_QRCode.Size = new System.Drawing.Size(145, 19);
            this.label_QRCode.TabIndex = 8;
            this.label_QRCode.Text = "OR SIGN IN WITH QR";
            // 
            // pictureBox_QRCode
            // 
            this.pictureBox_QRCode.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_QRCode.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_QRCode.Image")));
            this.pictureBox_QRCode.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_QRCode.Name = "pictureBox_QRCode";
            this.pictureBox_QRCode.Size = new System.Drawing.Size(264, 246);
            this.pictureBox_QRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_QRCode.TabIndex = 10;
            this.pictureBox_QRCode.TabStop = false;
            // 
            // cuiButton_SignIn
            // 
            this.cuiButton_SignIn.CheckButton = false;
            this.cuiButton_SignIn.Checked = false;
            this.cuiButton_SignIn.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_SignIn.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton_SignIn.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton_SignIn.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.cuiButton_SignIn.Content = "Sign in";
            this.cuiButton_SignIn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.cuiButton_SignIn.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiButton_SignIn.ForeColor = System.Drawing.Color.White;
            this.cuiButton_SignIn.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.cuiButton_SignIn.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_SignIn.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_SignIn.HoverOutline = System.Drawing.Color.Empty;
            this.cuiButton_SignIn.Image = null;
            this.cuiButton_SignIn.ImageAutoCenter = true;
            this.cuiButton_SignIn.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_SignIn.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_SignIn.Location = new System.Drawing.Point(120, 344);
            this.cuiButton_SignIn.Name = "cuiButton_SignIn";
            this.cuiButton_SignIn.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.cuiButton_SignIn.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton_SignIn.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_SignIn.NormalOutline = System.Drawing.Color.Empty;
            this.cuiButton_SignIn.OutlineThickness = 1.6F;
            this.cuiButton_SignIn.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(183)))), ((int)(((byte)(255)))));
            this.cuiButton_SignIn.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_SignIn.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_SignIn.PressedOutline = System.Drawing.Color.Empty;
            this.cuiButton_SignIn.Rounding = new System.Windows.Forms.Padding(2);
            this.cuiButton_SignIn.Size = new System.Drawing.Size(370, 57);
            this.cuiButton_SignIn.TabIndex = 13;
            this.cuiButton_SignIn.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiFormRounder_LoginSystem
            // 
            this.cuiFormRounder_LoginSystem.EnhanceCorners = true;
            this.cuiFormRounder_LoginSystem.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cuiFormRounder_LoginSystem.Rounding = 8;
            this.cuiFormRounder_LoginSystem.TargetForm = this;
            // 
            // cuiCheckbox_RememberMe
            // 
            this.cuiCheckbox_RememberMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.cuiCheckbox_RememberMe.Checked = false;
            this.cuiCheckbox_RememberMe.CheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.cuiCheckbox_RememberMe.CheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.cuiCheckbox_RememberMe.CheckedSymbolColor = System.Drawing.Color.White;
            this.cuiCheckbox_RememberMe.Content = " Remember Me";
            this.cuiCheckbox_RememberMe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiCheckbox_RememberMe.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiCheckbox_RememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.cuiCheckbox_RememberMe.Location = new System.Drawing.Point(48, 299);
            this.cuiCheckbox_RememberMe.MinimumSize = new System.Drawing.Size(16, 16);
            this.cuiCheckbox_RememberMe.Name = "cuiCheckbox_RememberMe";
            this.cuiCheckbox_RememberMe.OutlineStyle = true;
            this.cuiCheckbox_RememberMe.OutlineThickness = 1F;
            this.cuiCheckbox_RememberMe.Rounding = 2;
            this.cuiCheckbox_RememberMe.ShowSymbols = true;
            this.cuiCheckbox_RememberMe.Size = new System.Drawing.Size(233, 27);
            this.cuiCheckbox_RememberMe.TabIndex = 14;
            this.cuiCheckbox_RememberMe.Text = "Remember Me";
            this.cuiCheckbox_RememberMe.UncheckedForeground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.cuiCheckbox_RememberMe.UncheckedOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.cuiCheckbox_RememberMe.UncheckedSymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            // 
            // cuiGradientBorder_Background
            // 
            this.cuiGradientBorder_Background.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cuiGradientBorder_Background.GradientAngle = 90F;
            this.cuiGradientBorder_Background.Location = new System.Drawing.Point(0, 0);
            this.cuiGradientBorder_Background.Name = "cuiGradientBorder_Background";
            this.cuiGradientBorder_Background.OutlineThickness = 0F;
            this.cuiGradientBorder_Background.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.cuiGradientBorder_Background.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.cuiGradientBorder_Background.PanelOutlineColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.cuiGradientBorder_Background.PanelOutlineColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.cuiGradientBorder_Background.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiGradientBorder_Background.Size = new System.Drawing.Size(937, 539);
            this.cuiGradientBorder_Background.TabIndex = 15;
            // 
            // cuiBorder_QRCode
            // 
            this.cuiBorder_QRCode.Controls.Add(this.pictureBox_QRCode);
            this.cuiBorder_QRCode.Location = new System.Drawing.Point(615, 143);
            this.cuiBorder_QRCode.Name = "cuiBorder_QRCode";
            this.cuiBorder_QRCode.OutlineThickness = 1F;
            this.cuiBorder_QRCode.PanelColor = System.Drawing.Color.White;
            this.cuiBorder_QRCode.PanelOutlineColor = System.Drawing.Color.White;
            this.cuiBorder_QRCode.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiBorder_QRCode.Size = new System.Drawing.Size(270, 252);
            this.cuiBorder_QRCode.TabIndex = 16;
            // 
            // cuiControlBlur1
            // 
            this.cuiControlBlur1.BlurAmount = 15F;
            this.cuiControlBlur1.TargetControl = this.pictureBox_QRCode;
            // 
            // button_CantSignIn
            // 
            this.button_CantSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.button_CantSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CantSignIn.FlatAppearance.BorderSize = 0;
            this.button_CantSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CantSignIn.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CantSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.button_CantSignIn.Location = new System.Drawing.Point(22, 468);
            this.button_CantSignIn.Name = "button_CantSignIn";
            this.button_CantSignIn.Size = new System.Drawing.Size(186, 36);
            this.button_CantSignIn.TabIndex = 17;
            this.button_CantSignIn.Text = "Help, I can\'t sign in";
            this.button_CantSignIn.UseVisualStyleBackColor = false;
            // 
            // button_CreateAccount
            // 
            this.button_CreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.button_CreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CreateAccount.FlatAppearance.BorderSize = 0;
            this.button_CreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CreateAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.button_CreateAccount.Location = new System.Drawing.Point(730, 468);
            this.button_CreateAccount.Name = "button_CreateAccount";
            this.button_CreateAccount.Size = new System.Drawing.Size(186, 36);
            this.button_CreateAccount.TabIndex = 18;
            this.button_CreateAccount.Text = "Create a Free Account";
            this.button_CreateAccount.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.label1.Location = new System.Drawing.Point(560, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Don\'t have a Steam account?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.button1.Location = new System.Drawing.Point(651, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "Steam Mobile App";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.label2.Location = new System.Drawing.Point(628, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Use the";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.label3.Location = new System.Drawing.Point(803, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "to sign";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.label4.Location = new System.Drawing.Point(692, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "in via QR code";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.linkLabel1.Location = new System.Drawing.Point(367, 468);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(68, 16);
            this.linkLabel1.TabIndex = 24;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            // 
            // LoginSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(937, 539);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_CreateAccount);
            this.Controls.Add(this.button_CantSignIn);
            this.Controls.Add(this.cuiBorder_QRCode);
            this.Controls.Add(this.cuiCheckbox_RememberMe);
            this.Controls.Add(this.cuiButton_SignIn);
            this.Controls.Add(this.label_QRCode);
            this.Controls.Add(this.label_AccountName);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Steam);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.pictureBox_SteamLogo);
            this.Controls.Add(this.textBox_AccountName);
            this.Controls.Add(this.Panel_Title);
            this.Controls.Add(this.cuiGradientBorder_Background);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginSystem";
            this.Load += new System.EventHandler(this.LoginSystem_Load);
            this.Panel_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SteamLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QRCode)).EndInit();
            this.cuiBorder_QRCode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Title;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TextBox textBox_AccountName;
        private System.Windows.Forms.PictureBox pictureBox_SteamLogo;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_Steam;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_AccountName;
        private System.Windows.Forms.Label label_QRCode;
        private System.Windows.Forms.PictureBox pictureBox_QRCode;
        private CuoreUI.Controls.cuiButton cuiButton_SignIn;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder_LoginSystem;
        private CuoreUI.Controls.cuiCheckbox cuiCheckbox_RememberMe;
        private CuoreUI.Controls.cuiGradientBorder cuiGradientBorder_Background;
        private CuoreUI.Controls.cuiBorder cuiBorder_QRCode;
        private CuoreUI.Components.cuiControlBlur cuiControlBlur1;
        private System.Windows.Forms.Button button_CantSignIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_CreateAccount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

