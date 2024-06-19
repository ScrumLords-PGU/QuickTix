namespace QuickTix
{
    partial class LoginForm : Form
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
            tbPassword = new TextBox();
            label2 = new Label();
            tbUsername = new TextBox();
            label1 = new Label();
            label5 = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // tbPassword
            // 
            tbPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbPassword.Location = new Point(161, 140);
            tbPassword.Margin = new Padding(2);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(224, 29);
            tbPassword.TabIndex = 11;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.KeyDown += tbPassword_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 144);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 10;
            label2.Text = "Password:";
            // 
            // tbUsername
            // 
            tbUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsername.Location = new Point(161, 104);
            tbUsername.Margin = new Padding(2);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(224, 29);
            tbUsername.TabIndex = 9;
            tbUsername.KeyDown += tbUsername_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 104);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 8;
            label1.Text = "Username:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(77, 38);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(414, 51);
            label5.TabIndex = 16;
            label5.Text = "Welcome to QuickTix!";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(208, 192);
            btnLogin.Margin = new Padding(2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(128, 56);
            btnLogin.TabIndex = 17;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnConnect_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnLogin);
            Controls.Add(label5);
            Controls.Add(tbPassword);
            Controls.Add(label2);
            Controls.Add(tbUsername);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbPassword;
        private Label label2;
        private TextBox tbUsername;
        private Label label1;
        private Label label5;
        private Button btnLogin;
    }
}