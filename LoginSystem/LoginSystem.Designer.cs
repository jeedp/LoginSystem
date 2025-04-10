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
            this.cuiControlBlur_QRImage = new CuoreUI.Components.cuiControlBlur(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cuiButton_CantSignIn = new CuoreUI.Controls.cuiButton();
            this.cuiButton_CreateAccount = new CuoreUI.Controls.cuiButton();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.cuiControlBlur_QRPanel = new CuoreUI.Components.cuiControlBlur(this.components);
            this.panel_AccountName = new System.Windows.Forms.Panel();
            this.panel_Password = new System.Windows.Forms.Panel();
            this.label_ErrorMsg = new System.Windows.Forms.Label();
            this.panel_ErrorAccountName = new System.Windows.Forms.Panel();
            this.panel_ErrorPassword = new System.Windows.Forms.Panel();
            this.Panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SteamLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_QRCode)).BeginInit();
            this.cuiBorder_QRCode.SuspendLayout();
            this.panel_AccountName.SuspendLayout();
            this.panel_Password.SuspendLayout();
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
            this.textBox_AccountName.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBox_AccountName.ForeColor = System.Drawing.Color.White;
            this.textBox_AccountName.Location = new System.Drawing.Point(16, 14);
            this.textBox_AccountName.Name = "textBox_AccountName";
            this.textBox_AccountName.Size = new System.Drawing.Size(484, 21);
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
            this.textBox_Password.Font = new System.Drawing.Font("SansSerif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBox_Password.ForeColor = System.Drawing.Color.White;
            this.textBox_Password.Location = new System.Drawing.Point(16, 17);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(484, 21);
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
            this.label_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.label_Password.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.label_Password.Location = new System.Drawing.Point(49, 213);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(86, 19);
            this.label_Password.TabIndex = 6;
            this.label_Password.Text = "PASSWORD";
            // 
            // label_AccountName
            // 
            this.label_AccountName.AutoSize = true;
            this.label_AccountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(38)))));
            this.label_AccountName.Font = new System.Drawing.Font("Segoe UI Variable Display", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AccountName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_AccountName.Location = new System.Drawing.Point(48, 122);
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
            this.cuiButton_SignIn.Size = new System.Drawing.Size(370, 58);
            this.cuiButton_SignIn.TabIndex = 13;
            this.cuiButton_SignIn.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_SignIn.Click += new System.EventHandler(this.cuiButton_SignIn_Click);
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
            this.cuiCheckbox_RememberMe.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiCheckbox_RememberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.cuiCheckbox_RememberMe.Location = new System.Drawing.Point(54, 299);
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
            // cuiControlBlur_QRImage
            // 
            this.cuiControlBlur_QRImage.BlurAmount = 15F;
            this.cuiControlBlur_QRImage.TargetControl = this.pictureBox_QRCode;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.label1.Location = new System.Drawing.Point(488, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Don\'t have a Steam account?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.label2.Location = new System.Drawing.Point(616, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Use the";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.label3.Location = new System.Drawing.Point(816, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "to sign";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(30)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.label4.Location = new System.Drawing.Point(693, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "in via QR code";
            // 
            // cuiButton_CantSignIn
            // 
            this.cuiButton_CantSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.cuiButton_CantSignIn.CheckButton = false;
            this.cuiButton_CantSignIn.Checked = false;
            this.cuiButton_CantSignIn.CheckedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_CantSignIn.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton_CantSignIn.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton_CantSignIn.CheckedOutline = System.Drawing.Color.Transparent;
            this.cuiButton_CantSignIn.Content = "Help, I can\'t sign in";
            this.cuiButton_CantSignIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_CantSignIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiButton_CantSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.cuiButton_CantSignIn.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_CantSignIn.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_CantSignIn.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_CantSignIn.HoverOutline = System.Drawing.Color.Transparent;
            this.cuiButton_CantSignIn.Image = null;
            this.cuiButton_CantSignIn.ImageAutoCenter = true;
            this.cuiButton_CantSignIn.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_CantSignIn.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_CantSignIn.Location = new System.Drawing.Point(42, 466);
            this.cuiButton_CantSignIn.Name = "cuiButton_CantSignIn";
            this.cuiButton_CantSignIn.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_CantSignIn.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.cuiButton_CantSignIn.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_CantSignIn.NormalOutline = System.Drawing.Color.Transparent;
            this.cuiButton_CantSignIn.OutlineThickness = 0F;
            this.cuiButton_CantSignIn.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_CantSignIn.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_CantSignIn.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_CantSignIn.PressedOutline = System.Drawing.Color.Transparent;
            this.cuiButton_CantSignIn.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton_CantSignIn.Size = new System.Drawing.Size(153, 45);
            this.cuiButton_CantSignIn.TabIndex = 24;
            this.cuiButton_CantSignIn.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_CantSignIn.Click += new System.EventHandler(this.cuiButton_CantSignIn_Click);
            // 
            // cuiButton_CreateAccount
            // 
            this.cuiButton_CreateAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(27)))), ((int)(((byte)(31)))));
            this.cuiButton_CreateAccount.CheckButton = false;
            this.cuiButton_CreateAccount.Checked = false;
            this.cuiButton_CreateAccount.CheckedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_CreateAccount.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton_CreateAccount.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton_CreateAccount.CheckedOutline = System.Drawing.Color.Transparent;
            this.cuiButton_CreateAccount.Content = "Create a Free Account";
            this.cuiButton_CreateAccount.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton_CreateAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiButton_CreateAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.cuiButton_CreateAccount.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton_CreateAccount.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton_CreateAccount.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton_CreateAccount.HoverOutline = System.Drawing.Color.Transparent;
            this.cuiButton_CreateAccount.Image = null;
            this.cuiButton_CreateAccount.ImageAutoCenter = true;
            this.cuiButton_CreateAccount.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton_CreateAccount.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton_CreateAccount.Location = new System.Drawing.Point(718, 465);
            this.cuiButton_CreateAccount.Name = "cuiButton_CreateAccount";
            this.cuiButton_CreateAccount.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton_CreateAccount.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.cuiButton_CreateAccount.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton_CreateAccount.NormalOutline = System.Drawing.Color.Transparent;
            this.cuiButton_CreateAccount.OutlineThickness = 0F;
            this.cuiButton_CreateAccount.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton_CreateAccount.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton_CreateAccount.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton_CreateAccount.PressedOutline = System.Drawing.Color.Transparent;
            this.cuiButton_CreateAccount.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton_CreateAccount.Size = new System.Drawing.Size(169, 45);
            this.cuiButton_CreateAccount.TabIndex = 25;
            this.cuiButton_CreateAccount.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiButton1
            // 
            this.cuiButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.Color.Transparent;
            this.cuiButton1.CheckedForeColor = System.Drawing.Color.White;
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton1.CheckedOutline = System.Drawing.Color.Transparent;
            this.cuiButton1.Content = "Steam Mobile App";
            this.cuiButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.cuiButton1.HoverBackground = System.Drawing.Color.Transparent;
            this.cuiButton1.HoveredImageTint = System.Drawing.Color.White;
            this.cuiButton1.HoverForeColor = System.Drawing.Color.White;
            this.cuiButton1.HoverOutline = System.Drawing.Color.Transparent;
            this.cuiButton1.Image = null;
            this.cuiButton1.ImageAutoCenter = true;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(0, 0);
            this.cuiButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.Location = new System.Drawing.Point(669, 388);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.Transparent;
            this.cuiButton1.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.cuiButton1.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton1.NormalOutline = System.Drawing.Color.Transparent;
            this.cuiButton1.OutlineThickness = 0F;
            this.cuiButton1.PressedBackground = System.Drawing.Color.Transparent;
            this.cuiButton1.PressedForeColor = System.Drawing.Color.White;
            this.cuiButton1.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton1.PressedOutline = System.Drawing.Color.Transparent;
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiButton1.Size = new System.Drawing.Size(156, 45);
            this.cuiButton1.TabIndex = 26;
            this.cuiButton1.TextOffset = new System.Drawing.Point(0, 0);
            // 
            // cuiControlBlur_QRPanel
            // 
            this.cuiControlBlur_QRPanel.BlurAmount = 15F;
            this.cuiControlBlur_QRPanel.TargetControl = this.cuiBorder_QRCode;
            // 
            // panel_AccountName
            // 
            this.panel_AccountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.panel_AccountName.Controls.Add(this.textBox_AccountName);
            this.panel_AccountName.Location = new System.Drawing.Point(52, 148);
            this.panel_AccountName.Name = "panel_AccountName";
            this.panel_AccountName.Size = new System.Drawing.Size(515, 49);
            this.panel_AccountName.TabIndex = 27;
            // 
            // panel_Password
            // 
            this.panel_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.panel_Password.Controls.Add(this.textBox_Password);
            this.panel_Password.Location = new System.Drawing.Point(52, 238);
            this.panel_Password.Name = "panel_Password";
            this.panel_Password.Size = new System.Drawing.Size(515, 49);
            this.panel_Password.TabIndex = 28;
            // 
            // label_ErrorMsg
            // 
            this.label_ErrorMsg.AutoSize = true;
            this.label_ErrorMsg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.label_ErrorMsg.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ErrorMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(87)))), ((int)(((byte)(85)))));
            this.label_ErrorMsg.Location = new System.Drawing.Point(88, 421);
            this.label_ErrorMsg.Name = "label_ErrorMsg";
            this.label_ErrorMsg.Size = new System.Drawing.Size(429, 20);
            this.label_ErrorMsg.TabIndex = 29;
            this.label_ErrorMsg.Text = "Please check your password and account name and try again.";
            this.label_ErrorMsg.Visible = false;
            // 
            // panel_ErrorAccountName
            // 
            this.panel_ErrorAccountName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(87)))), ((int)(((byte)(85)))));
            this.panel_ErrorAccountName.Location = new System.Drawing.Point(51, 146);
            this.panel_ErrorAccountName.Name = "panel_ErrorAccountName";
            this.panel_ErrorAccountName.Size = new System.Drawing.Size(517, 52);
            this.panel_ErrorAccountName.TabIndex = 28;
            this.panel_ErrorAccountName.Visible = false;
            // 
            // panel_ErrorPassword
            // 
            this.panel_ErrorPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(87)))), ((int)(((byte)(85)))));
            this.panel_ErrorPassword.Location = new System.Drawing.Point(51, 236);
            this.panel_ErrorPassword.Name = "panel_ErrorPassword";
            this.panel_ErrorPassword.Size = new System.Drawing.Size(517, 52);
            this.panel_ErrorPassword.TabIndex = 29;
            this.panel_ErrorPassword.Visible = false;
            // 
            // LoginSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(937, 539);
            this.Controls.Add(this.panel_Password);
            this.Controls.Add(this.panel_ErrorPassword);
            this.Controls.Add(this.panel_AccountName);
            this.Controls.Add(this.panel_ErrorAccountName);
            this.Controls.Add(this.label_ErrorMsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cuiBorder_QRCode);
            this.Controls.Add(this.cuiButton1);
            this.Controls.Add(this.cuiButton_CreateAccount);
            this.Controls.Add(this.cuiButton_CantSignIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cuiCheckbox_RememberMe);
            this.Controls.Add(this.cuiButton_SignIn);
            this.Controls.Add(this.label_QRCode);
            this.Controls.Add(this.label_AccountName);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Steam);
            this.Controls.Add(this.pictureBox_SteamLogo);
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
            this.panel_AccountName.ResumeLayout(false);
            this.panel_AccountName.PerformLayout();
            this.panel_Password.ResumeLayout(false);
            this.panel_Password.PerformLayout();
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
        private CuoreUI.Components.cuiControlBlur cuiControlBlur_QRImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CuoreUI.Controls.cuiButton cuiButton_CantSignIn;
        private CuoreUI.Controls.cuiButton cuiButton_CreateAccount;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Components.cuiControlBlur cuiControlBlur_QRPanel;
        private System.Windows.Forms.Panel panel_Password;
        private System.Windows.Forms.Panel panel_AccountName;
        private System.Windows.Forms.Label label_ErrorMsg;
        private System.Windows.Forms.Panel panel_ErrorAccountName;
        private System.Windows.Forms.Panel panel_ErrorPassword;
    }
}

