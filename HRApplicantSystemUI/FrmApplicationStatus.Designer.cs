namespace HRApplicantSystemUI
{
    partial class FrmApplicationStatus
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
            grpHRRemarks = new GroupBox();
            lblmeets = new Label();
            lblTime = new Label();
            lblMode = new Label();
            lblInterviewSchedule = new Label();
            lblDate = new Label();
            lblDraft = new Label();
            lblSubmitted = new Label();
            lblUnderReview = new Label();
            lblShortlisted = new Label();
            lblForInterview = new Label();
            lblForAsseessment = new Label();
            lblForFinalReview = new Label();
            lblAccepted = new Label();
            Withdrawn = new Label();
            lblRejected = new Label();
            grpHRRemarks.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(250, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(272, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Application Status Tracking";
            // 
            // grpHRRemarks
            // 
            grpHRRemarks.Controls.Add(lblmeets);
            grpHRRemarks.Location = new Point(4, 451);
            grpHRRemarks.Name = "grpHRRemarks";
            grpHRRemarks.Size = new Size(367, 96);
            grpHRRemarks.TabIndex = 2;
            grpHRRemarks.TabStop = false;
            grpHRRemarks.Text = "HR Remarks";
            // 
            // lblmeets
            // 
            lblmeets.AutoSize = true;
            lblmeets.Location = new Point(22, 49);
            lblmeets.Name = "lblmeets";
            lblmeets.Size = new Size(339, 25);
            lblmeets.TabIndex = 0;
            lblmeets.Text = "Applicant meets minimum qualifications. ";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(4, 621);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(136, 25);
            lblTime.TabIndex = 5;
            lblTime.Text = "Time: 10:00 AM";
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Location = new Point(4, 646);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(119, 25);
            lblMode.TabIndex = 6;
            lblMode.Text = "Mode: Online";
            // 
            // lblInterviewSchedule
            // 
            lblInterviewSchedule.AutoSize = true;
            lblInterviewSchedule.Location = new Point(4, 571);
            lblInterviewSchedule.Name = "lblInterviewSchedule";
            lblInterviewSchedule.Size = new Size(159, 25);
            lblInterviewSchedule.TabIndex = 1;
            lblInterviewSchedule.Text = "Interview Schedule";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(4, 596);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(167, 25);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date: June 15, 2026";
            // 
            // lblDraft
            // 
            lblDraft.AutoSize = true;
            lblDraft.Location = new Point(26, 60);
            lblDraft.Name = "lblDraft";
            lblDraft.Size = new Size(82, 25);
            lblDraft.TabIndex = 7;
            lblDraft.Text = "✔ Draft";
            // 
            // lblSubmitted
            // 
            lblSubmitted.AutoSize = true;
            lblSubmitted.Location = new Point(26, 98);
            lblSubmitted.Name = "lblSubmitted";
            lblSubmitted.Size = new Size(125, 25);
            lblSubmitted.TabIndex = 8;
            lblSubmitted.Text = "✔ Submitted";
            // 
            // lblUnderReview
            // 
            lblUnderReview.AutoSize = true;
            lblUnderReview.Location = new Point(31, 140);
            lblUnderReview.Name = "lblUnderReview";
            lblUnderReview.Size = new Size(140, 25);
            lblUnderReview.TabIndex = 9;
            lblUnderReview.Text = "○ Under Review";
            // 
            // lblShortlisted
            // 
            lblShortlisted.AutoSize = true;
            lblShortlisted.Location = new Point(31, 180);
            lblShortlisted.Name = "lblShortlisted";
            lblShortlisted.Size = new Size(118, 25);
            lblShortlisted.TabIndex = 10;
            lblShortlisted.Text = "○ Shortlisted";
            // 
            // lblForInterview
            // 
            lblForInterview.AutoSize = true;
            lblForInterview.Location = new Point(31, 218);
            lblForInterview.Name = "lblForInterview";
            lblForInterview.Size = new Size(135, 25);
            lblForInterview.TabIndex = 11;
            lblForInterview.Text = "○ For Interview";
            // 
            // lblForAsseessment
            // 
            lblForAsseessment.AutoSize = true;
            lblForAsseessment.Location = new Point(31, 253);
            lblForAsseessment.Name = "lblForAsseessment";
            lblForAsseessment.Size = new Size(158, 25);
            lblForAsseessment.TabIndex = 12;
            lblForAsseessment.Text = "○ For Assessment";
            // 
            // lblForFinalReview
            // 
            lblForFinalReview.AutoSize = true;
            lblForFinalReview.Location = new Point(31, 295);
            lblForFinalReview.Name = "lblForFinalReview";
            lblForFinalReview.Size = new Size(159, 25);
            lblForFinalReview.TabIndex = 13;
            lblForFinalReview.Text = "○ For Final Review";
            // 
            // lblAccepted
            // 
            lblAccepted.AutoSize = true;
            lblAccepted.Location = new Point(31, 332);
            lblAccepted.Name = "lblAccepted";
            lblAccepted.Size = new Size(107, 25);
            lblAccepted.TabIndex = 14;
            lblAccepted.Text = "○ Accepted";
            // 
            // Withdrawn
            // 
            Withdrawn.AutoSize = true;
            Withdrawn.Location = new Point(30, 405);
            Withdrawn.Name = "Withdrawn";
            Withdrawn.Size = new Size(119, 25);
            Withdrawn.TabIndex = 16;
            Withdrawn.Text = "○ Withdrawn";
            // 
            // lblRejected
            // 
            lblRejected.AutoSize = true;
            lblRejected.Location = new Point(30, 368);
            lblRejected.Name = "lblRejected";
            lblRejected.Size = new Size(99, 25);
            lblRejected.TabIndex = 17;
            lblRejected.Text = "○ Rejected";
            // 
            // FrmApplicationStatus
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 720);
            Controls.Add(lblRejected);
            Controls.Add(Withdrawn);
            Controls.Add(lblAccepted);
            Controls.Add(lblForFinalReview);
            Controls.Add(lblForAsseessment);
            Controls.Add(lblForInterview);
            Controls.Add(lblShortlisted);
            Controls.Add(lblUnderReview);
            Controls.Add(lblSubmitted);
            Controls.Add(lblDraft);
            Controls.Add(lblInterviewSchedule);
            Controls.Add(lblDate);
            Controls.Add(lblMode);
            Controls.Add(lblTime);
            Controls.Add(grpHRRemarks);
            Controls.Add(lblTitle);
            Name = "FrmApplicationStatus";
            Text = "FrmApplicationStatus";
            Load += FrmApplicationStatus_Load;
            grpHRRemarks.ResumeLayout(false);
            grpHRRemarks.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox grpHRRemarks;
        private Label lblmeets;
        private Label lblDraft;
        private Label lblSubmitted;
        private Label lblTime;
        private Label lblMode;
        private Label lblInterviewSchedule;
        private Label lblDate;
        private Label lblUnderReview;
        private Label lblShortlisted;
        private Label lblForInterview;
        private Label lblForAsseessment;
        private Label lblForFinalReview;
        private Label lblAccepted;
        private Label label9;
        private Label Withdrawn;
        private Label lblRejected;
    }
}