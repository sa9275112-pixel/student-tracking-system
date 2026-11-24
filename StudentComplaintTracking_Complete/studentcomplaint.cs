using Student_Dashboard;
namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        private StudentDashboard? _studentDashboard;
        private AdminLoginForm? _adminLoginForm;
        private StudentComplaintTracking.Forms.AdminDashboardForm? _adminDashboardForm;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (_adminLoginForm == null || _adminLoginForm.IsDisposed)
                _adminLoginForm = new AdminLoginForm(this);

            _adminLoginForm.Show();
            _adminLoginForm.Activate();
            this.Hide();
        }

        public void ShowAdminDashboard()
        {
            if (_adminDashboardForm == null || _adminDashboardForm.IsDisposed)
                _adminDashboardForm = new StudentComplaintTracking.Forms.AdminDashboardForm(this);

            _adminDashboardForm.Show();
            _adminDashboardForm.Activate();
            this.Hide();
        }

        public void ReturnToLogin()
        {
            if (_adminLoginForm != null && !_adminLoginForm.IsDisposed)
                _adminLoginForm.Hide();
            if (_adminDashboardForm != null && !_adminDashboardForm.IsDisposed)
            {
                _adminDashboardForm.HideManageComplaints();
                _adminDashboardForm.Hide();
            }

            Show();
            Activate();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            // Select Student as the active login role.
            btnStudent.BackColor = Color.Navy;
            btnStudent.ForeColor = Color.LightGray;
            btnAdmin.BackColor = Color.LightGray;
            btnAdmin.ForeColor = Color.Navy;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show(
                    "Please enter your Student ID and password.",
                    "Missing information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // The supplied project does not contain student credential verification.
            // After the required fields are entered, open the Student Dashboard.
            if (_studentDashboard == null || _studentDashboard.IsDisposed)
                _studentDashboard = new StudentDashboard(this);

            _studentDashboard.Show();
            _studentDashboard.Activate();
            this.Hide();
        }
    }
}

