namespace HRApplicantSystem.Forms.HR
{
    partial class frmApplicantList
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
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvApplicants = new System.Windows.Forms.DataGridView();
            this.btnReview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Text = "Applicant List";
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(320, 20);
            this.lblTitle.Size = new System.Drawing.Size(250, 40);

            // lblSearch
            this.lblSearch.Text = "Search:";
            this.lblSearch.Location = new System.Drawing.Point(20, 80);
            this.lblSearch.Size = new System.Drawing.Size(60, 22);

            // txtSearch
            this.txtSearch.Location = new System.Drawing.Point(85, 77);
            this.txtSearch.Size = new System.Drawing.Size(200, 22);
            this.txtSearch.Name = "txtSearch";

            // lblStatus
            this.lblStatus.Text = "Status:";
            this.lblStatus.Location = new System.Drawing.Point(310, 80);
            this.lblStatus.Size = new System.Drawing.Size(60, 22);

            // cmbStatus
            this.cmbStatus.Location = new System.Drawing.Point(375, 77);
            this.cmbStatus.Size = new System.Drawing.Size(180, 22);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Items.AddRange(new object[] {
                "All",
                "Draft",
                "Submitted",
                "Under Review",
                "Shortlisted",
                "For Interview",
                "For Assessment",
                "For Final Review",
                "Accepted",
                "Rejected",
                "Withdrawn"
            });

            // btnSearch
            this.btnSearch.Text = "Search";
            this.btnSearch.Location = new System.Drawing.Point(580, 75);
            this.btnSearch.Size = new System.Drawing.Size(80, 26);
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // dgvApplicants
            this.dgvApplicants.Location = new System.Drawing.Point(20, 120);
            this.dgvApplicants.Size = new System.Drawing.Size(840, 380);
            this.dgvApplicants.Name = "dgvApplicants";
            this.dgvApplicants.ReadOnly = true;
            this.dgvApplicants.AllowUserToAddRows = false;
            this.dgvApplicants.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApplicants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // btnReview
            this.btnReview.Text = "Review Applicant";
            this.btnReview.Location = new System.Drawing.Point(370, 520);
            this.btnReview.Size = new System.Drawing.Size(150, 35);
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);

            // frmApplicantList
            this.Text = "Applicant List";
            this.Size = new System.Drawing.Size(900, 600);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvApplicants);
            this.Controls.Add(this.btnReview);
            ((System.ComponentModel.ISupportInitialize)(this.dgvApplicants)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvApplicants;
        private System.Windows.Forms.Button btnReview;
    }
}