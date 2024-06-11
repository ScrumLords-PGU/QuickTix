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
            SuspendLayout();
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(232, 435);
            buttonSubmit.Margin = new Padding(2);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(128, 20);
            buttonSubmit.TabIndex = 24;
            buttonSubmit.Text = "Submit Ticket";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // lbTicketInfo
            // 
            lbTicketInfo.AutoSize = true;
            lbTicketInfo.Location = new Point(251, 7);
            lbTicketInfo.Margin = new Padding(2, 0, 2, 0);
            lbTicketInfo.Name = "lbTicketInfo";
            lbTicketInfo.Size = new Size(107, 15);
            lbTicketInfo.TabIndex = 23;
            lbTicketInfo.Text = "Ticket Information:";
            // 
            // tbDetails
            // 
            tbDetails.Location = new Point(200, 292);
            tbDetails.Margin = new Padding(2);
            tbDetails.Multiline = true;
            tbDetails.Name = "tbDetails";
            tbDetails.Size = new Size(209, 126);
            tbDetails.TabIndex = 22;
            // 
            // lbDetails
            // 
            lbDetails.AutoSize = true;
            lbDetails.Location = new Point(200, 261);
            lbDetails.Margin = new Padding(2, 0, 2, 0);
            lbDetails.Name = "lbDetails";
            lbDetails.Size = new Size(45, 15);
            lbDetails.TabIndex = 21;
            lbDetails.Text = "Details:";
            // 
            // cdPriority
            // 
            cdPriority.FormattingEnabled = true;
            cdPriority.Items.AddRange(new object[] { "Low", "Medium", "High", "Urgent" });
            cdPriority.Location = new Point(276, 140);
            cdPriority.Margin = new Padding(3, 2, 3, 2);
            cdPriority.Name = "cdPriority";
            cdPriority.Size = new Size(133, 23);
            cdPriority.TabIndex = 25;
            cdPriority.SelectedIndexChanged += cbPriority_SelectedIndexChanged;
            // 
            // lbPriority
            // 
            lbPriority.AutoSize = true;
            lbPriority.Location = new Point(202, 140);
            lbPriority.Margin = new Padding(2, 0, 2, 0);
            lbPriority.Name = "lbPriority";
            lbPriority.Size = new Size(48, 15);
            lbPriority.TabIndex = 19;
            lbPriority.Text = "Priority:";
            // 
            // tbLocation
            // 
            tbLocation.AutoSize = true;
            tbLocation.Location = new Point(202, 50);
            tbLocation.Name = "tbLocation";
            tbLocation.Size = new Size(56, 15);
            tbLocation.TabIndex = 26;
            tbLocation.Text = "Location:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 76);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(209, 21);
            textBox1.TabIndex = 27;
            // 
            // tbSubject
            // 
            tbSubject.AutoSize = true;
            tbSubject.Location = new Point(200, 188);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(49, 15);
            tbSubject.TabIndex = 28;
            tbSubject.Text = "Subject:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(200, 217);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(209, 26);
            textBox2.TabIndex = 29;
            // 
            // lgOut
            // 
            lgOut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lgOut.Location = new Point(556, 451);
            lgOut.Name = "lgOut";
            lgOut.Size = new Size(101, 32);
            lgOut.TabIndex = 30;
            lgOut.Text = "Logout";
            lgOut.UseVisualStyleBackColor = true;
            lgOut.Click += lgOut_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 482);
            Controls.Add(lgOut);
            Controls.Add(textBox2);
            Controls.Add(tbSubject);
            Controls.Add(textBox1);
            Controls.Add(tbLocation);
            Controls.Add(cdPriority);
            Controls.Add(buttonSubmit);
            Controls.Add(lbTicketInfo);
            Controls.Add(tbDetails);
            Controls.Add(lbDetails);
            Controls.Add(lbPriority);
            Margin = new Padding(2);
            Name = "CustomerForm";
            Text = "UserForm";
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
    }
}
