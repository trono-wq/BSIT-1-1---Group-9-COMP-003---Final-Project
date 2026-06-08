namespace HRApplicantSystemUI
{
    partial class FrmMyProfile
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
            lblTitle = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblContact = new Label();
            lblAddres = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAddress = new TextBox();
            txtContact = new TextBox();
            lblSkill = new Label();
            txtSkill = new TextBox();
            txtExperience = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            lblExperience = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(316, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(126, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "MY PROFILE";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(12, 60);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(97, 25);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(14, 136);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(95, 25);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(12, 285);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(143, 25);
            lblContact.TabIndex = 4;
            lblContact.Text = "Contact Number";
            // 
            // lblAddres
            // 
            lblAddres.AutoSize = true;
            lblAddres.Location = new Point(14, 210);
            lblAddres.Name = "lblAddres";
            lblAddres.Size = new Size(77, 25);
            lblAddres.TabIndex = 7;
            lblAddres.Text = "Address";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 88);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(12, 164);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(12, 238);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 31);
            txtAddress.TabIndex = 11;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(12, 313);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(150, 31);
            txtContact.TabIndex = 12;
            // 
            // lblSkill
            // 
            lblSkill.AutoSize = true;
            lblSkill.Location = new Point(14, 363);
            lblSkill.Name = "lblSkill";
            lblSkill.Size = new Size(43, 25);
            lblSkill.TabIndex = 13;
            lblSkill.Text = "Skill";
            // 
            // txtSkill
            // 
            txtSkill.Location = new Point(12, 391);
            txtSkill.Name = "txtSkill";
            txtSkill.Size = new Size(150, 31);
            txtSkill.TabIndex = 15;
            // 
            // txtExperience
            // 
            txtExperience.Location = new Point(12, 480);
            txtExperience.Name = "txtExperience";
            txtExperience.Size = new Size(150, 31);
            txtExperience.TabIndex = 16;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(14, 549);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(152, 549);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Location = new Point(12, 452);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(142, 25);
            lblExperience.TabIndex = 19;
            lblExperience.Text = "Work Experience";
            // 
            // FrmMyProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 632);
            Controls.Add(lblExperience);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtExperience);
            Controls.Add(txtSkill);
            Controls.Add(lblSkill);
            Controls.Add(txtContact);
            Controls.Add(txtAddress);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblAddres);
            Controls.Add(lblContact);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblTitle);
            Name = "FrmMyProfile";
            Text = "FrmMyProfile";
            Load += FrmMyProfile_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblAdress;
        private Label lblContact;
        private Label lblSkills;
        private Label lblWorkExperience;
        private Label lblAddres;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAddress;
        private TextBox txtContact;
        private Label lblSkill;
        private Label label2;
        private TextBox txtSkill;
        private TextBox txtExperience;
        private Button btnSave;
        private Button btnUpdate;
        private Label lblExperience;
    }
    }