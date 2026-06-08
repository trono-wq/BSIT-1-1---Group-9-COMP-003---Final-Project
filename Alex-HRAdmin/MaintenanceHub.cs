using System;
using System.Windows.Forms;

namespace HRApplicantProcessingSystem
{
    public partial class MaintenanceHub : Form
    {
        // ======================================== SECTION 26-31: ( MAINTENANCE HUB ) =================================== //
        public MaintenanceHub()
        {
            InitializeComponent();
        }

        // =================== OPEN DEPARTMENT FORM ===================================================================== //
        private void btnDepartments_Click(object sender, EventArgs e)
        {
            DepartmentForm form = new DepartmentForm();
            form.ShowDialog();
        }

        // =================== OPEN POSITION FORM ===================================================================== //
        private void btnPositions_Click(object sender, EventArgs e)
        {
            PositionForm form = new PositionForm();
            form.ShowDialog();
        }

        // =================== OPEN EMPLOYMENT TYPE FORM =============================================================== //
        private void btnEmploymentTypes_Click(object sender, EventArgs e)
        {
            EmploymentTypeForm form = new EmploymentTypeForm();
            form.ShowDialog();
        }

        // =================== OPEN REQUIREMENT TYPE FORM ============================================================== //
        private void btnRequirementTypes_Click(object sender, EventArgs e)
        {
            RequirementTypeForm form = new RequirementTypeForm();
            form.ShowDialog();
        }

        // =================== OPEN INTERVIEW TYPE FORM ================================================================= //
        private void btnInterviewTypes_Click(object sender, EventArgs e)
        {
            InterviewTypeForm form = new InterviewTypeForm();
            form.ShowDialog();
        }

        // =================== OPEN ASSESSMENT TYPE FORM ================================================================ //
        private void btnAssessmentTypes_Click(object sender, EventArgs e)
        {
            AssessmentTypeForm form = new AssessmentTypeForm();
            form.ShowDialog();
        }
    }
}