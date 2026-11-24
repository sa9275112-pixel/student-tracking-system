namespace StudentComplaintTracking.Forms
{
    partial class MyComplaints
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
            pnlSidebar = new Panel();
            button4 = new Button();
            btnMyComplaints = new Button();
            button2 = new Button();
            button1 = new Button();
            lblAppTitle = new Label();
            lblMyComplaints = new Label();
            pnlComplaint1 = new Panel();
            lblTitle = new Label();
            label1 = new Label();
            lblDescriptionTitle = new Label();
            lblSubmit = new Label();
            lblCategory = new Label();
            lblComplaint = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pnlSidebar.SuspendLayout();
            pnlComplaint1.SuspendLayout();
            panel1.SuspendLayout();
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
            pnlSidebar.Margin = new Padding(4, 5, 4, 5);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(329, 1102);
            pnlSidebar.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSlateBlue;
            button4.Cursor = Cursors.Hand;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(29, 1013);
            button4.Margin = new Padding(4, 5, 4, 5);
            button4.Name = "button4";
            button4.Size = new Size(256, 68);
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
            btnMyComplaints.Location = new Point(29, 413);
            btnMyComplaints.Margin = new Padding(4, 5, 4, 5);
            btnMyComplaints.Name = "btnMyComplaints";
            btnMyComplaints.Size = new Size(256, 67);
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
            button2.Location = new Point(29, 300);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(256, 67);
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
            button1.Location = new Point(29, 183);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(256, 67);
            button1.TabIndex = 8;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblAppTitle
            // 
            lblAppTitle.BackColor = Color.DarkSlateBlue;
            lblAppTitle.Font = new Font("Segoe UI", 10F);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(14, 42);
            lblAppTitle.Margin = new Padding(4, 0, 4, 0);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(300, 100);
            lblAppTitle.TabIndex = 1;
            lblAppTitle.Text = "Student Complaints";
            lblAppTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMyComplaints
            // 
            lblMyComplaints.AutoSize = true;
            lblMyComplaints.Cursor = Cursors.No;
            lblMyComplaints.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMyComplaints.Location = new Point(373, 42);
            lblMyComplaints.Margin = new Padding(4, 0, 4, 0);
            lblMyComplaints.Name = "lblMyComplaints";
            lblMyComplaints.Size = new Size(273, 48);
            lblMyComplaints.TabIndex = 2;
            lblMyComplaints.Text = "My Complaints";
            lblMyComplaints.Click += lblWelcome_Click;
            // 
            // pnlComplaint1
            // 
            pnlComplaint1.BorderStyle = BorderStyle.FixedSingle;
            pnlComplaint1.Controls.Add(lblComplaint);
            pnlComplaint1.Controls.Add(lblCategory);
            pnlComplaint1.Controls.Add(lblSubmit);
            pnlComplaint1.Controls.Add(lblDescriptionTitle);
            pnlComplaint1.Controls.Add(label1);
            pnlComplaint1.Controls.Add(lblTitle);
            pnlComplaint1.Location = new Point(385, 121);
            pnlComplaint1.Name = "pnlComplaint1";
            pnlComplaint1.Size = new Size(1000, 220);
            pnlComplaint1.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.MidnightBlue;
            lblTitle.Location = new Point(12, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(455, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Internet Connection Problem";
            lblTitle.Click += lblTitle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 180);
            label1.Name = "label1";
            label1.Size = new Size(365, 25);
            label1.TabIndex = 1;
            label1.Text = "Internet keeps disconnecting during lectures.";
            // 
            // lblDescriptionTitle
            // 
            lblDescriptionTitle.AutoSize = true;
            lblDescriptionTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescriptionTitle.Location = new Point(25, 155);
            lblDescriptionTitle.Name = "lblDescriptionTitle";
            lblDescriptionTitle.Size = new Size(109, 25);
            lblDescriptionTitle.TabIndex = 2;
            lblDescriptionTitle.Text = "Description";
            // 
            // lblSubmit
            // 
            lblSubmit.AutoSize = true;
            lblSubmit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubmit.Location = new Point(25, 125);
            lblSubmit.Name = "lblSubmit";
            lblSubmit.Size = new Size(206, 25);
            lblSubmit.TabIndex = 3;
            lblSubmit.Text = "Submitted: 01/11/2026";
            lblSubmit.Click += lblSubmit_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(25, 95);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(179, 25);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Category: Technical";
            // 
            // lblComplaint
            // 
            lblComplaint.AutoSize = true;
            lblComplaint.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComplaint.Location = new Point(25, 65);
            lblComplaint.Name = "lblComplaint";
            lblComplaint.Size = new Size(174, 25);
            lblComplaint.TabIndex = 5;
            lblComplaint.Text = "Complaint ID: C001";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(385, 395);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 220);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 65);
            label2.Name = "label2";
            label2.Size = new Size(174, 25);
            label2.TabIndex = 5;
            label2.Text = "Complaint ID: C002";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 95);
            label3.Name = "label3";
            label3.Size = new Size(183, 25);
            label3.TabIndex = 4;
            label3.Text = "Category: Academic";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 125);
            label4.Name = "label4";
            label4.Size = new Size(206, 25);
            label4.TabIndex = 3;
            label4.Text = "Submitted: 30/10/2026";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 155);
            label5.Name = "label5";
            label5.Size = new Size(109, 25);
            label5.TabIndex = 2;
            label5.Text = "Description";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 180);
            label6.Name = "label6";
            label6.Size = new Size(321, 25);
            label6.TabIndex = 1;
            label6.Text = "Unable to register for required courses.";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.MidnightBlue;
            label7.Location = new Point(12, 10);
            label7.Name = "label7";
            label7.Size = new Size(397, 45);
            label7.TabIndex = 0;
            label7.Text = "Course Registration Issue";
            // 
            // MyComplaints
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1549, 1102);
            Controls.Add(panel1);
            Controls.Add(pnlComplaint1);
            Controls.Add(lblMyComplaints);
            Controls.Add(pnlSidebar);
            MinimumSize = new Size(1419, 1046);
            Name = "MyComplaints";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            pnlSidebar.ResumeLayout(false);
            pnlComplaint1.ResumeLayout(false);
            pnlComplaint1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlSidebar;
        private Button button4;
        private Button btnMyComplaints;
        private Button button2;
        private Button button1;
        private Label lblAppTitle;
        private Label lblMyComplaints;
        private Panel pnlComplaint1;
        private Label lblTitle;
        private Label lblComplaint;
        private Label lblCategory;
        private Label lblSubmit;
        private Label lblDescriptionTitle;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}