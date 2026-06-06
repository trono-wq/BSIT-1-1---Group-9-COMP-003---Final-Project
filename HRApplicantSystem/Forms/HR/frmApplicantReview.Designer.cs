namespace HRApplicantSystem.Forms.HR
{
    partial class frmApplicantReview
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
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblFullNameValue = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPositionValue = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusValue = new System.Windows.Forms.Label();
            this.lblEducation = new System.Windows.Forms.Label();
            this.rtxtEducation = new System.Windows.Forms.RichTextBox();
            this.lblSkills = new System.Windows.Forms.Label();
            this.rtxtSkills = new System.Windows.Forms.RichTextBox();
            this.lblWorkExp = new System.Windows.Forms.Label();
            this.rtxtWorkExp = new System.Windows.Forms.RichTextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.rtxtRemarks = new System.Windows.Forms.RichTextBox();
            this.btnLockReview = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Text = "Applicant Review";
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(280, 20);
            this.lblTitle.Size = new System.Drawing.Size(250, 40);

            // lblFullName
            this.lblFullName.Text = "Full Name:";
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblFullName.Location = new System.Drawing.Point(20, 80);
            this.lblFullName.Size = new System.Drawing.Size(100, 22);

            // lblFullNameValue
            this.lblFullNameValue.Text = "";
            this.lblFullNameValue.Location = new System.Drawing.Point(130, 80);
            this.lblFullNameValue.Size = new System.Drawing.Size(200, 22);

            // lblPosition
            this.lblPosition.Text = "Position:";
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPosition.Location = new System.Drawing.Point(20, 110);
            this.lblPosition.Size = new System.Drawing.Size(100, 22);

            // lblPositionValue
            this.lblPositionValue.Text = "";
            this.lblPositionValue.Location = new System.Drawing.Point(130, 110);
            this.lblPositionValue.Size = new System.Drawing.Size(200, 22);

            // lblStatus
            this.lblStatus.Text = "Status:";
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(20, 140);
            this.lblStatus.Size = new System.Drawing.Size(100, 22);

            // lblStatusValue
            this.lblStatusValue.Text = "";
            this.lblStatusValue.Location = new System.Drawing.Point(130, 140);
            this.lblStatusValue.Size = new System.Drawing.Size(200, 22);

            // lblEducation
            this.lblEducation.Text = "Education:";
            this.lblEducation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblEducation.Location = new System.Drawing.Point(20, 180);
            this.lblEducation.Size = new System.Drawing.Size(100, 22);

            // rtxtEducation
            this.rtxtEducation.Location = new System.Drawing.Point(20, 205);
            this.rtxtEducation.Size = new System.Drawing.Size(350, 80);
            this.rtxtEducation.ReadOnly = true;
            this.rtxtEducation.Name = "rtxtEducation";

            // lblSkills
            this.lblSkills.Text = "Skills:";
            this.lblSkills.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblSkills.Location = new System.Drawing.Point(400, 180);
            this.lblSkills.Size = new System.Drawing.Size(100, 22);

            // rtxtSkills
            this.rtxtSkills.Location = new System.Drawing.Point(400, 205);
            this.rtxtSkills.Size = new System.Drawing.Size(350, 80);
            this.rtxtSkills.ReadOnly = true;
            this.rtxtSkills.Name = "rtxtSkills";

            // lblWorkExp
            this.lblWorkExp.Text = "Work Experience:";
            this.lblWorkExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblWorkExp.Location = new System.Drawing.Point(20, 300);
            this.lblWorkExp.Size = new System.Drawing.Size(150, 22);

            // rtxtWorkExp
            this.rtxtWorkExp.Location = new System.Drawing.Point(20, 325);
            this.rtxtWorkExp.Size = new System.Drawing.Size(730, 80);
            this.rtxtWorkExp.ReadOnly = true;
            this.rtxtWorkExp.Name = "rtxtWorkExp";

            // lblRemarks
            this.lblRemarks.Text = "HR Remarks:";
            this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRemarks.Location = new System.Drawing.Point(20, 420);
            this.lblRemarks.Size = new System.Drawing.Size(150, 22);

            // rtxtRemarks
            this.rtxtRemarks.Location = new System.Drawing.Point(20, 445);
            this.rtxtRemarks.Size = new System.Drawing.Size(730, 60);
            this.rtxtRemarks.Name = "rtxtRemarks";

            // btnLockReview
            this.btnLockReview.Text = "Lock for Review";
            this.btnLockReview.Location = new System.Drawing.Point(500, 525);
            this.btnLockReview.Size = new System.Drawing.Size(130, 35);
            this.btnLockReview.BackColor = System.Drawing.Color.OrangeRed;
            this.btnLockReview.ForeColor = System.Drawing.Color.White;
            this.btnLockReview.Click += new System.EventHandler(this.btnLockReview_Click);

            // btnClose
            this.btnClose.Text = "Close";
            this.btnClose.Location = new System.Drawing.Point(650, 525);
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // frmApplicantReview
            this.Text = "Applicant Review";
            this.Size = new System.Drawing.Size(800, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblFullNameValue);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblPositionValue);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStatusValue);
            this.Controls.Add(this.lblEducation);
            this.Controls.Add(this.rtxtEducation);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.rtxtSkills);
            this.Controls.Add(this.lblWorkExp);
            this.Controls.Add(this.rtxtWorkExp);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.rtxtRemarks);
            this.Controls.Add(this.btnLockReview);
            this.Controls.Add(this.btnClose);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblFullNameValue;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPositionValue;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusValue;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.RichTextBox rtxtEducation;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.RichTextBox rtxtSkills;
        private System.Windows.Forms.Label lblWorkExp;
        private System.Windows.Forms.RichTextBox rtxtWorkExp;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.RichTextBox rtxtRemarks;
        private System.Windows.Forms.Button btnLockReview;
        private System.Windows.Forms.Button btnClose;
    }
}