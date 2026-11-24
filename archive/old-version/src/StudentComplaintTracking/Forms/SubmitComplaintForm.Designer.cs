namespace StudentComplaints
{
    partial class SubmitComplaintForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlContent = new Panel();
            lblPageTitle = new Label();
            pnlCard = new Panel();
            lblStudentName = new Label();
            txtStudentName = new TextBox();
            lblStudentId = new Label();
            txtStudentId = new TextBox();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblPriority = new Label();
            cmbPriority = new ComboBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            lblAttachment = new Label();
            txtAttachment = new TextBox();
            btnBrowse = new Button();
            lblError = new Label();
            btnClear = new Button();
            btnSubmitComplaint = new Button();
            pnlSidebar = new Panel();
            button4 = new Button();
            btnMyComplaints = new Button();
            button2 = new Button();
            button1 = new Button();
            lblAppTitle = new Label();
            pnlContent.SuspendLayout();
            pnlCard.SuspendLayout();
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent
            // 
            pnlContent.AutoScroll = true;
            pnlContent.Controls.Add(pnlSidebar);
            pnlContent.Controls.Add(lblPageTitle);
            pnlContent.Controls.Add(pnlCard);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(1239, 881);
            pnlContent.TabIndex = 0;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.Location = new Point(270, 24);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(275, 41);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Submit Complaint";
            // 
            // pnlCard
            // 
            pnlCard.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlCard.BackColor = Color.White;
            pnlCard.BorderStyle = BorderStyle.FixedSingle;
            pnlCard.Controls.Add(lblStudentName);
            pnlCard.Controls.Add(txtStudentName);
            pnlCard.Controls.Add(lblStudentId);
            pnlCard.Controls.Add(txtStudentId);
            pnlCard.Controls.Add(lblTitle);
            pnlCard.Controls.Add(txtTitle);
            pnlCard.Controls.Add(lblCategory);
            pnlCard.Controls.Add(cmbCategory);
            pnlCard.Controls.Add(lblPriority);
            pnlCard.Controls.Add(cmbPriority);
            pnlCard.Controls.Add(lblDescription);
            pnlCard.Controls.Add(txtDescription);
            pnlCard.Controls.Add(lblAttachment);
            pnlCard.Controls.Add(txtAttachment);
            pnlCard.Controls.Add(btnBrowse);
            pnlCard.Controls.Add(lblError);
            pnlCard.Controls.Add(btnClear);
            pnlCard.Controls.Add(btnSubmitComplaint);
            pnlCard.Location = new Point(270, 80);
            pnlCard.Name = "pnlCard";
            pnlCard.Size = new Size(921, 530);
            pnlCard.TabIndex = 1;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentName.Location = new Point(30, 20);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(126, 23);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "Student Name";
            // 
            // txtStudentName
            // 
            txtStudentName.BackColor = Color.FromArgb(245, 245, 245);
            txtStudentName.Location = new Point(30, 44);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.ReadOnly = true;
            txtStudentName.Size = new Size(355, 30);
            txtStudentName.TabIndex = 1;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentId.Location = new Point(405, 20);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(97, 23);
            lblStudentId.TabIndex = 2;
            lblStudentId.Text = "Student ID";
            // 
            // txtStudentId
            // 
            txtStudentId.BackColor = Color.FromArgb(245, 245, 245);
            txtStudentId.Location = new Point(405, 44);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.ReadOnly = true;
            txtStudentId.Size = new Size(355, 30);
            txtStudentId.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(30, 88);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(148, 23);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "Complaint Title *";
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.Location = new Point(30, 112);
            txtTitle.MaxLength = 100;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(861, 30);
            txtTitle.TabIndex = 5;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(30, 156);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(97, 23);
            lblCategory.TabIndex = 6;
            lblCategory.Text = "Category *";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Academic", "Administrative", "Facilities", "Financial", "IT Services", "Other" });
            cmbCategory.Location = new Point(30, 180);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(355, 31);
            cmbCategory.TabIndex = 7;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriority.Location = new Point(405, 156);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(83, 23);
            lblPriority.TabIndex = 8;
            lblPriority.Text = "Priority *";
            // 
            // cmbPriority
            // 
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "Low", "Medium", "High", "Urgent" });
            cmbPriority.Location = new Point(405, 180);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(355, 31);
            cmbPriority.TabIndex = 9;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(30, 224);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(115, 23);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Description *";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(30, 248);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(861, 140);
            txtDescription.TabIndex = 11;
            // 
            // lblAttachment
            // 
            lblAttachment.AutoSize = true;
            lblAttachment.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAttachment.Location = new Point(30, 402);
            lblAttachment.Name = "lblAttachment";
            lblAttachment.Size = new Size(189, 23);
            lblAttachment.TabIndex = 12;
            lblAttachment.Text = "Attachment (optional)";
            // 
            // txtAttachment
            // 
            txtAttachment.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtAttachment.BackColor = Color.FromArgb(245, 245, 245);
            txtAttachment.Location = new Point(30, 426);
            txtAttachment.Name = "txtAttachment";
            txtAttachment.ReadOnly = true;
            txtAttachment.Size = new Size(746, 30);
            txtAttachment.TabIndex = 13;
            // 
            // btnBrowse
            // 
            btnBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBrowse.Location = new Point(786, 425);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(105, 31);
            btnBrowse.TabIndex = 14;
            btnBrowse.Text = "Browse...";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.FromArgb(198, 40, 40);
            lblError.Location = new Point(30, 468);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 23);
            lblError.TabIndex = 15;
            lblError.Visible = false;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.BackColor = Color.FromArgb(224, 224, 224);
            btnClear.Cursor = Cursors.Hand;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(596, 480);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(140, 40);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSubmitComplaint
            // 
            btnSubmitComplaint.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSubmitComplaint.BackColor = Color.FromArgb(23, 23, 85);
            btnSubmitComplaint.Cursor = Cursors.Hand;
            btnSubmitComplaint.FlatAppearance.BorderSize = 0;
            btnSubmitComplaint.FlatStyle = FlatStyle.Flat;
            btnSubmitComplaint.ForeColor = Color.White;
            btnSubmitComplaint.Location = new Point(751, 480);
            btnSubmitComplaint.Name = "btnSubmitComplaint";
            btnSubmitComplaint.Size = new Size(140, 40);
            btnSubmitComplaint.TabIndex = 17;
            btnSubmitComplaint.Text = "Submit";
            btnSubmitComplaint.UseVisualStyleBackColor = false;
            btnSubmitComplaint.Click += btnSubmitComplaint_Click;
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
            pnlSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(263, 881);
            pnlSidebar.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSlateBlue;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(23, 811);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(205, 55);
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
            btnMyComplaints.Location = new Point(23, 331);
            btnMyComplaints.Margin = new Padding(3, 4, 3, 4);
            btnMyComplaints.Name = "btnMyComplaints";
            btnMyComplaints.Size = new Size(205, 53);
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
            button2.Location = new Point(23, 240);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(205, 53);
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
            button1.Location = new Point(23, 147);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(205, 53);
            button1.TabIndex = 8;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblAppTitle
            // 
            lblAppTitle.BackColor = Color.DarkSlateBlue;
            lblAppTitle.Font = new Font("Segoe UI", 10F);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(11, 33);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(240, 80);
            lblAppTitle.TabIndex = 1;
            lblAppTitle.Text = "Student Complaints";
            lblAppTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubmitComplaintForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1239, 881);
            Controls.Add(pnlContent);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(1140, 851);
            Name = "SubmitComplaintForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Submit Complaint - Student Complaint Tracking System";
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlCard.ResumeLayout(false);
            pnlCard.PerformLayout();
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.TextBox txtAttachment;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmitComplaint;
        private Panel pnlSidebar;
        private Button button4;
        private Button btnMyComplaints;
        private Button button2;
        private Button button1;
        private Label lblAppTitle;
    }
}