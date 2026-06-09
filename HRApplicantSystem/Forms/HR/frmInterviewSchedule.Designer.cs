namespace HRApplicantSystem.Forms.HR
{
    partial class frmInterviewSchedule
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
            this.lblInterviewDate = new System.Windows.Forms.Label();
            this.dtpInterviewDate = new System.Windows.Forms.DateTimePicker();
            this.lblInterviewType = new System.Windows.Forms.Label();
            this.cmbInterviewType = new System.Windows.Forms.ComboBox();
            this.lblModeLocation = new System.Windows.Forms.Label();
            this.txtModeLocation = new System.Windows.Forms.TextBox();
            this.lblInterviewer = new System.Windows.Forms.Label();
            this.txtInterviewer = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Text = "Interview Schedule";
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Location = new System.Drawing.Point(150, 20);
            this.lblTitle.Size = new System.Drawing.Size(280, 40);

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

            // lblInterviewDate
            this.lblInterviewDate.Text = "Interview Date:";
            this.lblInterviewDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblInterviewDate.Location = new System.Drawing.Point(30, 150);
            this.lblInterviewDate.Size = new System.Drawing.Size(110, 22);

            // dtpInterviewDate
            this.dtpInterviewDate.Location = new System.Drawing.Point(150, 147);
            this.dtpInterviewDate.Size = new System.Drawing.Size(250, 22);
            this.dtpInterviewDate.Name = "dtpInterviewDate";
            this.dtpInterviewDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInterviewDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.dtpInterviewDate.ShowUpDown = false;

            // lblInterviewType
            this.lblInterviewType.Text = "Interview Type:";
            this.lblInterviewType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblInterviewType.Location = new System.Drawing.Point(30, 190);
            this.lblInterviewType.Size = new System.Drawing.Size(110, 22);

            // cmbInterviewType
            this.cmbInterviewType.Location = new System.Drawing.Point(150, 187);
            this.cmbInterviewType.Size = new System.Drawing.Size(200, 22);
            this.cmbInterviewType.Name = "cmbInterviewType";
            this.cmbInterviewType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // lblModeLocation
            this.lblModeLocation.Text = "Mode/Location:";
            this.lblModeLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblModeLocation.Location = new System.Drawing.Point(30, 230);
            this.lblModeLocation.Size = new System.Drawing.Size(110, 22);

            // txtModeLocation
            this.txtModeLocation.Location = new System.Drawing.Point(150, 227);
            this.txtModeLocation.Size = new System.Drawing.Size(200, 22);
            this.txtModeLocation.Name = "txtModeLocation";

            // lblInterviewer
            this.lblInterviewer.Text = "Interviewer:";
            this.lblInterviewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblInterviewer.Location = new System.Drawing.Point(30, 270);
            this.lblInterviewer.Size = new System.Drawing.Size(110, 22);

            // txtInterviewer
            this.txtInterviewer.Location = new System.Drawing.Point(150, 267);
            this.txtInterviewer.Size = new System.Drawing.Size(200, 22);
            this.txtInterviewer.Name = "txtInterviewer";

            // lblStatus
            this.lblStatus.Text = "Status:";
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(30, 310);
            this.lblStatus.Size = new System.Drawing.Size(110, 22);

            // cmbStatus
            this.cmbStatus.Location = new System.Drawing.Point(150, 307);
            this.cmbStatus.Size = new System.Drawing.Size(200, 22);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Items.AddRange(new object[] {
                "Scheduled",
                "Completed",
                "Cancelled"
            });

            // btnSave
            this.btnSave.Text = "Save Schedule";
            this.btnSave.Location = new System.Drawing.Point(280, 400);
            this.btnSave.Size = new System.Drawing.Size(130, 35);
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnClose
            this.btnClose.Text = "Close";
            this.btnClose.Location = new System.Drawing.Point(430, 400);
            this.btnClose.Size = new System.Drawing.Size(90, 35);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // frmInterviewSchedule
            this.Text = "Interview Schedule";
            this.Size = new System.Drawing.Size(600, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblApplicantName);
            this.Controls.Add(this.lblApplicantNameValue);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.lblPositionValue);
            this.Controls.Add(this.lblInterviewDate);
            this.Controls.Add(this.dtpInterviewDate);
            this.Controls.Add(this.lblInterviewType);
            this.Controls.Add(this.cmbInterviewType);
            this.Controls.Add(this.lblModeLocation);
            this.Controls.Add(this.txtModeLocation);
            this.Controls.Add(this.lblInterviewer);
            this.Controls.Add(this.txtInterviewer);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblApplicantName;
        private System.Windows.Forms.Label lblApplicantNameValue;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPositionValue;
        private System.Windows.Forms.Label lblInterviewDate;
        private System.Windows.Forms.DateTimePicker dtpInterviewDate;
        private System.Windows.Forms.Label lblInterviewType;
        private System.Windows.Forms.ComboBox cmbInterviewType;
        private System.Windows.Forms.Label lblModeLocation;
        private System.Windows.Forms.TextBox txtModeLocation;
        private System.Windows.Forms.Label lblInterviewer;
        private System.Windows.Forms.TextBox txtInterviewer;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}