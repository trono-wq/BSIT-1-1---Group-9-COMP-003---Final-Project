using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmInterviewEvaluation : Form
    {
        private int _applicationId;

        public frmInterviewEvaluation(int applicationId)
        {
            InitializeComponent();
            _applicationId = applicationId;
            this.Load += new System.EventHandler(this.frmInterviewEvaluation_Load);
        }

        private void frmInterviewEvaluation_Load(object sender, EventArgs e)
        {
            cmbResult.SelectedIndex = 0;
            LoadApplicantData();
            AuditTrail.Log("Opened Interview Evaluation", "Application ID: " + _applicationId, "frmInterviewEvaluation");
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
            if (txtScore.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a score.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int score;
            if (!int.TryParse(txtScore.Text.Trim(), out score) || score < 0 || score > 100)
            {
                MessageBox.Show("Please enter a valid score between 0 and 100.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string result = cmbResult.SelectedItem.ToString();
            string remarks = rtxtRemarks.Text.Trim();
            string recommendations = rtxtRecommendations.Text.Trim();

            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    string query = @"INSERT INTO InterviewEvaluations 
                        (application_id, interview_score, interview_remarks, 
                        interview_evaluation_result, recommendations) 
                        VALUES (@applicationId, @score, @remarks, @result, @recommendations)
                        ON DUPLICATE KEY UPDATE
                        interview_score = @score,
                        interview_remarks = @remarks,
                        interview_evaluation_result = @result,
                        recommendations = @recommendations";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@applicationId", _applicationId);
                    cmd.Parameters.AddWithValue("@score", score);
                    cmd.Parameters.AddWithValue("@remarks", remarks);
                    cmd.Parameters.AddWithValue("@result", result);
                    cmd.Parameters.AddWithValue("@recommendations", recommendations);
                    cmd.ExecuteNonQuery();

                    string newStatus = result == "Pass" ? "For Final Review" : "Rejected";
                    string updateQuery = @"UPDATE Applications 
                        SET application_status = @status 
                        WHERE application_id = @applicationId";
                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@status", newStatus);
                    updateCmd.Parameters.AddWithValue("@applicationId", _applicationId);
                    updateCmd.ExecuteNonQuery();

                    string historyQuery = @"INSERT INTO ApplicationStatusHistory 
                        (application_id, old_status, new_status) 
                        VALUES (@applicationId, 'For Interview', @newStatus)";
                    MySqlCommand historyCmd = new MySqlCommand(historyQuery, conn);
                    historyCmd.Parameters.AddWithValue("@applicationId", _applicationId);
                    historyCmd.Parameters.AddWithValue("@newStatus", newStatus);
                    historyCmd.ExecuteNonQuery();

                    string scheduleQuery = @"UPDATE InterviewSchedules 
                        SET status = 'Completed' 
                        WHERE application_id = @applicationId";
                    MySqlCommand scheduleCmd = new MySqlCommand(scheduleQuery, conn);
                    scheduleCmd.Parameters.AddWithValue("@applicationId", _applicationId);
                    scheduleCmd.ExecuteNonQuery();

                    AuditTrail.Log("Saved Interview Evaluation", "Application ID: " + _applicationId + " | Score: " + score + " | Result: " + result + " | New Status: " + newStatus, "frmInterviewEvaluation");

                    MessageBox.Show("Evaluation saved! Status updated to: " + newStatus,
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving evaluation: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}