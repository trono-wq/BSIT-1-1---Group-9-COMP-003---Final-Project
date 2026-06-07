using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmScreening : Form
    {
        private int _applicationId;

        public frmScreening(int applicationId)
        {
            InitializeComponent();
            _applicationId = applicationId;
            this.Load += new System.EventHandler(this.frmScreening_Load);
        }

        private void frmScreening_Load(object sender, EventArgs e)
        {
            cmbResult.SelectedIndex = 0;
            LoadApplicantData();
            AuditTrail.Log("Opened Screening", "Application ID: " + _applicationId, "frmScreening");
        }

        private void LoadApplicantData()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT 
                        ap.pi_full_name,
                        jv.position
                        FROM Applications a
                        JOIN Applicants ap ON a.applicant_id = ap.applicant_id
                        JOIN JobVacancies jv ON a.job_vacancy_id = jv.job_vacancy_id
                        WHERE a.application_id = @applicationId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@applicationId", _applicationId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblApplicantNameValue.Text = reader["pi_full_name"].ToString();
                        lblPositionValue.Text = reader["position"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbResult.SelectedItem == null)
            {
                MessageBox.Show("Please select a screening result.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result = cmbResult.SelectedItem.ToString();
            string remarks = rtxtRemarks.Text.Trim();

            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO ScreeningResults 
                        (application_id, screening_result, remarks) 
                        VALUES (@applicationId, @result, @remarks)
                        ON DUPLICATE KEY UPDATE 
                        screening_result = @result, 
                        remarks = @remarks";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@applicationId", _applicationId);
                    cmd.Parameters.AddWithValue("@result", result);
                    cmd.Parameters.AddWithValue("@remarks", remarks);
                    cmd.ExecuteNonQuery();

                    string newStatus = result == "Qualified" ? "Shortlisted" : "Rejected";
                    string updateQuery = @"UPDATE Applications 
                        SET application_status = @status 
                        WHERE application_id = @applicationId";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@status", newStatus);
                    updateCmd.Parameters.AddWithValue("@applicationId", _applicationId);
                    updateCmd.ExecuteNonQuery();

                    string historyQuery = @"INSERT INTO ApplicationStatusHistory 
                        (application_id, old_status, new_status) 
                        VALUES (@applicationId, 'Under Review', @newStatus)";
                    MySqlCommand historyCmd = new MySqlCommand(historyQuery, conn);
                    historyCmd.Parameters.AddWithValue("@applicationId", _applicationId);
                    historyCmd.Parameters.AddWithValue("@newStatus", newStatus);
                    historyCmd.ExecuteNonQuery();

                    AuditTrail.Log("Saved Screening Result", "Application ID: " + _applicationId + " | Result: " + result + " | New Status: " + newStatus, "frmScreening");

                    MessageBox.Show("Screening result saved successfully! Status updated to: " + newStatus,
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving screening result: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}