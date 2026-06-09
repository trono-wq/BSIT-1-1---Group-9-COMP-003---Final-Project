using System.Windows.Forms;

namespace HRApplicantProcessingSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MaintenanceHub()); 
        }
    }
} 