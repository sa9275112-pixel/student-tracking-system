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
            pnlContent = new Panel();
            pnlRecentWrap = new Panel();
            pnlRecent = new Panel();
            dgvRecent = new DataGridView();
            colRecentId = new DataGridViewTextBoxColumn();
            colRecentTitle = new DataGridViewTextBoxColumn();
            colRecentStudent = new DataGridViewTextBoxColumn();
            colRecentCategory = new DataGridViewTextBoxColumn();
            colRecentStatus = new DataGridViewTextBoxColumn();
            colRecentPriority = new DataGridViewTextBoxColumn();
            colRecentDate = new DataGridViewTextBoxColumn();
            lblRecentTitle = new Label();
            tlpCharts = new TableLayoutPanel();
            cardChartStatus = new Panel();
            pnlChartStatus = new Panel();
            lblChartStatusTitle = new Label();
            cardChartCategory = new Panel();
            pnlChartCategory = new Panel();
            lblChartCategoryTitle = new Label();
            tlpCards = new TableLayoutPanel();
            cardTotal = new Panel();
            lblValTotal = new Label();
            lblCapTotal = new Label();
            pnlAccentTotal = new Panel();
            cardOpen = new Panel();
            lblValOpen = new Label();
            lblCapOpen = new Label();
            pnlAccentOpen = new Panel();
            cardInProgress = new Panel();
            lblValInProgress = new Label();
            lblCapInProgress = new Label();
            pnlAccentInProgress = new Panel();
            cardResolved = new Panel();
            lblValResolved = new Label();
            lblCapResolved = new Label();
            pnlAccentResolved = new Panel();
            lblTitle = new Label();
            lblSideTitle = new Label();
            btnDashboard = new Button();
            btnAdminDashboard = new Button();
            btnManageComplaints = new Button();
            btnLogout = new Button();
            pnlSidebar = new Panel();
            pnlContent.SuspendLayout();
            pnlRecentWrap.SuspendLayout();
            pnlRecent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecent).BeginInit();
            tlpCharts.SuspendLayout();
            cardChartStatus.SuspendLayout();
            cardChartCategory.SuspendLayout();
            tlpCards.SuspendLayout();
            cardTotal.SuspendLayout();
            cardOpen.SuspendLayout();
            cardInProgress.SuspendLayout();
            cardResolved.SuspendLayout();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(241, 245, 249);
            pnlContent.Controls.Add(pnlRecentWrap);
            pnlContent.Controls.Add(tlpCharts);
            pnlContent.Controls.Add(tlpCards);
            pnlContent.Controls.Add(lblTitle);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(220, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(16, 0, 16, 16);
            pnlContent.Size = new Size(1060, 760);
            pnlContent.TabIndex = 1;
            // 
            // pnlRecentWrap
            // 
            pnlRecentWrap.Controls.Add(pnlRecent);
            pnlRecentWrap.Dock = DockStyle.Fill;
            pnlRecentWrap.Location = new Point(16, 466);
            pnlRecentWrap.Name = "pnlRecentWrap";
            pnlRecentWrap.Padding = new Padding(0, 8, 0, 0);
            pnlRecentWrap.Size = new Size(1028, 278);
            pnlRecentWrap.TabIndex = 3;
            // 
            // pnlRecent
            // 
            pnlRecent.BackColor = Color.White;
            pnlRecent.Controls.Add(dgvRecent);
            pnlRecent.Controls.Add(lblRecentTitle);
            pnlRecent.Dock = DockStyle.Fill;
            pnlRecent.Location = new Point(0, 8);
            pnlRecent.Name = "pnlRecent";
            pnlRecent.Size = new Size(1028, 270);
            pnlRecent.TabIndex = 0;
            // 
            // dgvRecent
            // 
            dgvRecent.AllowUserToAddRows = false;
            dgvRecent.AllowUserToDeleteRows = false;
            dgvRecent.AllowUserToResizeRows = false;
            dgvRecent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecent.BackgroundColor = Color.White;
            dgvRecent.BorderStyle = BorderStyle.None;
            dgvRecent.ColumnHeadersHeight = 36;
            dgvRecent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRecent.Columns.AddRange(new DataGridViewColumn[] { colRecentId, colRecentTitle, colRecentStudent, colRecentCategory, colRecentStatus, colRecentPriority, colRecentDate });
            dgvRecent.Dock = DockStyle.Fill;
            dgvRecent.GridColor = Color.FromArgb(226, 232, 240);
            dgvRecent.Location = new Point(0, 38);
            dgvRecent.MultiSelect = false;
            dgvRecent.Name = "dgvRecent";
            dgvRecent.ReadOnly = true;
            dgvRecent.RowHeadersVisible = false;
            dgvRecent.RowHeadersWidth = 51;
            dgvRecent.RowTemplate.Height = 30;
            dgvRecent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecent.Size = new Size(1028, 232);
            dgvRecent.TabIndex = 1;
            // 
            // colRecentId
            // 
            colRecentId.FillWeight = 50F;
            colRecentId.HeaderText = "ID";
            colRecentId.MinimumWidth = 6;
            colRecentId.Name = "colRecentId";
            colRecentId.ReadOnly = true;
            // 
            // colRecentTitle
            // 
            colRecentTitle.FillWeight = 200F;
            colRecentTitle.HeaderText = "Title";
            colRecentTitle.MinimumWidth = 6;
            colRecentTitle.Name = "colRecentTitle";
            colRecentTitle.ReadOnly = true;
            // 
            // colRecentStudent
            // 
            colRecentStudent.FillWeight = 130F;
            colRecentStudent.HeaderText = "Student";
            colRecentStudent.MinimumWidth = 6;
            colRecentStudent.Name = "colRecentStudent";
            colRecentStudent.ReadOnly = true;
            // 
            // colRecentCategory
            // 
            colRecentCategory.HeaderText = "Category";
            colRecentCategory.MinimumWidth = 6;
            colRecentCategory.Name = "colRecentCategory";
            colRecentCategory.ReadOnly = true;
            // 
            // colRecentStatus
            // 
            colRecentStatus.FillWeight = 90F;
            colRecentStatus.HeaderText = "Status";
            colRecentStatus.MinimumWidth = 6;
            colRecentStatus.Name = "colRecentStatus";
            colRecentStatus.ReadOnly = true;
            // 
            // colRecentPriority
            // 
            colRecentPriority.FillWeight = 80F;
            colRecentPriority.HeaderText = "Priority";
            colRecentPriority.MinimumWidth = 6;
            colRecentPriority.Name = "colRecentPriority";
            colRecentPriority.ReadOnly = true;
            // 
            // colRecentDate
            // 
            colRecentDate.FillWeight = 90F;
            colRecentDate.HeaderText = "Submitted";
            colRecentDate.MinimumWidth = 6;
            colRecentDate.Name = "colRecentDate";
            colRecentDate.ReadOnly = true;
            // 
            // lblRecentTitle
            // 
            lblRecentTitle.Dock = DockStyle.Top;
            lblRecentTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblRecentTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblRecentTitle.Location = new Point(0, 0);
            lblRecentTitle.Name = "lblRecentTitle";
            lblRecentTitle.Padding = new Padding(12, 10, 0, 0);
            lblRecentTitle.Size = new Size(1028, 38);
            lblRecentTitle.TabIndex = 0;
            lblRecentTitle.Text = "Recent Complaints";
            // 
            // tlpCharts
            // 
            tlpCharts.ColumnCount = 2;
            tlpCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCharts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpCharts.Controls.Add(cardChartStatus, 0, 0);
            tlpCharts.Controls.Add(cardChartCategory, 1, 0);
            tlpCharts.Dock = DockStyle.Top;
            tlpCharts.Location = new Point(16, 176);
            tlpCharts.Name = "tlpCharts";
            tlpCharts.RowCount = 1;
            tlpCharts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCharts.Size = new Size(1028, 290);
            tlpCharts.TabIndex = 2;
            // 
            // cardChartStatus
            // 
            cardChartStatus.BackColor = Color.White;
            cardChartStatus.Controls.Add(pnlChartStatus);
            cardChartStatus.Controls.Add(lblChartStatusTitle);
            cardChartStatus.Dock = DockStyle.Fill;
            cardChartStatus.Location = new Point(0, 8);
            cardChartStatus.Margin = new Padding(0, 8, 6, 8);
            cardChartStatus.Name = "cardChartStatus";
            cardChartStatus.Size = new Size(508, 274);
            cardChartStatus.TabIndex = 0;
            // 
            // pnlChartStatus
            // 
            pnlChartStatus.BackColor = Color.White;
            pnlChartStatus.Dock = DockStyle.Fill;
            pnlChartStatus.Location = new Point(0, 38);
            pnlChartStatus.Name = "pnlChartStatus";
            pnlChartStatus.Size = new Size(508, 236);
            pnlChartStatus.TabIndex = 1;
            // 
            // lblChartStatusTitle
            // 
            lblChartStatusTitle.Dock = DockStyle.Top;
            lblChartStatusTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblChartStatusTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblChartStatusTitle.Location = new Point(0, 0);
            lblChartStatusTitle.Name = "lblChartStatusTitle";
            lblChartStatusTitle.Padding = new Padding(12, 10, 0, 0);
            lblChartStatusTitle.Size = new Size(508, 38);
            lblChartStatusTitle.TabIndex = 0;
            lblChartStatusTitle.Text = "Complaints by Status";
            // 
            // cardChartCategory
            // 
            cardChartCategory.BackColor = Color.White;
            cardChartCategory.Controls.Add(pnlChartCategory);
            cardChartCategory.Controls.Add(lblChartCategoryTitle);
            cardChartCategory.Dock = DockStyle.Fill;
            cardChartCategory.Location = new Point(520, 8);
            cardChartCategory.Margin = new Padding(6, 8, 0, 8);
            cardChartCategory.Name = "cardChartCategory";
            cardChartCategory.Size = new Size(508, 274);
            cardChartCategory.TabIndex = 1;
            // 
            // pnlChartCategory
            // 
            pnlChartCategory.BackColor = Color.White;
            pnlChartCategory.Dock = DockStyle.Fill;
            pnlChartCategory.Location = new Point(0, 38);
            pnlChartCategory.Name = "pnlChartCategory";
            pnlChartCategory.Size = new Size(508, 236);
            pnlChartCategory.TabIndex = 1;
            // 
            // lblChartCategoryTitle
            // 
            lblChartCategoryTitle.Dock = DockStyle.Top;
            lblChartCategoryTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblChartCategoryTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblChartCategoryTitle.Location = new Point(0, 0);
            lblChartCategoryTitle.Name = "lblChartCategoryTitle";
            lblChartCategoryTitle.Padding = new Padding(12, 10, 0, 0);
            lblChartCategoryTitle.Size = new Size(508, 38);
            lblChartCategoryTitle.TabIndex = 0;
            lblChartCategoryTitle.Text = "Complaints by Category";
            // 
            // tlpCards
            // 
            tlpCards.ColumnCount = 4;
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlpCards.Controls.Add(cardTotal, 0, 0);
            tlpCards.Controls.Add(cardOpen, 1, 0);
            tlpCards.Controls.Add(cardInProgress, 2, 0);
            tlpCards.Controls.Add(cardResolved, 3, 0);
            tlpCards.Dock = DockStyle.Top;
            tlpCards.Location = new Point(16, 56);
            tlpCards.Margin = new Padding(0);
            tlpCards.Name = "tlpCards";
            tlpCards.RowCount = 1;
            tlpCards.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpCards.Size = new Size(1028, 120);
            tlpCards.TabIndex = 1;
            // 
            // cardTotal
            // 
            cardTotal.BackColor = Color.White;
            cardTotal.Controls.Add(lblValTotal);
            cardTotal.Controls.Add(lblCapTotal);
            cardTotal.Controls.Add(pnlAccentTotal);
            cardTotal.Dock = DockStyle.Fill;
            cardTotal.Location = new Point(0, 8);
            cardTotal.Margin = new Padding(0, 8, 6, 8);
            cardTotal.Name = "cardTotal";
            cardTotal.Size = new Size(251, 104);
            cardTotal.TabIndex = 0;
            // 
            // lblValTotal
            // 
            lblValTotal.AutoSize = true;
            lblValTotal.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblValTotal.ForeColor = Color.FromArgb(15, 23, 42);
            lblValTotal.Location = new Point(18, 42);
            lblValTotal.Name = "lblValTotal";
            lblValTotal.Size = new Size(46, 54);
            lblValTotal.TabIndex = 2;
            lblValTotal.Text = "0";
            // 
            // lblCapTotal
            // 
            lblCapTotal.AutoSize = true;
            lblCapTotal.ForeColor = Color.FromArgb(100, 116, 139);
            lblCapTotal.Location = new Point(22, 18);
            lblCapTotal.Name = "lblCapTotal";
            lblCapTotal.Size = new Size(134, 23);
            lblCapTotal.TabIndex = 1;
            lblCapTotal.Text = "Total complaints";
            // 
            // pnlAccentTotal
            // 
            pnlAccentTotal.BackColor = Color.FromArgb(37, 99, 235);
            pnlAccentTotal.Dock = DockStyle.Left;
            pnlAccentTotal.Location = new Point(0, 0);
            pnlAccentTotal.Name = "pnlAccentTotal";
            pnlAccentTotal.Size = new Size(6, 104);
            pnlAccentTotal.TabIndex = 0;
            // 
            // cardOpen
            // 
            cardOpen.BackColor = Color.White;
            cardOpen.Controls.Add(lblValOpen);
            cardOpen.Controls.Add(lblCapOpen);
            cardOpen.Controls.Add(pnlAccentOpen);
            cardOpen.Dock = DockStyle.Fill;
            cardOpen.Location = new Point(263, 8);
            cardOpen.Margin = new Padding(6, 8, 6, 8);
            cardOpen.Name = "cardOpen";
            cardOpen.Size = new Size(245, 104);
            cardOpen.TabIndex = 1;
            // 
            // lblValOpen
            // 
            lblValOpen.AutoSize = true;
            lblValOpen.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblValOpen.ForeColor = Color.FromArgb(15, 23, 42);
            lblValOpen.Location = new Point(18, 42);
            lblValOpen.Name = "lblValOpen";
            lblValOpen.Size = new Size(46, 54);
            lblValOpen.TabIndex = 2;
            lblValOpen.Text = "0";
            // 
            // lblCapOpen
            // 
            lblCapOpen.AutoSize = true;
            lblCapOpen.ForeColor = Color.FromArgb(100, 116, 139);
            lblCapOpen.Location = new Point(22, 18);
            lblCapOpen.Name = "lblCapOpen";
            lblCapOpen.Size = new Size(103, 23);
            lblCapOpen.TabIndex = 1;
            lblCapOpen.Text = "Open / New";
            // 
            // pnlAccentOpen
            // 
            pnlAccentOpen.BackColor = Color.FromArgb(217, 119, 6);
            pnlAccentOpen.Dock = DockStyle.Left;
            pnlAccentOpen.Location = new Point(0, 0);
            pnlAccentOpen.Name = "pnlAccentOpen";
            pnlAccentOpen.Size = new Size(6, 104);
            pnlAccentOpen.TabIndex = 0;
            // 
            // cardInProgress
            // 
            cardInProgress.BackColor = Color.White;
            cardInProgress.Controls.Add(lblValInProgress);
            cardInProgress.Controls.Add(lblCapInProgress);
            cardInProgress.Controls.Add(pnlAccentInProgress);
            cardInProgress.Dock = DockStyle.Fill;
            cardInProgress.Location = new Point(520, 8);
            cardInProgress.Margin = new Padding(6, 8, 6, 8);
            cardInProgress.Name = "cardInProgress";
            cardInProgress.Size = new Size(245, 104);
            cardInProgress.TabIndex = 2;
            // 
            // lblValInProgress
            // 
            lblValInProgress.AutoSize = true;
            lblValInProgress.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblValInProgress.ForeColor = Color.FromArgb(15, 23, 42);
            lblValInProgress.Location = new Point(18, 42);
            lblValInProgress.Name = "lblValInProgress";
            lblValInProgress.Size = new Size(46, 54);
            lblValInProgress.TabIndex = 2;
            lblValInProgress.Text = "0";
            // 
            // lblCapInProgress
            // 
            lblCapInProgress.AutoSize = true;
            lblCapInProgress.ForeColor = Color.FromArgb(100, 116, 139);
            lblCapInProgress.Location = new Point(22, 18);
            lblCapInProgress.Name = "lblCapInProgress";
            lblCapInProgress.Size = new Size(95, 23);
            lblCapInProgress.TabIndex = 1;
            lblCapInProgress.Text = "In progress";
            // 
            // pnlAccentInProgress
            // 
            pnlAccentInProgress.BackColor = Color.FromArgb(124, 58, 237);
            pnlAccentInProgress.Dock = DockStyle.Left;
            pnlAccentInProgress.Location = new Point(0, 0);
            pnlAccentInProgress.Name = "pnlAccentInProgress";
            pnlAccentInProgress.Size = new Size(6, 104);
            pnlAccentInProgress.TabIndex = 0;
            // 
            // cardResolved
            // 
            cardResolved.BackColor = Color.White;
            cardResolved.Controls.Add(lblValResolved);
            cardResolved.Controls.Add(lblCapResolved);
            cardResolved.Controls.Add(pnlAccentResolved);
            cardResolved.Dock = DockStyle.Fill;
            cardResolved.Location = new Point(777, 8);
            cardResolved.Margin = new Padding(6, 8, 0, 8);
            cardResolved.Name = "cardResolved";
            cardResolved.Size = new Size(251, 104);
            cardResolved.TabIndex = 3;
            // 
            // lblValResolved
            // 
            lblValResolved.AutoSize = true;
            lblValResolved.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblValResolved.ForeColor = Color.FromArgb(15, 23, 42);
            lblValResolved.Location = new Point(18, 42);
            lblValResolved.Name = "lblValResolved";
            lblValResolved.Size = new Size(46, 54);
            lblValResolved.TabIndex = 2;
            lblValResolved.Text = "0";
            // 
            // lblCapResolved
            // 
            lblCapResolved.AutoSize = true;
            lblCapResolved.ForeColor = Color.FromArgb(100, 116, 139);
            lblCapResolved.Location = new Point(22, 18);
            lblCapResolved.Name = "lblCapResolved";
            lblCapResolved.Size = new Size(77, 23);
            lblCapResolved.TabIndex = 1;
            lblCapResolved.Text = "Resolved";
            // 
            // pnlAccentResolved
            // 
            pnlAccentResolved.BackColor = Color.FromArgb(22, 163, 74);
            pnlAccentResolved.Dock = DockStyle.Left;
            pnlAccentResolved.Location = new Point(0, 0);
            pnlAccentResolved.Name = "pnlAccentResolved";
            pnlAccentResolved.Size = new Size(6, 104);
            pnlAccentResolved.TabIndex = 0;
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
            lblTitle.Text = "Admin Dashboard";
            lblTitle.UseMnemonic = false;
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
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(20, 26, 90);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderColor = Color.FromArgb(190, 198, 230);
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 52, 140);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(20, 151);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(180, 40);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            // 
            // btnAdminDashboard
            // 
            btnAdminDashboard.BackColor = Color.FromArgb(20, 26, 90);
            btnAdminDashboard.Cursor = Cursors.Hand;
            btnAdminDashboard.FlatAppearance.BorderColor = Color.White;
            btnAdminDashboard.FlatAppearance.BorderSize = 2;
            btnAdminDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 52, 140);
            btnAdminDashboard.FlatStyle = FlatStyle.Flat;
            btnAdminDashboard.Font = new Font("Segoe UI", 10F);
            btnAdminDashboard.ForeColor = Color.White;
            btnAdminDashboard.Location = new Point(20, 222);
            btnAdminDashboard.Name = "btnAdminDashboard";
            btnAdminDashboard.Size = new Size(180, 40);
            btnAdminDashboard.TabIndex = 4;
            btnAdminDashboard.Text = "Admin Dashboard";
            btnAdminDashboard.UseVisualStyleBackColor = false;
            // 
            // btnManageComplaints
            // 
            btnManageComplaints.BackColor = Color.FromArgb(20, 26, 90);
            btnManageComplaints.Cursor = Cursors.Hand;
            btnManageComplaints.FlatAppearance.BorderColor = Color.FromArgb(190, 198, 230);
            btnManageComplaints.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 52, 140);
            btnManageComplaints.FlatStyle = FlatStyle.Flat;
            btnManageComplaints.Font = new Font("Segoe UI", 10F);
            btnManageComplaints.ForeColor = Color.White;
            btnManageComplaints.Location = new Point(20, 289);
            btnManageComplaints.Name = "btnManageComplaints";
            btnManageComplaints.Size = new Size(180, 40);
            btnManageComplaints.TabIndex = 5;
            btnManageComplaints.Text = "Manage Complaints";
            btnManageComplaints.UseVisualStyleBackColor = false;
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
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(120F, 120F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1280, 760);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Font = new Font("Segoe UI", 9.75F);
            MinimumSize = new Size(1100, 680);
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Dashboard - Student Complaint Tracking System";
            pnlContent.ResumeLayout(false);
            pnlRecentWrap.ResumeLayout(false);
            pnlRecent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecent).EndInit();
            tlpCharts.ResumeLayout(false);
            cardChartStatus.ResumeLayout(false);
            cardChartCategory.ResumeLayout(false);
            tlpCards.ResumeLayout(false);
            cardTotal.ResumeLayout(false);
            cardTotal.PerformLayout();
            cardOpen.ResumeLayout(false);
            cardOpen.PerformLayout();
            cardInProgress.ResumeLayout(false);
            cardInProgress.PerformLayout();
            cardResolved.ResumeLayout(false);
            cardResolved.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tlpCards;
        private System.Windows.Forms.Panel cardTotal;
        private System.Windows.Forms.Panel pnlAccentTotal;
        private System.Windows.Forms.Label lblCapTotal;
        private System.Windows.Forms.Label lblValTotal;
        private System.Windows.Forms.Panel cardOpen;
        private System.Windows.Forms.Panel pnlAccentOpen;
        private System.Windows.Forms.Label lblCapOpen;
        private System.Windows.Forms.Label lblValOpen;
        private System.Windows.Forms.Panel cardInProgress;
        private System.Windows.Forms.Panel pnlAccentInProgress;
        private System.Windows.Forms.Label lblCapInProgress;
        private System.Windows.Forms.Label lblValInProgress;
        private System.Windows.Forms.Panel cardResolved;
        private System.Windows.Forms.Panel pnlAccentResolved;
        private System.Windows.Forms.Label lblCapResolved;
        private System.Windows.Forms.Label lblValResolved;
        private System.Windows.Forms.TableLayoutPanel tlpCharts;
        private System.Windows.Forms.Panel cardChartStatus;
        private System.Windows.Forms.Label lblChartStatusTitle;
        private System.Windows.Forms.Panel pnlChartStatus;
        private System.Windows.Forms.Panel cardChartCategory;
        private System.Windows.Forms.Label lblChartCategoryTitle;
        private System.Windows.Forms.Panel pnlChartCategory;
        private System.Windows.Forms.Panel pnlRecentWrap;
        private System.Windows.Forms.Panel pnlRecent;
        private System.Windows.Forms.Label lblRecentTitle;
        private System.Windows.Forms.DataGridView dgvRecent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecentTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecentStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecentCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecentPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRecentDate;
    }
}
