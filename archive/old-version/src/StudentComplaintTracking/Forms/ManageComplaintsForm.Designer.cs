namespace StudentComplaintTracking.Forms
{
    partial class ManageComplaintsForm
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
            this.lblSideTitle = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnSubmitComplaints = new System.Windows.Forms.Button();
            this.btnMyComplaints = new System.Windows.Forms.Button();
            this.btnAdminDashboard = new System.Windows.Forms.Button();
            this.btnManageComplaints = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cboPriority = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlGapTop = new System.Windows.Forms.Panel();
            this.pnlUpdate = new System.Windows.Forms.Panel();
            this.lblUpdateTitle = new System.Windows.Forms.Label();
            this.lblSelectedCap = new System.Windows.Forms.Label();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblNewStatus = new System.Windows.Forms.Label();
            this.cboNewStatus = new System.Windows.Forms.ComboBox();
            this.lblAssignTo = new System.Windows.Forms.Label();
            this.cboAssignTo = new System.Windows.Forms.ComboBox();
            this.lblNewPriority = new System.Windows.Forms.Label();
            this.cboNewPriority = new System.Windows.Forms.ComboBox();
            this.lblResponse = new System.Windows.Forms.Label();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.chkNotify = new System.Windows.Forms.CheckBox();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.btnDeleteComplaint = new System.Windows.Forms.Button();
            this.pnlGapRight = new System.Windows.Forms.Panel();
            this.pnlListCard = new System.Windows.Forms.Panel();
            this.pnlListHead = new System.Windows.Forms.Panel();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.dgvComplaints = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAssignedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubmitted = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSidebar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnlGapTop.SuspendLayout();
            this.pnlUpdate.SuspendLayout();
            this.pnlGapRight.SuspendLayout();
            this.pnlListCard.SuspendLayout();
            this.pnlListHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaints)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.btnLogout);
            this.pnlSidebar.Controls.Add(this.btnManageComplaints);
            this.pnlSidebar.Controls.Add(this.btnAdminDashboard);
            this.pnlSidebar.Controls.Add(this.btnMyComplaints);
            this.pnlSidebar.Controls.Add(this.btnSubmitComplaints);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.lblSideTitle);
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(22, 30, 100);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Size = new System.Drawing.Size(220, 760);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.TabIndex = 0;
            this.pnlSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSidebar_Paint);
            this.pnlSidebar.Resize += new System.EventHandler(this.pnlSidebar_Resize);
            // 
            // lblSideTitle
            // 
            this.lblSideTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblSideTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lblSideTitle.ForeColor = System.Drawing.Color.White;
            this.lblSideTitle.Location = new System.Drawing.Point(0, 40);
            this.lblSideTitle.Size = new System.Drawing.Size(220, 40);
            this.lblSideTitle.Text = "Student Complaints";
            this.lblSideTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSideTitle.Name = "lblSideTitle";
            this.lblSideTitle.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(20, 26, 90);
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 198, 230);
            this.btnDashboard.FlatAppearance.BorderSize = 1;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 52, 140);
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(20, 120);
            this.btnDashboard.Size = new System.Drawing.Size(180, 40);
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.TabIndex = 1;
            // 
            // btnSubmitComplaints
            // 
            this.btnSubmitComplaints.BackColor = System.Drawing.Color.FromArgb(20, 26, 90);
            this.btnSubmitComplaints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmitComplaints.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 198, 230);
            this.btnSubmitComplaints.FlatAppearance.BorderSize = 1;
            this.btnSubmitComplaints.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 52, 140);
            this.btnSubmitComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitComplaints.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnSubmitComplaints.ForeColor = System.Drawing.Color.White;
            this.btnSubmitComplaints.Location = new System.Drawing.Point(20, 186);
            this.btnSubmitComplaints.Size = new System.Drawing.Size(180, 40);
            this.btnSubmitComplaints.Text = "Submit Complaints";
            this.btnSubmitComplaints.UseVisualStyleBackColor = false;
            this.btnSubmitComplaints.Name = "btnSubmitComplaints";
            this.btnSubmitComplaints.TabIndex = 2;
            // 
            // btnMyComplaints
            // 
            this.btnMyComplaints.BackColor = System.Drawing.Color.FromArgb(20, 26, 90);
            this.btnMyComplaints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyComplaints.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 198, 230);
            this.btnMyComplaints.FlatAppearance.BorderSize = 1;
            this.btnMyComplaints.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 52, 140);
            this.btnMyComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyComplaints.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMyComplaints.ForeColor = System.Drawing.Color.White;
            this.btnMyComplaints.Location = new System.Drawing.Point(20, 252);
            this.btnMyComplaints.Size = new System.Drawing.Size(180, 40);
            this.btnMyComplaints.Text = "My Complaints";
            this.btnMyComplaints.UseVisualStyleBackColor = false;
            this.btnMyComplaints.Name = "btnMyComplaints";
            this.btnMyComplaints.TabIndex = 3;
            // 
            // btnAdminDashboard
            // 
            this.btnAdminDashboard.BackColor = System.Drawing.Color.FromArgb(20, 26, 90);
            this.btnAdminDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminDashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 198, 230);
            this.btnAdminDashboard.FlatAppearance.BorderSize = 1;
            this.btnAdminDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 52, 140);
            this.btnAdminDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminDashboard.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAdminDashboard.ForeColor = System.Drawing.Color.White;
            this.btnAdminDashboard.Location = new System.Drawing.Point(20, 318);
            this.btnAdminDashboard.Size = new System.Drawing.Size(180, 40);
            this.btnAdminDashboard.Text = "Admin Dashboard";
            this.btnAdminDashboard.UseVisualStyleBackColor = false;
            this.btnAdminDashboard.Name = "btnAdminDashboard";
            this.btnAdminDashboard.TabIndex = 4;
            this.btnAdminDashboard.Click += new System.EventHandler(this.btnAdminDashboard_Click);
            // 
            // btnManageComplaints
            // 
            this.btnManageComplaints.BackColor = System.Drawing.Color.FromArgb(20, 26, 90);
            this.btnManageComplaints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageComplaints.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnManageComplaints.FlatAppearance.BorderSize = 2;
            this.btnManageComplaints.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 52, 140);
            this.btnManageComplaints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageComplaints.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnManageComplaints.ForeColor = System.Drawing.Color.White;
            this.btnManageComplaints.Location = new System.Drawing.Point(20, 384);
            this.btnManageComplaints.Size = new System.Drawing.Size(180, 40);
            this.btnManageComplaints.Text = "Manage Complaints";
            this.btnManageComplaints.UseVisualStyleBackColor = false;
            this.btnManageComplaints.Name = "btnManageComplaints";
            this.btnManageComplaints.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(36, 52, 145);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 198, 230);
            this.btnLogout.FlatAppearance.BorderSize = 1;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(40, 52, 140);
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(20, 696);
            this.btnLogout.Size = new System.Drawing.Size(180, 40);
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.TabIndex = 6;
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlListCard);
            this.pnlContent.Controls.Add(this.pnlGapRight);
            this.pnlContent.Controls.Add(this.pnlUpdate);
            this.pnlContent.Controls.Add(this.pnlGapTop);
            this.pnlContent.Controls.Add(this.pnlFilters);
            this.pnlContent.Controls.Add(this.lblTitle);
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Padding = new System.Windows.Forms.Padding(16, 0, 16, 16);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTitle.Padding = new System.Windows.Forms.Padding(4, 14, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(900, 56);
            this.lblTitle.Text = "Manage Complaints";
            this.lblTitle.UseMnemonic = false;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.btnClear);
            this.pnlFilters.Controls.Add(this.btnSearch);
            this.pnlFilters.Controls.Add(this.cboPriority);
            this.pnlFilters.Controls.Add(this.lblPriority);
            this.pnlFilters.Controls.Add(this.cboCategory);
            this.pnlFilters.Controls.Add(this.lblCategory);
            this.pnlFilters.Controls.Add(this.cboStatus);
            this.pnlFilters.Controls.Add(this.lblStatus);
            this.pnlFilters.Controls.Add(this.txtSearch);
            this.pnlFilters.Controls.Add(this.lblSearch);
            this.pnlFilters.BackColor = System.Drawing.Color.White;
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Size = new System.Drawing.Size(1028, 76);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(16, 10);
            this.lblSearch.Text = "Search";
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(16, 32);
            this.txtSearch.Size = new System.Drawing.Size(260, 25);
            this.txtSearch.PlaceholderText = "ID, title or student name";
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(292, 10);
            this.lblStatus.Text = "Status";
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.TabIndex = 2;
            // 
            // cboStatus
            // 
            this.cboStatus.Items.AddRange(new object[] {"All", "New", "Under Review", "In Progress", "Resolved", "Rejected", "Closed"});
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(292, 32);
            this.cboStatus.Size = new System.Drawing.Size(150, 25);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(458, 10);
            this.lblCategory.Text = "Category";
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.TabIndex = 4;
            // 
            // cboCategory
            // 
            this.cboCategory.Items.AddRange(new object[] {"All", "Academic", "Administrative", "Facilities", "IT Services", "Financial", "Student Affairs", "Other"});
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(458, 32);
            this.cboCategory.Size = new System.Drawing.Size(160, 25);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.TabIndex = 5;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(634, 10);
            this.lblPriority.Text = "Priority";
            this.lblPriority.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.TabIndex = 6;
            // 
            // cboPriority
            // 
            this.cboPriority.Items.AddRange(new object[] {"All", "Low", "Medium", "High", "Urgent"});
            this.cboPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.Location = new System.Drawing.Point(634, 32);
            this.cboPriority.Size = new System.Drawing.Size(120, 25);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(772, 29);
            this.btnSearch.Size = new System.Drawing.Size(90, 31);
            this.btnSearch.Text = "Search";
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(870, 29);
            this.btnClear.Size = new System.Drawing.Size(90, 31);
            this.btnClear.Text = "Clear";
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnClear.Name = "btnClear";
            this.btnClear.TabIndex = 9;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pnlGapTop
            // 
            this.pnlGapTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlGapTop.Size = new System.Drawing.Size(1028, 12);
            this.pnlGapTop.Name = "pnlGapTop";
            this.pnlGapTop.TabIndex = 2;
            // 
            // pnlUpdate
            // 
            this.pnlUpdate.Controls.Add(this.btnDeleteComplaint);
            this.pnlUpdate.Controls.Add(this.btnSaveChanges);
            this.pnlUpdate.Controls.Add(this.chkNotify);
            this.pnlUpdate.Controls.Add(this.txtResponse);
            this.pnlUpdate.Controls.Add(this.lblResponse);
            this.pnlUpdate.Controls.Add(this.cboNewPriority);
            this.pnlUpdate.Controls.Add(this.lblNewPriority);
            this.pnlUpdate.Controls.Add(this.cboAssignTo);
            this.pnlUpdate.Controls.Add(this.lblAssignTo);
            this.pnlUpdate.Controls.Add(this.cboNewStatus);
            this.pnlUpdate.Controls.Add(this.lblNewStatus);
            this.pnlUpdate.Controls.Add(this.lblSelected);
            this.pnlUpdate.Controls.Add(this.lblSelectedCap);
            this.pnlUpdate.Controls.Add(this.lblUpdateTitle);
            this.pnlUpdate.BackColor = System.Drawing.Color.White;
            this.pnlUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlUpdate.Size = new System.Drawing.Size(320, 600);
            this.pnlUpdate.Name = "pnlUpdate";
            this.pnlUpdate.TabIndex = 3;
            // 
            // lblUpdateTitle
            // 
            this.lblUpdateTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUpdateTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblUpdateTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblUpdateTitle.Padding = new System.Windows.Forms.Padding(12, 10, 0, 0);
            this.lblUpdateTitle.Size = new System.Drawing.Size(300, 38);
            this.lblUpdateTitle.Text = "Update Complaint";
            this.lblUpdateTitle.Name = "lblUpdateTitle";
            this.lblUpdateTitle.TabIndex = 0;
            // 
            // lblSelectedCap
            // 
            this.lblSelectedCap.AutoSize = true;
            this.lblSelectedCap.Location = new System.Drawing.Point(16, 46);
            this.lblSelectedCap.Text = "Selected complaint";
            this.lblSelectedCap.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSelectedCap.Name = "lblSelectedCap";
            this.lblSelectedCap.TabIndex = 1;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoEllipsis = true;
            this.lblSelected.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSelected.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblSelected.Location = new System.Drawing.Point(16, 66);
            this.lblSelected.Size = new System.Drawing.Size(288, 22);
            this.lblSelected.Text = "-";
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.TabIndex = 2;
            // 
            // lblNewStatus
            // 
            this.lblNewStatus.AutoSize = true;
            this.lblNewStatus.Location = new System.Drawing.Point(16, 100);
            this.lblNewStatus.Text = "Status";
            this.lblNewStatus.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblNewStatus.Name = "lblNewStatus";
            this.lblNewStatus.TabIndex = 3;
            // 
            // cboNewStatus
            // 
            this.cboNewStatus.Items.AddRange(new object[] {"New", "Under Review", "In Progress", "Resolved", "Rejected", "Closed"});
            this.cboNewStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewStatus.FormattingEnabled = true;
            this.cboNewStatus.Location = new System.Drawing.Point(16, 122);
            this.cboNewStatus.Size = new System.Drawing.Size(288, 25);
            this.cboNewStatus.Name = "cboNewStatus";
            this.cboNewStatus.TabIndex = 4;
            // 
            // lblAssignTo
            // 
            this.lblAssignTo.AutoSize = true;
            this.lblAssignTo.Location = new System.Drawing.Point(16, 158);
            this.lblAssignTo.Text = "Assign to";
            this.lblAssignTo.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblAssignTo.Name = "lblAssignTo";
            this.lblAssignTo.TabIndex = 5;
            // 
            // cboAssignTo
            // 
            this.cboAssignTo.Items.AddRange(new object[] {"Unassigned", "IT Support Team", "Academic Affairs", "Facilities Office", "Finance Office", "Student Affairs"});
            this.cboAssignTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAssignTo.FormattingEnabled = true;
            this.cboAssignTo.Location = new System.Drawing.Point(16, 180);
            this.cboAssignTo.Size = new System.Drawing.Size(288, 25);
            this.cboAssignTo.Name = "cboAssignTo";
            this.cboAssignTo.TabIndex = 6;
            // 
            // lblNewPriority
            // 
            this.lblNewPriority.AutoSize = true;
            this.lblNewPriority.Location = new System.Drawing.Point(16, 216);
            this.lblNewPriority.Text = "Priority";
            this.lblNewPriority.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblNewPriority.Name = "lblNewPriority";
            this.lblNewPriority.TabIndex = 7;
            // 
            // cboNewPriority
            // 
            this.cboNewPriority.Items.AddRange(new object[] {"Low", "Medium", "High", "Urgent"});
            this.cboNewPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNewPriority.FormattingEnabled = true;
            this.cboNewPriority.Location = new System.Drawing.Point(16, 238);
            this.cboNewPriority.Size = new System.Drawing.Size(288, 25);
            this.cboNewPriority.Name = "cboNewPriority";
            this.cboNewPriority.TabIndex = 8;
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(16, 274);
            this.lblResponse.Text = "Response to student";
            this.lblResponse.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.TabIndex = 9;
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(16, 296);
            this.txtResponse.Size = new System.Drawing.Size(288, 120);
            this.txtResponse.Multiline = true;
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.PlaceholderText = "Explain what was done or what happens next...";
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.TabIndex = 10;
            // 
            // chkNotify
            // 
            this.chkNotify.AutoSize = true;
            this.chkNotify.Location = new System.Drawing.Point(16, 426);
            this.chkNotify.Text = "Notify the student";
            this.chkNotify.UseVisualStyleBackColor = true;
            this.chkNotify.Checked = true;
            this.chkNotify.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotify.Name = "chkNotify";
            this.chkNotify.TabIndex = 11;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(16, 460);
            this.btnSaveChanges.Size = new System.Drawing.Size(288, 38);
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.TabIndex = 12;
            // 
            // btnDeleteComplaint
            // 
            this.btnDeleteComplaint.Location = new System.Drawing.Point(16, 506);
            this.btnDeleteComplaint.Size = new System.Drawing.Size(288, 34);
            this.btnDeleteComplaint.Text = "Delete Complaint";
            this.btnDeleteComplaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteComplaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteComplaint.UseVisualStyleBackColor = false;
            this.btnDeleteComplaint.BackColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnDeleteComplaint.ForeColor = System.Drawing.Color.White;
            this.btnDeleteComplaint.FlatAppearance.BorderSize = 0;
            this.btnDeleteComplaint.Name = "btnDeleteComplaint";
            this.btnDeleteComplaint.TabIndex = 13;
            // 
            // pnlGapRight
            // 
            this.pnlGapRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlGapRight.Size = new System.Drawing.Size(12, 600);
            this.pnlGapRight.Name = "pnlGapRight";
            this.pnlGapRight.TabIndex = 4;
            // 
            // pnlListCard
            // 
            this.pnlListCard.Controls.Add(this.dgvComplaints);
            this.pnlListCard.Controls.Add(this.pnlListHead);
            this.pnlListCard.BackColor = System.Drawing.Color.White;
            this.pnlListCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlListCard.Name = "pnlListCard";
            this.pnlListCard.TabIndex = 5;
            // 
            // pnlListHead
            // 
            this.pnlListHead.Controls.Add(this.lblCount);
            this.pnlListHead.Controls.Add(this.lblListTitle);
            this.pnlListHead.BackColor = System.Drawing.Color.White;
            this.pnlListHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListHead.Size = new System.Drawing.Size(696, 40);
            this.pnlListHead.Name = "pnlListHead";
            this.pnlListHead.TabIndex = 0;
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Location = new System.Drawing.Point(12, 10);
            this.lblListTitle.Text = "All Complaints";
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.TabIndex = 0;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(560, 13);
            this.lblCount.Text = "0 complaints";
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCount.Name = "lblCount";
            this.lblCount.TabIndex = 1;
            // 
            // dgvComplaints
            // 
            this.dgvComplaints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colTitle,
            this.colStudent,
            this.colCategory,
            this.colStatus,
            this.colPriority,
            this.colAssignedTo,
            this.colSubmitted});
            this.dgvComplaints.AllowUserToAddRows = false;
            this.dgvComplaints.AllowUserToDeleteRows = false;
            this.dgvComplaints.AllowUserToResizeRows = false;
            this.dgvComplaints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComplaints.BackgroundColor = System.Drawing.Color.White;
            this.dgvComplaints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvComplaints.ColumnHeadersHeight = 36;
            this.dgvComplaints.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvComplaints.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvComplaints.MultiSelect = false;
            this.dgvComplaints.ReadOnly = true;
            this.dgvComplaints.RowHeadersVisible = false;
            this.dgvComplaints.RowTemplate.Height = 30;
            this.dgvComplaints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComplaints.Name = "dgvComplaints";
            this.dgvComplaints.TabIndex = 1;
            this.dgvComplaints.SelectionChanged += new System.EventHandler(this.dgvComplaints_SelectionChanged);
            // 
            // colId
            // 
            this.colId.FillWeight = 50F;
            this.colId.HeaderText = "ID";
            this.colId.ReadOnly = true;
            this.colId.Name = "colId";
            // 
            // colTitle
            // 
            this.colTitle.FillWeight = 190F;
            this.colTitle.HeaderText = "Title";
            this.colTitle.ReadOnly = true;
            this.colTitle.Name = "colTitle";
            // 
            // colStudent
            // 
            this.colStudent.FillWeight = 120F;
            this.colStudent.HeaderText = "Student";
            this.colStudent.ReadOnly = true;
            this.colStudent.Name = "colStudent";
            // 
            // colCategory
            // 
            this.colCategory.FillWeight = 100F;
            this.colCategory.HeaderText = "Category";
            this.colCategory.ReadOnly = true;
            this.colCategory.Name = "colCategory";
            // 
            // colStatus
            // 
            this.colStatus.FillWeight = 95F;
            this.colStatus.HeaderText = "Status";
            this.colStatus.ReadOnly = true;
            this.colStatus.Name = "colStatus";
            // 
            // colPriority
            // 
            this.colPriority.FillWeight = 70F;
            this.colPriority.HeaderText = "Priority";
            this.colPriority.ReadOnly = true;
            this.colPriority.Name = "colPriority";
            // 
            // colAssignedTo
            // 
            this.colAssignedTo.FillWeight = 120F;
            this.colAssignedTo.HeaderText = "Assigned To";
            this.colAssignedTo.ReadOnly = true;
            this.colAssignedTo.Name = "colAssignedTo";
            // 
            // colSubmitted
            // 
            this.colSubmitted.FillWeight = 85F;
            this.colSubmitted.HeaderText = "Submitted";
            this.colSubmitted.ReadOnly = true;
            this.colSubmitted.Name = "colSubmitted";
            // 
            // ManageComplaintsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Complaints - Student Complaint Tracking System";
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "ManageComplaintsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComplaints)).EndInit();
            this.pnlListHead.ResumeLayout(false);
            this.pnlListHead.PerformLayout();
            this.pnlListCard.ResumeLayout(false);
            this.pnlListCard.PerformLayout();
            this.pnlGapRight.ResumeLayout(false);
            this.pnlGapRight.PerformLayout();
            this.pnlUpdate.ResumeLayout(false);
            this.pnlUpdate.PerformLayout();
            this.pnlGapTop.ResumeLayout(false);
            this.pnlGapTop.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblSideTitle;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSubmitComplaints;
        private System.Windows.Forms.Button btnMyComplaints;
        private System.Windows.Forms.Button btnAdminDashboard;
        private System.Windows.Forms.Button btnManageComplaints;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cboPriority;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlGapTop;
        private System.Windows.Forms.Panel pnlUpdate;
        private System.Windows.Forms.Label lblUpdateTitle;
        private System.Windows.Forms.Label lblSelectedCap;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblNewStatus;
        private System.Windows.Forms.ComboBox cboNewStatus;
        private System.Windows.Forms.Label lblAssignTo;
        private System.Windows.Forms.ComboBox cboAssignTo;
        private System.Windows.Forms.Label lblNewPriority;
        private System.Windows.Forms.ComboBox cboNewPriority;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.CheckBox chkNotify;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnDeleteComplaint;
        private System.Windows.Forms.Panel pnlGapRight;
        private System.Windows.Forms.Panel pnlListCard;
        private System.Windows.Forms.Panel pnlListHead;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dgvComplaints;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAssignedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubmitted;
    }
}
