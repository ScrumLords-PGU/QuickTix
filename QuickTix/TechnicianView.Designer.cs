namespace QuickTix
{
    partial class TechnicianView
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
            splitContainer1 = new SplitContainer();
            tabControl = new TabControl();
            tabOpen = new TabPage();
            listOpen = new ListView();
            tabAssigned = new TabPage();
            listAssigned = new ListView();
            tabClosed = new TabPage();
            listClosed = new ListView();
            tabResolved = new TabPage();
            lblComment = new Label();
            lblDescription = new Label();
            txtComment = new TextBox();
            flowLayoutPanelComments = new FlowLayoutPanel();
            txtCommentsNew = new TextBox();
            lblComments = new Label();
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblState = new Label();
            lblPriority = new Label();
            lblCategory = new Label();
            lblAssigned = new Label();
            bxPriority = new ComboBox();
            txtPhone = new TextBox();
            bxCategory = new ComboBox();
            bxAssigned = new ComboBox();
            txtLocation = new TextBox();
            txtEmail = new TextBox();
            txtCaller = new TextBox();
            lblEmail = new Label();
            lblLocation = new Label();
            lblPhone = new Label();
            lblCaller = new Label();
            bxState = new ComboBox();
            txtDescription = new TextBox();
            txtUpdatedDate = new TextBox();
            label13 = new Label();
            txtCreatedDate = new TextBox();
            txtID = new TextBox();
            lgOut = new Button();
            btnUpdate = new Button();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl.SuspendLayout();
            tabOpen.SuspendLayout();
            tabAssigned.SuspendLayout();
            tabClosed.SuspendLayout();
            flowLayoutPanelComments.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(2, 1, 2, 1);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControl);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Control;
            splitContainer1.Panel2.Controls.Add(lblComment);
            splitContainer1.Panel2.Controls.Add(lblDescription);
            splitContainer1.Panel2.Controls.Add(txtComment);
            splitContainer1.Panel2.Controls.Add(flowLayoutPanelComments);
            splitContainer1.Panel2.Controls.Add(lblComments);
            splitContainer1.Panel2.Controls.Add(lblTitle);
            splitContainer1.Panel2.Controls.Add(txtTitle);
            splitContainer1.Panel2.Controls.Add(lblState);
            splitContainer1.Panel2.Controls.Add(lblPriority);
            splitContainer1.Panel2.Controls.Add(lblCategory);
            splitContainer1.Panel2.Controls.Add(lblAssigned);
            splitContainer1.Panel2.Controls.Add(bxPriority);
            splitContainer1.Panel2.Controls.Add(txtPhone);
            splitContainer1.Panel2.Controls.Add(bxCategory);
            splitContainer1.Panel2.Controls.Add(bxAssigned);
            splitContainer1.Panel2.Controls.Add(txtLocation);
            splitContainer1.Panel2.Controls.Add(txtEmail);
            splitContainer1.Panel2.Controls.Add(txtCaller);
            splitContainer1.Panel2.Controls.Add(lblEmail);
            splitContainer1.Panel2.Controls.Add(lblLocation);
            splitContainer1.Panel2.Controls.Add(lblPhone);
            splitContainer1.Panel2.Controls.Add(lblCaller);
            splitContainer1.Panel2.Controls.Add(bxState);
            splitContainer1.Panel2.Controls.Add(txtDescription);
            splitContainer1.Panel2.Controls.Add(txtUpdatedDate);
            splitContainer1.Panel2.Controls.Add(label13);
            splitContainer1.Panel2.Controls.Add(txtCreatedDate);
            splitContainer1.Panel2.Controls.Add(txtID);
            splitContainer1.Panel2.Controls.Add(lgOut);
            splitContainer1.Panel2.Controls.Add(btnUpdate);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Size = new Size(1664, 861);
            splitContainer1.SplitterDistance = 410;
            splitContainer1.SplitterWidth = 2;
            splitContainer1.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabOpen);
            tabControl.Controls.Add(tabAssigned);
            tabControl.Controls.Add(tabClosed);
            tabControl.Controls.Add(tabResolved);
            tabControl.Dock = DockStyle.Fill;
            tabControl.ImeMode = ImeMode.Off;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(2, 1, 2, 1);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(410, 861);
            tabControl.TabIndex = 0;
            // 
            // tabOpen
            // 
            tabOpen.Controls.Add(listOpen);
            tabOpen.Font = new Font("Segoe UI", 10F);
            tabOpen.Location = new Point(4, 24);
            tabOpen.Margin = new Padding(2, 1, 2, 1);
            tabOpen.Name = "tabOpen";
            tabOpen.Padding = new Padding(2, 1, 2, 1);
            tabOpen.Size = new Size(402, 833);
            tabOpen.TabIndex = 0;
            tabOpen.Text = "Open";
            tabOpen.UseVisualStyleBackColor = true;
            // 
            // listOpen
            // 
            listOpen.Activation = ItemActivation.OneClick;
            listOpen.BorderStyle = BorderStyle.FixedSingle;
            listOpen.Cursor = Cursors.Hand;
            listOpen.Dock = DockStyle.Fill;
            listOpen.Font = new Font("Segoe UI", 14F);
            listOpen.FullRowSelect = true;
            listOpen.GridLines = true;
            listOpen.Location = new Point(2, 1);
            listOpen.Margin = new Padding(2);
            listOpen.MultiSelect = false;
            listOpen.Name = "listOpen";
            listOpen.RightToLeft = RightToLeft.No;
            listOpen.ShowItemToolTips = true;
            listOpen.Size = new Size(398, 831);
            listOpen.TabIndex = 1;
            listOpen.TileSize = new Size(400, 80);
            listOpen.UseCompatibleStateImageBehavior = false;
            listOpen.View = View.List;
            // 
            // tabAssigned
            // 
            tabAssigned.Controls.Add(listAssigned);
            tabAssigned.Location = new Point(4, 24);
            tabAssigned.Margin = new Padding(2, 1, 2, 1);
            tabAssigned.Name = "tabAssigned";
            tabAssigned.Padding = new Padding(2, 1, 2, 1);
            tabAssigned.Size = new Size(332, 833);
            tabAssigned.TabIndex = 1;
            tabAssigned.Text = "Assigned";
            tabAssigned.UseVisualStyleBackColor = true;
            // 
            // listAssigned
            // 
            listAssigned.Activation = ItemActivation.OneClick;
            listAssigned.BorderStyle = BorderStyle.FixedSingle;
            listAssigned.Cursor = Cursors.Hand;
            listAssigned.Dock = DockStyle.Fill;
            listAssigned.Font = new Font("Segoe UI", 14F);
            listAssigned.FullRowSelect = true;
            listAssigned.GridLines = true;
            listAssigned.Location = new Point(2, 1);
            listAssigned.Margin = new Padding(2);
            listAssigned.MultiSelect = false;
            listAssigned.Name = "listAssigned";
            listAssigned.RightToLeft = RightToLeft.No;
            listAssigned.ShowItemToolTips = true;
            listAssigned.Size = new Size(328, 831);
            listAssigned.TabIndex = 1;
            listAssigned.TileSize = new Size(400, 80);
            listAssigned.UseCompatibleStateImageBehavior = false;
            listAssigned.View = View.List;
            // 
            // tabClosed
            // 
            tabClosed.Controls.Add(listClosed);
            tabClosed.Location = new Point(4, 24);
            tabClosed.Margin = new Padding(2, 1, 2, 1);
            tabClosed.Name = "tabClosed";
            tabClosed.Padding = new Padding(2, 1, 2, 1);
            tabClosed.Size = new Size(332, 833);
            tabClosed.TabIndex = 2;
            tabClosed.Text = "Closed";
            tabClosed.UseVisualStyleBackColor = true;
            // 
            // listClosed
            // 
            listClosed.Activation = ItemActivation.OneClick;
            listClosed.BorderStyle = BorderStyle.FixedSingle;
            listClosed.Cursor = Cursors.Hand;
            listClosed.Dock = DockStyle.Fill;
            listClosed.Font = new Font("Segoe UI", 14F);
            listClosed.FullRowSelect = true;
            listClosed.GridLines = true;
            listClosed.Location = new Point(2, 1);
            listClosed.Margin = new Padding(2);
            listClosed.MultiSelect = false;
            listClosed.Name = "listClosed";
            listClosed.RightToLeft = RightToLeft.No;
            listClosed.ShowItemToolTips = true;
            listClosed.Size = new Size(328, 831);
            listClosed.TabIndex = 0;
            listClosed.TileSize = new Size(400, 80);
            listClosed.UseCompatibleStateImageBehavior = false;
            listClosed.View = View.List;
            // 
            // tabResolved
            // 
            tabResolved.Location = new Point(4, 24);
            tabResolved.Name = "tabResolved";
            tabResolved.Size = new Size(332, 833);
            tabResolved.TabIndex = 3;
            tabResolved.Text = "Resolved";
            tabResolved.UseVisualStyleBackColor = true;
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComment.Location = new Point(100, 319);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(79, 21);
            lblComment.TabIndex = 49;
            lblComment.Text = "Comment";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(88, 259);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(89, 21);
            lblDescription.TabIndex = 48;
            lblDescription.Text = "Description";
            // 
            // txtComment
            // 
            txtComment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComment.Location = new Point(184, 319);
            txtComment.Margin = new Padding(0, 4, 2, 1);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(704, 85);
            txtComment.TabIndex = 47;
            // 
            // flowLayoutPanelComments
            // 
            flowLayoutPanelComments.AutoScroll = true;
            flowLayoutPanelComments.Controls.Add(txtCommentsNew);
            flowLayoutPanelComments.Location = new Point(184, 427);
            flowLayoutPanelComments.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanelComments.Name = "flowLayoutPanelComments";
            flowLayoutPanelComments.Size = new Size(704, 432);
            flowLayoutPanelComments.TabIndex = 46;
            // 
            // txtCommentsNew
            // 
            txtCommentsNew.Dock = DockStyle.Top;
            txtCommentsNew.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCommentsNew.Location = new Point(3, 2);
            txtCommentsNew.Margin = new Padding(3, 2, 3, 2);
            txtCommentsNew.Multiline = true;
            txtCommentsNew.Name = "txtCommentsNew";
            txtCommentsNew.Size = new Size(701, 102);
            txtCommentsNew.TabIndex = 0;
            // 
            // lblComments
            // 
            lblComments.AutoSize = true;
            lblComments.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComments.Location = new Point(88, 427);
            lblComments.Name = "lblComments";
            lblComments.Size = new Size(86, 21);
            lblComments.TabIndex = 45;
            lblComments.Text = "Comments";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(386, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(39, 21);
            lblTitle.TabIndex = 44;
            lblTitle.Text = "Title";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(450, 16);
            txtTitle.Margin = new Padding(0, 4, 2, 1);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(263, 29);
            txtTitle.TabIndex = 43;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblState.Location = new Point(616, 103);
            lblState.Name = "lblState";
            lblState.Size = new Size(44, 21);
            lblState.TabIndex = 41;
            lblState.Text = "State";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPriority.Location = new Point(604, 139);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(61, 21);
            lblPriority.TabIndex = 40;
            lblPriority.Text = "Priority";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(592, 175);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(73, 21);
            lblCategory.TabIndex = 39;
            lblCategory.Text = "Category";
            // 
            // lblAssigned
            // 
            lblAssigned.AutoSize = true;
            lblAssigned.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAssigned.Location = new Point(580, 211);
            lblAssigned.Name = "lblAssigned";
            lblAssigned.Size = new Size(91, 21);
            lblAssigned.TabIndex = 38;
            lblAssigned.Text = "Assigned to";
            // 
            // bxPriority
            // 
            bxPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            bxPriority.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bxPriority.FormattingEnabled = true;
            bxPriority.Location = new Point(676, 139);
            bxPriority.Margin = new Padding(3, 2, 3, 2);
            bxPriority.Name = "bxPriority";
            bxPriority.Size = new Size(179, 29);
            bxPriority.TabIndex = 37;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(268, 211);
            txtPhone.Margin = new Padding(0, 4, 2, 1);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(239, 29);
            txtPhone.TabIndex = 36;
            // 
            // bxCategory
            // 
            bxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            bxCategory.DropDownWidth = 123;
            bxCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bxCategory.FormattingEnabled = true;
            bxCategory.Location = new Point(676, 175);
            bxCategory.Margin = new Padding(3, 2, 3, 2);
            bxCategory.Name = "bxCategory";
            bxCategory.Size = new Size(180, 29);
            bxCategory.TabIndex = 2;
            // 
            // bxAssigned
            // 
            bxAssigned.DropDownStyle = ComboBoxStyle.DropDownList;
            bxAssigned.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bxAssigned.FormattingEnabled = true;
            bxAssigned.Location = new Point(676, 211);
            bxAssigned.Margin = new Padding(3, 2, 3, 2);
            bxAssigned.Name = "bxAssigned";
            bxAssigned.Size = new Size(210, 29);
            bxAssigned.TabIndex = 18;
            // 
            // txtLocation
            // 
            txtLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocation.Location = new Point(268, 175);
            txtLocation.Margin = new Padding(0, 4, 2, 1);
            txtLocation.Name = "txtLocation";
            txtLocation.ReadOnly = true;
            txtLocation.Size = new Size(239, 29);
            txtLocation.TabIndex = 35;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(268, 139);
            txtEmail.Margin = new Padding(0, 4, 2, 1);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(239, 29);
            txtEmail.TabIndex = 34;
            // 
            // txtCaller
            // 
            txtCaller.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCaller.Location = new Point(268, 103);
            txtCaller.Margin = new Padding(0, 4, 2, 1);
            txtCaller.Name = "txtCaller";
            txtCaller.ReadOnly = true;
            txtCaller.Size = new Size(239, 29);
            txtCaller.TabIndex = 25;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(208, 139);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 31;
            lblEmail.Text = "Email";
            lblEmail.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocation.Location = new Point(196, 175);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(69, 21);
            lblLocation.TabIndex = 33;
            lblLocation.Text = "Location";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(208, 211);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(54, 21);
            lblPhone.TabIndex = 32;
            lblPhone.Text = "Phone";
            // 
            // lblCaller
            // 
            lblCaller.AutoSize = true;
            lblCaller.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCaller.Location = new Point(208, 103);
            lblCaller.Name = "lblCaller";
            lblCaller.Size = new Size(50, 21);
            lblCaller.TabIndex = 28;
            lblCaller.Text = "Caller";
            lblCaller.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // bxState
            // 
            bxState.DropDownStyle = ComboBoxStyle.DropDownList;
            bxState.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bxState.FormattingEnabled = true;
            bxState.Location = new Point(676, 103);
            bxState.Margin = new Padding(3, 2, 3, 2);
            bxState.Name = "bxState";
            bxState.Size = new Size(180, 29);
            bxState.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(184, 259);
            txtDescription.Margin = new Padding(0, 4, 2, 1);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(704, 36);
            txtDescription.TabIndex = 1;
            // 
            // txtUpdatedDate
            // 
            txtUpdatedDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUpdatedDate.Location = new Point(724, 55);
            txtUpdatedDate.Margin = new Padding(3, 2, 3, 2);
            txtUpdatedDate.Name = "txtUpdatedDate";
            txtUpdatedDate.ReadOnly = true;
            txtUpdatedDate.Size = new Size(144, 25);
            txtUpdatedDate.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(647, 56);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(72, 21);
            label13.TabIndex = 18;
            label13.Text = "Updated:";
            // 
            // txtCreatedDate
            // 
            txtCreatedDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCreatedDate.Location = new Point(448, 55);
            txtCreatedDate.Margin = new Padding(3, 2, 3, 2);
            txtCreatedDate.Name = "txtCreatedDate";
            txtCreatedDate.ReadOnly = true;
            txtCreatedDate.Size = new Size(144, 25);
            txtCreatedDate.TabIndex = 17;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(280, 55);
            txtID.Margin = new Padding(3, 2, 3, 2);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(72, 25);
            txtID.TabIndex = 16;
            // 
            // lgOut
            // 
            lgOut.Location = new Point(1092, 25);
            lgOut.Margin = new Padding(3, 2, 3, 2);
            lgOut.Name = "lgOut";
            lgOut.Size = new Size(111, 27);
            lgOut.TabIndex = 15;
            lgOut.Text = "Logout";
            lgOut.UseVisualStyleBackColor = true;
            lgOut.Click += lgOut_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(912, 360);
            btnUpdate.Margin = new Padding(2, 1, 2, 1);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(178, 44);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(376, 57);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 21);
            label3.TabIndex = 3;
            label3.Text = "Created: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(238, 56);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 21);
            label2.TabIndex = 1;
            label2.Text = "ID #";
            // 
            // TechnicianView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1664, 861);
            Controls.Add(splitContainer1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "TechnicianView";
            Text = "TechnicianView";
            Load += TechnicianView_Load_1;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabOpen.ResumeLayout(false);
            tabAssigned.ResumeLayout(false);
            tabClosed.ResumeLayout(false);
            flowLayoutPanelComments.ResumeLayout(false);
            flowLayoutPanelComments.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TabControl tabControl;
        private TabPage tabOpen;
        private TabPage tabAssigned;
        private TabPage tabClosed;
        private ListView listClosed;
        private Label label2;
        private TextBox txtDescription;
        private Label label3;
        private ListView listOpen;
        private ListView listAssigned;
        private Button btnUpdate;
        private Button lgOut;
        private ComboBox bxState;
        private ComboBox bxCategory;
        private TextBox txtCreatedDate;
        private TextBox txtID;
        private ComboBox bxAssigned;
        private TextBox txtUpdatedDate;
        private Label label13;
        private TextBox txtCaller;
        private Label lblEmail;
        private Label lblLocation;
        private Label lblPhone;
        private Label lblCaller;
        private TextBox txtPhone;
        private TextBox txtLocation;
        private TextBox txtEmail;
        private ComboBox bxPriority;
        private Label lblState;
        private Label lblPriority;
        private Label lblCategory;
        private Label lblAssigned;
        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblComments;
        private TextBox txtCommentsNew;
        private FlowLayoutPanel flowLayoutPanelComments;
        private Label lblComment;
        private Label lblDescription;
        private TextBox txtComment;
        private TabPage tabResolved;
    }
}