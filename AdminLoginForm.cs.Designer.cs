namespace WinFormsApp1
{
    partial class AdminLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlAdminLogin = new Panel();
            btnBack = new Button();
            btnAdminLogin = new Button();
            txtAdminPassword = new TextBox();
            lblPassword = new Label();
            textBox1 = new TextBox();
            lblUsername = new Label();
            lblAdminTitle = new Label();
            pnlAdminLogin.SuspendLayout();
            SuspendLayout();
            // 
            // pnlAdminLogin
            // 
            pnlAdminLogin.BackColor = Color.White;
            pnlAdminLogin.BorderStyle = BorderStyle.FixedSingle;
            pnlAdminLogin.Controls.Add(btnBack);
            pnlAdminLogin.Controls.Add(btnAdminLogin);
            pnlAdminLogin.Controls.Add(txtAdminPassword);
            pnlAdminLogin.Controls.Add(lblPassword);
            pnlAdminLogin.Controls.Add(textBox1);
            pnlAdminLogin.Controls.Add(lblUsername);
            pnlAdminLogin.Controls.Add(lblAdminTitle);
            pnlAdminLogin.Location = new Point(137, 46);
            pnlAdminLogin.Name = "pnlAdminLogin";
            pnlAdminLogin.Size = new Size(554, 370);
            pnlAdminLogin.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.ForeColor = Color.MidnightBlue;
            btnBack.Location = new Point(182, 326);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnAdminLogin
            // 
            btnAdminLogin.BackColor = Color.MidnightBlue;
            btnAdminLogin.FlatStyle = FlatStyle.Flat;
            btnAdminLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdminLogin.ForeColor = Color.White;
            btnAdminLogin.Location = new Point(72, 279);
            btnAdminLogin.Name = "btnAdminLogin";
            btnAdminLogin.Size = new Size(94, 37);
            btnAdminLogin.TabIndex = 5;
            btnAdminLogin.Text = "Login";
            btnAdminLogin.UseVisualStyleBackColor = false;
            // 
            // txtAdminPassword
            // 
            txtAdminPassword.Location = new Point(14, 228);
            txtAdminPassword.Name = "txtAdminPassword";
            txtAdminPassword.PlaceholderText = "Enter admin password";
            txtAdminPassword.Size = new Size(207, 27);
            txtAdminPassword.TabIndex = 4;
            txtAdminPassword.TabStop = false;
            txtAdminPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.MidnightBlue;
            lblPassword.Location = new Point(14, 196);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(14, 139);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter admin username";
            textBox1.Size = new Size(222, 27);
            textBox1.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.MidnightBlue;
            lblUsername.Location = new Point(14, 107);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(127, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Admin Username";
            lblUsername.Click += label1_Click;
            // 
            // lblAdminTitle
            // 
            lblAdminTitle.AutoSize = true;
            lblAdminTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdminTitle.ForeColor = Color.MidnightBlue;
            lblAdminTitle.Location = new Point(72, 18);
            lblAdminTitle.Name = "lblAdminTitle";
            lblAdminTitle.Size = new Size(226, 46);
            lblAdminTitle.TabIndex = 0;
            lblAdminTitle.Text = "Admin Login";
            // 
            // AdminLoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlAdminLogin);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AdminLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MUST - Admin Login";
            pnlAdminLogin.ResumeLayout(false);
            pnlAdminLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlAdminLogin;
        private Label lblUsername;
        private Label lblAdminTitle;
        private TextBox textBox1;
        private Label lblPassword;
        private TextBox txtAdminPassword;
        private Button btnAdminLogin;
        private Button btnBack;
    }
}