using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class AdminLoginForm : Form
    {
        private readonly LoginForm? mainPage;
        public AdminLoginForm()
        {
            InitializeComponent();
        }
        public AdminLoginForm(LoginForm previousPage) : this()
        {
            mainPage = previousPage;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdminLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(txtAdminPassword.Text))
            {
                MessageBox.Show(
                    "Please enter your admin username and password.",
                    "Missing information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // No admin credential store or verification rules are included in the supplied project.
            // Once both fields are filled, continue to the existing Admin Dashboard.
            if (mainPage == null)
            {
                MessageBox.Show(
                    "The login page is unavailable. Please return to the Login page and try again.",
                    "Navigation error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            mainPage.ShowAdminDashboard();
            Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (mainPage != null)
                mainPage.ReturnToLogin();

            // Keep this form instance available for the next Admin navigation.
            Hide();
        }
    }
}
