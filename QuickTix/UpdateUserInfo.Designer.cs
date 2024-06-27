namespace QuickTix
{
    partial class UpdateUserInfo
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
            lbHeading1 = new Label();
            btUpdate = new Button();
            tbCancel = new Button();
            tbPhone = new TextBox();
            tbEmail = new TextBox();
            cbPhone = new CheckBox();
            cbEmail = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbHeading1
            // 
            lbHeading1.AutoSize = true;
            lbHeading1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHeading1.Location = new Point(107, 22);
            lbHeading1.Name = "lbHeading1";
            lbHeading1.Size = new Size(471, 46);
            lbHeading1.TabIndex = 0;
            lbHeading1.Text = "Update Contact Information";
            // 
            // btUpdate
            // 
            btUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btUpdate.Location = new Point(185, 402);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new Size(159, 42);
            btUpdate.TabIndex = 5;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // tbCancel
            // 
            tbCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbCancel.Location = new Point(364, 403);
            tbCancel.Name = "tbCancel";
            tbCancel.Size = new Size(113, 43);
            tbCancel.TabIndex = 6;
            tbCancel.Text = "Cancel";
            tbCancel.UseVisualStyleBackColor = true;
            tbCancel.Click += tbCancel_Click;
            // 
            // tbPhone
            // 
            tbPhone.BackColor = SystemColors.Window;
            tbPhone.Enabled = false;
            tbPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPhone.Location = new Point(221, 205);
            tbPhone.Name = "tbPhone";
            tbPhone.ReadOnly = true;
            tbPhone.Size = new Size(237, 34);
            tbPhone.TabIndex = 7;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = SystemColors.Window;
            tbEmail.Enabled = false;
            tbEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbEmail.Location = new Point(221, 314);
            tbEmail.Name = "tbEmail";
            tbEmail.ReadOnly = true;
            tbEmail.Size = new Size(237, 34);
            tbEmail.TabIndex = 8;
            // 
            // cbPhone
            // 
            cbPhone.AutoSize = true;
            cbPhone.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbPhone.Location = new Point(221, 164);
            cbPhone.Name = "cbPhone";
            cbPhone.Size = new Size(200, 35);
            cbPhone.TabIndex = 9;
            cbPhone.Text = "Phone Number:";
            cbPhone.UseVisualStyleBackColor = true;
            cbPhone.CheckedChanged += cbPhone_CheckedChanged;
            // 
            // cbEmail
            // 
            cbEmail.AutoSize = true;
            cbEmail.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbEmail.Location = new Point(221, 273);
            cbEmail.Name = "cbEmail";
            cbEmail.Size = new Size(98, 35);
            cbEmail.TabIndex = 10;
            cbEmail.Text = "Email:";
            cbEmail.UseVisualStyleBackColor = true;
            cbEmail.CheckedChanged += cbEmail_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 85);
            label1.Name = "label1";
            label1.Size = new Size(610, 38);
            label1.TabIndex = 11;
            label1.Text = "Select the information you would like to change";
            // 
            // UpdateUserInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 503);
            Controls.Add(label1);
            Controls.Add(cbEmail);
            Controls.Add(cbPhone);
            Controls.Add(tbEmail);
            Controls.Add(tbPhone);
            Controls.Add(tbCancel);
            Controls.Add(btUpdate);
            Controls.Add(lbHeading1);
            Name = "UpdateUserInfo";
            Text = "Contact Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbHeading1;
        private Button btUpdate;
        private Button tbCancel;
        private TextBox tbPhone;
        private TextBox tbEmail;
        private CheckBox cbPhone;
        private CheckBox cbEmail;
        private Label label1;
    }
}