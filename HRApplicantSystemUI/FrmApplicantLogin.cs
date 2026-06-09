using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRApplicantSystemUI
{
    public partial class FrmApplicantLogin : Form
    {
        public FrmApplicantLogin()
        {
            InitializeComponent();
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmApplicantRegister register = new FrmApplicantRegister();
            register.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmApplicantDashboard dashboard = new FrmApplicantDashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
