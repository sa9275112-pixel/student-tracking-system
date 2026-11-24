using StudentComplaints;
using StudentComplaintTracking.Forms;
namespace Student_Dashboard
{
    public partial class StudentDashboard : Form
    {
        private readonly Form? _loginForm;
        private SubmitComplaintForm? _submitComplaintForm;
        private MyComplaints? _myComplaintsForm;

        public StudentDashboard(Form? loginForm = null)
        {
            _loginForm = loginForm;
            InitializeComponent();
            btnMyComplaints.Click += btnMyComplaints_Click;
            AddDashboardSections();

            dgvRecentComplaints.Rows.Add(
                "C001", "Internet Problem", "Technical", "01/11/2026", "Pending");

            dgvRecentComplaints.Rows.Add(
                "C002", "Course Registration", "Academic", "30/10/2026", "Resolved");

            dgvRecentComplaints.Rows.Add(
                "C003", "Student ID Issue", "Administrative", "28/10/2026", "Pending");

            dgvRecentComplaints.Rows.Add(
                "C004", "Lecture Schedule", "Academic", "25/10/2026", "Resolved");

        }


        private void AddDashboardSections()
        {
            // Helpful Information uses the existing empty area below Recent Complaints.
            // The dashboard window and all existing controls remain unchanged.
            var helpfulPanel = CreateSectionPanel(
                "Helpful Information",
                new Point(41, 440),
                new Size(770, 190));

            var helpfulText = new Label
            {
                AutoSize = false,
                Location = new Point(16, 43),
                Size = new Size(735, 132),
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(55, 65, 81),
                Text =
                    "• Write a clear title and describe the issue step by step. Include dates, locations, and any relevant details.\n\n" +
                    "• Choose the category that best matches your complaint and attach supporting documents or screenshots when useful.\n\n" +
                    "• Open My Complaints to review your submissions and check their latest status. If you need help or your issue requires urgent attention, contact Student Affairs."
            };
            helpfulPanel.Controls.Add(helpfulText);
            pnlMainContent.Controls.Add(helpfulPanel);
        }

        private static Panel CreateSectionPanel(string title, Point location, Size size)
        {
            var panel = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Location = location,
                Size = size
            };
            var heading = new Label
            {
                AutoSize = false,
                Location = new Point(12, 10),
                Size = new Size(size.Width - 24, 26),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(35, 45, 90),
                Text = title
            };
            panel.Controls.Add(heading);
            return panel;
        }

        private void btnMyComplaints_Click(object sender, EventArgs e)
        {
            ShowMyComplaints();
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNewComplaint_Click(object sender, EventArgs e)
        {
            ShowSubmitComplaint();
        }

        public void ShowSubmitComplaint()
        {
            if (_submitComplaintForm == null || _submitComplaintForm.IsDisposed)
                _submitComplaintForm = new SubmitComplaintForm(this, _loginForm);

            if (_myComplaintsForm != null && !_myComplaintsForm.IsDisposed)
                _myComplaintsForm.Hide();

            Hide();
            _submitComplaintForm.Show();
            _submitComplaintForm.Activate();
        }

        public void ShowMyComplaints()
        {
            if (_submitComplaintForm == null || _submitComplaintForm.IsDisposed)
                _submitComplaintForm = new SubmitComplaintForm(this, _loginForm);

            if (_myComplaintsForm == null || _myComplaintsForm.IsDisposed)
                _myComplaintsForm = new MyComplaints(this, _submitComplaintForm, _loginForm);

            if (_submitComplaintForm != null && !_submitComplaintForm.IsDisposed)
                _submitComplaintForm.Hide();

            Hide();
            _myComplaintsForm.Show();
            _myComplaintsForm.Activate();
        }

        public void ShowDashboard()
        {
            if (_myComplaintsForm != null && !_myComplaintsForm.IsDisposed)
                _myComplaintsForm.Hide();

            if (_submitComplaintForm != null && !_submitComplaintForm.IsDisposed)
                _submitComplaintForm.Hide();

            Show();
            Activate();
        }

        public void LogoutToLogin()
        {
            if (_myComplaintsForm != null && !_myComplaintsForm.IsDisposed)
                _myComplaintsForm.Hide();

            if (_submitComplaintForm != null && !_submitComplaintForm.IsDisposed)
                _submitComplaintForm.Hide();

            Hide();

            if (_loginForm != null)
            {
                _loginForm.Show();
                _loginForm.Activate();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogoutToLogin();
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
private void lblRecentComplaints_Click(object sender, EventArgs e)
        {

        }
    }
}
