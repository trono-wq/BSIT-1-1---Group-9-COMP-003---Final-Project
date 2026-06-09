using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRApplicantSystemUI
{
    public partial class FrmJobVacancies : Form
    {
        public FrmJobVacancies()
        {
            InitializeComponent();
        }

        private void FrmJobVacancies_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Load Event Working!");

            dgvVacancies.Rows.Add("IT Staff", "IT", "Full Time", "Open");
            dgvVacancies.Rows.Add("HR Assistant", "HR", "Full Time", "Open");
            dgvVacancies.Rows.Add("Office Clerk", "Admin", "Contract", "Open");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
