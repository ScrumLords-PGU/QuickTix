namespace QuickTix
{
    partial class TechnicianForm
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
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(295, 392);
            button1.Name = "button1";
            button1.Size = new Size(183, 34);
            button1.TabIndex = 24;
            button1.Text = "Submit Ticket";
            button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(252, 24);
            label9.Name = "label9";
            label9.Size = new Size(84, 25);
            label9.TabIndex = 23;
            label9.Text = "Ticket ID:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(252, 151);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(296, 207);
            textBox6.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(252, 123);
            label6.Name = "label6";
            label6.Size = new Size(103, 25);
            label6.TabIndex = 21;
            label6.Text = "Comments:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(353, 66);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(195, 31);
            textBox5.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(252, 72);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 19;
            label5.Text = "Status:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(353, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 31);
            textBox1.TabIndex = 25;
            // 
            // TechnicianForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Name = "TechnicianForm";
            Text = "TechnicianForm";
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
        private TextBox textBox1;
    }
}