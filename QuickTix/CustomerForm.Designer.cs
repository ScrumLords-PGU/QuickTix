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
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.lbTicketInfo = new System.Windows.Forms.Label();
            this.tbDetails = new System.Windows.Forms.TextBox();
            this.lbDetails = new System.Windows.Forms.Label();
            this.cdPriority = new System.Windows.Forms.ComboBox();
            this.lbPriority = new System.Windows.Forms.Label();
            this.tbLocation = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbSubject = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(232, 435);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(128, 20);
            this.buttonSubmit.TabIndex = 24;
            this.buttonSubmit.Text = "Submit Ticket";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // lbTicketInfo
            // 
            this.lbTicketInfo.AutoSize = true;
            this.lbTicketInfo.Location = new System.Drawing.Point(251, 7);
            this.lbTicketInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTicketInfo.Name = "lbTicketInfo";
            this.lbTicketInfo.Size = new System.Drawing.Size(107, 15);
            this.lbTicketInfo.TabIndex = 23;
            this.lbTicketInfo.Text = "Ticket Information:";
            // 
            // tbDetails
            // 
            this.tbDetails.Location = new System.Drawing.Point(200, 292);
            this.tbDetails.Margin = new System.Windows.Forms.Padding(2);
            this.tbDetails.Multiline = true;
            this.tbDetails.Name = "tbDetails";
            this.tbDetails.Size = new System.Drawing.Size(209, 126);
            this.tbDetails.TabIndex = 22;
            // 
            // lbDetails
            // 
            this.lbDetails.AutoSize = true;
            this.lbDetails.Location = new System.Drawing.Point(200, 261);
            this.lbDetails.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDetails.Name = "lbDetails";
            this.lbDetails.Size = new System.Drawing.Size(45, 15);
            this.lbDetails.TabIndex = 21;
            this.lbDetails.Text = "Details:";
            // 
            // cdPriority
            // 
            this.cdPriority.FormattingEnabled = true;
            this.cdPriority.Items.AddRange(new object[] { "Low", "Medium", "High", "Urgent" });
            this.cdPriority.Location = new System.Drawing.Point(276, 140);
            this.cdPriority.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cdPriority.Name = "cdPriority";
            this.cdPriority.Size = new System.Drawing.Size(133, 23);
            this.cdPriority.TabIndex = 25;
            this.cdPriority.SelectedIndexChanged += new System.EventHandler(this.cbPriority_SelectedIndexChanged);
            // 
            // lbPriority
            // 
            this.lbPriority.AutoSize = true;
            this.lbPriority.Location = new System.Drawing.Point(202, 140);
            this.lbPriority.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPriority.Name = "lbPriority";
            this.lbPriority.Size = new System.Drawing.Size(48, 15);
            this.lbPriority.TabIndex = 19;
            this.lbPriority.Text = "Priority:";
            // 
            // tbLocation
            // 
            this.tbLocation.AutoSize = true;
            this.tbLocation.Location = new System.Drawing.Point(202, 50);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(56, 15);
            this.tbLocation.TabIndex = 26;
            this.tbLocation.Text = "Location:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 76);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 21);
            this.textBox1.TabIndex = 27;
            // 
            // tbSubject
            // 
            this.tbSubject.AutoSize = true;
            this.tbSubject.Location = new System.Drawing.Point(200, 188);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(49, 15);
            this.tbSubject.TabIndex = 28;
            this.tbSubject.Text = "Subject:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 217);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 26);
            this.textBox2.TabIndex = 29;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 482);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbSubject);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tbLocation);
            this.Controls.Add(this.cdPriority);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.lbTicketInfo);
            this.Controls.Add(this.tbDetails);
            this.Controls.Add(this.lbDetails);
            this.Controls.Add(this.lbPriority);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();
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
    }
}
