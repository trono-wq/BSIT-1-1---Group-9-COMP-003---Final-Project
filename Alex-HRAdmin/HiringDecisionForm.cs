using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HRApplicantProcessingSystem
{
    public partial class HiringDecisionForm : Form
    {
        // ============================ SECTION 22.1: ( FORM INITIALIZATION ) =============================================================================== //
        public HiringDecisionForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(HiringDecisionForm_Load);
        }

        // ============================ SECTION 22.2: ( FORM LOAD ) ========================================================================================= //
        private void HiringDecisionForm_Load(object sender, EventArgs e)
        {
            cmbDecision.Items.Add("Accepted");
            cmbDecision.Items.Add("Rejected");
            cmbDecision.Items.Add("On Hold");
            cmbDecision.SelectedIndex = 0;

            loadApplicants();
            dgvApplicants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        // ============================ SECTION 22.3: ( LOAD APPLICANTS FOR FINAL REVIEW ) ================================================================== //
        private void loadApplicants()
        {
            try
            {
                MySqlConnection conn = DBConnection.GetConnection();
                conn.Open();
                string query = @"SELECT ap.application_id, a.pi_full_name, jv.position, ap.application_status
                        FROM Applications ap
                        JOIN Applicants a ON ap.applicant_id = a.applicant_id
                        JOIN JobVacancies jv ON ap.job_vacancy_id = jv.job_vacancy_id
                        WHERE ap.application_status = 'For Final Review'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvApplicants.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading applicants: " + ex.Message);
            }
        }
    }
}
