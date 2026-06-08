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
            lblTimeline = new Label();
            grpHRRemarks = new GroupBox();
            lblmeets = new Label();
            lblTime = new Label();
            lblMode = new Label();
            lblInterviewSchedule = new Label();
            lblDate = new Label();
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
            // lblTimeline
            // 
            lblTimeline.AutoSize = true;
            lblTimeline.Location = new Point(12, 82);
            lblTimeline.Name = "lblTimeline";
            lblTimeline.Size = new Size(159, 200);
            lblTimeline.TabIndex = 1;
            lblTimeline.Text = "✔ Draft\n✔ Submitted\n✔ Under Review\n○ Shortlisted\n○ For Interview\n○ For Assessment\n○ For Final Review\n○ Accepted\n";
            // 
            // grpHRRemarks
            // 
            grpHRRemarks.Controls.Add(lblmeets);
            grpHRRemarks.Location = new Point(12, 306);
            grpHRRemarks.Name = "grpHRRemarks";
            grpHRRemarks.Size = new Size(367, 212);
            grpHRRemarks.TabIndex = 2;
            grpHRRemarks.TabStop = false;
            grpHRRemarks.Text = "HR Remarks";
            // 
            // lblmeets
            // 
            lblmeets.AutoSize = true;
            lblmeets.Location = new Point(22, 111);
            lblmeets.Name = "lblmeets";
            lblmeets.Size = new Size(339, 25);
            lblmeets.TabIndex = 0;
            lblmeets.Text = "Applicant meets minimum qualifications. ";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(4, 605);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(136, 25);
            lblTime.TabIndex = 5;
            lblTime.Text = "Time: 10:00 AM";
            // 
            // lblMode
            // 
            lblMode.AutoSize = true;
            lblMode.Location = new Point(4, 630);
            lblMode.Name = "lblMode";
            lblMode.Size = new Size(119, 25);
            lblMode.TabIndex = 6;
            lblMode.Text = "Mode: Online";
            // 
            // lblInterviewSchedule
            // 
            lblInterviewSchedule.AutoSize = true;
            lblInterviewSchedule.Location = new Point(4, 542);
            lblInterviewSchedule.Name = "lblInterviewSchedule";
            lblInterviewSchedule.Size = new Size(159, 25);
            lblInterviewSchedule.TabIndex = 1;
            lblInterviewSchedule.Text = "Interview Schedule";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(4, 580);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(167, 25);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date: June 15, 2026";
            // 
            // FrmApplicationStatus
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 720);
            Controls.Add(lblInterviewSchedule);
            Controls.Add(lblDate);
            Controls.Add(lblMode);
            Controls.Add(lblTime);
            Controls.Add(grpHRRemarks);
            Controls.Add(lblTimeline);
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
        private Label lblTimeline;
        private GroupBox grpHRRemarks;
        private Label lblmeets;
        private Label label1;
        private Label label2;
        private Label lblTime;
        private Label lblMode;
        private Label lblInterviewSchedule;
        private Label lblDate;
    }
}