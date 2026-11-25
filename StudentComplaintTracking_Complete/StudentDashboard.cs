using StudentComplaints;
using StudentComplaintTracking.Forms;
using StudentComplaintTracking.Gdi;
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

            SetupGraphics();
        }

        // ───────────── GDI+ / Graphics / Visualization ─────────────

        /// <summary>
        /// Card icons and color accents, a "% resolved" progress ring,
        /// colored status badges in the table and flicker-free redraws.
        /// The sidebar gradient is drawn in panel1_Paint (already connected to pnlSidebar).
        /// </summary>
        private void SetupGraphics()
        {
            GdiHelpers.EnableDoubleBuffering(pnlSidebar);
            GdiHelpers.EnableDoubleBuffering(pnlMainContent);
            GdiHelpers.RedrawOnResize(pnlSidebar);

            // Summary cards: colored top strip + icon (matches the design reference image)
            panel1.Paint += (s, e) => PaintCard(e.Graphics, panel1, GdiHelpers.StatusColor("Resolved"), GdiHelpers.DrawCheckCircleIcon);
            panel2.Paint += (s, e) => PaintCard(e.Graphics, panel2, GdiHelpers.StatusColor("Pending"), GdiHelpers.DrawClockIcon);
            panel3.Paint += (s, e) => PaintCard(e.Graphics, panel3, GdiHelpers.Blue, GdiHelpers.DrawStackIcon);

            GdiHelpers.AttachBadges(dgvRecentComplaints, Status.Name, GdiHelpers.StatusColor);

            pnlMainContent.Paint += pnlMainContent_Paint;
            dgvRecentComplaints.RowsAdded += (s, e) => pnlMainContent.Invalidate(RingBounds());
            dgvRecentComplaints.RowsRemoved += (s, e) => pnlMainContent.Invalidate(RingBounds());
            dgvRecentComplaints.CellValueChanged += (s, e) => pnlMainContent.Invalidate(RingBounds());
        }

        private delegate void IconPainter(Graphics g, Rectangle r, Color color);

        /// <summary>Colored strip on top of a card and an icon in its bottom-left corner.</summary>
        private static void PaintCard(Graphics g, Panel card, Color color, IconPainter drawIcon)
        {
            GdiHelpers.HighQuality(g);
            using (var strip = new SolidBrush(color))
                g.FillRectangle(strip, 0, 0, card.ClientSize.Width, 4);

            var icon = new Rectangle(10, card.ClientSize.Height - 30, 20, 20);
            drawIcon(g, icon, color);
        }

        /// <summary>Where the progress ring sits: the free space right of the three cards.</summary>
        private Rectangle RingBounds() => new Rectangle(720, 118, 88, 88);

        /// <summary>Progress ring: share of the recent complaints that are resolved.</summary>
        private void pnlMainContent_Paint(object? sender, PaintEventArgs e)
        {
            var rows = dgvRecentComplaints.Rows.Cast<DataGridViewRow>().Where(r => !r.IsNewRow).ToList();
            if (rows.Count == 0) return;

            int resolved = rows.Count(r =>
                string.Equals(r.Cells[Status.Index].Value?.ToString(), "Resolved", StringComparison.OrdinalIgnoreCase));

            using var captionFont = new Font("Segoe UI", 8.5F);
            GdiHelpers.DrawProgressRing(e.Graphics, RingBounds(), resolved / (float)rows.Count,
                GdiHelpers.StatusColor("Resolved"), resolved + " of " + rows.Count + " resolved", captionFont);
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

        // Connected to pnlSidebar in the Designer: paints the sidebar gradient.
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Control sidebar)
                GdiHelpers.FillGradient(e.Graphics, sidebar.ClientRectangle);
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
