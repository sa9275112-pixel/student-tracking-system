namespace Student_Dashboard
{
    partial class StudentDashboard
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
            pnlSidebar = new Panel();
            button4 = new Button();
            button3 = new Button();
            bnbadmindashboard = new Button();
            btnMyComplaints = new Button();
            button2 = new Button();
            button1 = new Button();
            lblAppTitle = new Label();
            pnlMainContent = new Panel();
            lblRecentComplaints = new Label();
            dgvRecentComplaints = new DataGridView();
            ComplaintID = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            pnlHeader = new Panel();
            lblHeaderSubtitle = new Label();
            lblWelcome = new Label();
            pnlSidebar.SuspendLayout();
            pnlMainContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentComplaints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.MidnightBlue;
            pnlSidebar.BackgroundImageLayout = ImageLayout.Zoom;
            pnlSidebar.Controls.Add(button4);
            pnlSidebar.Controls.Add(button3);
            pnlSidebar.Controls.Add(bnbadmindashboard);
            pnlSidebar.Controls.Add(btnMyComplaints);
            pnlSidebar.Controls.Add(button2);
            pnlSidebar.Controls.Add(button1);
            pnlSidebar.Controls.Add(lblAppTitle);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(230, 661);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSlateBlue;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(20, 608);
            button4.Name = "button4";
            button4.Size = new Size(179, 41);
            button4.TabIndex = 13;
            button4.Text = "Logout";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkSlateBlue;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(20, 379);
            button3.Name = "button3";
            button3.Size = new Size(179, 40);
            button3.TabIndex = 12;
            button3.Text = "Manage Complaints";
            button3.UseVisualStyleBackColor = false;
            // 
            // bnbadmindashboard
            // 
            bnbadmindashboard.BackColor = Color.DarkSlateBlue;
            bnbadmindashboard.Cursor = Cursors.Hand;
            bnbadmindashboard.FlatStyle = FlatStyle.Flat;
            bnbadmindashboard.Font = new Font("Segoe UI", 10F);
            bnbadmindashboard.ForeColor = Color.White;
            bnbadmindashboard.Location = new Point(20, 314);
            bnbadmindashboard.Name = "bnbadmindashboard";
            bnbadmindashboard.Size = new Size(179, 40);
            bnbadmindashboard.TabIndex = 11;
            bnbadmindashboard.Text = "Admin Dashboad";
            bnbadmindashboard.UseVisualStyleBackColor = false;
            // 
            // btnMyComplaints
            // 
            btnMyComplaints.BackColor = Color.DarkSlateBlue;
            btnMyComplaints.Cursor = Cursors.Hand;
            btnMyComplaints.FlatStyle = FlatStyle.Flat;
            btnMyComplaints.Font = new Font("Segoe UI", 10F);
            btnMyComplaints.ForeColor = Color.White;
            btnMyComplaints.Location = new Point(20, 248);
            btnMyComplaints.Name = "btnMyComplaints";
            btnMyComplaints.Size = new Size(179, 40);
            btnMyComplaints.TabIndex = 10;
            btnMyComplaints.Text = "My Complaints";
            btnMyComplaints.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSlateBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(20, 180);
            button2.Name = "button2";
            button2.Size = new Size(179, 40);
            button2.TabIndex = 9;
            button2.Text = "Submit Complaints";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(20, 110);
            button1.Name = "button1";
            button1.Size = new Size(179, 40);
            button1.TabIndex = 8;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblAppTitle
            // 
            lblAppTitle.BackColor = Color.DarkSlateBlue;
            lblAppTitle.Font = new Font("Segoe UI", 10F);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(10, 25);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(210, 60);
            lblAppTitle.TabIndex = 1;
            lblAppTitle.Text = "Student Complaints";
            lblAppTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMainContent
            // 
            pnlMainContent.BackColor = Color.FromArgb(224, 224, 224);
            pnlMainContent.Controls.Add(lblRecentComplaints);
            pnlMainContent.Controls.Add(dgvRecentComplaints);
            pnlMainContent.Controls.Add(pictureBox1);
            pnlMainContent.Controls.Add(pnlHeader);
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(230, 0);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(854, 661);
            pnlMainContent.TabIndex = 1;
            // 
            // lblRecentComplaints
            // 
            lblRecentComplaints.AutoSize = true;
            lblRecentComplaints.Font = new Font("Segoe UI", 14F);
            lblRecentComplaints.ForeColor = Color.Gray;
            lblRecentComplaints.Location = new Point(41, 263);
            lblRecentComplaints.Name = "lblRecentComplaints";
            lblRecentComplaints.Size = new Size(168, 25);
            lblRecentComplaints.TabIndex = 3;
            lblRecentComplaints.Text = "Recent Complaints";
            // 
            // dgvRecentComplaints
            // 
            dgvRecentComplaints.AllowUserToAddRows = false;
            dgvRecentComplaints.AllowUserToDeleteRows = false;
            dgvRecentComplaints.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentComplaints.BackgroundColor = Color.White;
            dgvRecentComplaints.BorderStyle = BorderStyle.None;
            dgvRecentComplaints.ColumnHeadersHeight = 40;
            dgvRecentComplaints.Columns.AddRange(new DataGridViewColumn[] { ComplaintID, Title, Category, Date, Status });
            dgvRecentComplaints.EnableHeadersVisualStyles = false;
            dgvRecentComplaints.GridColor = Color.Gainsboro;
            dgvRecentComplaints.Location = new Point(41, 314);
            dgvRecentComplaints.MultiSelect = false;
            dgvRecentComplaints.Name = "dgvRecentComplaints";
            dgvRecentComplaints.ReadOnly = true;
            dgvRecentComplaints.RowHeadersVisible = false;
            dgvRecentComplaints.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentComplaints.Size = new Size(690, 150);
            dgvRecentComplaints.TabIndex = 2;
            // 
            // ComplaintID
            // 
            ComplaintID.HeaderText = "ComplaintID";
            ComplaintID.Name = "ComplaintID";
            ComplaintID.ReadOnly = true;
            ComplaintID.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Category
            // 
            Category.HeaderText = "Category";
            Category.Name = "Category";
            Category.ReadOnly = true;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2026_11_01_at_10_53_28_PM;
            pictureBox1.Location = new Point(41, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(690, 121);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblHeaderSubtitle);
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(854, 90);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeaderSubtitle
            // 
            lblHeaderSubtitle.AutoSize = true;
            lblHeaderSubtitle.Location = new Point(30, 57);
            lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            lblHeaderSubtitle.Size = new Size(174, 15);
            lblHeaderSubtitle.TabIndex = 1;
            lblHeaderSubtitle.Text = "Here's your complaint overview";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 18F);
            lblWelcome.Location = new Point(20, 25);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(271, 32);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome Back, Student!";
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1084, 661);
            Controls.Add(pnlMainContent);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(1000, 650);
            Name = "StudentDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Student Dashboard";
            Load += StudentDashboard_Load;
            pnlSidebar.ResumeLayout(false);
            pnlMainContent.ResumeLayout(false);
            pnlMainContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentComplaints).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Label lblAppTitle;
        private Panel pnlMainContent;
        private Panel pnlHeader;
        private Label lblHeaderSubtitle;
        private Label lblWelcome;
        private PictureBox pictureBox1;
        private DataGridView dgvRecentComplaints;
        private Label lblRecentComplaints;
        private DataGridViewTextBoxColumn ComplaintID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Category;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Status;
        private Button btnMyComplaints;
        private Button button2;
        private Button button1;
        private Button bnbadmindashboard;
        private Button button3;
        private Button button4;
    }
}
