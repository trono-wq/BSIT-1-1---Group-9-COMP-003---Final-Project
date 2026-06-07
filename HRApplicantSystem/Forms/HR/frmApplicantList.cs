using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Data;
using System.Windows.Forms;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmApplicantList : Form
    {
        public frmApplicantList()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.frmApplicantList_Load);
        }

        private void frmApplicantList_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            LoadApplicants();
            AuditTrail.Log("Viewed Applicant List", "HR Staff opened the applicant list", "frmApplicantList");
        }

        private void LoadApplicants(string search = "", string status = "All")
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT 
                        a.application_id,
                        ap.pi_full_name AS 'Full Name',
                        jv.position AS 'Position',
                        a.application_status AS 'Status',
                        a.o_application_updated_at AS 'Last Updated'
                        FROM Applications a
                        JOIN Applicants ap ON a.applicant_id = ap.applicant_id
                        JOIN JobVacancies jv ON a.job_vacancy_id = jv.job_vacancy_id
                        WHERE 1=1";

                    if (search != "")
                        query += " AND ap.pi_full_name LIKE @search";
                    if (status != "All")
                        query += " AND a.application_status = @status";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    if (search != "")
                        cmd.Parameters.AddWithValue("@search", "%" + search + "%");
                    if (status != "All")
                        cmd.Parameters.AddWithValue("@status", status);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvApplicants.DataSource = dt;

                    if (dgvApplicants.Columns["application_id"] != null)
                        dgvApplicants.Columns["application_id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applicants: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.Trim();
            string status = cmbStatus.SelectedItem.ToString();
            LoadApplicants(search, status);
            AuditTrail.Log("Searched Applicants", "Search: " + search + " | Status: " + status, "frmApplicantList");
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            if (dgvApplicants.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an applicant first.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int applicationId = Convert.ToInt32(dgvApplicants.SelectedRows[0].Cells["application_id"].Value);
            AuditTrail.Log("Opened Applicant Review", "Application ID: " + applicationId, "frmApplicantList");
            frmApplicantReview review = new frmApplicantReview(applicationId);
            review.Show();
        }
    }
}