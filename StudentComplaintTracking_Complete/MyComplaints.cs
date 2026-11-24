using System;
using System.Windows.Forms;
using System.Drawing;
using Student_Dashboard;
using StudentComplaints;

namespace StudentComplaintTracking.Forms
{
    public partial class MyComplaints : Form
    {
        private readonly StudentDashboard _dashboardForm;
        private readonly SubmitComplaintForm _submitComplaintForm;
        private readonly Form? _loginForm;

        public MyComplaints(StudentDashboard dashboardForm, SubmitComplaintForm submitComplaintForm, Form? loginForm)
        {
            _dashboardForm = dashboardForm;
            _submitComplaintForm = submitComplaintForm;
            _loginForm = loginForm;

            InitializeComponent();
            AddStatusGuideSection();

            // Connect the existing sidebar buttons without changing their design.
            button1.Click += (sender, e) => _dashboardForm.ShowDashboard();
            button2.Click += (sender, e) => _dashboardForm.ShowSubmitComplaint();
            button4.Click += (sender, e) => _dashboardForm.LogoutToLogin();
        }


        private void AddStatusGuideSection()
        {
            var guidePanel = new Panel
            {
                Name = "pnlStatusGuide",
                Location = new Point(260, 485),
                Size = new Size(794, 145),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            var heading = new Label
            {
                Text = "Complaint Status & Follow-up Guide",
                Location = new Point(15, 8),
                Size = new Size(750, 30),
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.MidnightBlue
            };
            guidePanel.Controls.Add(heading);

            AddGuideItem(guidePanel, "Pending", "Your complaint has been received and is waiting for review.", 15, 43, 365);
            AddGuideItem(guidePanel, "In Progress", "The administration is currently reviewing your complaint.", 15, 76, 365);
            AddGuideItem(guidePanel, "Resolved", "The issue has been reviewed and addressed.", 15, 109, 365);
            AddGuideItem(guidePanel, "Follow-up", "Check this page regularly for status updates and replies.", 395, 43, 380);
            AddGuideItem(guidePanel, "Need Help?", "Contact Student Affairs if your complaint is delayed.", 395, 89, 380);

            Controls.Add(guidePanel);
            guidePanel.BringToFront();
        }

        private static void AddGuideItem(Panel parent, string title, string description, int x, int y, int width)
        {
            var item = new Label
            {
                Text = title + ": " + description,
                Location = new Point(x, y),
                Size = new Size(width, 36),
                Font = new Font("Segoe UI", 8.5F, FontStyle.Regular),
                ForeColor = Color.FromArgb(55, 55, 55),
                AutoSize = false
            };
            parent.Controls.Add(item);
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void lblWelcome_Click(object sender, EventArgs e) { }
        private void lblTitle_Click(object sender, EventArgs e) { }
        private void lblSubmit_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
    }
}
