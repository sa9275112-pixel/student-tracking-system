using System;
using System.Drawing;
using System.Windows.Forms;
using Student_Dashboard;
using StudentComplaintTracking.Gdi;

namespace StudentComplaints
{
    public partial class SubmitComplaintForm : Form
    {
        private readonly Form _dashboardForm;
        private readonly Form? _loginForm;

        public SubmitComplaintForm(Form dashboardForm, Form? loginForm)
        {
            _dashboardForm = dashboardForm;
            _loginForm = loginForm;
            InitializeComponent();
            btnMyComplaints.Click += btnMyComplaints_Click;

            // TODO: replace with the logged-in student's real data
            txtStudentName.Text = "Ahmed Hassan";
            txtStudentId.Text = "S1001";

            SetupGraphics();
        }

        // ───────────── GDI+ / Graphics / Visualization ─────────────

        /// <summary>True after Submit was pressed with missing fields: red outlines are drawn.</summary>
        private bool _showValidation;

        /// <summary>
        /// Sidebar gradient, shadow under the form card, red outlines around missing
        /// required fields, and colored priority dots in the Priority dropdown.
        /// </summary>
        private void SetupGraphics()
        {
            GdiHelpers.AttachSidebarGradient(pnlSidebar);
            GdiHelpers.EnableDoubleBuffering(pnlContent);
            GdiHelpers.EnableDoubleBuffering(pnlCard);

            pnlCard.Paint += pnlCard_Paint;

            // Runs after the existing Submit/Clear handlers (handlers fire in the order they were added)
            btnSubmitComplaint.Click += (s, e) => { _showValidation = lblError.Visible; pnlCard.Invalidate(); };
            btnClear.Click += (s, e) => { _showValidation = false; pnlCard.Invalidate(); };

            // Remove a field's red outline as soon as it is filled in
            txtTitle.TextChanged += (s, e) => pnlCard.Invalidate();
            txtDescription.TextChanged += (s, e) => pnlCard.Invalidate();
            cmbCategory.SelectedIndexChanged += (s, e) => pnlCard.Invalidate();
            cmbPriority.SelectedIndexChanged += (s, e) => pnlCard.Invalidate();

            // Priority dropdown: we draw each item ourselves (colored dot + text)
            cmbPriority.DrawMode = DrawMode.OwnerDrawFixed;
            cmbPriority.DrawItem += cmbPriority_DrawItem;
        }

        /// <summary>Red rounded outline around every required field that is still empty.</summary>
        private void pnlCard_Paint(object? sender, PaintEventArgs e)
        {
            if (!_showValidation) return;

            var missing = new System.Collections.Generic.List<Control>();
            if (string.IsNullOrWhiteSpace(txtTitle.Text)) missing.Add(txtTitle);
            if (cmbCategory.SelectedIndex < 0) missing.Add(cmbCategory);
            if (cmbPriority.SelectedIndex < 0) missing.Add(cmbPriority);
            if (string.IsNullOrWhiteSpace(txtDescription.Text)) missing.Add(txtDescription);

            GdiHelpers.HighQuality(e.Graphics);
            var red = Color.FromArgb(198, 40, 40);
            foreach (var field in missing)
            {
                var outline = Rectangle.Inflate(field.Bounds, 3, 3);
                GdiHelpers.DrawRounded(e.Graphics, outline, 4, red, 2f);
            }
        }

        /// <summary>Draws a Priority item: colored dot (Low green … Urgent red) followed by the text.</summary>
        private void cmbPriority_DrawItem(object? sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            if (e.Index < 0) return;

            string text = cmbPriority.Items[e.Index]?.ToString() ?? "";
            GdiHelpers.HighQuality(e.Graphics);

            int dot = Math.Max(8, e.Bounds.Height / 2 - 2);
            using (var brush = new SolidBrush(GdiHelpers.PriorityColor(text)))
                e.Graphics.FillEllipse(brush, e.Bounds.X + 6, e.Bounds.Y + (e.Bounds.Height - dot) / 2, dot, dot);

            var textRect = new Rectangle(e.Bounds.X + dot + 14, e.Bounds.Y, e.Bounds.Width - dot - 14, e.Bounds.Height);
            TextRenderer.DrawText(e.Graphics, text, e.Font ?? cmbPriority.Font, textRect, e.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            e.DrawFocusRectangle();
        }

        // ---------- Submit logic ----------
        private void btnSubmitComplaint_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string description = txtDescription.Text.Trim();
            string category = cmbCategory.SelectedItem?.ToString();
            string priority = cmbPriority.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(category) ||
                string.IsNullOrEmpty(priority) || string.IsNullOrEmpty(description))
            {
                lblError.Text = "Please fill in all required fields (*).";
                lblError.Visible = true;
                return;
            }

            lblError.Visible = false;

            // TODO: save to your database / list, e.g.
            // var complaint = new Complaint {
            //     Title = title, Category = category, Priority = priority,
            //     Description = description, Status = "New",
            //     Student = txtStudentName.Text, Submitted = DateTime.Now,
            //     Attachment = txtAttachment.Text
            // };
            // ComplaintService.Add(complaint);

            MessageBox.Show("Your complaint has been submitted successfully.",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearForm();
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearForm();

        private void ClearForm()
        {
            txtTitle.Clear();
            txtDescription.Clear();
            txtAttachment.Clear();
            cmbCategory.SelectedIndex = -1;
            cmbPriority.SelectedIndex = 1; // Medium
            lblError.Visible = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "Images and Documents|*.png;*.jpg;*.jpeg;*.pdf;*.docx|All files|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                    txtAttachment.Text = dlg.FileName;
            }
        }

        // ---------- Sidebar navigation (connect to your own forms) ----------
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Hide();
            _dashboardForm.Show();
            _dashboardForm.Activate();
        }

        private void btnSubmit_Click(object sender, EventArgs e) { /* already here */ }

        private void btnMyComplaints_Click(object sender, EventArgs e)
        {
            if (_dashboardForm is StudentDashboard dashboard)
                dashboard.ShowMyComplaints();
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            // new AdminDashboardForm().Show(); Hide();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            // new ManageComplaintsForm().Show(); Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (_dashboardForm is StudentDashboard dashboard)
            {
                dashboard.LogoutToLogin();
                return;
            }

            if (_loginForm != null)
            {
                _loginForm.Show();
                _loginForm.Activate();
            }

            Hide();
            _dashboardForm.Hide();
        }

        // Soft shadow under the white form card
        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {
            GdiHelpers.DrawShadow(e.Graphics, pnlCard.Bounds);
        }
    }
}
