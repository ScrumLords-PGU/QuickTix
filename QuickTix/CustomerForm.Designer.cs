namespace QuickTix
{
    partial class CustomerForm
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
            btSubmit = new Button();
            lbTicketInfo = new Label();
            tbDetails = new TextBox();
            lbDetails = new Label();
            cbPriority = new ComboBox();
            lbPriority = new Label();
            lbLocation = new Label();
            tbLocation = new TextBox();
            lbCategory = new Label();
            btLgOut = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            tbUserName = new TextBox();
            lbUserName = new Label();
            lbPhone = new Label();
            tbPhone = new TextBox();
            tbEmail = new TextBox();
            lbEmail = new Label();
            TicketDetails = new GroupBox();
            tbSubject = new TextBox();
            lbSubject = new Label();
            cbCategory = new ComboBox();
            groupBox1.SuspendLayout();
            TicketDetails.SuspendLayout();
            SuspendLayout();
            // 
            // btSubmit
            // 
            btSubmit.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSubmit.Location = new Point(488, 572);
            btSubmit.Margin = new Padding(2, 3, 2, 3);
            btSubmit.Name = "btSubmit";
            btSubmit.Size = new Size(280, 52);
            btSubmit.TabIndex = 7;
            btSubmit.Text = "Submit Ticket";
            btSubmit.UseVisualStyleBackColor = true;
            btSubmit.Click += buttonSubmit_Click;
            // 
            // lbTicketInfo
            // 
            lbTicketInfo.AutoSize = true;
            lbTicketInfo.Location = new Point(287, 9);
            lbTicketInfo.Margin = new Padding(2, 0, 2, 0);
            lbTicketInfo.Name = "lbTicketInfo";
            lbTicketInfo.Size = new Size(0, 20);
            lbTicketInfo.TabIndex = 23;
            // 
            // tbDetails
            // 
            tbDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDetails.Location = new Point(171, 244);
            tbDetails.Margin = new Padding(2, 3, 2, 3);
            tbDetails.Multiline = true;
            tbDetails.Name = "tbDetails";
            tbDetails.Size = new Size(315, 143);
            tbDetails.TabIndex = 6;
            // 
            // lbDetails
            // 
            lbDetails.AutoSize = true;
            lbDetails.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDetails.Location = new Point(56, 244);
            lbDetails.Margin = new Padding(2, 0, 2, 0);
            lbDetails.Name = "lbDetails";
            lbDetails.Size = new Size(91, 31);
            lbDetails.TabIndex = 21;
            lbDetails.Text = "Details:";
            // 
            // cbPriority
            // 
            cbPriority.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPriority.FormattingEnabled = true;
            cbPriority.Items.AddRange(new object[] { "Low", "Medium", "High", "Critical" });
            cbPriority.Location = new Point(171, 47);
            cbPriority.Name = "cbPriority";
            cbPriority.Size = new Size(151, 36);
            cbPriority.TabIndex = 4;
            cbPriority.SelectedIndexChanged += cbPriority_SelectedIndexChanged;
            // 
            // lbPriority
            // 
            lbPriority.AutoSize = true;
            lbPriority.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPriority.Location = new Point(49, 47);
            lbPriority.Margin = new Padding(2, 0, 2, 0);
            lbPriority.Name = "lbPriority";
            lbPriority.Size = new Size(97, 31);
            lbPriority.TabIndex = 19;
            lbPriority.Text = "Priority:";
            // 
            // lbLocation
            // 
            lbLocation.AutoSize = true;
            lbLocation.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLocation.Location = new Point(94, 289);
            lbLocation.Name = "lbLocation";
            lbLocation.Size = new Size(109, 31);
            lbLocation.TabIndex = 26;
            lbLocation.Text = "Location:";
            // 
            // tbLocation
            // 
            tbLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbLocation.Location = new Point(236, 289);
            tbLocation.Name = "tbLocation";
            tbLocation.Size = new Size(237, 34);
            tbLocation.TabIndex = 3;
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCategory.Location = new Point(33, 111);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(116, 31);
            lbCategory.TabIndex = 28;
            lbCategory.Text = "Category:";
            // 
            // btLgOut
            // 
            btLgOut.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLgOut.Location = new Point(569, 651);
            btLgOut.Margin = new Padding(3, 4, 3, 4);
            btLgOut.Name = "btLgOut";
            btLgOut.Size = new Size(115, 43);
            btLgOut.TabIndex = 8;
            btLgOut.Text = "Logout";
            btLgOut.UseVisualStyleBackColor = true;
            btLgOut.Click += lgOut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(332, 18);
            label1.Name = "label1";
            label1.Size = new Size(675, 46);
            label1.TabIndex = 31;
            label1.Text = "Welcome! Fill out the information below.";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbUserName);
            groupBox1.Controls.Add(lbUserName);
            groupBox1.Controls.Add(lbPhone);
            groupBox1.Controls.Add(tbPhone);
            groupBox1.Controls.Add(tbEmail);
            groupBox1.Controls.Add(lbEmail);
            groupBox1.Controls.Add(tbLocation);
            groupBox1.Controls.Add(lbLocation);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(80, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 405);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "General Information";
            // 
            // tbUserName
            // 
            tbUserName.BackColor = SystemColors.Control;
            tbUserName.BorderStyle = BorderStyle.None;
            tbUserName.Enabled = false;
            tbUserName.ForeColor = SystemColors.ControlText;
            tbUserName.Location = new Point(238, 81);
            tbUserName.Name = "tbUserName";
            tbUserName.ReadOnly = true;
            tbUserName.Size = new Size(235, 31);
            tbUserName.TabIndex = 33;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUserName.ForeColor = SystemColors.ControlText;
            lbUserName.Location = new Point(70, 81);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(135, 31);
            lbUserName.TabIndex = 32;
            lbUserName.Text = "User Name:";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPhone.Location = new Point(24, 150);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(178, 31);
            lbPhone.TabIndex = 31;
            lbPhone.Text = "Phone Number:";
            // 
            // tbPhone
            // 
            tbPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPhone.Location = new Point(236, 150);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(237, 34);
            tbPhone.TabIndex = 1;
            // 
            // tbEmail
            // 
            tbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(236, 220);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(237, 34);
            tbEmail.TabIndex = 2;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(128, 220);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(76, 31);
            lbEmail.TabIndex = 28;
            lbEmail.Text = "Email:";
            // 
            // TicketDetails
            // 
            TicketDetails.Controls.Add(tbSubject);
            TicketDetails.Controls.Add(lbSubject);
            TicketDetails.Controls.Add(cbCategory);
            TicketDetails.Controls.Add(lbPriority);
            TicketDetails.Controls.Add(tbDetails);
            TicketDetails.Controls.Add(cbPriority);
            TicketDetails.Controls.Add(lbDetails);
            TicketDetails.Controls.Add(lbCategory);
            TicketDetails.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TicketDetails.Location = new Point(650, 109);
            TicketDetails.Name = "TicketDetails";
            TicketDetails.Size = new Size(540, 405);
            TicketDetails.TabIndex = 34;
            TicketDetails.TabStop = false;
            TicketDetails.Text = "Ticket Details";
            // 
            // tbSubject
            // 
            tbSubject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSubject.Location = new Point(171, 180);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(315, 34);
            tbSubject.TabIndex = 30;
            // 
            // lbSubject
            // 
            lbSubject.AutoSize = true;
            lbSubject.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSubject.Location = new Point(50, 180);
            lbSubject.Margin = new Padding(2, 0, 2, 0);
            lbSubject.Name = "lbSubject";
            lbSubject.Size = new Size(97, 31);
            lbSubject.TabIndex = 29;
            lbSubject.Text = "Subject:";
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(171, 111);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 36);
            cbCategory.TabIndex = 5;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1262, 717);
            Controls.Add(label1);
            Controls.Add(btLgOut);
            Controls.Add(btSubmit);
            Controls.Add(lbTicketInfo);
            Controls.Add(groupBox1);
            Controls.Add(TicketDetails);
            Margin = new Padding(2, 3, 2, 3);
            Name = "CustomerForm";
            Text = "Ticket Information";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            TicketDetails.ResumeLayout(false);
            TicketDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Label lbTicketInfo;
        private System.Windows.Forms.TextBox tbDetails;
        private System.Windows.Forms.Label lbDetails;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label lbPriority;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.TextBox tbLocation;
        private System.Windows.Forms.Label lbCategory;
        private Button btLgOut;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox TicketDetails;
        private Label lbPhone;
        private TextBox tbPhone;
        private TextBox tbEmail;
        private Label lbEmail;
        private ComboBox cbCategory;
        private TextBox tbUserName;
        private Label lbUserName;
        private TextBox tbSubject;
        private Label lbSubject;
    }
}
