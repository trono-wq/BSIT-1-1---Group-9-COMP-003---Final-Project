using System;
using MySql.Data.MySqlClient;

namespace HRApplicantProcessingSystem
{
    internal class DBConnection
    {
        private static string connectionString = "Server=localhost;Database=hr_applicant_process_window_application;Uid=root;Pwd=3STARGENERAL;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
