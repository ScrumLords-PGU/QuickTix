namespace QuickTix
{
    partial class AioForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 38);
            label1.Name = "label1";
            label1.Size = new Size(95, 25);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(168, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 31);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(168, 82);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(195, 31);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 88);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(560, 32);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 31);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(459, 38);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 4;
            label3.Text = "Server:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(560, 82);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(195, 31);
            textBox4.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(459, 88);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 6;
            label4.Text = "Database:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(168, 223);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(195, 31);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 229);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 8;
            label5.Text = "Status:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(67, 308);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(296, 207);
            textBox6.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 280);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 10;
            label6.Text = "Comments:";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(459, 308);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(296, 207);
            textBox7.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(459, 280);
            label7.Name = "label7";
            label7.Size = new Size(103, 25);
            label7.TabIndex = 14;
            label7.Text = "Comments:";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(560, 223);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(195, 31);
            textBox8.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(459, 229);
            label8.Name = "label8";
            label8.Size = new Size(95, 25);
            label8.TabIndex = 12;
            label8.Text = "Technician:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(67, 181);
            label9.Name = "label9";
            label9.Size = new Size(160, 25);
            label9.TabIndex = 16;
            label9.Text = "Ticket Information:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(459, 181);
            label10.Name = "label10";
            label10.Size = new Size(99, 25);
            label10.TabIndex = 17;
            label10.Text = "Resolution:";
            // 
            // button1
            // 
            button1.Location = new Point(110, 549);
            button1.Name = "button1";
            button1.Size = new Size(183, 34);
            button1.TabIndex = 18;
            button1.Text = "Submit Ticket";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(512, 549);
            button2.Name = "button2";
            button2.Size = new Size(194, 34);
            button2.TabIndex = 19;
            button2.Text = "Finalize Ticket";
            button2.UseVisualStyleBackColor = true;
            // 
            // AioForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 649);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox8);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "AioForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox8;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Button button2;
    }
}
