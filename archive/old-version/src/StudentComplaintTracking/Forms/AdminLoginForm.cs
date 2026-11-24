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
        private LoginForm mainPage;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainPage.Show();
            this.Close();
        }
    }
}
