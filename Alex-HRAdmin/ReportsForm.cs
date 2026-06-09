using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace HRApplicantProcessingSystem
{
    public partial class ReportsForm : Form
    {
        // ======= SECTION 23.1: ( FORM INITIALIZATION ) ======================================================================== //
        public ReportsForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(ReportsForm_Load);
        }

        // ======= SECTION 23.2: ( FORM LOAD ) ================================================================================== //
        private void ReportsForm_Load(object sender, EventArgs e)
        {
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cmbReportType.Items.Add("All Applicants");
            cmbReportType.Items.Add("Accepted Applicants");
            cmbReportType.Items.Add("Rejected Applicants");
            cmbReportType.Items.Add("Interviews");
            cmbReportType.Items.Add("Missing Requirements");
            cmbReportType.SelectedIndex = 0;
        }

        // ======= SECTION 23.3: ( GENERATE REPORT ) ============================================================================ //
        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string selected = cmbReportType.SelectedItem.ToString();

            if (selected == "All Applicants") LoadAllApplicants();
            else if (selected == "Accepted Applicants") LoadAcceptedApplicants();
            else if (selected == "Rejected Applicants") LoadRejectedApplicants();
            else if (selected == "Interviews") LoadInterviews();
            else if (selected == "Missing Requirements") LoadMissingRequirements();

        }
        // ======= SECTION 23.4: ( ALL APPLICANTS REPORT ) ======================================================================= //
        private void LoadAllApplicants()
        {
            try
            {
                MySqlConnection conn = DBConnection.GetConnection();
                conn.Open();
                string query = @"SELECT a.pi_full_name, jv.position, ap.application_status
                        FROM Applicants a
                        JOIN Applications ap ON a.applicant_id = ap.applicant_id
                        JOIN JobVacancies jv ON ap.job_vacancy_id = jv.job_vacancy_id";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvReport.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        // ======= SECTION 23.5: ( ACCEPTED APPLICANTS REPORT ) ================================================================= //
        private void LoadAcceptedApplicants()
        {
            try
            {
                MySqlConnection conn = DBConnection.GetConnection();
                conn.Open();
                string query = @"SELECT a.pi_full_name, jv.position, hd.final_decision, hd.final_remarks
                        FROM Applicants a
                        JOIN Applications ap ON a.applicant_id = ap.applicant_id
                        JOIN JobVacancies jv ON ap.job_vacancy_id = jv.job_vacancy_id
                        JOIN HiringDecisions hd ON ap.application_id = hd.application_id
                        WHERE hd.final_decision = 'Accepted'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvReport.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ======= SECTION 23.6: ( REJECTED APPLICANTS REPORT ) ================================================================ //
        private void LoadRejectedApplicants()
        {
            try
            {
                MySqlConnection conn = DBConnection.GetConnection();
                conn.Open();
                string query = @"SELECT a.pi_full_name, jv.position, hd.final_decision, hd.final_remarks
                        FROM Applicants a
                        JOIN Applications ap ON a.applicant_id = ap.applicant_id
                        JOIN JobVacancies jv ON ap.job_vacancy_id = jv.job_vacancy_id
                        JOIN HiringDecisions hd ON ap.application_id = hd.application_id
                        WHERE hd.final_decision = 'Rejected'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvReport.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ======= SECTION 23.7: ( INTERVIEWS REPORT ) ========================================================================== //
        private void LoadInterviews()
        {
            try
            {
                MySqlConnection conn = DBConnection.GetConnection();
                conn.Open();
                string query = @"SELECT a.pi_full_name, jv.position, isch.interview_date_time, isch.mode_location, isch.status
                        FROM Applicants a
                        JOIN Applications ap ON a.applicant_id = ap.applicant_id
                        JOIN JobVacancies jv ON ap.job_vacancy_id = jv.job_vacancy_id
                        JOIN InterviewSchedules isch ON ap.application_id = isch.application_id";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvReport.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ======= SECTION 23.8: ( MISSING REQUIREMENTS REPORT ) =================================================================== //
        private void LoadMissingRequirements()
        {
            try
            {
                MySqlConnection conn = DBConnection.GetConnection();
                conn.Open();
                string query = @"SELECT a.pi_full_name, rt.requirement_type_name, ad.document_status
                        FROM Applicants a
                        JOIN Applications ap ON a.applicant_id = ap.applicant_id
                        JOIN ApplicantDocuments ad ON ap.application_id = ad.application_id
                        JOIN RequirementTypes rt ON ad.requirement_type_id = rt.requirement_type_id
                        WHERE ad.document_status = 'Missing'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvReport.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}