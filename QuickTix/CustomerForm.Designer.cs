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
            cdPriority = new ComboBox();
            lbPriority = new Label();
            tbLocation = new Label();
            txtLocation = new TextBox();
            tbSubject = new Label();
            txtSubject = new TextBox();
            lgOut = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            txtUserName = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btSubmit
            // 
            btSubmit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSubmit.Location = new Point(488, 559);
            btSubmit.Margin = new Padding(2, 3, 2, 3);
            btSubmit.Name = "btSubmit";
            btSubmit.Size = new Size(282, 41);
            btSubmit.TabIndex = 24;
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
            // txtDetails
            // 
            txtDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDetails.Location = new Point(154, 212);
            txtDetails.Margin = new Padding(2, 3, 2, 3);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.Size = new Size(315, 143);
            txtDetails.TabIndex = 22;
            // 
            // lbDetails
            // 
            lbDetails.AutoSize = true;
            lbDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDetails.Location = new Point(44, 212);
            lbDetails.Margin = new Padding(2, 0, 2, 0);
            lbDetails.Name = "lbDetails";
            lbDetails.Size = new Size(75, 28);
            lbDetails.TabIndex = 21;
            lbDetails.Text = "Details:";
            // 
            // cdPriority
            // 
            cdPriority.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cdPriority.FormattingEnabled = true;
            cdPriority.Items.AddRange(new object[] { "Low", "Medium", "High", "Critical" });
            cdPriority.Location = new Point(154, 73);
            cdPriority.Name = "cdPriority";
            cdPriority.Size = new Size(151, 36);
            cdPriority.TabIndex = 25;
            cdPriority.SelectedIndexChanged += cbPriority_SelectedIndexChanged;
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
            tbLocation.Location = new Point(83, 281);
            tbLocation.Name = "tbLocation";
            tbLocation.Size = new Size(91, 28);
            tbLocation.TabIndex = 26;
            tbLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            txtLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocation.Location = new Point(223, 281);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(237, 34);
            txtLocation.TabIndex = 27;
            // 
            // tbSubject
            // 
            tbSubject.AutoSize = true;
            tbSubject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSubject.Location = new Point(38, 142);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(81, 28);
            tbSubject.TabIndex = 28;
            tbSubject.Text = "Subject:";
            // 
            // txtSubject
            // 
            txtSubject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubject.Location = new Point(154, 142);
            txtSubject.Multiline = true;
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(268, 36);
            txtSubject.TabIndex = 29;
            // 
            // lgOut
            // 
            lgOut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lgOut.Location = new Point(569, 629);
            lgOut.Margin = new Padding(3, 4, 3, 4);
            lgOut.Name = "lgOut";
            lgOut.Size = new Size(115, 43);
            lgOut.TabIndex = 30;
            lgOut.Text = "Logout";
            lgOut.UseVisualStyleBackColor = true;
            lgOut.Click += lgOut_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 24);
            label1.Name = "label1";
            label1.Size = new Size(629, 46);
            label1.TabIndex = 31;
            label1.Text = "Welcome! Fill out the information below.";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtLocation);
            groupBox1.Controls.Add(tbLocation);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(70, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 405);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "General Information";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(62, 76);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 32;
            label4.Text = "User Name:";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(223, 76);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(237, 38);
            txtUserName.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 142);
            label3.Name = "label3";
            label3.Size = new Size(148, 28);
            label3.TabIndex = 31;
            label3.Text = "Phone Number:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(223, 142);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(237, 38);
            txtPhone.TabIndex = 30;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(223, 212);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(237, 38);
            txtEmail.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 212);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 28;
            label2.Text = "Email:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtSubject);
            groupBox2.Controls.Add(lbPriority);
            groupBox2.Controls.Add(txtDetails);
            groupBox2.Controls.Add(cdPriority);
            groupBox2.Controls.Add(lbDetails);
            groupBox2.Controls.Add(tbSubject);
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(665, 109);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(540, 405);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "Issue Details";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 741);
            Controls.Add(label1);
            Controls.Add(lgOut);
            Controls.Add(btSubmit);
            Controls.Add(lbTicketInfo);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Margin = new Padding(2, 3, 2, 3);
            Name = "CustomerForm";
            Text = "Ticket Information";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Label lbTicketInfo;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lbDetails;
        private System.Windows.Forms.ComboBox cdPriority;
        private System.Windows.Forms.Label lbPriority;
        private System.Windows.Forms.Label tbLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label tbSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private Button lgOut;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private TextBox txtUserName;
        private Label label3;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Label label2;
    }
}
