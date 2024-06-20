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
            txtDetails = new TextBox();
            lbDetails = new Label();
            cbPriority = new ComboBox();
            lbPriority = new Label();
            tbLocation = new Label();
            txtLocation = new TextBox();
            lbCategory = new Label();
            lgOut = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            tbUserName = new TextBox();
            lbUserName = new Label();
            label3 = new Label();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            TicketDetails = new GroupBox();
            cbCategory = new ComboBox();
            groupBox1.SuspendLayout();
            TicketDetails.SuspendLayout();
            SuspendLayout();
            // 
            // btSubmit
            // 
            btSubmit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSubmit.Location = new Point(486, 581);
            btSubmit.Margin = new Padding(2, 3, 2, 3);
            btSubmit.Name = "btSubmit";
            btSubmit.Size = new Size(280, 41);
            btSubmit.TabIndex = 7;
            btSubmit.Text = "Submit Ticket";
            btSubmit.UseVisualStyleBackColor = true;
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
            // txtDetails
            // 
            txtDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDetails.Location = new Point(141, 227);
            txtDetails.Margin = new Padding(2, 3, 2, 3);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.Size = new Size(315, 143);
            txtDetails.TabIndex = 6;
            // 
            // lbDetails
            // 
            lbDetails.AutoSize = true;
            lbDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDetails.Location = new Point(44, 227);
            lbDetails.Margin = new Padding(2, 0, 2, 0);
            lbDetails.Name = "lbDetails";
            lbDetails.Size = new Size(75, 28);
            lbDetails.TabIndex = 21;
            lbDetails.Text = "Details:";
            // 
            // cbPriority
            // 
            cbPriority.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPriority.FormattingEnabled = true;
            cbPriority.Items.AddRange(new object[] { "Low", "Medium", "High", "Critical" });
            cbPriority.Location = new Point(154, 73);
            cbPriority.Name = "cbPriority";
            cbPriority.Size = new Size(151, 36);
            cbPriority.TabIndex = 4;
            cbPriority.SelectedIndexChanged += cbPriority_SelectedIndexChanged;
            // 
            // lbPriority
            // 
            lbPriority.AutoSize = true;
            lbPriority.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPriority.Location = new Point(39, 73);
            lbPriority.Margin = new Padding(2, 0, 2, 0);
            lbPriority.Name = "lbPriority";
            lbPriority.Size = new Size(80, 28);
            lbPriority.TabIndex = 19;
            lbPriority.Text = "Priority:";
            // 
            // tbLocation
            // 
            tbLocation.AutoSize = true;
            tbLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbLocation.Location = new Point(77, 289);
            tbLocation.Name = "tbLocation";
            tbLocation.Size = new Size(91, 28);
            tbLocation.TabIndex = 26;
            tbLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            txtLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocation.Location = new Point(217, 289);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(237, 34);
            txtLocation.TabIndex = 3;
            // 
            // lbCategory
            // 
            lbCategory.AutoSize = true;
            lbCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCategory.Location = new Point(39, 137);
            lbCategory.Name = "lbCategory";
            lbCategory.Size = new Size(96, 28);
            lbCategory.TabIndex = 28;
            lbCategory.Text = "Category:";
            // 
            // lgOut
            // 
            lgOut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lgOut.Location = new Point(575, 660);
            lgOut.Margin = new Padding(3, 4, 3, 4);
            lgOut.Name = "lgOut";
            lgOut.Size = new Size(115, 43);
            lgOut.TabIndex = 8;
            lgOut.Text = "Logout";
            lgOut.UseVisualStyleBackColor = true;
            lgOut.Click += lgOut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(326, 25);
            label1.Name = "label1";
            label1.Size = new Size(629, 46);
            label1.TabIndex = 31;
            label1.Text = "Welcome! Fill out the information below.";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbUserName);
            groupBox1.Controls.Add(lbUserName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtLocation);
            groupBox1.Controls.Add(tbLocation);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(80, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 405);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "General Information";
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(219, 81);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(235, 38);
            tbUserName.TabIndex = 33;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUserName.Location = new Point(56, 81);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(112, 28);
            lbUserName.TabIndex = 32;
            lbUserName.Text = "User Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 150);
            label3.Name = "label3";
            label3.Size = new Size(148, 28);
            label3.TabIndex = 31;
            label3.Text = "Phone Number:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(217, 150);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(237, 38);
            txtPhone.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(217, 220);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 38);
            txtEmail.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(105, 220);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 28;
            label2.Text = "Email:";
            // 
            // TicketDetails
            // 
            TicketDetails.Controls.Add(cbCategory);
            TicketDetails.Controls.Add(lbPriority);
            TicketDetails.Controls.Add(txtDetails);
            TicketDetails.Controls.Add(cbPriority);
            TicketDetails.Controls.Add(lbDetails);
            TicketDetails.Controls.Add(lbCategory);
            TicketDetails.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TicketDetails.Location = new Point(650, 109);
            TicketDetails.Name = "TicketDetails";
            TicketDetails.Size = new Size(540, 405);
            TicketDetails.TabIndex = 34;
            TicketDetails.TabStop = false;
            TicketDetails.Text = "Ticket Details";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(154, 137);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(151, 39);
            cbCategory.TabIndex = 5;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 741);
            Controls.Add(label1);
            Controls.Add(lgOut);
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
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lbDetails;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.Label lbPriority;
        private System.Windows.Forms.Label tbLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lbCategory;
        private Button lgOut;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox TicketDetails;
        private Label label3;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Label label2;
        private ComboBox cbCategory;
        private TextBox tbUserName;
        private Label lbUserName;
    }
}
