namespace StudentComplaintTracking.Forms
{
    /// <summary>
    /// Admin dashboard: sidebar, welcome header, complaint stats and recent complaints.
    /// GUI only for now: the numbers and rows below are sample data for display.
    /// </summary>
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            LoadSampleRows();
        }

        /// <summary>
        /// Placeholder rows so the table looks filled in. Replace with database data later.
        /// </summary>
        private void LoadSampleRows()
        {
            dgvRecentComplaints.Rows.Add("C001", "Internet Problem", "Technical", "01/11/2026", "Pending");
            dgvRecentComplaints.Rows.Add("C002", "Course Registration", "Academic", "30/10/2026", "Resolved");
            dgvRecentComplaints.Rows.Add("C003", "Student ID Issue", "Administrative", "28/10/2026", "Pending");
            dgvRecentComplaints.Rows.Add("C004", "Lecture Schedule", "Academic", "25/10/2026", "Resolved");
        }
    }
}
