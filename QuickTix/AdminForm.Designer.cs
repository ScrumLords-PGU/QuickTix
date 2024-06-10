namespace QuickTix
{
    partial class AdminForm
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
            txtNewUsername = new TextBox();
            txtNewPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnCreateUser = new Button();
            tchView = new Button();
            tchForm = new Button();
            cstForm = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNewUsername
            // 
            txtNewUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewUsername.Location = new Point(248, 184);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(248, 29);
            txtNewUsername.TabIndex = 0;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(248, 232);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(248, 29);
            txtNewPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(145, 188);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(145, 232);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btnCreateUser
            // 
            btnCreateUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateUser.Location = new Point(248, 295);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(248, 63);
            btnCreateUser.TabIndex = 4;
            btnCreateUser.Text = "Create New User";
            btnCreateUser.UseVisualStyleBackColor = true;
            // 
            // tchView
            // 
            tchView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tchView.Location = new Point(3, 3);
            tchView.Name = "tchView";
            tchView.Size = new Size(145, 61);
            tchView.TabIndex = 5;
            tchView.Text = "Technician View";
            tchView.UseVisualStyleBackColor = true;
            tchView.Click += tchView_Click;
            // 
            // tchForm
            // 
            tchForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tchForm.Location = new Point(154, 3);
            tchForm.Name = "tchForm";
            tchForm.Size = new Size(145, 61);
            tchForm.TabIndex = 6;
            tchForm.Text = "Technician Form";
            tchForm.UseVisualStyleBackColor = true;
            tchForm.Click += tchForm_Click;
            // 
            // cstForm
            // 
            cstForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cstForm.Location = new Point(305, 3);
            cstForm.Name = "cstForm";
            cstForm.Size = new Size(142, 61);
            cstForm.TabIndex = 7;
            cstForm.Text = "Customer Form";
            cstForm.UseVisualStyleBackColor = true;
            cstForm.Click += cstForm_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(tchView);
            flowLayoutPanel1.Controls.Add(tchForm);
            flowLayoutPanel1.Controls.Add(cstForm);
            flowLayoutPanel1.Location = new Point(119, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(454, 68);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(655, 482);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnCreateUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNewPassword);
            Controls.Add(txtNewUsername);
            Name = "AdminForm";
            Text = "AdminForm";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNewUsername;
        private TextBox txtNewPassword;
        private Label label1;
        private Label label2;
        private Button btnCreateUser;
        private Button tchView;
        private Button tchForm;
        private Button cstForm;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}