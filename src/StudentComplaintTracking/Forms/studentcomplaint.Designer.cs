namespace WinFormsApp1
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerPanel = new Panel();
            label1 = new Label();
            lblTitle = new Label();
            loginPanel = new Panel();
            lblLoginAs = new Label();
            btnStudent = new Button();
            btnAdmin = new Button();
            lnkForgotPassword = new LinkLabel();
            btnLogin = new Button();
            txtPassword = new TextBox();
            lblPassword = new Label();
            textBox1 = new TextBox();
            lblStudentID = new Label();
            lblSubtitle = new Label();
            lblWelcome = new Label();
            headerPanel.SuspendLayout();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.MidnightBlue;
            headerPanel.Controls.Add(label1);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Margin = new Padding(5, 4, 5, 4);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1288, 141);
            headerPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(495, 113);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(320, 28);
            label1.TabIndex = 1;
            label1.Text = "Student Complaint Tracking System";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(595, 48);
            lblTitle.Margin = new Padding(5, 0, 5, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(127, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "MUST";
            lblTitle.Click += lblTitle_Click;
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.White;
            loginPanel.BorderStyle = BorderStyle.FixedSingle;
            loginPanel.Controls.Add(lblLoginAs);
            loginPanel.Controls.Add(btnStudent);
            loginPanel.Controls.Add(btnAdmin);
            loginPanel.Controls.Add(lnkForgotPassword);
            loginPanel.Controls.Add(btnLogin);
            loginPanel.Controls.Add(txtPassword);
            loginPanel.Controls.Add(lblPassword);
            loginPanel.Controls.Add(textBox1);
            loginPanel.Controls.Add(lblStudentID);
            loginPanel.Controls.Add(lblSubtitle);
            loginPanel.Controls.Add(lblWelcome);
            loginPanel.Location = new Point(274, 144);
            loginPanel.Margin = new Padding(4, 3, 4, 3);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(677, 588);
            loginPanel.TabIndex = 1;
            // 
            // lblLoginAs
            // 
            lblLoginAs.AutoSize = true;
            lblLoginAs.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoginAs.ForeColor = Color.Navy;
            lblLoginAs.Location = new Point(111, 146);
            lblLoginAs.Name = "lblLoginAs";
            lblLoginAs.Size = new Size(93, 28);
            lblLoginAs.TabIndex = 10;
            lblLoginAs.Text = "Login As";
            // 
            // btnStudent
            // 
            btnStudent.BackColor = Color.Navy;
            btnStudent.FlatStyle = FlatStyle.Flat;
            btnStudent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudent.ForeColor = Color.LightGray;
            btnStudent.Location = new Point(193, 195);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new Size(172, 33);
            btnStudent.TabIndex = 9;
            btnStudent.Text = "Student";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += btnStudent_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.LightGray;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdmin.ForeColor = Color.Navy;
            btnAdmin.Location = new Point(4, 195);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(150, 33);
            btnAdmin.TabIndex = 8;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.BackColor = Color.White;
            lnkForgotPassword.Enabled = false;
            lnkForgotPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lnkForgotPassword.ForeColor = Color.Navy;
            lnkForgotPassword.LinkColor = Color.MidnightBlue;
            lnkForgotPassword.LinkVisited = true;
            lnkForgotPassword.Location = new Point(4, 455);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(200, 30);
            lnkForgotPassword.TabIndex = 7;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Forgot Password?";
            lnkForgotPassword.VisitedLinkColor = Color.MidnightBlue;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Navy;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(20, 528);
            btnLogin.Margin = new Padding(4, 3, 4, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(600, 55);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            txtPassword.ForeColor = SystemColors.AppWorkspace;
            txtPassword.Location = new Point(4, 397);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(589, 34);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.MidnightBlue;
            lblPassword.Location = new Point(4, 357);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(85, 23);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.AppWorkspace;
            textBox1.Location = new Point(4, 294);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter your Student ID";
            textBox1.Size = new Size(507, 31);
            textBox1.TabIndex = 3;
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentID.ForeColor = Color.MidnightBlue;
            lblStudentID.Location = new Point(4, 250);
            lblStudentID.Margin = new Padding(4, 0, 4, 0);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(97, 23);
            lblStudentID.TabIndex = 2;
            lblStudentID.Text = "Student ID";
            // 
            // lblSubtitle
            // 
            lblSubtitle.ForeColor = Color.DimGray;
            lblSubtitle.Location = new Point(193, 86);
            lblSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(400, 30);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Sign in to your account";
            // 
            // lblWelcome
            // 
            lblWelcome.Enabled = false;
            lblWelcome.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.Navy;
            lblWelcome.Location = new Point(165, 29);
            lblWelcome.Margin = new Padding(4, 0, 4, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(360, 45);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome Back!";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(1288, 775);
            Controls.Add(loginPanel);
            Controls.Add(headerPanel);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            Margin = new Padding(5, 4, 5, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MUST - Student Complaint Tracking System";
            Load += LoginForm_Load;
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerPanel;
        private Label lblTitle;
        private Label label1;
        private Panel loginPanel;
        private Label lblWelcome;
        private Label lblSubtitle;
        private TextBox textBox1;
        private Label lblStudentID;
        private Label lblPassword;
        private Button btnLogin;
        private TextBox txtPassword;
        private LinkLabel lnkForgotPassword;
        private Button btnAdmin;
        private Button btnStudent;
        private Label lblLoginAs;
    }
}
