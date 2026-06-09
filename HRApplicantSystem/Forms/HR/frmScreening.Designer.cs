namespace HRApplicantSystem.Forms.HR
{
    partial class frmScreening
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
            this.lblApplicantName = new System.Windows.Forms.Label();
            this.lblApplicantNameValue = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblPositionValue = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.cmbResult = new System.Windows.Forms.ComboBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.rtxtRemarks = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Text = "Screening";
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Location = new System.Drawing.Point(180, 20);
            this.lblTitle.Size = new System.Drawing.Size(200, 40);

            // lblApplicantName
            this.lblApplicantName.Text = "Applicant:";
            this.lblApplicantName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblApplicantName.Location = new System.Drawing.Point(30, 80);
            this.lblApplicantName.Size = new System.Drawing.Size(100, 22);

            // lblApplicantNameValue
            this.lblApplicantNameValue.Text = "";
            this.lblApplicantNameValue.Location = new System.Drawing.Point(140, 80);
            this.lblApplicantNameValue.Size = new System.Drawing.Size(200, 22);

            // lblPosition
            this.lblPosition.Text = "Position:";
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblPosition.Location = new System.Drawing.Point(30, 110);
            this.lblPosition.Size = new System.Drawing.Size(100, 22);

            // lblPositionValue
            this.lblPositionValue.Text = "";
            this.lblPositionValue.Location = new System.Drawing.Point(140, 110);
            this.lblPositionValue.Size = new System.Drawing.Size(200, 22);

            // lblResult
            this.lblResult.Text = "Result:";
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(30, 150);
            this.lblResult.Size = new System.Drawing.Size(100, 22);

            // cmbResult
            this.cmbResult.Location = new System.Drawing.Point(140, 147);
            this.cmbResult.Size = new System.Drawing.Size(200, 22);
            this.cmbResult.Name = "cmbResult";
            this.cmbResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResult.Items.AddRange(new object[] {
                "Qualified",
                "Not Qualified"
            });

            // lblRemarks
            this.lblRemarks.Text = "Remarks:";
            this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblRemarks.Location = new System.Drawing.Point(30, 190);
            this.lblRemarks.Size = new System.Drawing.Size(100, 22);

            // rtxtRemarks
            this.rtxtRemarks.Location = new System.Drawing.Point(30, 215);
            this.rtxtRemarks.Size = new System.Drawing.Size(520, 80);
            this.rtxtRemarks.Name = "rtxtRemarks";

            // btnSave
            this.btnSave.Text = "Save Screening Result";
            this.btnSave.Location = new System.Drawing.Point(280, 320);
            this.btnSave.Size = new System.Drawing.Size(160, 35);
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnClose
            this.btnClose.Text = "Close";
            this.btnClose.Location = new System.Drawing.Point(460, 320);
            this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // frmScreening
            this.Text = "Screening";
            this.Size = new System.Drawing.Size(600, 400);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblApplicantName);
            this.Controls.Add(this.lblApplicantNameValue);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblPositionValue);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cmbResult);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.rtxtRemarks);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblApplicantName;
        private System.Windows.Forms.Label lblApplicantNameValue;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPositionValue;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.ComboBox cmbResult;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.RichTextBox rtxtRemarks;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}