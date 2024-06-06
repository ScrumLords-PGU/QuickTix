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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label9 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            controllerBindingSource1 = new BindingSource(components);
            controllerBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)controllerBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)controllerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(392, 576);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(128, 20);
            button1.TabIndex = 24;
            button1.Text = "Submit Ticket";
            button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(264, 320);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 23;
            label9.Text = "Ticket ID:";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(352, 408);
            textBox6.Margin = new Padding(2);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(208, 126);
            textBox6.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(408, 376);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 21;
            label6.Text = "Comments:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(584, 312);
            textBox5.Margin = new Padding(2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(138, 23);
            textBox5.TabIndex = 20;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(528, 320);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 19;
            label5.Text = "Status:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(320, 312);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 23);
            textBox1.TabIndex = 25;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = controllerBindingSource1;
            dataGridView1.Location = new Point(40, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(960, 248);
            dataGridView1.TabIndex = 26;
            // 
            // controllerBindingSource1
            // 
            controllerBindingSource1.DataSource = typeof(Controller);
            // 
            // controllerBindingSource
            // 
            controllerBindingSource.DataSource = typeof(Controller);
            // 
            // TechnicianForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 811);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Name = "TechnicianForm";
            Text = "TechnicianForm";
            Controls.SetChildIndex(label5, 0);
            Controls.SetChildIndex(textBox5, 0);
            Controls.SetChildIndex(label6, 0);
            Controls.SetChildIndex(textBox6, 0);
            Controls.SetChildIndex(label9, 0);
            Controls.SetChildIndex(button1, 0);
            Controls.SetChildIndex(textBox1, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)controllerBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)controllerBindingSource).EndInit();
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
        private DataGridView dataGridView1;
        private BindingSource controllerBindingSource;
        private BindingSource controllerBindingSource1;
    }
}