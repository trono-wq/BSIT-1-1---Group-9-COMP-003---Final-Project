using HRApplicantProcessSystem.Database;
using MySql.Data.MySqlClient;
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
    public partial class frmHRDashboard : Form
    {
        public frmHRDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmJobVacancyManagement
                vacancyForm =
                new frmJobVacancyManagement();

            vacancyForm.Show();
        }

        private void frmHRDashboard_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Users");
            comboBox1.Items.Add("Roles");
            comboBox1.Items.Add("ApplicantAccounts");
            comboBox1.Items.Add("Applicants");
            comboBox1.Items.Add("Departments");
            comboBox1.Items.Add("EmploymentTypes");
            comboBox1.Items.Add("JobVacancies");
            comboBox1.Items.Add("Applications");
            comboBox1.Items.Add("RequirementTypes");
            comboBox1.Items.Add("ApplicantDocuments");
            comboBox1.Items.Add("ScreeningResults");
            comboBox1.Items.Add("InterviewTypes");
            comboBox1.Items.Add("InterviewSchedules");
            comboBox1.Items.Add("InterviewEvaluations");
            comboBox1.Items.Add("AssessmentTypes");
            comboBox1.Items.Add("AssessmentScores");
            comboBox1.Items.Add("HiringDecisions");
            comboBox1.Items.Add("ApplicationStatusHistory");
            comboBox1.Items.Add("AuditTrail");

            try
            {
                DatabaseConnection db = new DatabaseConnection();

                using (MySqlConnection conn = db.GetConnection())
                {
                    conn.Open();

                    string query =
                    @"SELECT COUNT(*)
                    FROM JobVacancies
                    WHERE vacancy_status = 'Open'";

                    MySqlCommand cmd =
                    new MySqlCommand(
                    query,
                    conn);

                    int totalOpenJobs =
                    Convert.ToInt32(
                    cmd.ExecuteScalar());

                    txtOJV.Text =
                    totalOpenJobs.ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DatabaseConnection db =
                new DatabaseConnection();

                using (MySqlConnection conn =
                db.GetConnection())
                {
                    conn.Open();

                    string tableName =
                    comboBox1.Text;

                    string query =
                    $"SELECT * FROM {tableName}";

                    MySqlDataAdapter adapter =
                    new MySqlDataAdapter(
                    query,
                    conn);

                    DataTable dt =
                    new DataTable();

                    adapter.Fill(dt);

                    dataGridView1.DataSource =
                    dt;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(
                "Error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmAddHRUsers addHRUserForm = new FrmAddHRUsers();
            addHRUserForm.Show();
        }

        private void label6_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
    }
}


