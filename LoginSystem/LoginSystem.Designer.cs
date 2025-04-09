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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginSystem));
            this.Panel_Title = new System.Windows.Forms.Panel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.textBox_AccountName = new System.Windows.Forms.TextBox();
            this.pictureBox_SteamLogo = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_Steam = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_AccountName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_RememberMe = new System.Windows.Forms.CheckBox();
            this.Panel_Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SteamLogo)).BeginInit();
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
            this.textBox_AccountName.Size = new System.Drawing.Size(478, 49);
            this.textBox_AccountName.TabIndex = 2;
            this.textBox_AccountName.Text = "asdawds";
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("SansSerif", 25.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(48, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(478, 49);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "asdawds";
            // 
            // label_Steam
            // 
            this.label_Steam.AutoSize = true;
            this.label_Steam.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Steam.ForeColor = System.Drawing.Color.LightGray;
            this.label_Steam.Location = new System.Drawing.Point(141, 40);
            this.label_Steam.Name = "label_Steam";
            this.label_Steam.Size = new System.Drawing.Size(130, 46);
            this.label_Steam.TabIndex = 5;
            this.label_Steam.Text = "STEAM";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(45, 216);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(78, 17);
            this.label_Password.TabIndex = 6;
            this.label_Password.Text = "PASSWORD";
            // 
            // label_AccountName
            // 
            this.label_AccountName.AutoSize = true;
            this.label_AccountName.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AccountName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_AccountName.Location = new System.Drawing.Point(45, 123);
            this.label_AccountName.Name = "label_AccountName";
            this.label_AccountName.Size = new System.Drawing.Size(201, 17);
            this.label_AccountName.TabIndex = 7;
            this.label_AccountName.Text = "SIGN IN WITH ACCOUNT NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(549, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "OR SIGN IN WITH QR";
            // 
            // checkBox_RememberMe
            // 
            this.checkBox_RememberMe.AutoSize = true;
            this.checkBox_RememberMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_RememberMe.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_RememberMe.Location = new System.Drawing.Point(48, 307);
            this.checkBox_RememberMe.Name = "checkBox_RememberMe";
            this.checkBox_RememberMe.Size = new System.Drawing.Size(115, 21);
            this.checkBox_RememberMe.TabIndex = 9;
            this.checkBox_RememberMe.Text = "Remember Me";
            this.checkBox_RememberMe.UseVisualStyleBackColor = true;
            // 
            // LoginSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(937, 539);
            this.Controls.Add(this.checkBox_RememberMe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_AccountName);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Steam);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox_SteamLogo);
            this.Controls.Add(this.textBox_AccountName);
            this.Controls.Add(this.Panel_Title);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginSystem";
            this.Load += new System.EventHandler(this.LoginSystem_Load);
            this.Panel_Title.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SteamLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Title;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TextBox textBox_AccountName;
        private System.Windows.Forms.PictureBox pictureBox_SteamLogo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_Steam;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_AccountName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_RememberMe;
    }
}

