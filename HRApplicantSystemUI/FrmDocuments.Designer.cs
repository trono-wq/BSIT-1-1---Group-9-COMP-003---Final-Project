namespace HRApplicantSystemUI
{
    partial class FrmDocuments
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
            dgvDocuments = new DataGridView();
            colRequirement = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            btnUpload = new Button();
            btnReplace = new Button();
            lblMissingRequirements = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(294, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(155, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "My Documents";
            // 
            // dgvDocuments
            // 
            dgvDocuments.AllowUserToAddRows = false;
            dgvDocuments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocuments.Columns.AddRange(new DataGridViewColumn[] { colRequirement, colStatus });
            dgvDocuments.Location = new Point(12, 136);
            dgvDocuments.Name = "dgvDocuments";
            dgvDocuments.RowHeadersWidth = 62;
            dgvDocuments.Size = new Size(364, 225);
            dgvDocuments.TabIndex = 1;
            dgvDocuments.CellContentClick += dgvDocuments_CellContentClick;
            // 
            // colRequirement
            // 
            colRequirement.HeaderText = "Requirement";
            colRequirement.MinimumWidth = 8;
            colRequirement.Name = "colRequirement";
            colRequirement.Width = 150;
            // 
            // colStatus
            // 
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 8;
            colStatus.Name = "colStatus";
            colStatus.Width = 150;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(21, 388);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(112, 34);
            btnUpload.TabIndex = 2;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnReplace
            // 
            btnReplace.Location = new Point(158, 388);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new Size(112, 34);
            btnReplace.TabIndex = 3;
            btnReplace.Text = "Replace";
            btnReplace.UseVisualStyleBackColor = true;
            // 
            // lblMissingRequirements
            // 
            lblMissingRequirements.AutoSize = true;
            lblMissingRequirements.Location = new Point(12, 75);
            lblMissingRequirements.Name = "lblMissingRequirements";
            lblMissingRequirements.Size = new Size(205, 25);
            lblMissingRequirements.TabIndex = 4;
            lblMissingRequirements.Text = "Missing Requirements: 2\n";
            // 
            // FrmDocuments
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMissingRequirements);
            Controls.Add(btnReplace);
            Controls.Add(btnUpload);
            Controls.Add(dgvDocuments);
            Controls.Add(lblTitle);
            Name = "FrmDocuments";
            Text = "FrmDocuments";
            Load += FrmDocuments_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDocuments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private DataGridView dgvDocuments;
        private DataGridViewTextBoxColumn colRequirement;
        private DataGridViewTextBoxColumn colStatus;
        private Button btnUpload;
        private Button btnReplace;
        private Label lblMissingRequirements;
    }
}