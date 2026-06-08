using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRApplicantSystemUI
{
    public partial class FrmMyApplication : Form
    {
        public FrmMyApplication()
        {
            InitializeComponent();
        }

        private void btnSubmitApplication_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application Submitted!");
        }

        private void btnEditApplication_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application Editing Opened.");
        }
    }
}
