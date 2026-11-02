namespace StudentComplaintTracking.Forms
{
    partial class AdminDashboardForm
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.pnlSideTitle = new System.Windows.Forms.Panel();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnNewComplaint = new System.Windows.Forms.Button();
            this.btnMyComplaints = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.tlpStats = new System.Windows.Forms.TableLayoutPanel();
            this.pnlStatResolved = new System.Windows.Forms.Panel();
            this.lblIconResolved = new System.Windows.Forms.Label();
            this.lblValueResolved = new System.Windows.Forms.Label();
            this.lblCaptionResolved = new System.Windows.Forms.Label();
            this.pnlStatPending = new System.Windows.Forms.Panel();
            this.lblIconPending = new System.Windows.Forms.Label();
            this.lblValuePending = new System.Windows.Forms.Label();
            this.lblCaptionPending = new System.Windows.Forms.Label();
            this.pnlStatTotal = new System.Windows.Forms.Panel();
            this.lblIconTotal = new System.Windows.Forms.Label();
            this.lblValueTotal = new System.Windows.Forms.Label();
            this.lblCaptionTotal = new System.Windows.Forms.Label();
            this.lblRecent = new System.Windows.Forms.Label();
            this.dgvRecentComplaints = new System.Windows.Forms.DataGridView();
            this.colComplaintId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSidebar.SuspendLayout();
            this.pnlSideTitle.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.tlpStats.SuspendLayout();
            this.pnlStatResolved.SuspendLayout();
            this.pnlStatPending.SuspendLayout();
            this.pnlStatTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentComplaints)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnMyComplaints);
            this.pnlSidebar.Controls.Add(this.btnNewComplaint);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.pnlSideTitle);
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(28, 36, 150);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Size = new System.Drawing.Size(220, 650);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlSideTitle
            // 
            this.pnlSideTitle.Controls.Add(this.lblAppTitle);
            this.pnlSideTitle.BackColor = System.Drawing.Color.FromArgb(24, 30, 128);
            this.pnlSideTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSideTitle.Size = new System.Drawing.Size(220, 90);
            this.pnlSideTitle.Name = "pnlSideTitle";
            this.pnlSideTitle.TabIndex = 0;
            // 
            // lblAppTitle
            // 
            this.lblAppTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblAppTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppTitle.Text = "Student Complaints";
            this.lblAppTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(35, 55, 200);
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(8, 124);
            this.btnDashboard.Size = new System.Drawing.Size(212, 54);
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.TabIndex = 1;
            // 
            // btnNewComplaint
            // 
            this.btnNewComplaint.BackColor = System.Drawing.Color.FromArgb(35, 55, 200);
            this.btnNewComplaint.FlatAppearance.BorderSize = 0;
            this.btnNewComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewComplaint.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnNewComplaint.ForeColor = System.Drawing.Color.White;
            this.btnNewComplaint.Location = new System.Drawing.Point(8, 188);
            this.btnNewComplaint.Size = new System.Drawing.Size(212, 54);
            this.btnNewComplaint.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnNewComplaint.Text = "New Complaint";
            this.btnNewComplaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewComplaint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewComplaint.UseVisualStyleBackColor = false;
            this.btnNewComplaint.Name = "btnNewComplaint";
            this.btnNewComplaint.TabIndex = 2;
            // 
            // btnMyComplaints
            // 
            this.btnMyComplaints.BackColor = System.Drawing.Color.FromArgb(35, 55, 200);
            this.btnMyComplaints.FlatAppearance.BorderSize = 0;
            this.btnMyComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyComplaints.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnMyComplaints.ForeColor = System.Drawing.Color.White;
            this.btnMyComplaints.Location = new System.Drawing.Point(8, 252);
            this.btnMyComplaints.Size = new System.Drawing.Size(212, 54);
            this.btnMyComplaints.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnMyComplaints.Text = "My Complaints";
            this.btnMyComplaints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyComplaints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyComplaints.UseVisualStyleBackColor = false;
            this.btnMyComplaints.Name = "btnMyComplaints";
            this.btnMyComplaints.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(72, 82, 150);
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(225, 228, 240);
            this.btnLogout.Location = new System.Drawing.Point(8, 586);
            this.btnLogout.Size = new System.Drawing.Size(212, 54);
            this.btnLogout.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnLogout.Text = "Logout";
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.TabIndex = 4;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvRecentComplaints);
            this.pnlMain.Controls.Add(this.lblRecent);
            this.pnlMain.Controls.Add(this.tlpStats);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(214, 219, 233);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.TabIndex = 1;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Size = new System.Drawing.Size(850, 90);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.TabIndex = 0;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(25, 22);
            this.lblWelcome.Text = "Welcome Back, Admin!";
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(30, 40, 80);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Location = new System.Drawing.Point(30, 58);
            this.lblSubtitle.Text = "Here's your complaint overview";
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(30, 40, 80);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.TabIndex = 1;
            // 
            // tlpStats
            // 
            this.tlpStats.Controls.Add(this.pnlStatResolved, 0, 0);
            this.tlpStats.Controls.Add(this.pnlStatPending, 1, 0);
            this.tlpStats.Controls.Add(this.pnlStatTotal, 2, 0);
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpStats.BackColor = System.Drawing.Color.FromArgb(248, 248, 250);
            this.tlpStats.ColumnCount = 3;
            this.tlpStats.RowCount = 1;
            this.tlpStats.Location = new System.Drawing.Point(72, 125);
            this.tlpStats.Size = new System.Drawing.Size(690, 115);
            this.tlpStats.Name = "tlpStats";
            this.tlpStats.TabIndex = 1;
            // 
            // pnlStatResolved
            // 
            this.pnlStatResolved.Controls.Add(this.lblCaptionResolved);
            this.pnlStatResolved.Controls.Add(this.lblValueResolved);
            this.pnlStatResolved.Controls.Add(this.lblIconResolved);
            this.pnlStatResolved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatResolved.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlStatResolved.Size = new System.Drawing.Size(230, 115);
            this.pnlStatResolved.Name = "pnlStatResolved";
            this.pnlStatResolved.TabIndex = 0;
            // 
            // lblIconResolved
            // 
            this.lblIconResolved.Dock = System.Windows.Forms.DockStyle.None;
            this.lblIconResolved.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F);
            this.lblIconResolved.ForeColor = System.Drawing.Color.FromArgb(40, 160, 90);
            this.lblIconResolved.Location = new System.Drawing.Point(0, 14);
            this.lblIconResolved.Size = new System.Drawing.Size(230, 28);
            this.lblIconResolved.Text = "\uE930";
            this.lblIconResolved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIconResolved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIconResolved.Name = "lblIconResolved";
            this.lblIconResolved.TabIndex = 0;
            // 
            // lblValueResolved
            // 
            this.lblValueResolved.Dock = System.Windows.Forms.DockStyle.None;
            this.lblValueResolved.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblValueResolved.ForeColor = System.Drawing.Color.FromArgb(30, 40, 80);
            this.lblValueResolved.Location = new System.Drawing.Point(0, 44);
            this.lblValueResolved.Size = new System.Drawing.Size(230, 34);
            this.lblValueResolved.Text = "7";
            this.lblValueResolved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValueResolved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblValueResolved.Name = "lblValueResolved";
            this.lblValueResolved.TabIndex = 1;
            // 
            // lblCaptionResolved
            // 
            this.lblCaptionResolved.Dock = System.Windows.Forms.DockStyle.None;
            this.lblCaptionResolved.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCaptionResolved.ForeColor = System.Drawing.Color.FromArgb(80, 90, 120);
            this.lblCaptionResolved.Location = new System.Drawing.Point(0, 80);
            this.lblCaptionResolved.Size = new System.Drawing.Size(230, 22);
            this.lblCaptionResolved.Text = "Resolved";
            this.lblCaptionResolved.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCaptionResolved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCaptionResolved.Name = "lblCaptionResolved";
            this.lblCaptionResolved.TabIndex = 2;
            // 
            // pnlStatPending
            // 
            this.pnlStatPending.Controls.Add(this.lblCaptionPending);
            this.pnlStatPending.Controls.Add(this.lblValuePending);
            this.pnlStatPending.Controls.Add(this.lblIconPending);
            this.pnlStatPending.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatPending.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlStatPending.Size = new System.Drawing.Size(230, 115);
            this.pnlStatPending.Name = "pnlStatPending";
            this.pnlStatPending.TabIndex = 1;
            // 
            // lblIconPending
            // 
            this.lblIconPending.Dock = System.Windows.Forms.DockStyle.None;
            this.lblIconPending.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F);
            this.lblIconPending.ForeColor = System.Drawing.Color.FromArgb(210, 80, 60);
            this.lblIconPending.Location = new System.Drawing.Point(0, 14);
            this.lblIconPending.Size = new System.Drawing.Size(230, 28);
            this.lblIconPending.Text = "\uE823";
            this.lblIconPending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIconPending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIconPending.Name = "lblIconPending";
            this.lblIconPending.TabIndex = 0;
            // 
            // lblValuePending
            // 
            this.lblValuePending.Dock = System.Windows.Forms.DockStyle.None;
            this.lblValuePending.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblValuePending.ForeColor = System.Drawing.Color.FromArgb(30, 40, 80);
            this.lblValuePending.Location = new System.Drawing.Point(0, 44);
            this.lblValuePending.Size = new System.Drawing.Size(230, 34);
            this.lblValuePending.Text = "5";
            this.lblValuePending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValuePending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblValuePending.Name = "lblValuePending";
            this.lblValuePending.TabIndex = 1;
            // 
            // lblCaptionPending
            // 
            this.lblCaptionPending.Dock = System.Windows.Forms.DockStyle.None;
            this.lblCaptionPending.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCaptionPending.ForeColor = System.Drawing.Color.FromArgb(80, 90, 120);
            this.lblCaptionPending.Location = new System.Drawing.Point(0, 80);
            this.lblCaptionPending.Size = new System.Drawing.Size(230, 22);
            this.lblCaptionPending.Text = "Pending";
            this.lblCaptionPending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCaptionPending.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCaptionPending.Name = "lblCaptionPending";
            this.lblCaptionPending.TabIndex = 2;
            // 
            // pnlStatTotal
            // 
            this.pnlStatTotal.Controls.Add(this.lblCaptionTotal);
            this.pnlStatTotal.Controls.Add(this.lblValueTotal);
            this.pnlStatTotal.Controls.Add(this.lblIconTotal);
            this.pnlStatTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatTotal.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.pnlStatTotal.Size = new System.Drawing.Size(230, 115);
            this.pnlStatTotal.Name = "pnlStatTotal";
            this.pnlStatTotal.TabIndex = 2;
            // 
            // lblIconTotal
            // 
            this.lblIconTotal.Dock = System.Windows.Forms.DockStyle.None;
            this.lblIconTotal.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F);
            this.lblIconTotal.ForeColor = System.Drawing.Color.FromArgb(40, 90, 200);
            this.lblIconTotal.Location = new System.Drawing.Point(0, 14);
            this.lblIconTotal.Size = new System.Drawing.Size(230, 28);
            this.lblIconTotal.Text = "\uE8C8";
            this.lblIconTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIconTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIconTotal.Name = "lblIconTotal";
            this.lblIconTotal.TabIndex = 0;
            // 
            // lblValueTotal
            // 
            this.lblValueTotal.Dock = System.Windows.Forms.DockStyle.None;
            this.lblValueTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblValueTotal.ForeColor = System.Drawing.Color.FromArgb(30, 40, 80);
            this.lblValueTotal.Location = new System.Drawing.Point(0, 44);
            this.lblValueTotal.Size = new System.Drawing.Size(230, 34);
            this.lblValueTotal.Text = "12";
            this.lblValueTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValueTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblValueTotal.Name = "lblValueTotal";
            this.lblValueTotal.TabIndex = 1;
            // 
            // lblCaptionTotal
            // 
            this.lblCaptionTotal.Dock = System.Windows.Forms.DockStyle.None;
            this.lblCaptionTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblCaptionTotal.ForeColor = System.Drawing.Color.FromArgb(80, 90, 120);
            this.lblCaptionTotal.Location = new System.Drawing.Point(0, 80);
            this.lblCaptionTotal.Size = new System.Drawing.Size(230, 22);
            this.lblCaptionTotal.Text = "Total Complaints";
            this.lblCaptionTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCaptionTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCaptionTotal.Name = "lblCaptionTotal";
            this.lblCaptionTotal.TabIndex = 2;
            // 
            // lblRecent
            // 
            this.lblRecent.AutoSize = true;
            this.lblRecent.Location = new System.Drawing.Point(70, 282);
            this.lblRecent.Text = "Recent Complaints";
            this.lblRecent.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblRecent.ForeColor = System.Drawing.Color.FromArgb(70, 80, 110);
            this.lblRecent.Name = "lblRecent";
            this.lblRecent.TabIndex = 2;
            // 
            // dgvRecentComplaints
            // 
            this.dgvRecentComplaints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colComplaintId,
            this.colTitle,
            this.colCategory,
            this.colDate,
            this.colStatus});
            this.dgvRecentComplaints.AllowUserToAddRows = false;
            this.dgvRecentComplaints.AllowUserToDeleteRows = false;
            this.dgvRecentComplaints.AllowUserToResizeRows = false;
            this.dgvRecentComplaints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentComplaints.BackgroundColor = System.Drawing.Color.FromArgb(214, 219, 233);
            this.dgvRecentComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecentComplaints.ColumnHeadersHeight = 40;
            this.dgvRecentComplaints.Location = new System.Drawing.Point(72, 334);
            this.dgvRecentComplaints.ReadOnly = true;
            this.dgvRecentComplaints.RowHeadersVisible = false;
            this.dgvRecentComplaints.RowTemplate.Height = 27;
            this.dgvRecentComplaints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentComplaints.Size = new System.Drawing.Size(690, 150);
            this.dgvRecentComplaints.Name = "dgvRecentComplaints";
            this.dgvRecentComplaints.TabIndex = 3;
            // 
            // colComplaintId
            // 
            this.colComplaintId.HeaderText = "ComplaintID";
            this.colComplaintId.ReadOnly = true;
            this.colComplaintId.Name = "colComplaintId";
            // 
            // colTitle
            // 
            this.colTitle.HeaderText = "Title";
            this.colTitle.ReadOnly = true;
            this.colTitle.Name = "colTitle";
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.ReadOnly = true;
            this.colCategory.Name = "colCategory";
            // 
            // colDate
            // 
            this.colDate.HeaderText = "Date";
            this.colDate.ReadOnly = true;
            this.colDate.Name = "colDate";
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.ReadOnly = true;
            this.colStatus.Name = "colStatus";
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(214, 219, 233);
            this.ClientSize = new System.Drawing.Size(1070, 650);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "AdminDashboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentComplaints)).EndInit();
            this.pnlStatTotal.ResumeLayout(false);
            this.pnlStatTotal.PerformLayout();
            this.pnlStatPending.ResumeLayout(false);
            this.pnlStatPending.PerformLayout();
            this.pnlStatResolved.ResumeLayout(false);
            this.pnlStatResolved.PerformLayout();
            this.tlpStats.ResumeLayout(false);
            this.tlpStats.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlSideTitle.ResumeLayout(false);
            this.pnlSideTitle.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlSideTitle;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnNewComplaint;
        private System.Windows.Forms.Button btnMyComplaints;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.TableLayoutPanel tlpStats;
        private System.Windows.Forms.Panel pnlStatResolved;
        private System.Windows.Forms.Label lblIconResolved;
        private System.Windows.Forms.Label lblValueResolved;
        private System.Windows.Forms.Label lblCaptionResolved;
        private System.Windows.Forms.Panel pnlStatPending;
        private System.Windows.Forms.Label lblIconPending;
        private System.Windows.Forms.Label lblValuePending;
        private System.Windows.Forms.Label lblCaptionPending;
        private System.Windows.Forms.Panel pnlStatTotal;
        private System.Windows.Forms.Label lblIconTotal;
        private System.Windows.Forms.Label lblValueTotal;
        private System.Windows.Forms.Label lblCaptionTotal;
        private System.Windows.Forms.Label lblRecent;
        private System.Windows.Forms.DataGridView dgvRecentComplaints;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComplaintId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}
