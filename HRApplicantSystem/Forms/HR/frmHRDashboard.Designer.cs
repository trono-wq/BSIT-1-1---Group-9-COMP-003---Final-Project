namespace HRApplicantSystem.Forms.HR
{
    partial class frmHRDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.lblPendingCount = new System.Windows.Forms.Label();
            this.lblInterview = new System.Windows.Forms.Label();
            this.lblInterviewCount = new System.Windows.Forms.Label();
            this.lblShortlisted = new System.Windows.Forms.Label();
            this.lblShortlistedCount = new System.Windows.Forms.Label();
            this.btnViewApplicants = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(200, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(380, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HR Staff Dashboard";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(50, 100);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(150, 22);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total Applicants";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalCount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblTotalCount.Location = new System.Drawing.Point(50, 125);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(150, 50);
            this.lblTotalCount.TabIndex = 2;
            this.lblTotalCount.Text = "0";
            // 
            // lblPending
            // 
            this.lblPending.Location = new System.Drawing.Point(250, 100);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(150, 22);
            this.lblPending.TabIndex = 3;
            this.lblPending.Text = "Pending Review";
            // 
            // lblPendingCount
            // 
            this.lblPendingCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblPendingCount.ForeColor = System.Drawing.Color.Orange;
            this.lblPendingCount.Location = new System.Drawing.Point(250, 125);
            this.lblPendingCount.Name = "lblPendingCount";
            this.lblPendingCount.Size = new System.Drawing.Size(150, 50);
            this.lblPendingCount.TabIndex = 4;
            this.lblPendingCount.Text = "0";
            // 
            // lblInterview
            // 
            this.lblInterview.Location = new System.Drawing.Point(450, 100);
            this.lblInterview.Name = "lblInterview";
            this.lblInterview.Size = new System.Drawing.Size(180, 22);
            this.lblInterview.TabIndex = 5;
            this.lblInterview.Text = "Scheduled Interviews";
            // 
            // lblInterviewCount
            // 
            this.lblInterviewCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblInterviewCount.ForeColor = System.Drawing.Color.Green;
            this.lblInterviewCount.Location = new System.Drawing.Point(450, 125);
            this.lblInterviewCount.Name = "lblInterviewCount";
            this.lblInterviewCount.Size = new System.Drawing.Size(150, 50);
            this.lblInterviewCount.TabIndex = 6;
            this.lblInterviewCount.Text = "0";
            // 
            // lblShortlisted
            // 
            this.lblShortlisted.Location = new System.Drawing.Point(50, 220);
            this.lblShortlisted.Name = "lblShortlisted";
            this.lblShortlisted.Size = new System.Drawing.Size(150, 22);
            this.lblShortlisted.TabIndex = 7;
            this.lblShortlisted.Text = "Shortlisted";
            // 
            // lblShortlistedCount
            // 
            this.lblShortlistedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblShortlistedCount.ForeColor = System.Drawing.Color.Purple;
            this.lblShortlistedCount.Location = new System.Drawing.Point(50, 245);
            this.lblShortlistedCount.Name = "lblShortlistedCount";
            this.lblShortlistedCount.Size = new System.Drawing.Size(150, 50);
            this.lblShortlistedCount.TabIndex = 8;
            this.lblShortlistedCount.Text = "0";
            // 
            // btnViewApplicants
            // 
            this.btnViewApplicants.Location = new System.Drawing.Point(300, 380);
            this.btnViewApplicants.Name = "btnViewApplicants";
            this.btnViewApplicants.Size = new System.Drawing.Size(150, 40);
            this.btnViewApplicants.TabIndex = 9;
            this.btnViewApplicants.Text = "View Applicants";
            this.btnViewApplicants.Click += new System.EventHandler(this.btnViewApplicants_Click);
            // 
            // frmHRDashboard
            // 
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.lblPending);
            this.Controls.Add(this.lblPendingCount);
            this.Controls.Add(this.lblInterview);
            this.Controls.Add(this.lblInterviewCount);
            this.Controls.Add(this.lblShortlisted);
            this.Controls.Add(this.lblShortlistedCount);
            this.Controls.Add(this.btnViewApplicants);
            this.Name = "frmHRDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.Label lblPendingCount;
        private System.Windows.Forms.Label lblInterview;
        private System.Windows.Forms.Label lblInterviewCount;
        private System.Windows.Forms.Label lblShortlisted;
        private System.Windows.Forms.Label lblShortlistedCount;
        private System.Windows.Forms.Button btnViewApplicants;
    }
}