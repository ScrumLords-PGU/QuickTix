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
            cstForm = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            roleAssignment = new ComboBox();
            lgOut = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtNewUsername
            // 
            txtNewUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewUsername.Location = new Point(422, 290);
            txtNewUsername.Margin = new Padding(3, 4, 3, 4);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(283, 34);
            txtNewUsername.TabIndex = 0;
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(422, 354);
            txtNewPassword.Margin = new Padding(3, 4, 3, 4);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(283, 34);
            txtNewPassword.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(307, 294);
            label1.Name = "label1";
            label1.Size = new Size(121, 32);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(314, 357);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btnCreateUser
            // 
            btnCreateUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreateUser.Location = new Point(407, 472);
            btnCreateUser.Margin = new Padding(3, 4, 3, 4);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(283, 84);
            btnCreateUser.TabIndex = 4;
            btnCreateUser.Text = "Create New User";
            btnCreateUser.UseVisualStyleBackColor = true;
            // 
            // tchView
            // 
            tchView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tchView.Location = new Point(64, 331);
            tchView.Margin = new Padding(3, 4, 3, 4);
            tchView.Name = "tchView";
            tchView.Size = new Size(166, 81);
            tchView.TabIndex = 5;
            tchView.Text = "Technician View";
            tchView.UseVisualStyleBackColor = true;
            tchView.Click += tchView_Click;
            // 
            // cstForm
            // 
            cstForm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cstForm.Location = new Point(68, 442);
            cstForm.Margin = new Padding(3, 4, 3, 4);
            cstForm.Name = "cstForm";
            cstForm.Size = new Size(162, 81);
            cstForm.TabIndex = 7;
            cstForm.Text = "Customer Form";
            cstForm.UseVisualStyleBackColor = true;
            cstForm.Click += cstForm_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(54, 318);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(193, 219);
            flowLayoutPanel1.TabIndex = 8;
            // 
            // roleAssignment
            // 
            roleAssignment.FormattingEnabled = true;
            roleAssignment.Location = new Point(459, 418);
            roleAssignment.Margin = new Padding(3, 4, 3, 4);
            roleAssignment.Name = "roleAssignment";
            roleAssignment.Size = new Size(188, 28);
            roleAssignment.TabIndex = 9;
            // 
            // lgOut
            // 
            lgOut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lgOut.Location = new Point(491, 579);
            lgOut.Margin = new Padding(3, 4, 3, 4);
            lgOut.Name = "lgOut";
            lgOut.Size = new Size(119, 43);
            lgOut.TabIndex = 10;
            lgOut.Text = "Logout";
            lgOut.UseVisualStyleBackColor = true;
            lgOut.Click += lgOut_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_06_29_185255;
            pictureBox1.Location = new Point(51, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(654, 244);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 643);
            Controls.Add(pictureBox1);
            Controls.Add(cstForm);
            Controls.Add(tchView);
            Controls.Add(lgOut);
            Controls.Add(roleAssignment);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnCreateUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNewPassword);
            Controls.Add(txtNewUsername);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button cstForm;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox roleAssignment;
        private Button lgOut;
        private PictureBox pictureBox1;
    }
}