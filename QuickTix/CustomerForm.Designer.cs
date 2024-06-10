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
            button1 = new Button();
            label9 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
<<<<<<< Updated upstream
            button1.Location = new Point(295, 392);
            button1.Name = "button1";
            button1.Size = new Size(183, 34);
            button1.TabIndex = 24;
            button1.Text = "Submit Ticket";
            button1.UseVisualStyleBackColor = true;
=======
            buttonSubmit.Location = new Point(232, 435);
            buttonSubmit.Margin = new Padding(2);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(128, 20);
            buttonSubmit.TabIndex = 24;
            buttonSubmit.Text = "Submit Ticket";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
>>>>>>> Stashed changes
            // 
            // label9
            // 
<<<<<<< Updated upstream
            label9.AutoSize = true;
            label9.Location = new Point(252, 24);
            label9.Name = "label9";
            label9.Size = new Size(160, 25);
            label9.TabIndex = 23;
            label9.Text = "Ticket Information:";
=======
            lbTicketInfo.AutoSize = true;
            lbTicketInfo.Location = new Point(251, 7);
            lbTicketInfo.Margin = new Padding(2, 0, 2, 0);
            lbTicketInfo.Name = "lbTicketInfo";
            lbTicketInfo.Size = new Size(107, 15);
            lbTicketInfo.TabIndex = 23;
            lbTicketInfo.Text = "Ticket Information:";
>>>>>>> Stashed changes
            // 
            // textBox6
            // 
<<<<<<< Updated upstream
            textBox6.Location = new Point(252, 151);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(296, 207);
            textBox6.TabIndex = 22;
=======
            tbDetails.Location = new Point(200, 292);
            tbDetails.Margin = new Padding(2);
            tbDetails.Multiline = true;
            tbDetails.Name = "tbDetails";
            tbDetails.Size = new Size(209, 126);
            tbDetails.TabIndex = 22;
>>>>>>> Stashed changes
            // 
            // label6
            // 
<<<<<<< Updated upstream
            label6.AutoSize = true;
            label6.Location = new Point(252, 123);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 21;
            label6.Text = "Comments:";
=======
            lbDetails.AutoSize = true;
            lbDetails.Location = new Point(200, 261);
            lbDetails.Margin = new Padding(2, 0, 2, 0);
            lbDetails.Name = "lbDetails";
            lbDetails.Size = new Size(45, 15);
            lbDetails.TabIndex = 21;
            lbDetails.Text = "Details:";
>>>>>>> Stashed changes
            // 
            // textBox5
            // 
<<<<<<< Updated upstream
            textBox5.Location = new Point(353, 66);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(195, 31);
            textBox5.TabIndex = 20;
=======
            lbPriority.AutoSize = true;
            lbPriority.Location = new Point(202, 140);
            lbPriority.Margin = new Padding(2, 0, 2, 0);
            lbPriority.Name = "lbPriority";
            lbPriority.Size = new Size(48, 15);
            lbPriority.TabIndex = 19;
            lbPriority.Text = "Priority:";
>>>>>>> Stashed changes
            // 
            // label5
            // 
<<<<<<< Updated upstream
            label5.AutoSize = true;
            label5.Location = new Point(252, 72);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 19;
            label5.Text = "Status:";
=======
            cdPriority.FormattingEnabled = true;
            cdPriority.Items.AddRange(new object[] { "Low", "Medium", "High", "Urgent" });
            cdPriority.Location = new Point(276, 140);
            cdPriority.Margin = new Padding(3, 2, 3, 2);
            cdPriority.Name = "cdPriority";
            cdPriority.Size = new Size(133, 23);
            cdPriority.TabIndex = 25;
            cdPriority.SelectedIndexChanged += cbPriority_SelectedIndexChanged;
>>>>>>> Stashed changes
            // 
            // CustomerForm
            // 
<<<<<<< Updated upstream
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Name = "CustomerForm";
            Text = "Form2";
=======
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
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 482);
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
>>>>>>> Stashed changes
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label9;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox5;
        private Label label5;
    }
}