namespace HRApplicantSystemUI
{
    partial class FrmJobVacancies
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
            btnSearch = new Button();
            lblSearchJob = new Label();
            txtSearchJob = new TextBox();
            dgvVacancies = new DataGridView();
            colPosition = new DataGridViewTextBoxColumn();
            colDepartment = new DataGridViewTextBoxColumn();
            colType = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colApply = new DataGridViewTextBoxColumn();
            lblPosition = new Label();
            lblDepartment = new Label();
            lblRequiredDocuments = new Label();
            btnApplyNow = new Button();
            lblQualification = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvVacancies).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(275, 16);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 34);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblSearchJob
            // 
            lblSearchJob.AutoSize = true;
            lblSearchJob.Location = new Point(12, 21);
            lblSearchJob.Name = "lblSearchJob";
            lblSearchJob.Size = new Size(101, 25);
            lblSearchJob.TabIndex = 1;
            lblSearchJob.Text = "Search Job:";
            // 
            // txtSearchJob
            // 
            txtSearchJob.Location = new Point(119, 18);
            txtSearchJob.Name = "txtSearchJob";
            txtSearchJob.Size = new Size(150, 31);
            txtSearchJob.TabIndex = 2;
            // 
            // dgvVacancies
            // 
            dgvVacancies.AllowUserToAddRows = false;
            dgvVacancies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVacancies.Columns.AddRange(new DataGridViewColumn[] { colPosition, colDepartment, colType, colStatus, colApply });
            dgvVacancies.Location = new Point(12, 86);
            dgvVacancies.Name = "dgvVacancies";
            dgvVacancies.RowHeadersWidth = 62;
            dgvVacancies.Size = new Size(826, 225);
            dgvVacancies.TabIndex = 3;
            // 
            // colPosition
            // 
            colPosition.HeaderText = "Position ";
            colPosition.MinimumWidth = 8;
            colPosition.Name = "colPosition";
            colPosition.Width = 150;
            // 
            // colDepartment
            // 
            colDepartment.HeaderText = "Department";
            colDepartment.MinimumWidth = 8;
            colDepartment.Name = "colDepartment";
            colDepartment.Width = 150;
            // 
            // colType
            // 
            colType.HeaderText = "Type";
            colType.MinimumWidth = 8;
            colType.Name = "colType";
            colType.Width = 150;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.Width = 150;
            // 
            // colApply
            // 
            colApply.HeaderText = "Apply";
            colApply.MinimumWidth = 8;
            colApply.Name = "colApply";
            colApply.Width = 150;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(22, 346);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(139, 25);
            lblPosition.TabIndex = 4;
            lblPosition.Text = "Position: IT Staff";
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Location = new Point(22, 389);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(230, 25);
            lblDepartment.TabIndex = 6;
            lblDepartment.Text = "Department: IT Department";
            // 
            // lblRequiredDocuments
            // 
            lblRequiredDocuments.AutoSize = true;
            lblRequiredDocuments.Location = new Point(22, 488);
            lblRequiredDocuments.Name = "lblRequiredDocuments";
            lblRequiredDocuments.Size = new Size(182, 100);
            lblRequiredDocuments.TabIndex = 7;
            lblRequiredDocuments.Text = "Required Documents:\nResume\nTranscript\nGovernment ID";
            // 
            // btnApplyNow
            // 
            btnApplyNow.Location = new Point(22, 619);
            btnApplyNow.Name = "btnApplyNow";
            btnApplyNow.Size = new Size(112, 34);
            btnApplyNow.TabIndex = 8;
            btnApplyNow.Text = "Apply Now";
            btnApplyNow.UseVisualStyleBackColor = true;
            // 
            // lblQualification
            // 
            lblQualification.AutoSize = true;
            lblQualification.Location = new Point(22, 433);
            lblQualification.Name = "lblQualification";
            lblQualification.Size = new Size(263, 50);
            lblQualification.TabIndex = 9;
            lblQualification.Text = "Qualifications:\nGraduate of IT or related course";
            // 
            // FrmJobVacancies
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 677);
            Controls.Add(lblQualification);
            Controls.Add(btnApplyNow);
            Controls.Add(lblRequiredDocuments);
            Controls.Add(lblDepartment);
            Controls.Add(lblPosition);
            Controls.Add(dgvVacancies);
            Controls.Add(txtSearchJob);
            Controls.Add(lblSearchJob);
            Controls.Add(btnSearch);
            Name = "FrmJobVacancies";
            Text = "FrmJobVacancies";
            Load += FrmJobVacancies_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVacancies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private Label lblSearchJob;
        private TextBox txtSearchJob;
        private DataGridView dgvVacancies;
        private DataGridViewTextBoxColumn colPosition;
        private DataGridViewTextBoxColumn colDepartment;
        private DataGridViewTextBoxColumn colType;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colApply;
        private Label lblPosition;
        private Label label1;
        private Label lblDepartment;
        private Label lblRequiredDocuments;
        private Button btnApplyNow;
        private Label lblQualification;
    }
}