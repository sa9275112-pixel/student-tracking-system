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

        public ManageComplaintsForm()
        {
            InitializeComponent();
            ResetFilters();
            cboNewStatus.SelectedIndex = 0;
            cboAssignTo.SelectedIndex = 0;
            cboNewPriority.SelectedIndex = 1; // Medium
            LoadSampleRows();
        }

        private void pnlSidebar_Paint(object sender, PaintEventArgs e) => SidebarStyle.PaintGradient(pnlSidebar, e);

        private void pnlSidebar_Resize(object sender, EventArgs e) => pnlSidebar.Invalidate();

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            BackToDashboard = true;
            Close();
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
