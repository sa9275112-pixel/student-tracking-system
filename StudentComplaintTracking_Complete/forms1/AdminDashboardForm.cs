using System.Linq;
using Student_Dashboard;
using StudentComplaintTracking.Gdi;

namespace StudentComplaintTracking.Forms
{
    /// <summary>
    /// Admin dashboard: sidebar, summary cards, chart areas and recent complaints.
    /// GUI only for now: the table rows below are sample data for display.
    /// </summary>
    public partial class AdminDashboardForm : Form
    {
        private readonly WinFormsApp1.LoginForm _loginForm;
        private ManageComplaintsForm? _manageComplaintsForm;

        public AdminDashboardForm(WinFormsApp1.LoginForm loginForm)
        {
            _loginForm = loginForm;
            InitializeComponent();
            LoadSampleRows();
            SetupGraphics();
        }

        // ───────────── GDI+ / Graphics / Visualization ─────────────

        /// <summary>
        /// Connects all custom drawing on this screen:
        /// donut + bar charts, live summary cards, colored badges in the table,
        /// flicker-free redraws and Ctrl+P print preview.
        /// </summary>
        private void SetupGraphics()
        {
            GdiHelpers.EnableDoubleBuffering(pnlSidebar);
            GdiHelpers.EnableDoubleBuffering(pnlChartStatus);
            GdiHelpers.EnableDoubleBuffering(pnlChartCategory);

            pnlChartStatus.Paint += pnlChartStatus_Paint;
            pnlChartCategory.Paint += pnlChartCategory_Paint;
            GdiHelpers.RedrawOnResize(pnlChartStatus);
            GdiHelpers.RedrawOnResize(pnlChartCategory);

            // Status and Priority cells become colored pills (the cell text is unchanged)
            GdiHelpers.AttachBadges(dgvRecent, colRecentStatus.Name, GdiHelpers.StatusColor);
            GdiHelpers.AttachBadges(dgvRecent, colRecentPriority.Name, GdiHelpers.PriorityColor);

            // Redraw charts and cards whenever the table data changes
            dgvRecent.RowsAdded += (s, e) => RefreshCharts();
            dgvRecent.RowsRemoved += (s, e) => RefreshCharts();
            dgvRecent.CellValueChanged += (s, e) => RefreshCharts();

            // Ctrl+P = print preview of the dashboard report
            KeyPreview = true;
            KeyDown += (s, e) =>
            {
                if (e.Control && e.KeyCode == Keys.P)
                {
                    e.SuppressKeyPress = true;
                    PrintReport();
                }
            };

            UpdateSummaryCards();
        }

        /// <summary>Forces both charts to repaint and refreshes the card numbers.</summary>
        private void RefreshCharts()
        {
            UpdateSummaryCards();
            pnlChartStatus.Invalidate();
            pnlChartCategory.Invalidate();
        }

        /// <summary>Counts table rows grouped by one column (Status or Category).</summary>
        private List<KeyValuePair<string, int>> CountBy(string columnName)
        {
            return dgvRecent.Rows.Cast<DataGridViewRow>()
                .Where(r => !r.IsNewRow && r.Cells[columnName].Value != null)
                .GroupBy(r => r.Cells[columnName].Value!.ToString()!)
                .Select(g => new KeyValuePair<string, int>(g.Key, g.Count()))
                .ToList();
        }

        /// <summary>
        /// Fills the 4 summary cards from the table instead of a fixed 0.
        /// Open = New + Under Review, Resolved = Resolved + Closed.
        /// </summary>
        private void UpdateSummaryCards()
        {
            var byStatus = CountBy(colRecentStatus.Name).ToDictionary(k => k.Key, k => k.Value);
            int Get(string s) => byStatus.TryGetValue(s, out int n) ? n : 0;

            lblValTotal.Text = byStatus.Values.Sum().ToString();
            lblValOpen.Text = (Get("New") + Get("Under Review")).ToString();
            lblValInProgress.Text = Get("In Progress").ToString();
            lblValResolved.Text = (Get("Resolved") + Get("Closed")).ToString();
        }

        /// <summary>Donut chart: complaints by status (slice colors match the status badges).</summary>
        private void pnlChartStatus_Paint(object? sender, PaintEventArgs e)
        {
            using var font = new Font("Segoe UI", 9F);
            GdiHelpers.DrawDonutChart(e.Graphics, pnlChartStatus.ClientRectangle,
                CountBy(colRecentStatus.Name), (label, i) => GdiHelpers.StatusColor(label), font);
        }

        /// <summary>Horizontal bar chart: complaints by category, largest first.</summary>
        private void pnlChartCategory_Paint(object? sender, PaintEventArgs e)
        {
            using var font = new Font("Segoe UI", 9F);
            GdiHelpers.DrawBarChart(e.Graphics, pnlChartCategory.ClientRectangle, CountBy(colRecentCategory.Name), font);
        }

        /// <summary>Print preview: both charts on top, then the Recent Complaints table.</summary>
        private void PrintReport()
        {
            GdiHelpers.ShowPrintPreview(this, "Admin Dashboard - Complaints Report", dgvRecent, (g, area) =>
            {
                using var font = new Font("Segoe UI", 9F);
                var left = new Rectangle(area.X, area.Y, area.Width / 2 - 10, area.Height);
                var right = new Rectangle(area.X + area.Width / 2 + 10, area.Y, area.Width / 2 - 10, area.Height);
                GdiHelpers.DrawDonutChart(g, left, CountBy(colRecentStatus.Name), (label, i) => GdiHelpers.StatusColor(label), font);
                GdiHelpers.DrawBarChart(g, right, CountBy(colRecentCategory.Name), font);
            }, 220);
        }

        /// <summary>
        /// Paints the sidebar with a navy-to-blue gradient.
        /// </summary>
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

        private void pnlSidebar_Resize(object sender, EventArgs e)
        {
            pnlSidebar.Invalidate();
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

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            Show();
            Activate();
        }

        private void btnManageComplaints_Click(object sender, EventArgs e)
        {
            if (_manageComplaintsForm == null || _manageComplaintsForm.IsDisposed)
                _manageComplaintsForm = new ManageComplaintsForm(_loginForm, this);

            Hide();
            _manageComplaintsForm.Show();
            _manageComplaintsForm.Activate();
        }

        public void HideManageComplaints()
        {
            if (_manageComplaintsForm != null && !_manageComplaintsForm.IsDisposed)
                _manageComplaintsForm.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _loginForm.ReturnToLogin();
        }
    }
}
