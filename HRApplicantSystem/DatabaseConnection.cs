using System;
using MySql.Data.MySqlClient;

namespace HRApplicantSystem
{
    public class DatabaseConnection
    {
        private static string connectionString =
            "Server=localhost;" +
            "Database=hr_applicant_process_window_application;" +
            "User ID=root;" +
            "Password=admin123;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}