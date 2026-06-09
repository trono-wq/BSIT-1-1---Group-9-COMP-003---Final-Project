using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRApplicantSystemUI
{
    public partial class FrmDocuments : Form
    {
        public FrmDocuments()
        {
            InitializeComponent();
        }

        private void dgvDocuments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Document Uploaded!");
            }
        }

        private void FrmDocuments_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Load Event Working!");

            dgvDocuments.Rows.Add("Resume", "Submitted");
            dgvDocuments.Rows.Add("Transcript", "Missing");
            dgvDocuments.Rows.Add("Government ID", "Submitted");
            dgvDocuments.Rows.Add("Certificate", "Missing");
        }
    }
}

