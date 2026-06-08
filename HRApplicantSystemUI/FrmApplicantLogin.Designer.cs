namespace HRApplicantSystemUI
{
    partial class FrmApplicantLogin
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
            lblEmail = new Label();
            lblPassword = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblTitle = new Label();
            lnkRegister = new LinkLabel();
            lblNoAccount = new Label();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(23, 80);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(23, 166);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(23, 108);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(23, 194);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(23, 259);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(285, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 28);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "HR Applicant Portal";
            // 
            // lnkRegister
            // 
            lnkRegister.AutoSize = true;
            lnkRegister.Location = new Point(35, 359);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(75, 25);
            lnkRegister.TabIndex = 6;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Register";
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;
            // 
            // lblNoAccount
            // 
            lblNoAccount.AutoSize = true;
            lblNoAccount.Location = new Point(32, 334);
            lblNoAccount.Name = "lblNoAccount";
            lblNoAccount.Size = new Size(197, 25);
            lblNoAccount.TabIndex = 7;
            lblNoAccount.Text = "Don't have an account?";
            // 
            // FrmApplicantLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNoAccount);
            Controls.Add(lnkRegister);
            Controls.Add(lblTitle);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Name = "FrmApplicantLogin";
            Text = "FrmApplicantLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblTitle;
        private LinkLabel lnkRegister;
        private Label lblNoAccount;
    }
}