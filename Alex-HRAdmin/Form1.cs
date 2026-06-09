using HRApplicantProcessingSystem;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace HRApplicantProcessingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = DBConnection.GetConnection();
                conn.Open();
                MessageBox.Show("Database Connected Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}