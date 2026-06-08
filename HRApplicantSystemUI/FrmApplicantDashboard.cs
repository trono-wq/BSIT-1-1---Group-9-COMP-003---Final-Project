using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRApplicantSystemUI
{
    public partial class FrmApplicantDashboard : Form
    {
        public FrmApplicantDashboard()
        {
            InitializeComponent();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            FrmMyProfile profile = new FrmMyProfile();
            profile.Show();
        }

        private void btnApplication_Click(object sender, EventArgs e)
        {
            FrmMyApplication app = new FrmMyApplication();
            app.Show();
        }

        private void btnDocuments_Click(object sender, EventArgs e)
        {
            FrmDocuments docs = new FrmDocuments();
            docs.Show();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            FrmApplicationStatus status = new FrmApplicationStatus();
            status.Show();
        }

        private void btnJobs_Click(object sender, EventArgs e)
        {
            FrmJobVacancies jobs = new FrmJobVacancies();
            jobs.Show();
        }
    }
}
