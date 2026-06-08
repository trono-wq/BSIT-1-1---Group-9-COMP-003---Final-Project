namespace HRApplicantSystemUI
{
    partial class FrmMyApplication
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
            lblAppliedPosition = new Label();
            lblDateApplied = new Label();
            lblDepartment = new Label();
            lblApplicationStatus = new Label();
            grpApplication = new GroupBox();
            lblForFinalReview = new Label();
            lblAccepted = new Label();
            lblForAssessment = new Label();
            lblForInterview = new Label();
            lblShortlisted = new Label();
            lblUnderReview = new Label();
            lblSubmitted = new Label();
            lblDraft = new Label();
            btnEditApplication = new Button();
            btnSubmitApplication = new Button();
            grpApplication.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(315, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(157, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "My Application";
            // 
            // lblAppliedPosition
            // 
            lblAppliedPosition.AutoSize = true;
            lblAppliedPosition.Location = new Point(30, 48);
            lblAppliedPosition.Name = "lblAppliedPosition";
            lblAppliedPosition.Size = new Size(206, 25);
            lblAppliedPosition.TabIndex = 1;
            lblAppliedPosition.Text = "Applied Position: IT Staff";
            // 
            // lblDateApplied
            // 
            lblDateApplied.AutoSize = true;
            lblDateApplied.Location = new Point(30, 146);
            lblDateApplied.Name = "lblDateApplied";
            lblDateApplied.Size = new Size(224, 25);
            lblDateApplied.TabIndex = 2;
            lblDateApplied.Text = "Date Applied: June 3, 2026";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(30, 97);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(230, 25);
            lblDepartment.TabIndex = 3;
            lblDepartment.Text = "Department: IT Department";
            // 
            // lblApplicationStatus
            // 
            lblApplicationStatus.AutoSize = true;
            lblApplicationStatus.Location = new Point(30, 193);
            lblApplicationStatus.Name = "lblApplicationStatus";
            lblApplicationStatus.Size = new Size(247, 25);
            lblApplicationStatus.TabIndex = 4;
            lblApplicationStatus.Text = "Application Status: Submitted";
            // 
            // grpApplication
            // 
            grpApplication.Controls.Add(lblForFinalReview);
            grpApplication.Controls.Add(lblAccepted);
            grpApplication.Controls.Add(lblForAssessment);
            grpApplication.Controls.Add(lblForInterview);
            grpApplication.Controls.Add(lblShortlisted);
            grpApplication.Controls.Add(lblUnderReview);
            grpApplication.Controls.Add(lblSubmitted);
            grpApplication.Controls.Add(lblDraft);
            grpApplication.Location = new Point(30, 248);
            grpApplication.Name = "grpApplication";
            grpApplication.Size = new Size(300, 389);
            grpApplication.TabIndex = 5;
            grpApplication.TabStop = false;
            grpApplication.Text = "Application Progress ";
            // 
            // lblForFinalReview
            // 
            lblForFinalReview.AutoSize = true;
            lblForFinalReview.Location = new Point(18, 288);
            lblForFinalReview.Name = "lblForFinalReview";
            lblForFinalReview.Size = new Size(159, 25);
            lblForFinalReview.TabIndex = 10;
            lblForFinalReview.Text = "○ For Final Review";
            // 
            // lblAccepted
            // 
            lblAccepted.AutoSize = true;
            lblAccepted.Location = new Point(18, 336);
            lblAccepted.Name = "lblAccepted";
            lblAccepted.Size = new Size(107, 25);
            lblAccepted.TabIndex = 11;
            lblAccepted.Text = "○ Accepted";
            // 
            // lblForAssessment
            // 
            lblForAssessment.AutoSize = true;
            lblForAssessment.Location = new Point(18, 244);
            lblForAssessment.Name = "lblForAssessment";
            lblForAssessment.Size = new Size(158, 25);
            lblForAssessment.TabIndex = 5;
            lblForAssessment.Text = "○ For Assessment";
            // 
            // lblForInterview
            // 
            lblForInterview.AutoSize = true;
            lblForInterview.Location = new Point(18, 200);
            lblForInterview.Name = "lblForInterview";
            lblForInterview.Size = new Size(135, 25);
            lblForInterview.TabIndex = 4;
            lblForInterview.Text = "○ For Interview";
            // 
            // lblShortlisted
            // 
            lblShortlisted.AutoSize = true;
            lblShortlisted.Location = new Point(18, 162);
            lblShortlisted.Name = "lblShortlisted";
            lblShortlisted.Size = new Size(118, 25);
            lblShortlisted.TabIndex = 3;
            lblShortlisted.Text = "○ Shortlisted";
            // 
            // lblUnderReview
            // 
            lblUnderReview.AutoSize = true;
            lblUnderReview.Location = new Point(18, 121);
            lblUnderReview.Name = "lblUnderReview";
            lblUnderReview.Size = new Size(140, 25);
            lblUnderReview.TabIndex = 2;
            lblUnderReview.Text = "○ Under Review";
            // 
            // lblSubmitted
            // 
            lblSubmitted.AutoSize = true;
            lblSubmitted.Location = new Point(18, 79);
            lblSubmitted.Name = "lblSubmitted";
            lblSubmitted.Size = new Size(125, 25);
            lblSubmitted.TabIndex = 1;
            lblSubmitted.Text = "✔ Submitted";
            // 
            // lblDraft
            // 
            lblDraft.AutoSize = true;
            lblDraft.Location = new Point(18, 39);
            lblDraft.Name = "lblDraft";
            lblDraft.Size = new Size(82, 25);
            lblDraft.TabIndex = 0;
            lblDraft.Text = "✔ Draft";
            // 
            // btnEditApplication
            // 
            btnEditApplication.Location = new Point(37, 662);
            btnEditApplication.Name = "btnEditApplication";
            btnEditApplication.Size = new Size(151, 34);
            btnEditApplication.TabIndex = 8;
            btnEditApplication.Text = "Edit Application";
            btnEditApplication.UseVisualStyleBackColor = true;
            btnEditApplication.Click += btnEditApplication_Click;
            // 
            // btnSubmitApplication
            // 
            btnSubmitApplication.Location = new Point(207, 662);
            btnSubmitApplication.Name = "btnSubmitApplication";
            btnSubmitApplication.Size = new Size(181, 34);
            btnSubmitApplication.TabIndex = 9;
            btnSubmitApplication.Text = "Submit Application";
            btnSubmitApplication.UseVisualStyleBackColor = true;
            btnSubmitApplication.Click += btnSubmitApplication_Click;
            // 
            // FrmMyApplication
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 708);
            Controls.Add(btnEditApplication);
            Controls.Add(btnSubmitApplication);
            Controls.Add(grpApplication);
            Controls.Add(lblApplicationStatus);
            Controls.Add(lblDepartment);
            Controls.Add(lblDateApplied);
            Controls.Add(lblAppliedPosition);
            Controls.Add(lblTitle);
            Name = "FrmMyApplication";
            Text = "FrmMyApplication";
            grpApplication.ResumeLayout(false);
            grpApplication.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAppliedPosition;
        private Label lblDateApplied;
        private Label lblDepartment;
        private Label lblApplicationStatus;
        private GroupBox grpApplication;
        private Label label8;
        private Label label7;
        private Label lblForAssessment;
        private Label lblForInterview;
        private Label lblShortlisted;
        private Label lblUnderReview;
        private Label lblSubmitted;
        private Label lblDraft;
        private Button btnEditApplication;
        private Button btnSubmitApplication;
        private Label lblForFinalReview;
        private Label lblAccepted;
    }
}