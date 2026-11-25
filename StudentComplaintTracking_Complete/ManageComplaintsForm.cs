using StudentComplaintTracking.Gdi;

namespace StudentComplaintTracking.Forms
{
    /// <summary>
    /// Manage Complaints: filter the list, pick a complaint and update its status, owner and priority.
    /// GUI only for now: the table rows below are sample data, and Save / Delete are not connected yet.
    /// </summary>
    public partial class ManageComplaintsForm : Form
    {
        /// <summary>True when the window was closed with the "Admin Dashboard" button.</summary>
        public bool BackToDashboard { get; private set; }

        private readonly WinFormsApp1.LoginForm _loginForm;
        private readonly AdminDashboardForm _adminDashboardForm;

        public ManageComplaintsForm(WinFormsApp1.LoginForm loginForm, AdminDashboardForm adminDashboardForm)
        {
            _loginForm = loginForm;
            _adminDashboardForm = adminDashboardForm;
            InitializeComponent();
            ResetFilters();
            cboNewStatus.SelectedIndex = 0;
            cboAssignTo.SelectedIndex = 0;
            cboNewPriority.SelectedIndex = 1; // Medium
            LoadSampleRows();
            SetupGraphics();
        }

        // ───────────── GDI+ / Graphics / Visualization ─────────────

        /// <summary>
        /// Colored Status / Priority badges in the table, a status-colored marker next to
        /// the selected complaint, flicker-free redraws and Ctrl+P print preview.
        /// </summary>
        private void SetupGraphics()
        {
            GdiHelpers.EnableDoubleBuffering(pnlSidebar);
            GdiHelpers.EnableDoubleBuffering(pnlUpdate);

            GdiHelpers.AttachBadges(dgvComplaints, colStatus.Name, GdiHelpers.StatusColor);
            GdiHelpers.AttachBadges(dgvComplaints, colPriority.Name, GdiHelpers.PriorityColor);

            pnlUpdate.Paint += pnlUpdate_Paint;
            dgvComplaints.SelectionChanged += (s, e) => pnlUpdate.Invalidate();

            KeyPreview = true;
            KeyDown += (s, e) =>
            {
                if (e.Control && e.KeyCode == Keys.P)
                {
                    e.SuppressKeyPress = true;
                    GdiHelpers.ShowPrintPreview(this, "All Complaints", dgvComplaints);
                }
            };
        }

        /// <summary>
        /// Draws a rounded bar in the selected complaint's status color,
        /// just left of the "Selected complaint" text.
        /// </summary>
        private void pnlUpdate_Paint(object? sender, PaintEventArgs e)
        {
            var row = dgvComplaints.CurrentRow;
            if (row == null) return;

            string status = row.Cells[colStatus.Index].Value?.ToString() ?? "";
            var bar = new Rectangle(lblSelected.Left - 9, lblSelected.Top, 5, lblSelected.Height);
            GdiHelpers.HighQuality(e.Graphics);
            GdiHelpers.FillRounded(e.Graphics, bar, 2, GdiHelpers.StatusColor(status));
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e)
        {
            var rect = pnlSidebar.ClientRectangle;
            if (rect.Width == 0 || rect.Height == 0) return;

            using var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                rect,
                Color.FromArgb(14, 18, 62),
                Color.FromArgb(42, 66, 180),
                System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal);
            e.Graphics.FillRectangle(brush, rect);
        }

        private void pnlSidebar_Resize(object sender, EventArgs e) => pnlSidebar.Invalidate();

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            Hide();
            _adminDashboardForm.Show();
            _adminDashboardForm.Activate();
        }

        private void btnManageComplaints_Click(object sender, EventArgs e)
        {
            Show();
            Activate();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Hide();
            _loginForm.ReturnToLogin();
        }

        private void ResetFilters()
        {
            txtSearch.Clear();
            cboStatus.SelectedIndex = 0;
            cboCategory.SelectedIndex = 0;
            cboPriority.SelectedIndex = 0;
        }

        private void btnClear_Click(object sender, EventArgs e) => ResetFilters();

        /// <summary>Shows the selected row's ID and title in the Update panel.</summary>
        private void dgvComplaints_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvComplaints.CurrentRow == null)
            {
                lblSelected.Text = "-";
                return;
            }

            var row = dgvComplaints.CurrentRow;
            lblSelected.Text = row.Cells[colId.Index].Value + " - " + row.Cells[colTitle.Index].Value;
        }

        /// <summary>
        /// Placeholder rows so the table looks filled in. Replace with database data later.
        /// </summary>
        private void LoadSampleRows()
        {
            dgvComplaints.Rows.Add("C010", "Wi-Fi not working in Building B", "Ahmed Hassan", "IT Services", "New", "High", "Unassigned", "03/11/2026");
            dgvComplaints.Rows.Add("C009", "Wrong grade recorded for CS312", "Mariam Adel", "Academic", "Under Review", "Urgent", "Academic Affairs", "02/11/2026");
            dgvComplaints.Rows.Add("C008", "Broken air conditioner in Lab 4", "Omar Khaled", "Facilities", "In Progress", "Medium", "Facilities Office", "01/11/2026");
            dgvComplaints.Rows.Add("C007", "Tuition fee charged twice", "Nour Ibrahim", "Financial", "In Progress", "High", "Finance Office", "31/10/2026");
            dgvComplaints.Rows.Add("C006", "Course registration error", "Youssef Ali", "Academic", "Resolved", "Medium", "Academic Affairs", "30/10/2026");
            dgvComplaints.Rows.Add("C005", "Student ID card not issued", "Salma Mostafa", "Administrative", "Resolved", "Low", "Student Affairs", "28/10/2026");
            dgvComplaints.Rows.Add("C004", "Library late fee dispute", "Karim Fathy", "Other", "Rejected", "Low", "Student Affairs", "27/10/2026");
            dgvComplaints.Rows.Add("C003", "Lecture schedule clash", "Hana Samir", "Academic", "Closed", "Medium", "Academic Affairs", "25/10/2026");
            dgvComplaints.Rows.Add("C002", "Course Registration", "Mohamed Tarek", "Academic", "Resolved", "Medium", "Academic Affairs", "30/10/2026");
            dgvComplaints.Rows.Add("C001", "Internet Problem", "Farida Sherif", "IT Services", "New", "High", "Unassigned", "01/11/2026");

            lblCount.Text = dgvComplaints.Rows.Count + " complaints";
        }
    }
}
