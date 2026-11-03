namespace StudentComplaintTracking.Forms
{
    /// <summary>
    /// Admin dashboard: sidebar, summary cards, chart areas and recent complaints.
    /// GUI only for now: the table rows below are sample data for display.
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
            dgvRecent.Rows.Add("C010", "Wi-Fi not working in Building B", "Ahmed Hassan", "IT Services", "New", "High", "03/11/2026");
            dgvRecent.Rows.Add("C009", "Wrong grade recorded for CS312", "Mariam Adel", "Academic", "Under Review", "Urgent", "02/11/2026");
            dgvRecent.Rows.Add("C008", "Broken air conditioner in Lab 4", "Omar Khaled", "Facilities", "In Progress", "Medium", "01/11/2026");
            dgvRecent.Rows.Add("C007", "Tuition fee charged twice", "Nour Ibrahim", "Financial", "In Progress", "High", "31/10/2026");
            dgvRecent.Rows.Add("C006", "Course registration error", "Youssef Ali", "Academic", "Resolved", "Medium", "30/10/2026");
            dgvRecent.Rows.Add("C005", "Student ID card not issued", "Salma Mostafa", "Administrative", "Resolved", "Low", "28/10/2026");
            dgvRecent.Rows.Add("C004", "Library late fee dispute", "Karim Fathy", "Other", "Rejected", "Low", "27/10/2026");
            dgvRecent.Rows.Add("C003", "Lecture schedule clash", "Hana Samir", "Academic", "Closed", "Medium", "25/10/2026");
        }
    }
}
