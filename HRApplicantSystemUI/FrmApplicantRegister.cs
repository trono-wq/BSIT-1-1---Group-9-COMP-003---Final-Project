using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRApplicantSystemUI
{
    public partial class FrmApplicantRegister : Form
    {
        public FrmApplicantRegister()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmApplicantLogin login = new FrmApplicantLogin();
            login.Show();
            this.Close();
        }
    }
}
