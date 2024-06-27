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
            components = new System.ComponentModel.Container();
            btSubmit = new Button();
            lbTicketInfo = new Label();
            tbDescription = new TextBox();
            lbDetails = new Label();
            cbPriority = new ComboBox();
            lbPriority = new Label();
            lbLocation = new Label();
            tbLocation = new TextBox();
            lbCategory = new Label();
            btLgOut = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            lbUpdateContactInfo = new LinkLabel();
            tbUserName = new TextBox();
            lbUserName = new Label();
            lbPhone = new Label();
            tbPhone = new TextBox();
            tbEmail = new TextBox();
            lbEmail = new Label();
            TicketDetails = new GroupBox();
            tbTitle = new TextBox();
            lbSubject = new Label();
            cbCategory = new ComboBox();
            emailToolTip = new ToolTip(components);
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
            btSubmit.TabIndex = 9;
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
            // tbDescription
            // 
            tbDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDescription.Location = new Point(171, 244);
            tbDescription.Margin = new Padding(2, 3, 2, 3);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(315, 143);
            tbDescription.TabIndex = 8;
            // 
            // lbDetails
            // 
            lbDetails.AutoSize = true;
            lbDetails.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDetails.Location = new Point(9, 244);
            lbDetails.Margin = new Padding(2, 0, 2, 0);
            lbDetails.Name = "lbDetails";
            lbDetails.Size = new Size(140, 31);
            lbDetails.TabIndex = 21;
            lbDetails.Text = "Description:";
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
            lbPriority.TabIndex = 5;
            lbPriority.Text = "Priority:";
            // 
            // lbLocation
            // 
            lbLocation.AutoSize = true;
            lbLocation.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbLocation.Location = new Point(82, 303);
            lbLocation.Name = "lbLocation";
            lbLocation.Size = new Size(109, 31);
            lbLocation.TabIndex = 26;
            lbLocation.Text = "Location:";
            // 
            // tbLocation
            // 
            tbLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbLocation.Location = new Point(224, 303);
            tbLocation.Name = "tbLocation";
            tbLocation.Size = new Size(237, 34);
            tbLocation.TabIndex = 4;
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
            btLgOut.TabIndex = 10;
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
            groupBox1.Controls.Add(lbUpdateContactInfo);
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
            // lbUpdateContactInfo
            // 
            lbUpdateContactInfo.AutoSize = true;
            lbUpdateContactInfo.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUpdateContactInfo.Location = new Point(112, 244);
            lbUpdateContactInfo.Name = "lbUpdateContactInfo";
            lbUpdateContactInfo.Size = new Size(347, 25);
            lbUpdateContactInfo.TabIndex = 0;
            lbUpdateContactInfo.TabStop = true;
            lbUpdateContactInfo.Text = "Need to update your contact information?";
            lbUpdateContactInfo.LinkClicked += lbUpdateContactInfo_LinkClicked;
            // 
            // tbUserName
            // 
            tbUserName.BackColor = SystemColors.Control;
            tbUserName.BorderStyle = BorderStyle.None;
            tbUserName.Enabled = false;
            tbUserName.ForeColor = SystemColors.ControlText;
            tbUserName.Location = new Point(222, 63);
            tbUserName.Name = "tbUserName";
            tbUserName.ReadOnly = true;
            tbUserName.Size = new Size(235, 31);
            tbUserName.TabIndex = 11;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUserName.ForeColor = SystemColors.ControlText;
            lbUserName.Location = new Point(54, 63);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(135, 31);
            lbUserName.TabIndex = 32;
            lbUserName.Text = "User Name:";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPhone.Location = new Point(10, 120);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(178, 31);
            lbPhone.TabIndex = 31;
            lbPhone.Text = "Phone Number:";
            // 
            // tbPhone
            // 
            tbPhone.BorderStyle = BorderStyle.None;
            tbPhone.Enabled = false;
            tbPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPhone.Location = new Point(222, 120);
            tbPhone.Name = "tbPhone";
            tbPhone.ReadOnly = true;
            tbPhone.Size = new Size(237, 27);
            tbPhone.TabIndex = 2;
            tbPhone.TextChanged += tbPhone_TextChanged;
            // 
            // tbEmail
            // 
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Enabled = false;
            tbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(222, 180);
            tbEmail.Name = "tbEmail";
            tbEmail.ReadOnly = true;
            tbEmail.Size = new Size(237, 27);
            tbEmail.TabIndex = 3;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(114, 180);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(76, 31);
            lbEmail.TabIndex = 28;
            lbEmail.Text = "Email:";
            // 
            // TicketDetails
            // 
            TicketDetails.Controls.Add(tbTitle);
            TicketDetails.Controls.Add(lbSubject);
            TicketDetails.Controls.Add(cbCategory);
            TicketDetails.Controls.Add(lbPriority);
            TicketDetails.Controls.Add(tbDescription);
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
            // tbTitle
            // 
            tbTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTitle.Location = new Point(171, 180);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(315, 34);
            tbTitle.TabIndex = 7;
            // 
            // lbSubject
            // 
            lbSubject.AutoSize = true;
            lbSubject.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSubject.Location = new Point(81, 180);
            lbSubject.Margin = new Padding(2, 0, 2, 0);
            lbSubject.Name = "lbSubject";
            lbSubject.Size = new Size(65, 31);
            lbSubject.TabIndex = 29;
            lbSubject.Text = "Title:";
            // 
            // cbCategory
            // 
            cbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(171, 111);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 36);
            cbCategory.TabIndex = 6;
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
        private System.Windows.Forms.TextBox tbDescription;
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
        private TextBox tbTitle;
        private Label lbSubject;
        private LinkLabel lbUpdateContactInfo;
        private ToolTip emailToolTip;
    }
}
