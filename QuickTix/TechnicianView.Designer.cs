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
            tabResovled = new TabPage();
            listResolved = new ListView();
            panelOverlay = new Panel();
            label2 = new Label();
            lblComment = new Label();
            label3 = new Label();
            lblDescription = new Label();
            txtCreatedDate = new TextBox();
            txtComment = new TextBox();
            bxAssigned = new ComboBox();
            flowLayoutPanelComments = new FlowLayoutPanel();
            txtCommentsNew = new TextBox();
            lblAssigned = new Label();
            lblComments = new Label();
            lblCategory = new Label();
            txtDescription = new TextBox();
            txtPhone = new TextBox();
            btnUpdate = new Button();
            lblPriority = new Label();
            lblEmail = new Label();
            bxCategory = new ComboBox();
            txtEmail = new TextBox();
            lblPhone = new Label();
            bxState = new ComboBox();
            lblState = new Label();
            txtCaller = new TextBox();
            bxPriority = new ComboBox();
            lblCaller = new Label();
            label13 = new Label();
            txtUpdatedDate = new TextBox();
            lgOut = new Button();
            lblLocation = new Label();
            txtLocation = new TextBox();
            txtID = new TextBox();
            txtTitle = new TextBox();
            lblTitle = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl.SuspendLayout();
            tabOpen.SuspendLayout();
            tabAssigned.SuspendLayout();
            tabClosed.SuspendLayout();
            tabResovled.SuspendLayout();
            flowLayoutPanelComments.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 2, 4, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabControl);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = SystemColors.Control;
            splitContainer1.Panel2.Controls.Add(panelOverlay);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(lblComment);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(lblDescription);
            splitContainer1.Panel2.Controls.Add(txtCreatedDate);
            splitContainer1.Panel2.Controls.Add(txtComment);
            splitContainer1.Panel2.Controls.Add(bxAssigned);
            splitContainer1.Panel2.Controls.Add(flowLayoutPanelComments);
            splitContainer1.Panel2.Controls.Add(lblAssigned);
            splitContainer1.Panel2.Controls.Add(lblComments);
            splitContainer1.Panel2.Controls.Add(lblCategory);
            splitContainer1.Panel2.Controls.Add(txtDescription);
            splitContainer1.Panel2.Controls.Add(txtPhone);
            splitContainer1.Panel2.Controls.Add(btnUpdate);
            splitContainer1.Panel2.Controls.Add(lblPriority);
            splitContainer1.Panel2.Controls.Add(lblEmail);
            splitContainer1.Panel2.Controls.Add(bxCategory);
            splitContainer1.Panel2.Controls.Add(txtEmail);
            splitContainer1.Panel2.Controls.Add(lblPhone);
            splitContainer1.Panel2.Controls.Add(bxState);
            splitContainer1.Panel2.Controls.Add(lblState);
            splitContainer1.Panel2.Controls.Add(txtCaller);
            splitContainer1.Panel2.Controls.Add(bxPriority);
            splitContainer1.Panel2.Controls.Add(lblCaller);
            splitContainer1.Panel2.Controls.Add(label13);
            splitContainer1.Panel2.Controls.Add(txtUpdatedDate);
            splitContainer1.Panel2.Controls.Add(lgOut);
            splitContainer1.Panel2.Controls.Add(lblLocation);
            splitContainer1.Panel2.Controls.Add(txtLocation);
            splitContainer1.Panel2.Controls.Add(txtID);
            splitContainer1.Panel2.Controls.Add(txtTitle);
            splitContainer1.Panel2.Controls.Add(lblTitle);
            splitContainer1.Size = new Size(2884, 1759);
            splitContainer1.SplitterDistance = 900;
            splitContainer1.TabIndex = 0;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabOpen);
            tabControl.Controls.Add(tabAssigned);
            tabControl.Controls.Add(tabClosed);
            tabControl.Controls.Add(tabResovled);
            tabControl.ImeMode = ImeMode.Off;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(4, 2, 4, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(905, 1759);
            tabControl.TabIndex = 0;
            tabControl.Click += showTechViewOverlay;
            // 
            // tabOpen
            // 
            tabOpen.Controls.Add(listOpen);
            tabOpen.Font = new Font("Segoe UI", 10F);
            tabOpen.Location = new Point(8, 46);
            tabOpen.Margin = new Padding(4, 2, 4, 2);
            tabOpen.Name = "tabOpen";
            tabOpen.Padding = new Padding(4, 2, 4, 2);
            tabOpen.Size = new Size(889, 1705);
            tabOpen.TabIndex = 0;
            tabOpen.Text = "Open";
            tabOpen.UseVisualStyleBackColor = true;
            tabOpen.Click += showTechViewOverlay;
            // 
            // listOpen
            // 
            listOpen.Activation = ItemActivation.OneClick;
            listOpen.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listOpen.BorderStyle = BorderStyle.FixedSingle;
            listOpen.Cursor = Cursors.Hand;
            listOpen.Font = new Font("Segoe UI", 14F);
            listOpen.FullRowSelect = true;
            listOpen.GridLines = true;
            listOpen.Location = new Point(4, 2);
            listOpen.Margin = new Padding(4);
            listOpen.MultiSelect = false;
            listOpen.Name = "listOpen";
            listOpen.RightToLeft = RightToLeft.No;
            listOpen.ShowItemToolTips = true;
            listOpen.Size = new Size(881, 1701);
            listOpen.TabIndex = 1;
            listOpen.TileSize = new Size(400, 80);
            listOpen.UseCompatibleStateImageBehavior = false;
            listOpen.View = View.List;
            listOpen.SelectedIndexChanged += listOpen_SelectedIndexChanged;
            // 
            // tabAssigned
            // 
            tabAssigned.Controls.Add(listAssigned);
            tabAssigned.Location = new Point(8, 46);
            tabAssigned.Margin = new Padding(4, 2, 4, 2);
            tabAssigned.Name = "tabAssigned";
            tabAssigned.Padding = new Padding(4, 2, 4, 2);
            tabAssigned.Size = new Size(789, 1705);
            tabAssigned.TabIndex = 1;
            tabAssigned.Text = "Assigned";
            tabAssigned.UseVisualStyleBackColor = true;
            tabAssigned.Click += showTechViewOverlay;
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
            listAssigned.Location = new Point(4, 2);
            listAssigned.Margin = new Padding(4);
            listAssigned.MultiSelect = false;
            listAssigned.Name = "listAssigned";
            listAssigned.RightToLeft = RightToLeft.No;
            listAssigned.ShowItemToolTips = true;
            listAssigned.Size = new Size(781, 1701);
            listAssigned.TabIndex = 1;
            listAssigned.TileSize = new Size(400, 80);
            listAssigned.UseCompatibleStateImageBehavior = false;
            listAssigned.View = View.List;
            // 
            // tabClosed
            // 
            tabClosed.Controls.Add(listClosed);
            tabClosed.Location = new Point(8, 46);
            tabClosed.Margin = new Padding(4, 2, 4, 2);
            tabClosed.Name = "tabClosed";
            tabClosed.Padding = new Padding(4, 2, 4, 2);
            tabClosed.Size = new Size(789, 1705);
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
            listClosed.Location = new Point(4, 2);
            listClosed.Margin = new Padding(4);
            listClosed.MultiSelect = false;
            listClosed.Name = "listClosed";
            listClosed.RightToLeft = RightToLeft.No;
            listClosed.ShowItemToolTips = true;
            listClosed.Size = new Size(781, 1701);
            listClosed.TabIndex = 0;
            listClosed.TileSize = new Size(400, 80);
            listClosed.UseCompatibleStateImageBehavior = false;
            listClosed.View = View.List;
            listClosed.Click += showTechViewOverlay;
            // 
            // tabResovled
            // 
            tabResovled.Controls.Add(listResolved);
            tabResovled.Location = new Point(8, 46);
            tabResovled.Margin = new Padding(6);
            tabResovled.Name = "tabResovled";
            tabResovled.Size = new Size(789, 1705);
            tabResovled.TabIndex = 3;
            tabResovled.Text = "Resolved";
            tabResovled.UseVisualStyleBackColor = true;
            tabResovled.Click += showTechViewOverlay;
            // 
            // listResolved
            // 
            listResolved.Activation = ItemActivation.OneClick;
            listResolved.BorderStyle = BorderStyle.FixedSingle;
            listResolved.Cursor = Cursors.Hand;
            listResolved.Dock = DockStyle.Fill;
            listResolved.Font = new Font("Segoe UI", 14F);
            listResolved.FullRowSelect = true;
            listResolved.GridLines = true;
            listResolved.Location = new Point(0, 0);
            listResolved.Margin = new Padding(4);
            listResolved.MultiSelect = false;
            listResolved.Name = "listResolved";
            listResolved.RightToLeft = RightToLeft.No;
            listResolved.ShowItemToolTips = true;
            listResolved.Size = new Size(789, 1705);
            listResolved.TabIndex = 1;
            listResolved.TileSize = new Size(400, 80);
            listResolved.UseCompatibleStateImageBehavior = false;
            listResolved.View = View.List;
            // 
            // panelOverlay
            // 
            panelOverlay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelOverlay.Location = new Point(11, 6);
            panelOverlay.Margin = new Padding(6);
            panelOverlay.Name = "panelOverlay";
            panelOverlay.Size = new Size(168, 59);
            panelOverlay.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(143, 141);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 45);
            label2.TabIndex = 1;
            label2.Text = "ID #";
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComment.Location = new Point(143, 826);
            lblComment.Margin = new Padding(6, 0, 6, 0);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(168, 45);
            lblComment.TabIndex = 49;
            lblComment.Text = "Comment:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(449, 140);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(147, 45);
            label3.TabIndex = 3;
            label3.Text = "Created: ";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(143, 642);
            lblDescription.Margin = new Padding(6, 0, 6, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(189, 45);
            lblDescription.TabIndex = 48;
            lblDescription.Text = "Description:";
            // 
            // txtCreatedDate
            // 
            txtCreatedDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtCreatedDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCreatedDate.Location = new Point(606, 140);
            txtCreatedDate.Margin = new Padding(6, 4, 6, 4);
            txtCreatedDate.Name = "txtCreatedDate";
            txtCreatedDate.ReadOnly = true;
            txtCreatedDate.Size = new Size(278, 42);
            txtCreatedDate.TabIndex = 17;
            // 
            // txtComment
            // 
            txtComment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComment.Location = new Point(371, 753);
            txtComment.Margin = new Padding(0, 9, 4, 2);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(738, 177);
            txtComment.TabIndex = 47;
            // 
            // bxAssigned
            // 
            bxAssigned.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            bxAssigned.DropDownStyle = ComboBoxStyle.DropDownList;
            bxAssigned.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bxAssigned.FormattingEnabled = true;
            bxAssigned.Location = new Point(1068, 496);
            bxAssigned.Margin = new Padding(6, 4, 6, 4);
            bxAssigned.Name = "bxAssigned";
            bxAssigned.Size = new Size(292, 53);
            bxAssigned.TabIndex = 18;
            // 
            // flowLayoutPanelComments
            // 
            flowLayoutPanelComments.AutoScroll = true;
            flowLayoutPanelComments.Controls.Add(txtCommentsNew);
            flowLayoutPanelComments.Location = new Point(365, 970);
            flowLayoutPanelComments.Margin = new Padding(6, 4, 6, 4);
            flowLayoutPanelComments.Name = "flowLayoutPanelComments";
            flowLayoutPanelComments.Size = new Size(995, 714);
            flowLayoutPanelComments.TabIndex = 46;
            // 
            // txtCommentsNew
            // 
            txtCommentsNew.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtCommentsNew.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCommentsNew.Location = new Point(6, 4);
            txtCommentsNew.Margin = new Padding(6, 4, 6, 4);
            txtCommentsNew.Multiline = true;
            txtCommentsNew.Name = "txtCommentsNew";
            txtCommentsNew.Size = new Size(1298, 0);
            txtCommentsNew.TabIndex = 0;
            // 
            // lblAssigned
            // 
            lblAssigned.AutoSize = true;
            lblAssigned.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAssigned.Location = new Point(860, 496);
            lblAssigned.Margin = new Padding(6, 0, 6, 0);
            lblAssigned.Name = "lblAssigned";
            lblAssigned.Size = new Size(196, 45);
            lblAssigned.TabIndex = 38;
            lblAssigned.Text = "Assigned to:";
            // 
            // lblComments
            // 
            lblComments.AutoSize = true;
            lblComments.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComments.Location = new Point(143, 1002);
            lblComments.Margin = new Padding(6, 0, 6, 0);
            lblComments.Name = "lblComments";
            lblComments.Size = new Size(182, 45);
            lblComments.TabIndex = 45;
            lblComments.Text = "Comments:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(901, 396);
            lblCategory.Margin = new Padding(6, 0, 6, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(155, 45);
            lblCategory.TabIndex = 39;
            lblCategory.Text = "Category:";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(371, 629);
            txtDescription.Margin = new Padding(0, 9, 4, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(989, 72);
            txtDescription.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(305, 491);
            txtPhone.Margin = new Padding(0, 9, 4, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(536, 50);
            txtPhone.TabIndex = 36;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(1144, 817);
            btnUpdate.Margin = new Padding(4, 2, 4, 2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(216, 63);
            btnUpdate.TabIndex = 14;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPriority.Location = new Point(908, 316);
            lblPriority.Margin = new Padding(6, 0, 6, 0);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(128, 45);
            lblPriority.TabIndex = 40;
            lblPriority.Text = "Priority:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(143, 311);
            lblEmail.Margin = new Padding(6, 0, 6, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(103, 45);
            lblEmail.TabIndex = 31;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.TopCenter;
            // 
            // bxCategory
            // 
            bxCategory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            bxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            bxCategory.DropDownWidth = 123;
            bxCategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bxCategory.FormattingEnabled = true;
            bxCategory.Location = new Point(1068, 393);
            bxCategory.Margin = new Padding(6, 4, 6, 4);
            bxCategory.Name = "bxCategory";
            bxCategory.Size = new Size(292, 53);
            bxCategory.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(305, 311);
            txtEmail.Margin = new Padding(0, 9, 4, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(536, 50);
            txtEmail.TabIndex = 34;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(143, 494);
            lblPhone.Margin = new Padding(6, 0, 6, 0);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(117, 45);
            lblPhone.TabIndex = 32;
            lblPhone.Text = "Phone:";
            // 
            // bxState
            // 
            bxState.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            bxState.DropDownStyle = ComboBoxStyle.DropDownList;
            bxState.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bxState.FormattingEnabled = true;
            bxState.Location = new Point(1068, 224);
            bxState.Margin = new Padding(6, 4, 6, 4);
            bxState.Name = "bxState";
            bxState.Size = new Size(286, 53);
            bxState.TabIndex = 1;
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblState.Location = new Point(908, 232);
            lblState.Margin = new Padding(6, 0, 6, 0);
            lblState.Name = "lblState";
            lblState.Size = new Size(98, 45);
            lblState.TabIndex = 41;
            lblState.Text = "State:";
            // 
            // txtCaller
            // 
            txtCaller.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtCaller.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCaller.Location = new Point(305, 232);
            txtCaller.Margin = new Padding(0, 9, 4, 2);
            txtCaller.Name = "txtCaller";
            txtCaller.ReadOnly = true;
            txtCaller.Size = new Size(536, 50);
            txtCaller.TabIndex = 25;
            // 
            // bxPriority
            // 
            bxPriority.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            bxPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            bxPriority.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bxPriority.FormattingEnabled = true;
            bxPriority.Location = new Point(1064, 311);
            bxPriority.Margin = new Padding(6, 4, 6, 4);
            bxPriority.Name = "bxPriority";
            bxPriority.Size = new Size(286, 53);
            bxPriority.TabIndex = 37;
            // 
            // lblCaller
            // 
            lblCaller.AutoSize = true;
            lblCaller.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCaller.Location = new Point(143, 232);
            lblCaller.Margin = new Padding(6, 0, 6, 0);
            lblCaller.Name = "lblCaller";
            lblCaller.Size = new Size(107, 45);
            lblCaller.TabIndex = 28;
            lblCaller.Text = "Caller:";
            lblCaller.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(908, 136);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(150, 45);
            label13.TabIndex = 18;
            label13.Text = "Updated:";
            // 
            // txtUpdatedDate
            // 
            txtUpdatedDate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtUpdatedDate.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUpdatedDate.Location = new Point(1068, 136);
            txtUpdatedDate.Margin = new Padding(6, 4, 6, 4);
            txtUpdatedDate.Name = "txtUpdatedDate";
            txtUpdatedDate.ReadOnly = true;
            txtUpdatedDate.Size = new Size(286, 42);
            txtUpdatedDate.TabIndex = 19;
            // 
            // lgOut
            // 
            lgOut.Location = new Point(1144, 49);
            lgOut.Margin = new Padding(6, 4, 6, 4);
            lgOut.Name = "lgOut";
            lgOut.Size = new Size(206, 58);
            lgOut.TabIndex = 15;
            lgOut.Text = "Logout";
            lgOut.UseVisualStyleBackColor = true;
            lgOut.Click += lgOut_Click;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLocation.Location = new Point(143, 414);
            lblLocation.Margin = new Padding(6, 0, 6, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(148, 45);
            lblLocation.TabIndex = 33;
            lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            txtLocation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLocation.Location = new Point(305, 396);
            txtLocation.Margin = new Padding(0, 9, 4, 2);
            txtLocation.Name = "txtLocation";
            txtLocation.ReadOnly = true;
            txtLocation.Size = new Size(536, 50);
            txtLocation.TabIndex = 35;
            // 
            // txtID
            // 
            txtID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtID.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtID.Location = new Point(305, 144);
            txtID.Margin = new Padding(6, 4, 6, 4);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(120, 42);
            txtID.TabIndex = 16;
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            txtTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(305, 57);
            txtTitle.Margin = new Padding(0, 9, 4, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.ReadOnly = true;
            txtTitle.Size = new Size(763, 50);
            txtTitle.TabIndex = 43;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(143, 57);
            lblTitle.Margin = new Padding(6, 0, 6, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(88, 45);
            lblTitle.TabIndex = 44;
            lblTitle.Text = "Title:";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TechnicianView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2884, 1759);
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 2, 4, 2);
            Name = "TechnicianView";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
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
            tabResovled.ResumeLayout(false);
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
        private TabPage tabResovled;
        private ListView listResolved;
        private Panel panelOverlay;
    }
}