using System;
using System.Windows.Forms;

namespace StudentComplaints
{
    public partial class SubmitComplaintForm : Form
    {
        public SubmitComplaintForm()
        {
            InitializeComponent();

            // TODO: replace with the logged-in student's real data
            txtStudentName.Text = "Ahmed Hassan";
            txtStudentId.Text = "S1001";
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
            // new DashboardForm().Show(); Hide();
        }

        private void btnSubmit_Click(object sender, EventArgs e) { /* already here */ }

        private void btnMyComplaints_Click(object sender, EventArgs e)
        {
            // new MyComplaintsForm().Show(); Hide();
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
            // new LoginForm().Show();
            Close();
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
