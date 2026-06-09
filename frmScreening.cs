using HRApplicantProcessSystem.Database;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace HRApplicantProcessingSystem.Forms.HR
{
    public partial class frmScreening : Form
    {
        private int _applicationId;

        // Designer constructor
        public frmScreening()
        {
            InitializeComponent();
        }

        // Runtime constructor
        public frmScreening(int applicationId) : this()
        {
            _applicationId = applicationId;
            this.Load += frmScreening_Load;
        }

        private void frmScreening_Load(object sender, EventArgs e)
        {
            if (this.DesignMode) return;

            cmbResult.SelectedIndex = 0;
            LoadApplicantData();
            AddAuditTrail("Opened Screening for Application ID: " + _applicationId);
        }

        private void LoadApplicantData()
        {
            if (this.DesignMode) return;

            try
            {
                DatabaseConnection db = new DatabaseConnection();
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT ap.pi_full_name, jv.position
                                     FROM Applications a
                                     JOIN Applicants ap ON a.applicant_id = ap.applicant_id
                                     JOIN JobVacancies jv ON a.job_vacancy_id = jv.job_vacancy_id
                                     WHERE a.application_id = @applicationId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@applicationId", _applicationId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblApplicantNameValue.Text = reader["pi_full_name"].ToString();
                            lblPositionValue.Text = reader["position"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbResult.SelectedItem == null) return;

            string result = cmbResult.SelectedItem.ToString();
            string remarks = rtxtRemarks.Text.Trim();

            try
            {
                DatabaseConnection db = new DatabaseConnection();
                using (MySqlConnection conn = db.GetConnection())
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

                    string updateQuery = @"UPDATE Applications SET application_status = @status WHERE application_id = @applicationId";
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

                    AddAuditTrail($"Saved Screening Result for Application ID: {_applicationId}, Result: {result}, New Status: {newStatus}");

                    MessageBox.Show($"Screening result saved successfully! Status updated to: {newStatus}");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving screening result: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ------------------------- Audit Trail -------------------------
        private void AddAuditTrail(string action)
        {
            try
            {
                DatabaseConnection db = new DatabaseConnection();
                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO AuditTrail
                                    (user_id, action, affected_table, affected_record_id)
                                    VALUES (@userId, @action, @table, NULL)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", UserSession.UserId);
                    cmd.Parameters.AddWithValue("@action", action);
                    cmd.Parameters.AddWithValue("@table", "ScreeningResults");
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

