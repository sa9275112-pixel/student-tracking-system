using Student_Dashboard;
using StudentComplaintTracking.Gdi;
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
            SetupGraphics();
        }

        // ───────────── GDI+ / Graphics / Visualization ─────────────

        /// <summary>
        /// Gradient header, soft shadow around the login card and an underline
        /// under the selected role (Student).
        /// </summary>
        private void SetupGraphics()
        {
            GdiHelpers.EnableDoubleBuffering(this);
            GdiHelpers.EnableDoubleBuffering(headerPanel);

            // Header text must be see-through so the gradient shows behind it
            label1.BackColor = Color.Transparent;
            headerPanel.Paint += (s, e) =>
                GdiHelpers.FillGradient(e.Graphics, headerPanel.ClientRectangle, System.Drawing.Drawing2D.LinearGradientMode.Horizontal);
            GdiHelpers.RedrawOnResize(headerPanel);

            Paint += (s, e) => GdiHelpers.DrawShadow(e.Graphics, loginPanel.Bounds, 8, 4);
            Resize += (s, e) => Invalidate();

            loginPanel.Paint += loginPanel_Paint;
            btnStudent.Click += (s, e) => loginPanel.Invalidate();
        }

        /// <summary>Rounded accent bar under the Student role button.</summary>
        private void loginPanel_Paint(object? sender, PaintEventArgs e)
        {
            GdiHelpers.HighQuality(e.Graphics);
            var bar = new Rectangle(btnStudent.Left + 20, btnStudent.Bottom + 3, btnStudent.Width - 40, 4);
            GdiHelpers.FillRounded(e.Graphics, bar, 2, GdiHelpers.Blue);
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

