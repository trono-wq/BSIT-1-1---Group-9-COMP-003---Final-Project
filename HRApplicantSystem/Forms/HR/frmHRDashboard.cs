using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmHRDashboard : Form
    {
        public frmHRDashboard()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frmHRDashboard_Load);
        }

        private void frmHRDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    // Total Applicants
                    string q1 = "SELECT COUNT(*) FROM Applications";
                    MySqlCommand cmd1 = new MySqlCommand(q1, conn);
                    lblTotalCount.Text = cmd1.ExecuteScalar().ToString();

                    // Pending Review
                    string q2 = "SELECT COUNT(*) FROM Applications WHERE application_status = 'Submitted'";
                    MySqlCommand cmd2 = new MySqlCommand(q2, conn);
                    lblPendingCount.Text = cmd2.ExecuteScalar().ToString();

                    // Scheduled Interviews
                    string q3 = "SELECT COUNT(*) FROM InterviewSchedules WHERE status = 'Scheduled'";
                    MySqlCommand cmd3 = new MySqlCommand(q3, conn);
                    lblInterviewCount.Text = cmd3.ExecuteScalar().ToString();

                    // Shortlisted
                    string q4 = "SELECT COUNT(*) FROM Applications WHERE application_status = 'Shortlisted'";
                    MySqlCommand cmd4 = new MySqlCommand(q4, conn);
                    lblShortlistedCount.Text = cmd4.ExecuteScalar().ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewApplicants_Click(object sender, EventArgs e)
        {
            frmApplicantList applicantList = new frmApplicantList();
            applicantList.Show();
        }
    }
}