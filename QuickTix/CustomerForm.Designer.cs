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
            buttonSubmit = new Button();
            lbTicketInfo = new Label();
            tbDetails = new TextBox();
            lbDetails = new Label();
            cdPriority = new ComboBox();
            lbPriority = new Label();
            tbLocation = new Label();
            textBox1 = new TextBox();
            tbSubject = new Label();
            textBox2 = new TextBox();
            lgOut = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSubmit
            // 
            buttonSubmit.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSubmit.Location = new Point(355, 646);
            buttonSubmit.Margin = new Padding(2, 3, 2, 3);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(268, 41);
            buttonSubmit.TabIndex = 24;
            buttonSubmit.Text = "Submit Ticket";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
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
            tbDetails.Location = new Point(144, 129);
            tbDetails.Margin = new Padding(2, 3, 2, 3);
            tbDetails.Multiline = true;
            tbDetails.Name = "tbDetails";
            tbDetails.Size = new Size(268, 151);
            tbDetails.TabIndex = 22;
            // 
            // lbDetails
            // 
            lbDetails.AutoSize = true;
            lbDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbDetails.Location = new Point(34, 129);
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
            cdPriority.Items.AddRange(new object[] { "Low", "Medium", "High", "Urgent" });
            cdPriority.Location = new Point(144, 114);
            cdPriority.Name = "cdPriority";
            cdPriority.Size = new Size(151, 36);
            cdPriority.TabIndex = 25;
            cdPriority.SelectedIndexChanged += cbPriority_SelectedIndexChanged;
            // 
            // lbPriority
            // 
            lbPriority.AutoSize = true;
            lbPriority.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPriority.Location = new Point(34, 114);
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
            tbLocation.Location = new Point(34, 54);
            tbLocation.Name = "tbLocation";
            tbLocation.Size = new Size(91, 28);
            tbLocation.TabIndex = 26;
            tbLocation.Text = "Location:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(144, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 34);
            textBox1.TabIndex = 27;
            // 
            // tbSubject
            // 
            tbSubject.AutoSize = true;
            tbSubject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSubject.Location = new Point(34, 59);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(81, 28);
            tbSubject.TabIndex = 28;
            tbSubject.Text = "Subject:";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(144, 59);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(268, 33);
            textBox2.TabIndex = 29;
            // 
            // lgOut
            // 
            lgOut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lgOut.Location = new Point(811, 9);
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
            label1.Location = new Point(180, 29);
            label1.Name = "label1";
            label1.Size = new Size(629, 46);
            label1.TabIndex = 31;
            label1.Text = "Welcome! Fill out the information below.";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lbPriority);
            groupBox1.Controls.Add(cdPriority);
            groupBox1.Controls.Add(tbLocation);
            groupBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(211, 109);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(522, 172);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Text = "General Information";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(tbDetails);
            groupBox2.Controls.Add(lbDetails);
            groupBox2.Controls.Add(tbSubject);
            groupBox2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(211, 319);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(522, 299);
            groupBox2.TabIndex = 34;
            groupBox2.TabStop = false;
            groupBox2.Text = "Issue Details";
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 738);
            Controls.Add(label1);
            Controls.Add(lgOut);
            Controls.Add(buttonSubmit);
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

        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label lbTicketInfo;
        private System.Windows.Forms.TextBox tbDetails;
        private System.Windows.Forms.Label lbDetails;
        private System.Windows.Forms.ComboBox cdPriority;
        private System.Windows.Forms.Label lbPriority;
        private System.Windows.Forms.Label tbLocation;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tbSubject;
        private System.Windows.Forms.TextBox textBox2;
        private Button lgOut;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
