namespace HRApplicantSystemUI
{
    partial class FrmApplicantRegister
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
            lblCreateAccount = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblEmail = new Label();
            lblContactNumber = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtContactNumber = new TextBox();
            lblPassword = new Label();
            lvlConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            btnCreateAccount = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblCreateAccount
            // 
            lblCreateAccount.AutoSize = true;
            lblCreateAccount.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreateAccount.Location = new Point(320, 9);
            lblCreateAccount.Name = "lblCreateAccount";
            lblCreateAccount.Size = new Size(157, 28);
            lblCreateAccount.TabIndex = 0;
            lblCreateAccount.Text = "Create Account";
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(8, 69);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(91, 25);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(12, 97);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(150, 31);
            txtFullName.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 131);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 25);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.Location = new Point(12, 204);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(143, 25);
            lblContactNumber.TabIndex = 4;
            lblContactNumber.Text = "Contact Number";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 159);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 5;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 302);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(150, 31);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(12, 232);
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(150, 31);
            txtContactNumber.TabIndex = 7;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 274);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(87, 25);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password";
            // 
            // lvlConfirmPassword
            // 
            lvlConfirmPassword.AutoSize = true;
            lvlConfirmPassword.Location = new Point(12, 346);
            lvlConfirmPassword.Name = "lvlConfirmPassword";
            lvlConfirmPassword.Size = new Size(156, 25);
            lvlConfirmPassword.TabIndex = 9;
            lvlConfirmPassword.Text = "Confirm Password";
            lvlConfirmPassword.Click += label2_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(12, 374);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(150, 31);
            txtConfirmPassword.TabIndex = 10;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnCreateAccount
            // 
            btnCreateAccount.Location = new Point(12, 426);
            btnCreateAccount.Name = "btnCreateAccount";
            btnCreateAccount.Size = new Size(143, 34);
            btnCreateAccount.TabIndex = 11;
            btnCreateAccount.Text = "Create Account";
            btnCreateAccount.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(177, 426);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(112, 34);
            btnBack.TabIndex = 12;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FrmApplicantRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 496);
            Controls.Add(btnBack);
            Controls.Add(btnCreateAccount);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lvlConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtContactNumber);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblContactNumber);
            Controls.Add(lblEmail);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(lblCreateAccount);
            Name = "FrmApplicantRegister";
            Text = "FrmApplicantRegister";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreateAccount;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblEmail;
        private Label lblContactNumber;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtContactNumber;
        private Label lblPassword;
        private Label lvlConfirmPassword;
        private TextBox txtConfirmPassword;
        private Button btnCreateAccount;
        private Button btnBack;
    }
}