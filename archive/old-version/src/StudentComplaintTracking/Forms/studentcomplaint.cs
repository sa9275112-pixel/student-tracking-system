namespace WinFormsApp1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLoginForm adminPage = new AdminLoginForm(this);
            adminPage.Show();
            this.Hide();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
         

        }
    }
}

