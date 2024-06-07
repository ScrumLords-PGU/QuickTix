namespace QuickTix
{
    partial class UserForm
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
            lbPriority = new Label();
            cdPriority = new ComboBox();
            tbLocation = new Label();
            textBox1 = new TextBox();
            tbSubject = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(265, 580);
            buttonSubmit.Margin = new Padding(2);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(146, 27);
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
            lbTicketInfo.Size = new Size(133, 20);
            lbTicketInfo.TabIndex = 23;
            lbTicketInfo.Text = "Ticket Information:";
            // 
            // tbDetails
            // 
            tbDetails.Location = new Point(229, 389);
            tbDetails.Margin = new Padding(2);
            tbDetails.Multiline = true;
            tbDetails.Name = "tbDetails";
            tbDetails.Size = new Size(238, 166);
            tbDetails.TabIndex = 22;
            // 
            // lbDetails
            // 
            lbDetails.AutoSize = true;
            lbDetails.Location = new Point(229, 348);
            lbDetails.Margin = new Padding(2, 0, 2, 0);
            lbDetails.Name = "lbDetails";
            lbDetails.Size = new Size(58, 20);
            lbDetails.TabIndex = 21;
            lbDetails.Text = "Details:";
            // 
            // lbPriority
            // 
            lbPriority.AutoSize = true;
            lbPriority.Location = new Point(231, 187);
            lbPriority.Margin = new Padding(2, 0, 2, 0);
            lbPriority.Name = "lbPriority";
            lbPriority.Size = new Size(59, 20);
            lbPriority.TabIndex = 19;
            lbPriority.Text = "Priority:";
            // 
            // cdPriority
            // 
            cdPriority.FormattingEnabled = true;
            cdPriority.Items.AddRange(new object[] { "Low", "Medium", "High", "Urgent" });
            cdPriority.Location = new Point(316, 187);
            cdPriority.Name = "cdPriority";
            cdPriority.Size = new Size(151, 28);
            cdPriority.TabIndex = 25;
            cdPriority.SelectedIndexChanged += cbPriority_SelectedIndexChanged;
            // 
            // tbLocation
            // 
            tbLocation.AutoSize = true;
            tbLocation.Location = new Point(231, 66);
            tbLocation.Name = "tbLocation";
            tbLocation.Size = new Size(69, 20);
            tbLocation.TabIndex = 26;
            tbLocation.Text = "Location:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(229, 102);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 27);
            textBox1.TabIndex = 27;
            // 
            // tbSubject
            // 
            tbSubject.AutoSize = true;
            tbSubject.Location = new Point(229, 251);
            tbSubject.Name = "tbSubject";
            tbSubject.Size = new Size(61, 20);
            tbSubject.TabIndex = 28;
            tbSubject.Text = "Subject:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(229, 289);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 34);
            textBox2.TabIndex = 29;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 642);
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
            Name = "UserForm";
            Text = "UserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSubmit;
        private Label lbTicketInfo;
        private TextBox tbDetails;
        private Label lbDetails;
        private Label lbPriority;
        private ComboBox cdPriority;
        private Label tbLocation;
        private TextBox textBox1;
        private Label tbSubject;
        private TextBox textBox2;
    }
}