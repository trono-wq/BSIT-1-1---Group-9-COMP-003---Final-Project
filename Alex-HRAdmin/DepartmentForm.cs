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
    public partial class DepartmentForm : Form
    {
        // ======================================== SECTION 26.1: ( FORM INITIALIZATION ) =================================== //
        public DepartmentForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(DepartmentForm_Load);
        }

        // ======================================== SECTION 26.2: ( FORM LOAD ) ============================================ //
        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();
        }

        // =================== SECTION 26.3: ( LOAD DEPARTMENTS FROM DATABASE ) =================== //
        private void LoadDepartments()
        {
            MySqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string query = "SELECT department_id, department_name FROM Departments";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgvDepartments.DataSource = dt;
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = DBConnection.GetConnection();
            conn.Open();
            string query = "INSERT INTO Departments (department_name) VALUES (@name)";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", txtDepartmentName.Text);
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Department added successfully!");
            txtDepartmentName.Text = "";
            LoadDepartments();
        }
    }
}