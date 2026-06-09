using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Admin__Manager
{
    public partial class frmGeneralLogin : Form
    {
        public frmGeneralLogin()
        {
            InitializeComponent();
        }

        private void cmbBox1_Click(object sender, EventArgs e)
        {

        }

        private void cmbBox2_Click(object sender, EventArgs e)
        {
            frmHRLogin HRLogin =  new frmHRLogin();

            HRLogin.Show();
        }
    }
}
