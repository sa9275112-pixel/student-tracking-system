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
            btnMyComplaints = new Button();
            button2 = new Button();
            button1 = new Button();
            lblAppTitle = new Label();
            pnlMainContent = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            label5 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            lblRecentComplaints = new Label();
            dgvRecentComplaints = new DataGridView();
            ComplaintID = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Category = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            pnlHeader = new Panel();
            lblHeaderSubtitle = new Label();
            lblWelcome = new Label();
            pnlSidebar.SuspendLayout();
            pnlMainContent.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentComplaints).BeginInit();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.MidnightBlue;
            pnlSidebar.BackgroundImageLayout = ImageLayout.Zoom;
            pnlSidebar.Controls.Add(button4);
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
            pnlMainContent.Controls.Add(panel3);
            pnlMainContent.Controls.Add(panel2);
            pnlMainContent.Controls.Add(panel1);
            pnlMainContent.Controls.Add(lblRecentComplaints);
            pnlMainContent.Controls.Add(dgvRecentComplaints);
            pnlMainContent.Controls.Add(pnlHeader);
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(230, 0);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(854, 661);
            pnlMainContent.TabIndex = 1;
            // 
            // pictureBox1
            // 
            //pictureBox1.Image = Properties.Resources.Monthly_Complaints_Trend_Chart;
            //pictureBox1.Location = new Point(30, 436);
            //pictureBox1.Name = "pictureBox1";
            //pictureBox1.Size = new Size(701, 213);
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox1.TabIndex = 9;
            //pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Ivory;
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(541, 120);
            panel3.Name = "panel3";
            panel3.Size = new Size(136, 100);
            panel3.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.Location = new Point(3, 16);
            label6.Name = "label6";
            label6.Size = new Size(119, 20);
            label6.TabIndex = 3;
            label6.Text = "Total complains";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label3.Location = new Point(93, 37);
            label3.Name = "label3";
            label3.Size = new Size(36, 46);
            label3.TabIndex = 1;
            label3.Text = "9";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Ivory;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(302, 120);
            panel2.Name = "panel2";
            panel2.Size = new Size(136, 100);
            panel2.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(15, 16);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 2;
            label5.Text = "Pending...";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label2.Location = new Point(93, 37);
            label2.Name = "label2";
            label2.Size = new Size(36, 46);
            label2.TabIndex = 1;
            label2.Text = "5";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Ivory;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(83, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(136, 100);
            panel1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(12, 16);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 1;
            label4.Text = "Resolved";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.Location = new Point(81, 37);
            label1.Name = "label1";
            label1.Size = new Size(36, 46);
            label1.TabIndex = 0;
            label1.Text = "7";
            // 
            // lblRecentComplaints
            // 
            lblRecentComplaints.AutoSize = true;
            lblRecentComplaints.Font = new Font("Segoe UI", 14F);
            lblRecentComplaints.ForeColor = Color.Gray;
            lblRecentComplaints.Location = new Point(41, 235);
            lblRecentComplaints.Name = "lblRecentComplaints";
            lblRecentComplaints.Size = new Size(168, 25);
            lblRecentComplaints.TabIndex = 3;
            lblRecentComplaints.Text = "Recent Complaints";
            lblRecentComplaints.Click += lblRecentComplaints_Click;
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
            dgvRecentComplaints.Location = new Point(41, 269);
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
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentComplaints).EndInit();
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
        private Button button4;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
    }
}
