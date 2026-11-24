namespace Student_Dashboard
{
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();

            dgvRecentComplaints.Rows.Add(
                "C001", "Internet Problem", "Technical", "01/11/2026", "Pending");

            dgvRecentComplaints.Rows.Add(
                "C002", "Course Registration", "Academic", "30/10/2026", "Resolved");

            dgvRecentComplaints.Rows.Add(
                "C003", "Student ID Issue", "Administrative", "28/10/2026", "Pending");

            dgvRecentComplaints.Rows.Add(
                "C004", "Lecture Schedule", "Academic", "25/10/2026", "Resolved");

        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNewComplaint_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void pnlMainContent_Click(object sender, EventArgs e)
        {

        }

        private void pnlMainContent_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bnbadmindashboard_Click(object sender, EventArgs e)
        {
            
        }

        private void lblRecentComplaints_Click(object sender, EventArgs e)
        {

        }
    }
}
