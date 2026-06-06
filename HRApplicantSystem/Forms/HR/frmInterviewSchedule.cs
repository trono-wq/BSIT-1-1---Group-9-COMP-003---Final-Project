using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmInterviewSchedule : Form
    {
        private int _applicationId;

        public frmInterviewSchedule(int applicationId)
        {
            InitializeComponent();
            _applicationId = applicationId;
            this.Load += new System.EventHandler(this.frmInterviewSchedule_Load);
        }

        private void frmInterviewSchedule_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            LoadApplicantData();
            LoadInterviewTypes();
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

        private void LoadInterviewTypes()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = "SELECT interview_type_id, interview_type_name FROM InterviewTypes";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    cmbInterviewType.Items.Clear();
                    while (reader.Read())
                    {
                        cmbInterviewType.Items.Add(new
                        {
                            Id = reader["interview_type_id"],
                            Name = reader["interview_type_name"].ToString()
                        });
                    }

                    if (cmbInterviewType.Items.Count > 0)
                        cmbInterviewType.SelectedIndex = 0;
                    else
                        cmbInterviewType.Items.Add("No interview types found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading interview types: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtModeLocation.Text.Trim() == "")
            {
                MessageBox.Show("Please enter mode/location.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtpInterviewDate.Value <= DateTime.Now)
            {
                MessageBox.Show("Interview date must be in the future.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO InterviewSchedules 
                        (application_id, interview_date_time, mode_location, status) 
                        VALUES (@applicationId, @dateTime, @modeLocation, @status)
                        ON DUPLICATE KEY UPDATE
                        interview_date_time = @dateTime,
                        mode_location = @modeLocation,
                        status = @status";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@applicationId", _applicationId);
                    cmd.Parameters.AddWithValue("@dateTime", dtpInterviewDate.Value);
                    cmd.Parameters.AddWithValue("@modeLocation", txtModeLocation.Text.Trim());
                    cmd.Parameters.AddWithValue("@status", cmbStatus.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();

                    // Update application status
                    string updateQuery = @"UPDATE Applications 
                        SET application_status = 'For Interview' 
                        WHERE application_id = @applicationId";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@applicationId", _applicationId);
                    updateCmd.ExecuteNonQuery();

                    // Record in ApplicationStatusHistory
                    string historyQuery = @"INSERT INTO ApplicationStatusHistory 
                        (application_id, old_status, new_status) 
                        VALUES (@applicationId, 'Shortlisted', 'For Interview')";
                    MySqlCommand historyCmd = new MySqlCommand(historyQuery, conn);
                    historyCmd.Parameters.AddWithValue("@applicationId", _applicationId);
                    historyCmd.ExecuteNonQuery();

                    MessageBox.Show("Interview scheduled successfully!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving schedule: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}