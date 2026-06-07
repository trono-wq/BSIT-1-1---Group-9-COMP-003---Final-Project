using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HRApplicantSystem.Forms.HR
{
    public partial class frmApplicantReview : Form
    {
        private int _applicationId;

        public frmApplicantReview(int applicationId)
        {
            InitializeComponent();
            _applicationId = applicationId;
            this.Load += new System.EventHandler(this.frmApplicantReview_Load);
        }

        private void frmApplicantReview_Load(object sender, EventArgs e)
        {
            LoadApplicantData();
            LoadDocuments();
            AuditTrail.Log("Viewed Applicant Profile", "Application ID: " + _applicationId, "frmApplicantReview");
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
                        ap.education,
                        ap.skills,
                        ap.work_experience,
                        jv.position,
                        a.application_status,
                        a.locked
                        FROM Applications a
                        JOIN Applicants ap ON a.applicant_id = ap.applicant_id
                        JOIN JobVacancies jv ON a.job_vacancy_id = jv.job_vacancy_id
                        WHERE a.application_id = @applicationId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@applicationId", _applicationId);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        lblFullNameValue.Text = reader["pi_full_name"].ToString();
                        lblPositionValue.Text = reader["position"].ToString();
                        lblStatusValue.Text = reader["application_status"].ToString();
                        rtxtEducation.Text = reader["education"].ToString();
                        rtxtSkills.Text = reader["skills"].ToString();
                        rtxtWorkExp.Text = reader["work_experience"].ToString();

                        bool isLocked = Convert.ToBoolean(reader["locked"]);
                        if (isLocked)
                        {
                            btnLockReview.Enabled = false;
                            btnLockReview.Text = "Already Locked";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applicant data: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDocuments()
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();
                    string query = @"SELECT 
                        rt.requirement_type_name AS 'Document Type',
                        ad.document_status AS 'Status',
                        ad.o_document_uploaded_at AS 'Uploaded At'
                        FROM ApplicantDocuments ad
                        JOIN RequirementTypes rt ON ad.requirement_type_id = rt.requirement_type_id
                        WHERE ad.application_id = @applicationId";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@applicationId", _applicationId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvDocuments.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading documents: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLockReview_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to lock this application for review? The applicant will no longer be able to edit.",
                "Confirm Lock", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = DatabaseConnection.GetConnection())
                    {
                        conn.Open();

                        string query = @"UPDATE Applications 
                            SET application_status = 'Under Review', 
                            locked = TRUE 
                            WHERE application_id = @applicationId";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@applicationId", _applicationId);
                        cmd.ExecuteNonQuery();

                        string historyQuery = @"INSERT INTO ApplicationStatusHistory 
                            (application_id, old_status, new_status) 
                            VALUES (@applicationId, 'Submitted', 'Under Review')";
                        MySqlCommand historyCmd = new MySqlCommand(historyQuery, conn);
                        historyCmd.Parameters.AddWithValue("@applicationId", _applicationId);
                        historyCmd.ExecuteNonQuery();

                        AuditTrail.Log("Locked Application", "Application ID: " + _applicationId + " locked for review", "frmApplicantReview");

                        MessageBox.Show("Application locked for review successfully!",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        lblStatusValue.Text = "Under Review";
                        btnLockReview.Enabled = false;
                        btnLockReview.Text = "Already Locked";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error locking application: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}