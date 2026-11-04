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
            this.lblSideTitle = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnSubmitComplaints = new System.Windows.Forms.Button();
            this.btnMyComplaints = new System.Windows.Forms.Button();
            this.btnAdminDashboard = new System.Windows.Forms.Button();
            this.btnManageComplaints = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tlpCards = new System.Windows.Forms.TableLayoutPanel();
            this.cardTotal = new System.Windows.Forms.Panel();
            this.pnlAccentTotal = new System.Windows.Forms.Panel();
            this.lblCapTotal = new System.Windows.Forms.Label();
            this.lblValTotal = new System.Windows.Forms.Label();
            this.cardOpen = new System.Windows.Forms.Panel();
            this.pnlAccentOpen = new System.Windows.Forms.Panel();
            this.lblCapOpen = new System.Windows.Forms.Label();
            this.lblValOpen = new System.Windows.Forms.Label();
            this.cardInProgress = new System.Windows.Forms.Panel();
            this.pnlAccentInProgress = new System.Windows.Forms.Panel();
            this.lblCapInProgress = new System.Windows.Forms.Label();
            this.lblValInProgress = new System.Windows.Forms.Label();
            this.cardResolved = new System.Windows.Forms.Panel();
            this.pnlAccentResolved = new System.Windows.Forms.Panel();
            this.lblCapResolved = new System.Windows.Forms.Label();
            this.lblValResolved = new System.Windows.Forms.Label();
            this.tlpCharts = new System.Windows.Forms.TableLayoutPanel();
            this.cardChartStatus = new System.Windows.Forms.Panel();
            this.lblChartStatusTitle = new System.Windows.Forms.Label();
            this.pnlChartStatus = new System.Windows.Forms.Panel();
            this.cardChartCategory = new System.Windows.Forms.Panel();
            this.lblChartCategoryTitle = new System.Windows.Forms.Label();
            this.pnlChartCategory = new System.Windows.Forms.Panel();
            this.pnlRecentWrap = new System.Windows.Forms.Panel();
            this.pnlRecent = new System.Windows.Forms.Panel();
            this.lblRecentTitle = new System.Windows.Forms.Label();
            this.dgvRecent = new System.Windows.Forms.DataGridView();
            this.colRecentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecentTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecentStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecentCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecentPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRecentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSidebar.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.tlpCards.SuspendLayout();
            this.cardTotal.SuspendLayout();
            this.pnlAccentTotal.SuspendLayout();
            this.cardOpen.SuspendLayout();
            this.pnlAccentOpen.SuspendLayout();
            this.cardInProgress.SuspendLayout();
            this.pnlAccentInProgress.SuspendLayout();
            this.cardResolved.SuspendLayout();
            this.pnlAccentResolved.SuspendLayout();
            this.tlpCharts.SuspendLayout();
            this.cardChartStatus.SuspendLayout();
            this.pnlChartStatus.SuspendLayout();
            this.cardChartCategory.SuspendLayout();
            this.pnlChartCategory.SuspendLayout();
            this.pnlRecentWrap.SuspendLayout();
            this.pnlRecent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).BeginInit();
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
            this.btnAdminDashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdminDashboard.FlatAppearance.BorderSize = 2;
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
            // 
            // btnManageComplaints
            // 
            this.btnManageComplaints.BackColor = System.Drawing.Color.FromArgb(20, 26, 90);
            this.btnManageComplaints.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageComplaints.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(190, 198, 230);
            this.btnManageComplaints.FlatAppearance.BorderSize = 1;
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
            this.btnManageComplaints.Click += new System.EventHandler(this.btnManageComplaints_Click);
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
            this.pnlContent.Controls.Add(this.pnlRecentWrap);
            this.pnlContent.Controls.Add(this.tlpCharts);
            this.pnlContent.Controls.Add(this.tlpCards);
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
            this.lblTitle.Text = "Admin Dashboard";
            this.lblTitle.UseMnemonic = false;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            // 
            // tlpCards
            // 
            this.tlpCards.Controls.Add(this.cardTotal, 0, 0);
            this.tlpCards.Controls.Add(this.cardOpen, 1, 0);
            this.tlpCards.Controls.Add(this.cardInProgress, 2, 0);
            this.tlpCards.Controls.Add(this.cardResolved, 3, 0);
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F));
            this.tlpCards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F));
            this.tlpCards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
            this.tlpCards.ColumnCount = 4;
            this.tlpCards.RowCount = 1;
            this.tlpCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpCards.Size = new System.Drawing.Size(1028, 120);
            this.tlpCards.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.tlpCards.Name = "tlpCards";
            this.tlpCards.TabIndex = 1;
            // 
            // cardTotal
            // 
            this.cardTotal.Controls.Add(this.lblValTotal);
            this.cardTotal.Controls.Add(this.lblCapTotal);
            this.cardTotal.Controls.Add(this.pnlAccentTotal);
            this.cardTotal.BackColor = System.Drawing.Color.White;
            this.cardTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardTotal.Margin = new System.Windows.Forms.Padding(0, 8, 6, 8);
            this.cardTotal.Name = "cardTotal";
            this.cardTotal.TabIndex = 0;
            // 
            // pnlAccentTotal
            // 
            this.pnlAccentTotal.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.pnlAccentTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccentTotal.Size = new System.Drawing.Size(6, 104);
            this.pnlAccentTotal.Name = "pnlAccentTotal";
            this.pnlAccentTotal.TabIndex = 0;
            // 
            // lblCapTotal
            // 
            this.lblCapTotal.AutoSize = true;
            this.lblCapTotal.Location = new System.Drawing.Point(22, 18);
            this.lblCapTotal.Text = "Total complaints";
            this.lblCapTotal.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblCapTotal.Name = "lblCapTotal";
            this.lblCapTotal.TabIndex = 1;
            // 
            // lblValTotal
            // 
            this.lblValTotal.AutoSize = true;
            this.lblValTotal.Location = new System.Drawing.Point(18, 42);
            this.lblValTotal.Text = "0";
            this.lblValTotal.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblValTotal.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblValTotal.Name = "lblValTotal";
            this.lblValTotal.TabIndex = 2;
            // 
            // cardOpen
            // 
            this.cardOpen.Controls.Add(this.lblValOpen);
            this.cardOpen.Controls.Add(this.lblCapOpen);
            this.cardOpen.Controls.Add(this.pnlAccentOpen);
            this.cardOpen.BackColor = System.Drawing.Color.White;
            this.cardOpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardOpen.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cardOpen.Name = "cardOpen";
            this.cardOpen.TabIndex = 1;
            // 
            // pnlAccentOpen
            // 
            this.pnlAccentOpen.BackColor = System.Drawing.Color.FromArgb(217, 119, 6);
            this.pnlAccentOpen.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccentOpen.Size = new System.Drawing.Size(6, 104);
            this.pnlAccentOpen.Name = "pnlAccentOpen";
            this.pnlAccentOpen.TabIndex = 0;
            // 
            // lblCapOpen
            // 
            this.lblCapOpen.AutoSize = true;
            this.lblCapOpen.Location = new System.Drawing.Point(22, 18);
            this.lblCapOpen.Text = "Open / New";
            this.lblCapOpen.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblCapOpen.Name = "lblCapOpen";
            this.lblCapOpen.TabIndex = 1;
            // 
            // lblValOpen
            // 
            this.lblValOpen.AutoSize = true;
            this.lblValOpen.Location = new System.Drawing.Point(18, 42);
            this.lblValOpen.Text = "0";
            this.lblValOpen.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblValOpen.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblValOpen.Name = "lblValOpen";
            this.lblValOpen.TabIndex = 2;
            // 
            // cardInProgress
            // 
            this.cardInProgress.Controls.Add(this.lblValInProgress);
            this.cardInProgress.Controls.Add(this.lblCapInProgress);
            this.cardInProgress.Controls.Add(this.pnlAccentInProgress);
            this.cardInProgress.BackColor = System.Drawing.Color.White;
            this.cardInProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardInProgress.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.cardInProgress.Name = "cardInProgress";
            this.cardInProgress.TabIndex = 2;
            // 
            // pnlAccentInProgress
            // 
            this.pnlAccentInProgress.BackColor = System.Drawing.Color.FromArgb(124, 58, 237);
            this.pnlAccentInProgress.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccentInProgress.Size = new System.Drawing.Size(6, 104);
            this.pnlAccentInProgress.Name = "pnlAccentInProgress";
            this.pnlAccentInProgress.TabIndex = 0;
            // 
            // lblCapInProgress
            // 
            this.lblCapInProgress.AutoSize = true;
            this.lblCapInProgress.Location = new System.Drawing.Point(22, 18);
            this.lblCapInProgress.Text = "In progress";
            this.lblCapInProgress.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblCapInProgress.Name = "lblCapInProgress";
            this.lblCapInProgress.TabIndex = 1;
            // 
            // lblValInProgress
            // 
            this.lblValInProgress.AutoSize = true;
            this.lblValInProgress.Location = new System.Drawing.Point(18, 42);
            this.lblValInProgress.Text = "0";
            this.lblValInProgress.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblValInProgress.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblValInProgress.Name = "lblValInProgress";
            this.lblValInProgress.TabIndex = 2;
            // 
            // cardResolved
            // 
            this.cardResolved.Controls.Add(this.lblValResolved);
            this.cardResolved.Controls.Add(this.lblCapResolved);
            this.cardResolved.Controls.Add(this.pnlAccentResolved);
            this.cardResolved.BackColor = System.Drawing.Color.White;
            this.cardResolved.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardResolved.Margin = new System.Windows.Forms.Padding(6, 8, 0, 8);
            this.cardResolved.Name = "cardResolved";
            this.cardResolved.TabIndex = 3;
            // 
            // pnlAccentResolved
            // 
            this.pnlAccentResolved.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.pnlAccentResolved.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAccentResolved.Size = new System.Drawing.Size(6, 104);
            this.pnlAccentResolved.Name = "pnlAccentResolved";
            this.pnlAccentResolved.TabIndex = 0;
            // 
            // lblCapResolved
            // 
            this.lblCapResolved.AutoSize = true;
            this.lblCapResolved.Location = new System.Drawing.Point(22, 18);
            this.lblCapResolved.Text = "Resolved";
            this.lblCapResolved.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblCapResolved.Name = "lblCapResolved";
            this.lblCapResolved.TabIndex = 1;
            // 
            // lblValResolved
            // 
            this.lblValResolved.AutoSize = true;
            this.lblValResolved.Location = new System.Drawing.Point(18, 42);
            this.lblValResolved.Text = "0";
            this.lblValResolved.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblValResolved.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblValResolved.Name = "lblValResolved";
            this.lblValResolved.TabIndex = 2;
            // 
            // tlpCharts
            // 
            this.tlpCharts.Controls.Add(this.cardChartStatus, 0, 0);
            this.tlpCharts.Controls.Add(this.cardChartCategory, 1, 0);
            this.tlpCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F));
            this.tlpCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F));
            this.tlpCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F));
            this.tlpCharts.ColumnCount = 2;
            this.tlpCharts.RowCount = 1;
            this.tlpCharts.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpCharts.Size = new System.Drawing.Size(1028, 290);
            this.tlpCharts.Name = "tlpCharts";
            this.tlpCharts.TabIndex = 2;
            // 
            // cardChartStatus
            // 
            this.cardChartStatus.Controls.Add(this.pnlChartStatus);
            this.cardChartStatus.Controls.Add(this.lblChartStatusTitle);
            this.cardChartStatus.BackColor = System.Drawing.Color.White;
            this.cardChartStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardChartStatus.Margin = new System.Windows.Forms.Padding(0, 8, 6, 8);
            this.cardChartStatus.Name = "cardChartStatus";
            this.cardChartStatus.TabIndex = 0;
            // 
            // lblChartStatusTitle
            // 
            this.lblChartStatusTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChartStatusTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblChartStatusTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblChartStatusTitle.Padding = new System.Windows.Forms.Padding(12, 10, 0, 0);
            this.lblChartStatusTitle.Size = new System.Drawing.Size(300, 38);
            this.lblChartStatusTitle.Text = "Complaints by Status";
            this.lblChartStatusTitle.Name = "lblChartStatusTitle";
            this.lblChartStatusTitle.TabIndex = 0;
            // 
            // pnlChartStatus
            // 
            this.pnlChartStatus.BackColor = System.Drawing.Color.White;
            this.pnlChartStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChartStatus.Name = "pnlChartStatus";
            this.pnlChartStatus.TabIndex = 1;
            // 
            // cardChartCategory
            // 
            this.cardChartCategory.Controls.Add(this.pnlChartCategory);
            this.cardChartCategory.Controls.Add(this.lblChartCategoryTitle);
            this.cardChartCategory.BackColor = System.Drawing.Color.White;
            this.cardChartCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardChartCategory.Margin = new System.Windows.Forms.Padding(6, 8, 0, 8);
            this.cardChartCategory.Name = "cardChartCategory";
            this.cardChartCategory.TabIndex = 1;
            // 
            // lblChartCategoryTitle
            // 
            this.lblChartCategoryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChartCategoryTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblChartCategoryTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblChartCategoryTitle.Padding = new System.Windows.Forms.Padding(12, 10, 0, 0);
            this.lblChartCategoryTitle.Size = new System.Drawing.Size(300, 38);
            this.lblChartCategoryTitle.Text = "Complaints by Category";
            this.lblChartCategoryTitle.Name = "lblChartCategoryTitle";
            this.lblChartCategoryTitle.TabIndex = 0;
            // 
            // pnlChartCategory
            // 
            this.pnlChartCategory.BackColor = System.Drawing.Color.White;
            this.pnlChartCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChartCategory.Name = "pnlChartCategory";
            this.pnlChartCategory.TabIndex = 1;
            // 
            // pnlRecentWrap
            // 
            this.pnlRecentWrap.Controls.Add(this.pnlRecent);
            this.pnlRecentWrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecentWrap.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pnlRecentWrap.Name = "pnlRecentWrap";
            this.pnlRecentWrap.TabIndex = 3;
            // 
            // pnlRecent
            // 
            this.pnlRecent.Controls.Add(this.dgvRecent);
            this.pnlRecent.Controls.Add(this.lblRecentTitle);
            this.pnlRecent.BackColor = System.Drawing.Color.White;
            this.pnlRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecent.Name = "pnlRecent";
            this.pnlRecent.TabIndex = 0;
            // 
            // lblRecentTitle
            // 
            this.lblRecentTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRecentTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblRecentTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblRecentTitle.Padding = new System.Windows.Forms.Padding(12, 10, 0, 0);
            this.lblRecentTitle.Size = new System.Drawing.Size(300, 38);
            this.lblRecentTitle.Text = "Recent Complaints";
            this.lblRecentTitle.Name = "lblRecentTitle";
            this.lblRecentTitle.TabIndex = 0;
            // 
            // dgvRecent
            // 
            this.dgvRecent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRecentId,
            this.colRecentTitle,
            this.colRecentStudent,
            this.colRecentCategory,
            this.colRecentStatus,
            this.colRecentPriority,
            this.colRecentDate});
            this.dgvRecent.AllowUserToAddRows = false;
            this.dgvRecent.AllowUserToDeleteRows = false;
            this.dgvRecent.AllowUserToResizeRows = false;
            this.dgvRecent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecent.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRecent.ColumnHeadersHeight = 36;
            this.dgvRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecent.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvRecent.MultiSelect = false;
            this.dgvRecent.ReadOnly = true;
            this.dgvRecent.RowHeadersVisible = false;
            this.dgvRecent.RowTemplate.Height = 30;
            this.dgvRecent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecent.Name = "dgvRecent";
            this.dgvRecent.TabIndex = 1;
            // 
            // colRecentId
            // 
            this.colRecentId.FillWeight = 50F;
            this.colRecentId.HeaderText = "ID";
            this.colRecentId.ReadOnly = true;
            this.colRecentId.Name = "colRecentId";
            // 
            // colRecentTitle
            // 
            this.colRecentTitle.FillWeight = 200F;
            this.colRecentTitle.HeaderText = "Title";
            this.colRecentTitle.ReadOnly = true;
            this.colRecentTitle.Name = "colRecentTitle";
            // 
            // colRecentStudent
            // 
            this.colRecentStudent.FillWeight = 130F;
            this.colRecentStudent.HeaderText = "Student";
            this.colRecentStudent.ReadOnly = true;
            this.colRecentStudent.Name = "colRecentStudent";
            // 
            // colRecentCategory
            // 
            this.colRecentCategory.FillWeight = 100F;
            this.colRecentCategory.HeaderText = "Category";
            this.colRecentCategory.ReadOnly = true;
            this.colRecentCategory.Name = "colRecentCategory";
            // 
            // colRecentStatus
            // 
            this.colRecentStatus.FillWeight = 90F;
            this.colRecentStatus.HeaderText = "Status";
            this.colRecentStatus.ReadOnly = true;
            this.colRecentStatus.Name = "colRecentStatus";
            // 
            // colRecentPriority
            // 
            this.colRecentPriority.FillWeight = 80F;
            this.colRecentPriority.HeaderText = "Priority";
            this.colRecentPriority.ReadOnly = true;
            this.colRecentPriority.Name = "colRecentPriority";
            // 
            // colRecentDate
            // 
            this.colRecentDate.FillWeight = 90F;
            this.colRecentDate.HeaderText = "Submitted";
            this.colRecentDate.ReadOnly = true;
            this.colRecentDate.Name = "colRecentDate";
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.MinimumSize = new System.Drawing.Size(1100, 680);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard - Student Complaint Tracking System";
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "AdminDashboardForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecent)).EndInit();
            this.pnlRecent.ResumeLayout(false);
            this.pnlRecent.PerformLayout();
            this.pnlRecentWrap.ResumeLayout(false);
            this.pnlRecentWrap.PerformLayout();
            this.pnlChartCategory.ResumeLayout(false);
            this.pnlChartCategory.PerformLayout();
            this.cardChartCategory.ResumeLayout(false);
            this.cardChartCategory.PerformLayout();
            this.pnlChartStatus.ResumeLayout(false);
            this.pnlChartStatus.PerformLayout();
            this.cardChartStatus.ResumeLayout(false);
            this.cardChartStatus.PerformLayout();
            this.tlpCharts.ResumeLayout(false);
            this.tlpCharts.PerformLayout();
            this.pnlAccentResolved.ResumeLayout(false);
            this.pnlAccentResolved.PerformLayout();
            this.cardResolved.ResumeLayout(false);
            this.cardResolved.PerformLayout();
            this.pnlAccentInProgress.ResumeLayout(false);
            this.pnlAccentInProgress.PerformLayout();
            this.cardInProgress.ResumeLayout(false);
            this.cardInProgress.PerformLayout();
            this.pnlAccentOpen.ResumeLayout(false);
            this.pnlAccentOpen.PerformLayout();
            this.cardOpen.ResumeLayout(false);
            this.cardOpen.PerformLayout();
            this.pnlAccentTotal.ResumeLayout(false);
            this.pnlAccentTotal.PerformLayout();
            this.cardTotal.ResumeLayout(false);
            this.cardTotal.PerformLayout();
            this.tlpCards.ResumeLayout(false);
            this.tlpCards.PerformLayout();
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
