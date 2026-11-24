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
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnManageComplaints = new Button();
            btnAdminDashboard = new Button();
            btnDashboard = new Button();
            lblSideTitle = new Label();
            pnlContent = new Panel();
            pnlListCard = new Panel();
            dgvComplaints = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colStudent = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colPriority = new DataGridViewTextBoxColumn();
            colAssignedTo = new DataGridViewTextBoxColumn();
            colSubmitted = new DataGridViewTextBoxColumn();
            pnlListHead = new Panel();
            lblCount = new Label();
            lblListTitle = new Label();
            pnlGapRight = new Panel();
            pnlUpdate = new Panel();
            btnDeleteComplaint = new Button();
            btnSaveChanges = new Button();
            chkNotify = new CheckBox();
            txtResponse = new TextBox();
            lblResponse = new Label();
            cboNewPriority = new ComboBox();
            lblNewPriority = new Label();
            cboAssignTo = new ComboBox();
            lblAssignTo = new Label();
            cboNewStatus = new ComboBox();
            lblNewStatus = new Label();
            lblSelected = new Label();
            lblSelectedCap = new Label();
            lblUpdateTitle = new Label();
            pnlGapTop = new Panel();
            pnlFilters = new Panel();
            btnClear = new Button();
            btnSearch = new Button();
            cboPriority = new ComboBox();
            lblPriority = new Label();
            cboCategory = new ComboBox();
            lblCategory = new Label();
            cboStatus = new ComboBox();
            lblStatus = new Label();
            txtSearch = new TextBox();
            lblSearch = new Label();
            lblTitle = new Label();
            pnlSidebar.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlListCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComplaints).BeginInit();
            pnlListHead.SuspendLayout();
            pnlUpdate.SuspendLayout();
            pnlFilters.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.FromArgb(22, 30, 100);
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnManageComplaints);
            pnlSidebar.Controls.Add(btnAdminDashboard);
            pnlSidebar.Controls.Add(btnDashboard);
            pnlSidebar.Controls.Add(lblSideTitle);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(220, 760);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Paint += pnlSidebar_Paint;
            pnlSidebar.Resize += pnlSidebar_Resize;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.BackColor = Color.FromArgb(36, 52, 145);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(190, 198, 230);
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 52, 140);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(20, 696);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(180, 40);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnManageComplaints
            // 
            btnManageComplaints.BackColor = Color.FromArgb(20, 26, 90);
            btnManageComplaints.Cursor = Cursors.Hand;
            btnManageComplaints.FlatAppearance.BorderColor = Color.White;
            btnManageComplaints.FlatAppearance.BorderSize = 2;
            btnManageComplaints.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 52, 140);
            btnManageComplaints.FlatStyle = FlatStyle.Flat;
            btnManageComplaints.Font = new Font("Segoe UI", 10F);
            btnManageComplaints.ForeColor = Color.White;
            btnManageComplaints.Location = new Point(20, 384);
            btnManageComplaints.Name = "btnManageComplaints";
            btnManageComplaints.Size = new Size(180, 40);
            btnManageComplaints.TabIndex = 5;
            btnManageComplaints.Text = "Manage Complaints";
            btnManageComplaints.UseVisualStyleBackColor = false;
            // 
            // btnAdminDashboard
            // 
            btnAdminDashboard.BackColor = Color.FromArgb(20, 26, 90);
            btnAdminDashboard.Cursor = Cursors.Hand;
            btnAdminDashboard.FlatAppearance.BorderColor = Color.FromArgb(190, 198, 230);
            btnAdminDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 52, 140);
            btnAdminDashboard.FlatStyle = FlatStyle.Flat;
            btnAdminDashboard.Font = new Font("Segoe UI", 10F);
            btnAdminDashboard.ForeColor = Color.White;
            btnAdminDashboard.Location = new Point(20, 266);
            btnAdminDashboard.Name = "btnAdminDashboard";
            btnAdminDashboard.Size = new Size(180, 40);
            btnAdminDashboard.TabIndex = 4;
            btnAdminDashboard.Text = "Admin Dashboard";
            btnAdminDashboard.UseVisualStyleBackColor = false;
            btnAdminDashboard.Click += btnAdminDashboard_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(20, 26, 90);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderColor = Color.FromArgb(190, 198, 230);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 52, 140);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(20, 140);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(180, 40);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // lblSideTitle
            // 
            lblSideTitle.BackColor = Color.Transparent;
            lblSideTitle.Font = new Font("Segoe UI", 10.5F);
            lblSideTitle.ForeColor = Color.White;
            lblSideTitle.Location = new Point(0, 40);
            lblSideTitle.Name = "lblSideTitle";
            lblSideTitle.Size = new Size(220, 40);
            lblSideTitle.TabIndex = 0;
            lblSideTitle.Text = "Student Complaints";
            lblSideTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(241, 245, 249);
            pnlContent.Controls.Add(pnlListCard);
            pnlContent.Controls.Add(pnlGapRight);
            pnlContent.Controls.Add(pnlUpdate);
            pnlContent.Controls.Add(pnlGapTop);
            pnlContent.Controls.Add(pnlFilters);
            pnlContent.Controls.Add(lblTitle);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(220, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(16, 0, 16, 16);
            pnlContent.Size = new Size(1060, 760);
            pnlContent.TabIndex = 1;
            // 
            // pnlListCard
            // 
            pnlListCard.BackColor = Color.White;
            pnlListCard.Controls.Add(dgvComplaints);
            pnlListCard.Controls.Add(pnlListHead);
            pnlListCard.Dock = DockStyle.Fill;
            pnlListCard.Location = new Point(16, 144);
            pnlListCard.Name = "pnlListCard";
            pnlListCard.Size = new Size(696, 600);
            pnlListCard.TabIndex = 5;
            // 
            // dgvComplaints
            // 
            dgvComplaints.AllowUserToAddRows = false;
            dgvComplaints.AllowUserToDeleteRows = false;
            dgvComplaints.AllowUserToResizeRows = false;
            dgvComplaints.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComplaints.BackgroundColor = Color.White;
            dgvComplaints.BorderStyle = BorderStyle.None;
            dgvComplaints.ColumnHeadersHeight = 36;
            dgvComplaints.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvComplaints.Columns.AddRange(new DataGridViewColumn[] { colId, colTitle, colStudent, colCategory, colStatus, colPriority, colAssignedTo, colSubmitted });
            dgvComplaints.Dock = DockStyle.Fill;
            dgvComplaints.GridColor = Color.FromArgb(226, 232, 240);
            dgvComplaints.Location = new Point(0, 40);
            dgvComplaints.MultiSelect = false;
            dgvComplaints.Name = "dgvComplaints";
            dgvComplaints.ReadOnly = true;
            dgvComplaints.RowHeadersVisible = false;
            dgvComplaints.RowHeadersWidth = 51;
            dgvComplaints.RowTemplate.Height = 30;
            dgvComplaints.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComplaints.Size = new Size(696, 560);
            dgvComplaints.TabIndex = 1;
            dgvComplaints.SelectionChanged += dgvComplaints_SelectionChanged;
            // 
            // colId
            // 
            colId.FillWeight = 50F;
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colTitle
            // 
            colTitle.FillWeight = 190F;
            colTitle.HeaderText = "Title";
            colTitle.MinimumWidth = 6;
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // colStudent
            // 
            colStudent.FillWeight = 120F;
            colStudent.HeaderText = "Student";
            colStudent.MinimumWidth = 6;
            colStudent.Name = "colStudent";
            colStudent.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 6;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 95F;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colPriority
            // 
            colPriority.FillWeight = 70F;
            colPriority.HeaderText = "Priority";
            colPriority.MinimumWidth = 6;
            colPriority.Name = "colPriority";
            colPriority.ReadOnly = true;
            // 
            // colAssignedTo
            // 
            colAssignedTo.FillWeight = 120F;
            colAssignedTo.HeaderText = "Assigned To";
            colAssignedTo.MinimumWidth = 6;
            colAssignedTo.Name = "colAssignedTo";
            colAssignedTo.ReadOnly = true;
            // 
            // colSubmitted
            // 
            colSubmitted.FillWeight = 85F;
            colSubmitted.HeaderText = "Submitted";
            colSubmitted.MinimumWidth = 6;
            colSubmitted.Name = "colSubmitted";
            colSubmitted.ReadOnly = true;
            // 
            // pnlListHead
            // 
            pnlListHead.BackColor = Color.White;
            pnlListHead.Controls.Add(lblCount);
            pnlListHead.Controls.Add(lblListTitle);
            pnlListHead.Dock = DockStyle.Top;
            pnlListHead.Location = new Point(0, 0);
            pnlListHead.Name = "pnlListHead";
            pnlListHead.Size = new Size(696, 40);
            pnlListHead.TabIndex = 0;
            // 
            // lblCount
            // 
            lblCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCount.AutoSize = true;
            lblCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblCount.Location = new Point(396, 13);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(107, 23);
            lblCount.TabIndex = 1;
            lblCount.Text = "0 complaints";
            // 
            // lblListTitle
            // 
            lblListTitle.AutoSize = true;
            lblListTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblListTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblListTitle.Location = new Point(12, 10);
            lblListTitle.Name = "lblListTitle";
            lblListTitle.Size = new Size(140, 25);
            lblListTitle.TabIndex = 0;
            lblListTitle.Text = "All Complaints";
            // 
            // pnlGapRight
            // 
            pnlGapRight.Dock = DockStyle.Right;
            pnlGapRight.Location = new Point(712, 144);
            pnlGapRight.Name = "pnlGapRight";
            pnlGapRight.Size = new Size(12, 600);
            pnlGapRight.TabIndex = 4;
            // 
            // pnlUpdate
            // 
            pnlUpdate.BackColor = Color.White;
            pnlUpdate.Controls.Add(btnDeleteComplaint);
            pnlUpdate.Controls.Add(btnSaveChanges);
            pnlUpdate.Controls.Add(chkNotify);
            pnlUpdate.Controls.Add(txtResponse);
            pnlUpdate.Controls.Add(lblResponse);
            pnlUpdate.Controls.Add(cboNewPriority);
            pnlUpdate.Controls.Add(lblNewPriority);
            pnlUpdate.Controls.Add(cboAssignTo);
            pnlUpdate.Controls.Add(lblAssignTo);
            pnlUpdate.Controls.Add(cboNewStatus);
            pnlUpdate.Controls.Add(lblNewStatus);
            pnlUpdate.Controls.Add(lblSelected);
            pnlUpdate.Controls.Add(lblSelectedCap);
            pnlUpdate.Controls.Add(lblUpdateTitle);
            pnlUpdate.Dock = DockStyle.Right;
            pnlUpdate.Location = new Point(724, 144);
            pnlUpdate.Name = "pnlUpdate";
            pnlUpdate.Size = new Size(320, 600);
            pnlUpdate.TabIndex = 3;
            // 
            // btnDeleteComplaint
            // 
            btnDeleteComplaint.BackColor = Color.FromArgb(220, 38, 38);
            btnDeleteComplaint.Cursor = Cursors.Hand;
            btnDeleteComplaint.FlatAppearance.BorderSize = 0;
            btnDeleteComplaint.FlatStyle = FlatStyle.Flat;
            btnDeleteComplaint.ForeColor = Color.White;
            btnDeleteComplaint.Location = new Point(16, 506);
            btnDeleteComplaint.Name = "btnDeleteComplaint";
            btnDeleteComplaint.Size = new Size(288, 34);
            btnDeleteComplaint.TabIndex = 13;
            btnDeleteComplaint.Text = "Resolved Complaint";
            btnDeleteComplaint.UseVisualStyleBackColor = false;
            btnDeleteComplaint.Click += btnDeleteComplaint_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.FromArgb(37, 99, 235);
            btnSaveChanges.Cursor = Cursors.Hand;
            btnSaveChanges.FlatAppearance.BorderSize = 0;
            btnSaveChanges.FlatStyle = FlatStyle.Flat;
            btnSaveChanges.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSaveChanges.ForeColor = Color.White;
            btnSaveChanges.Location = new Point(16, 460);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(288, 38);
            btnSaveChanges.TabIndex = 12;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = false;
            // 
            // chkNotify
            // 
            chkNotify.AutoSize = true;
            chkNotify.Checked = true;
            chkNotify.CheckState = CheckState.Checked;
            chkNotify.Location = new Point(16, 426);
            chkNotify.Name = "chkNotify";
            chkNotify.Size = new Size(171, 27);
            chkNotify.TabIndex = 11;
            chkNotify.Text = "Notify the student";
            chkNotify.UseVisualStyleBackColor = true;
            // 
            // txtResponse
            // 
            txtResponse.Location = new Point(16, 296);
            txtResponse.Multiline = true;
            txtResponse.Name = "txtResponse";
            txtResponse.PlaceholderText = "Explain what was done or what happens next...";
            txtResponse.ScrollBars = ScrollBars.Vertical;
            txtResponse.Size = new Size(288, 120);
            txtResponse.TabIndex = 10;
            // 
            // lblResponse
            // 
            lblResponse.AutoSize = true;
            lblResponse.ForeColor = Color.FromArgb(51, 65, 85);
            lblResponse.Location = new Point(16, 274);
            lblResponse.Name = "lblResponse";
            lblResponse.Size = new Size(166, 23);
            lblResponse.TabIndex = 9;
            lblResponse.Text = "Response to student";
            // 
            // cboNewPriority
            // 
            cboNewPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNewPriority.FormattingEnabled = true;
            cboNewPriority.Items.AddRange(new object[] { "Low", "Medium", "High", "Urgent" });
            cboNewPriority.Location = new Point(16, 238);
            cboNewPriority.Name = "cboNewPriority";
            cboNewPriority.Size = new Size(288, 29);
            cboNewPriority.TabIndex = 8;
            // 
            // lblNewPriority
            // 
            lblNewPriority.AutoSize = true;
            lblNewPriority.ForeColor = Color.FromArgb(51, 65, 85);
            lblNewPriority.Location = new Point(16, 216);
            lblNewPriority.Name = "lblNewPriority";
            lblNewPriority.Size = new Size(64, 23);
            lblNewPriority.TabIndex = 7;
            lblNewPriority.Text = "Priority";
            // 
            // cboAssignTo
            // 
            cboAssignTo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAssignTo.FormattingEnabled = true;
            cboAssignTo.Items.AddRange(new object[] { "Unassigned", "IT Support Team", "Academic Affairs", "Facilities Office", "Finance Office", "Student Affairs" });
            cboAssignTo.Location = new Point(16, 180);
            cboAssignTo.Name = "cboAssignTo";
            cboAssignTo.Size = new Size(288, 29);
            cboAssignTo.TabIndex = 6;
            // 
            // lblAssignTo
            // 
            lblAssignTo.AutoSize = true;
            lblAssignTo.ForeColor = Color.FromArgb(51, 65, 85);
            lblAssignTo.Location = new Point(16, 158);
            lblAssignTo.Name = "lblAssignTo";
            lblAssignTo.Size = new Size(80, 23);
            lblAssignTo.TabIndex = 5;
            lblAssignTo.Text = "Assign to";
            // 
            // cboNewStatus
            // 
            cboNewStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNewStatus.FormattingEnabled = true;
            cboNewStatus.Items.AddRange(new object[] { "New", "Under Review", "In Progress", "Resolved", "Rejected", "Closed" });
            cboNewStatus.Location = new Point(16, 122);
            cboNewStatus.Name = "cboNewStatus";
            cboNewStatus.Size = new Size(288, 29);
            cboNewStatus.TabIndex = 4;
            // 
            // lblNewStatus
            // 
            lblNewStatus.AutoSize = true;
            lblNewStatus.ForeColor = Color.FromArgb(51, 65, 85);
            lblNewStatus.Location = new Point(16, 100);
            lblNewStatus.Name = "lblNewStatus";
            lblNewStatus.Size = new Size(56, 23);
            lblNewStatus.TabIndex = 3;
            lblNewStatus.Text = "Status";
            // 
            // lblSelected
            // 
            lblSelected.AutoEllipsis = true;
            lblSelected.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSelected.ForeColor = Color.FromArgb(15, 23, 42);
            lblSelected.Location = new Point(16, 66);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(288, 22);
            lblSelected.TabIndex = 2;
            lblSelected.Text = "-";
            // 
            // lblSelectedCap
            // 
            lblSelectedCap.AutoSize = true;
            lblSelectedCap.ForeColor = Color.FromArgb(100, 116, 139);
            lblSelectedCap.Location = new Point(16, 46);
            lblSelectedCap.Name = "lblSelectedCap";
            lblSelectedCap.Size = new Size(155, 23);
            lblSelectedCap.TabIndex = 1;
            lblSelectedCap.Text = "Selected complaint";
            // 
            // lblUpdateTitle
            // 
            lblUpdateTitle.Dock = DockStyle.Top;
            lblUpdateTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblUpdateTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblUpdateTitle.Location = new Point(0, 0);
            lblUpdateTitle.Name = "lblUpdateTitle";
            lblUpdateTitle.Padding = new Padding(12, 10, 0, 0);
            lblUpdateTitle.Size = new Size(320, 38);
            lblUpdateTitle.TabIndex = 0;
            lblUpdateTitle.Text = "Update Complaint";
            // 
            // pnlGapTop
            // 
            pnlGapTop.Dock = DockStyle.Top;
            pnlGapTop.Location = new Point(16, 132);
            pnlGapTop.Name = "pnlGapTop";
            pnlGapTop.Size = new Size(1028, 12);
            pnlGapTop.TabIndex = 2;
            // 
            // pnlFilters
            // 
            pnlFilters.BackColor = Color.White;
            pnlFilters.Controls.Add(btnClear);
            pnlFilters.Controls.Add(btnSearch);
            pnlFilters.Controls.Add(cboPriority);
            pnlFilters.Controls.Add(lblPriority);
            pnlFilters.Controls.Add(cboCategory);
            pnlFilters.Controls.Add(lblCategory);
            pnlFilters.Controls.Add(cboStatus);
            pnlFilters.Controls.Add(lblStatus);
            pnlFilters.Controls.Add(txtSearch);
            pnlFilters.Controls.Add(lblSearch);
            pnlFilters.Dock = DockStyle.Top;
            pnlFilters.Location = new Point(16, 56);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Size = new Size(1028, 76);
            pnlFilters.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.White;
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.ForeColor = Color.FromArgb(15, 23, 42);
            btnClear.Location = new Point(870, 29);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 31);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(37, 99, 235);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(772, 29);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 31);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // cboPriority
            // 
            cboPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPriority.FormattingEnabled = true;
            cboPriority.Items.AddRange(new object[] { "All", "Low", "Medium", "High", "Urgent" });
            cboPriority.Location = new Point(634, 32);
            cboPriority.Name = "cboPriority";
            cboPriority.Size = new Size(120, 29);
            cboPriority.TabIndex = 7;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.ForeColor = Color.FromArgb(51, 65, 85);
            lblPriority.Location = new Point(634, 10);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(64, 23);
            lblPriority.TabIndex = 6;
            lblPriority.Text = "Priority";
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "All", "Academic", "Administrative", "Facilities", "IT Services", "Financial", "Student Affairs", "Other" });
            cboCategory.Location = new Point(458, 32);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(160, 29);
            cboCategory.TabIndex = 5;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.ForeColor = Color.FromArgb(51, 65, 85);
            lblCategory.Location = new Point(458, 10);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(79, 23);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Category";
            // 
            // cboStatus
            // 
            cboStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStatus.FormattingEnabled = true;
            cboStatus.Items.AddRange(new object[] { "All", "New", "Under Review", "In Progress", "Resolved", "Rejected", "Closed" });
            cboStatus.Location = new Point(292, 32);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(150, 29);
            cboStatus.TabIndex = 3;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.ForeColor = Color.FromArgb(51, 65, 85);
            lblStatus.Location = new Point(292, 10);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(56, 23);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Status";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(16, 32);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "ID, title or student name";
            txtSearch.Size = new Size(260, 29);
            txtSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.ForeColor = Color.FromArgb(51, 65, 85);
            lblSearch.Location = new Point(16, 10);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(61, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTitle.Location = new Point(16, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new Padding(4, 14, 0, 0);
            lblTitle.Size = new Size(1028, 56);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Manage Complaints";
            lblTitle.UseMnemonic = false;
            // 
            // ManageComplaintsForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1280, 760);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9.75F);
            MinimumSize = new Size(1200, 700);
            Name = "ManageComplaintsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Complaints - Student Complaint Tracking System";
            pnlSidebar.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            pnlListCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvComplaints).EndInit();
            pnlListHead.ResumeLayout(false);
            pnlListHead.PerformLayout();
            pnlUpdate.ResumeLayout(false);
            pnlUpdate.PerformLayout();
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblSideTitle;
        private System.Windows.Forms.Button btnDashboard;
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
