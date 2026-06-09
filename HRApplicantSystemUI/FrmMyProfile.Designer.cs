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
            lblFullName = new Label();
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
            dtpBirthDate = new DateTimePicker();
            cmbGender = new ComboBox();
            cmbCivilStatus = new ComboBox();
            lblGender = new Label();
            lblCivilStatus = new Label();
            lblEducation = new Label();
            textBox1 = new TextBox();
            lblBirthDate = new Label();
            lblNationality = new Label();
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
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(12, 44);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(91, 25);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Full Name";
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Location = new Point(11, 479);
            lblContact.Name = "lblContact";
            lblContact.Size = new Size(143, 25);
            lblContact.TabIndex = 4;
            lblContact.Text = "Contact Number";
            // 
            // lblAddres
            // 
            lblAddres.AutoSize = true;
            lblAddres.Location = new Point(14, 417);
            lblAddres.Name = "lblAddres";
            lblAddres.Size = new Size(77, 25);
            lblAddres.TabIndex = 7;
            lblAddres.Text = "Address";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(12, 72);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(150, 31);
            txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(11, 326);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(150, 31);
            txtLastName.TabIndex = 10;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(11, 445);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(150, 31);
            txtAddress.TabIndex = 11;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(12, 507);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(150, 31);
            txtContact.TabIndex = 12;
            // 
            // lblSkill
            // 
            lblSkill.AutoSize = true;
            lblSkill.Location = new Point(14, 541);
            lblSkill.Name = "lblSkill";
            lblSkill.Size = new Size(43, 25);
            lblSkill.TabIndex = 13;
            lblSkill.Text = "Skill";
            // 
            // txtSkill
            // 
            txtSkill.Location = new Point(12, 569);
            txtSkill.Name = "txtSkill";
            txtSkill.Size = new Size(150, 31);
            txtSkill.TabIndex = 15;
            // 
            // txtExperience
            // 
            txtExperience.Location = new Point(14, 631);
            txtExperience.Name = "txtExperience";
            txtExperience.Size = new Size(150, 31);
            txtExperience.TabIndex = 16;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 696);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 17;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(151, 696);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Location = new Point(12, 603);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(142, 25);
            lblExperience.TabIndex = 19;
            lblExperience.Text = "Work Experience";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(12, 134);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(300, 31);
            dtpBirthDate.TabIndex = 20;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbGender.Location = new Point(14, 196);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(182, 33);
            cmbGender.TabIndex = 21;
            // 
            // cmbCivilStatus
            // 
            cmbCivilStatus.FormattingEnabled = true;
            cmbCivilStatus.Items.AddRange(new object[] { "Single", "Married", "Divorced", "Widowed" });
            cmbCivilStatus.Location = new Point(12, 260);
            cmbCivilStatus.Name = "cmbCivilStatus";
            cmbCivilStatus.Size = new Size(182, 33);
            cmbCivilStatus.TabIndex = 22;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(12, 168);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(69, 25);
            lblGender.TabIndex = 23;
            lblGender.Text = "Gender";
            // 
            // lblCivilStatus
            // 
            lblCivilStatus.AutoSize = true;
            lblCivilStatus.Location = new Point(14, 232);
            lblCivilStatus.Name = "lblCivilStatus";
            lblCivilStatus.Size = new Size(97, 25);
            lblCivilStatus.TabIndex = 24;
            lblCivilStatus.Text = "Civil Status";
            // 
            // lblEducation
            // 
            lblEducation.AutoSize = true;
            lblEducation.Location = new Point(14, 360);
            lblEducation.Name = "lblEducation";
            lblEducation.Size = new Size(90, 25);
            lblEducation.TabIndex = 26;
            lblEducation.Text = "Education";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 388);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 27;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(14, 106);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(115, 25);
            lblBirthDate.TabIndex = 28;
            lblBirthDate.Text = "Date Of Birth";
            // 
            // lblNationality
            // 
            lblNationality.AutoSize = true;
            lblNationality.Location = new Point(12, 296);
            lblNationality.Name = "lblNationality";
            lblNationality.Size = new Size(97, 25);
            lblNationality.TabIndex = 29;
            lblNationality.Text = "Nationality";
            // 
            // FrmMyProfile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 742);
            Controls.Add(lblNationality);
            Controls.Add(lblBirthDate);
            Controls.Add(textBox1);
            Controls.Add(lblEducation);
            Controls.Add(lblCivilStatus);
            Controls.Add(lblGender);
            Controls.Add(cmbCivilStatus);
            Controls.Add(cmbGender);
            Controls.Add(dtpBirthDate);
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
            Controls.Add(lblFullName);
            Controls.Add(lblTitle);
            Name = "FrmMyProfile";
            Text = "FrmMyProfile";
            Load += FrmMyProfile_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblFullName;
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
        private Label lblCivilStatus;
        private TextBox txtSkill;
        private TextBox txtExperience;
        private Button btnSave;
        private Button btnUpdate;
        private Label lblExperience;
        private DateTimePicker dtpBirthDate;
        private ComboBox cmbGender;
        private ComboBox cmbCivilStatus;
        private Label lblGender;
        private Label label1;
        private Label lblEducation;
        private TextBox textBox1;
        private Label lblBirthDate;
        private Label lblNationality;
    }
    }