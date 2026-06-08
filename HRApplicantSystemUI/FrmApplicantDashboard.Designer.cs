namespace HRApplicantSystemUI
{
    partial class FrmApplicantDashboard
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
            panel1 = new Panel();
            btnLogout = new Button();
            btnStatus = new Button();
            btnDocuments = new Button();
            btnApplication = new Button();
            btnJobs = new Button();
            btnProfile = new Button();
            btnDashboard = new Button();
            lblTitle = new Label();
            lblInterviewSchedule = new Label();
            lblMissing = new Label();
            lblStatus = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnStatus);
            panel1.Controls.Add(btnDocuments);
            panel1.Controls.Add(btnApplication);
            panel1.Controls.Add(btnJobs);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(btnDashboard);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 450);
            panel1.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(12, 376);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(112, 34);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnStatus
            // 
            btnStatus.Location = new Point(12, 286);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(112, 34);
            btnStatus.TabIndex = 5;
            btnStatus.Text = "Status";
            btnStatus.UseVisualStyleBackColor = true;
            btnStatus.Click += btnStatus_Click;
            // 
            // btnDocuments
            // 
            btnDocuments.Location = new Point(12, 235);
            btnDocuments.Name = "btnDocuments";
            btnDocuments.Size = new Size(112, 34);
            btnDocuments.TabIndex = 4;
            btnDocuments.Text = "Documents";
            btnDocuments.UseVisualStyleBackColor = true;
            btnDocuments.Click += btnDocuments_Click;
            // 
            // btnApplication
            // 
            btnApplication.Location = new Point(12, 184);
            btnApplication.Name = "btnApplication";
            btnApplication.Size = new Size(112, 34);
            btnApplication.TabIndex = 3;
            btnApplication.Text = "Application";
            btnApplication.UseVisualStyleBackColor = true;
            btnApplication.Click += btnApplication_Click;
            // 
            // btnJobs
            // 
            btnJobs.Location = new Point(12, 131);
            btnJobs.Name = "btnJobs";
            btnJobs.Size = new Size(136, 34);
            btnJobs.TabIndex = 2;
            btnJobs.Text = "Job Vacancies";
            btnJobs.UseVisualStyleBackColor = true;
            btnJobs.Click += btnJobs_Click;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(12, 80);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(112, 34);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.Location = new Point(12, 29);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(112, 34);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(431, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(196, 28);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Welcome Applicant";
            // 
            // lblInterviewSchedule
            // 
            lblInterviewSchedule.AutoSize = true;
            lblInterviewSchedule.Location = new Point(309, 265);
            lblInterviewSchedule.Name = "lblInterviewSchedule";
            lblInterviewSchedule.Size = new Size(211, 25);
            lblInterviewSchedule.TabIndex = 4;
            lblInterviewSchedule.Text = "Interview Schedule: None";
            // 
            // lblMissing
            // 
            lblMissing.AutoSize = true;
            lblMissing.Location = new Point(309, 193);
            lblMissing.Name = "lblMissing";
            lblMissing.Size = new Size(188, 25);
            lblMissing.TabIndex = 5;
            lblMissing.Text = "Missing Documents: 2";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(309, 122);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(204, 25);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Application Status: Draft";
            // 
            // FrmApplicantDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStatus);
            Controls.Add(lblMissing);
            Controls.Add(lblInterviewSchedule);
            Controls.Add(lblTitle);
            Controls.Add(panel1);
            Name = "FrmApplicantDashboard";
            Text = "FrmApplicantDashboard";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button7;
        private Button btnStatus;
        private Button btnDocuments;
        private Button btnApplication;
        private Button btnJobs;
        private Button btnProfile;
        private Button btnDashboard;
        private Button btnLogout;
        private Label lblTitle;
        private Label label2;
        private Label label3;
        private Label lblInterviewSchedule;
        private Label lblMissing;
        private Label lblStatus;
    }
}