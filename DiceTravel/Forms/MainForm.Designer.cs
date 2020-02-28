namespace DiceTravel
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.usersTable = new DiceTravel.UsersTable();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new DiceTravel.UsersTableTableAdapters.usersTableAdapter();
            this.mainToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.BtnNewEntry = new System.Windows.Forms.Button();
            this.GrpBxNextDestinationData = new System.Windows.Forms.GroupBox();
            this.BtnNextDestCancel = new System.Windows.Forms.Button();
            this.TxtNextDestTitle = new System.Windows.Forms.RichTextBox();
            this.BtnNextDestReached = new System.Windows.Forms.Button();
            this.PctBxNextDestVisibility = new System.Windows.Forms.PictureBox();
            this.GrpBxActiveJourneyData = new System.Windows.Forms.GroupBox();
            this.TxtActiveJourneyTitle = new System.Windows.Forms.RichTextBox();
            this.PctBxActiveJourneyVisibility = new System.Windows.Forms.PictureBox();
            this.BtnActiveJourneyNewJourney = new System.Windows.Forms.Button();
            this.BtnActiveJourneyDelete = new System.Windows.Forms.Button();
            this.TxtActiveJourneyInfo = new System.Windows.Forms.Label();
            this.GrpBxUserData = new System.Windows.Forms.GroupBox();
            this.TxtMainFormUserDataBirthDate = new System.Windows.Forms.Label();
            this.TxtUserDataBirthDate = new System.Windows.Forms.Label();
            this.TxtUserDataLoginName = new System.Windows.Forms.Label();
            this.GrpBxMainFrame = new System.Windows.Forms.GroupBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuMain = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMainLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMainSignUp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMainLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMainQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMe = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMeMyFlow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMeMyJourneys = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMeNewJourney = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMeNewEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMeGoalReached = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dice_travelDataSet = new DiceTravel.dice_travelDataSet();
            this.journeysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.journeysTableAdapter = new DiceTravel.dice_travelDataSetTableAdapters.journeysTableAdapter();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startlocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visibilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.mainToolStripContainer.ContentPanel.SuspendLayout();
            this.mainToolStripContainer.TopToolStripPanel.SuspendLayout();
            this.mainToolStripContainer.SuspendLayout();
            this.GrpBxNextDestinationData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxNextDestVisibility)).BeginInit();
            this.GrpBxActiveJourneyData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxActiveJourneyVisibility)).BeginInit();
            this.GrpBxUserData.SuspendLayout();
            this.GrpBxMainFrame.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_travelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journeysBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usersTable
            // 
            this.usersTable.DataSetName = "UsersTable";
            this.usersTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.usersTable;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // mainToolStripContainer
            // 
            // 
            // mainToolStripContainer.ContentPanel
            // 
            this.mainToolStripContainer.ContentPanel.Controls.Add(this.BtnNewEntry);
            this.mainToolStripContainer.ContentPanel.Controls.Add(this.GrpBxNextDestinationData);
            this.mainToolStripContainer.ContentPanel.Controls.Add(this.GrpBxActiveJourneyData);
            this.mainToolStripContainer.ContentPanel.Controls.Add(this.GrpBxUserData);
            this.mainToolStripContainer.ContentPanel.Controls.Add(this.GrpBxMainFrame);
            this.mainToolStripContainer.ContentPanel.Size = new System.Drawing.Size(1484, 737);
            this.mainToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainToolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.mainToolStripContainer.Name = "mainToolStripContainer";
            this.mainToolStripContainer.Size = new System.Drawing.Size(1484, 761);
            this.mainToolStripContainer.TabIndex = 0;
            this.mainToolStripContainer.Text = "mainToolStripContainer";
            // 
            // mainToolStripContainer.TopToolStripPanel
            // 
            this.mainToolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
            // 
            // BtnNewEntry
            // 
            this.BtnNewEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnNewEntry.Location = new System.Drawing.Point(3, 328);
            this.BtnNewEntry.Name = "BtnNewEntry";
            this.BtnNewEntry.Size = new System.Drawing.Size(229, 46);
            this.BtnNewEntry.TabIndex = 5;
            this.BtnNewEntry.Text = "New Entry";
            this.BtnNewEntry.UseVisualStyleBackColor = true;
            this.BtnNewEntry.Visible = false;
            // 
            // GrpBxNextDestinationData
            // 
            this.GrpBxNextDestinationData.Controls.Add(this.BtnNextDestCancel);
            this.GrpBxNextDestinationData.Controls.Add(this.TxtNextDestTitle);
            this.GrpBxNextDestinationData.Controls.Add(this.BtnNextDestReached);
            this.GrpBxNextDestinationData.Controls.Add(this.PctBxNextDestVisibility);
            this.GrpBxNextDestinationData.Location = new System.Drawing.Point(4, 235);
            this.GrpBxNextDestinationData.Name = "GrpBxNextDestinationData";
            this.GrpBxNextDestinationData.Size = new System.Drawing.Size(228, 87);
            this.GrpBxNextDestinationData.TabIndex = 4;
            this.GrpBxNextDestinationData.TabStop = false;
            this.GrpBxNextDestinationData.Text = "Next destination";
            this.GrpBxNextDestinationData.Visible = false;
            // 
            // BtnNextDestCancel
            // 
            this.BtnNextDestCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnNextDestCancel.Enabled = false;
            this.BtnNextDestCancel.Location = new System.Drawing.Point(172, 58);
            this.BtnNextDestCancel.Name = "BtnNextDestCancel";
            this.BtnNextDestCancel.Size = new System.Drawing.Size(48, 23);
            this.BtnNextDestCancel.TabIndex = 16;
            this.BtnNextDestCancel.Text = "Cancel";
            this.BtnNextDestCancel.UseVisualStyleBackColor = true;
            // 
            // TxtNextDestTitle
            // 
            this.TxtNextDestTitle.BackColor = System.Drawing.SystemColors.Control;
            this.TxtNextDestTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNextDestTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtNextDestTitle.Location = new System.Drawing.Point(46, 19);
            this.TxtNextDestTitle.Name = "TxtNextDestTitle";
            this.TxtNextDestTitle.ReadOnly = true;
            this.TxtNextDestTitle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TxtNextDestTitle.Size = new System.Drawing.Size(176, 22);
            this.TxtNextDestTitle.TabIndex = 19;
            this.TxtNextDestTitle.Text = "TITLE";
            // 
            // BtnNextDestReached
            // 
            this.BtnNextDestReached.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnNextDestReached.Enabled = false;
            this.BtnNextDestReached.Location = new System.Drawing.Point(6, 58);
            this.BtnNextDestReached.Name = "BtnNextDestReached";
            this.BtnNextDestReached.Size = new System.Drawing.Size(103, 23);
            this.BtnNextDestReached.TabIndex = 17;
            this.BtnNextDestReached.Text = "I\'m here!";
            this.BtnNextDestReached.UseVisualStyleBackColor = true;
            this.BtnNextDestReached.Click += new System.EventHandler(this.BtnNextDestReached_Click);
            // 
            // PctBxNextDestVisibility
            // 
            this.PctBxNextDestVisibility.Location = new System.Drawing.Point(6, 19);
            this.PctBxNextDestVisibility.Name = "PctBxNextDestVisibility";
            this.PctBxNextDestVisibility.Size = new System.Drawing.Size(33, 33);
            this.PctBxNextDestVisibility.TabIndex = 18;
            this.PctBxNextDestVisibility.TabStop = false;
            this.PctBxNextDestVisibility.WaitOnLoad = true;
            // 
            // GrpBxActiveJourneyData
            // 
            this.GrpBxActiveJourneyData.Controls.Add(this.TxtActiveJourneyTitle);
            this.GrpBxActiveJourneyData.Controls.Add(this.PctBxActiveJourneyVisibility);
            this.GrpBxActiveJourneyData.Controls.Add(this.BtnActiveJourneyNewJourney);
            this.GrpBxActiveJourneyData.Controls.Add(this.BtnActiveJourneyDelete);
            this.GrpBxActiveJourneyData.Controls.Add(this.TxtActiveJourneyInfo);
            this.GrpBxActiveJourneyData.Location = new System.Drawing.Point(4, 113);
            this.GrpBxActiveJourneyData.Name = "GrpBxActiveJourneyData";
            this.GrpBxActiveJourneyData.Size = new System.Drawing.Size(228, 115);
            this.GrpBxActiveJourneyData.TabIndex = 3;
            this.GrpBxActiveJourneyData.TabStop = false;
            this.GrpBxActiveJourneyData.Text = "Active journey";
            this.GrpBxActiveJourneyData.Visible = false;
            // 
            // TxtActiveJourneyTitle
            // 
            this.TxtActiveJourneyTitle.BackColor = System.Drawing.SystemColors.Control;
            this.TxtActiveJourneyTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtActiveJourneyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtActiveJourneyTitle.Location = new System.Drawing.Point(46, 49);
            this.TxtActiveJourneyTitle.Name = "TxtActiveJourneyTitle";
            this.TxtActiveJourneyTitle.ReadOnly = true;
            this.TxtActiveJourneyTitle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TxtActiveJourneyTitle.Size = new System.Drawing.Size(176, 22);
            this.TxtActiveJourneyTitle.TabIndex = 15;
            this.TxtActiveJourneyTitle.Text = "TITLE";
            // 
            // PctBxActiveJourneyVisibility
            // 
            this.PctBxActiveJourneyVisibility.Location = new System.Drawing.Point(6, 49);
            this.PctBxActiveJourneyVisibility.Name = "PctBxActiveJourneyVisibility";
            this.PctBxActiveJourneyVisibility.Size = new System.Drawing.Size(33, 33);
            this.PctBxActiveJourneyVisibility.TabIndex = 14;
            this.PctBxActiveJourneyVisibility.TabStop = false;
            this.PctBxActiveJourneyVisibility.WaitOnLoad = true;
            // 
            // BtnActiveJourneyNewJourney
            // 
            this.BtnActiveJourneyNewJourney.Enabled = false;
            this.BtnActiveJourneyNewJourney.Location = new System.Drawing.Point(6, 19);
            this.BtnActiveJourneyNewJourney.Name = "BtnActiveJourneyNewJourney";
            this.BtnActiveJourneyNewJourney.Size = new System.Drawing.Size(103, 23);
            this.BtnActiveJourneyNewJourney.TabIndex = 13;
            this.BtnActiveJourneyNewJourney.Text = "Start new Journey!";
            this.BtnActiveJourneyNewJourney.UseVisualStyleBackColor = true;
            this.BtnActiveJourneyNewJourney.Click += new System.EventHandler(this.BtnNewJourney_Click);
            // 
            // BtnActiveJourneyDelete
            // 
            this.BtnActiveJourneyDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActiveJourneyDelete.Enabled = false;
            this.BtnActiveJourneyDelete.Location = new System.Drawing.Point(174, 19);
            this.BtnActiveJourneyDelete.Name = "BtnActiveJourneyDelete";
            this.BtnActiveJourneyDelete.Size = new System.Drawing.Size(48, 23);
            this.BtnActiveJourneyDelete.TabIndex = 12;
            this.BtnActiveJourneyDelete.Text = "Delete";
            this.BtnActiveJourneyDelete.UseVisualStyleBackColor = true;
            this.BtnActiveJourneyDelete.Click += new System.EventHandler(this.BtnMyJourneyDelete_Click);
            // 
            // TxtActiveJourneyInfo
            // 
            this.TxtActiveJourneyInfo.AutoSize = true;
            this.TxtActiveJourneyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtActiveJourneyInfo.Location = new System.Drawing.Point(45, 74);
            this.TxtActiveJourneyInfo.Name = "TxtActiveJourneyInfo";
            this.TxtActiveJourneyInfo.Size = new System.Drawing.Size(70, 20);
            this.TxtActiveJourneyInfo.TabIndex = 7;
            this.TxtActiveJourneyInfo.Text = "Location";
            this.TxtActiveJourneyInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrpBxUserData
            // 
            this.GrpBxUserData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBxUserData.Controls.Add(this.TxtMainFormUserDataBirthDate);
            this.GrpBxUserData.Controls.Add(this.TxtUserDataBirthDate);
            this.GrpBxUserData.Controls.Add(this.TxtUserDataLoginName);
            this.GrpBxUserData.Location = new System.Drawing.Point(3, 3);
            this.GrpBxUserData.Name = "GrpBxUserData";
            this.GrpBxUserData.Size = new System.Drawing.Size(229, 104);
            this.GrpBxUserData.TabIndex = 1;
            this.GrpBxUserData.TabStop = false;
            this.GrpBxUserData.Text = "MyData";
            this.GrpBxUserData.Visible = false;
            // 
            // TxtMainFormUserDataBirthDate
            // 
            this.TxtMainFormUserDataBirthDate.AutoSize = true;
            this.TxtMainFormUserDataBirthDate.Location = new System.Drawing.Point(6, 54);
            this.TxtMainFormUserDataBirthDate.Name = "TxtMainFormUserDataBirthDate";
            this.TxtMainFormUserDataBirthDate.Size = new System.Drawing.Size(65, 13);
            this.TxtMainFormUserDataBirthDate.TabIndex = 6;
            this.TxtMainFormUserDataBirthDate.Text = "Date of birth";
            // 
            // TxtUserDataBirthDate
            // 
            this.TxtUserDataBirthDate.AutoSize = true;
            this.TxtUserDataBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtUserDataBirthDate.Location = new System.Drawing.Point(8, 67);
            this.TxtUserDataBirthDate.Name = "TxtUserDataBirthDate";
            this.TxtUserDataBirthDate.Size = new System.Drawing.Size(101, 20);
            this.TxtUserDataBirthDate.TabIndex = 4;
            this.TxtUserDataBirthDate.Text = "BIRTHDATE";
            this.TxtUserDataBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtUserDataLoginName
            // 
            this.TxtUserDataLoginName.AutoSize = true;
            this.TxtUserDataLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtUserDataLoginName.Location = new System.Drawing.Point(8, 16);
            this.TxtUserDataLoginName.Name = "TxtUserDataLoginName";
            this.TxtUserDataLoginName.Size = new System.Drawing.Size(132, 24);
            this.TxtUserDataLoginName.TabIndex = 2;
            this.TxtUserDataLoginName.Text = "LOGINNAME";
            this.TxtUserDataLoginName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrpBxMainFrame
            // 
            this.GrpBxMainFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBxMainFrame.Controls.Add(this.dataGridView1);
            this.GrpBxMainFrame.Location = new System.Drawing.Point(238, 3);
            this.GrpBxMainFrame.Name = "GrpBxMainFrame";
            this.GrpBxMainFrame.Size = new System.Drawing.Size(1243, 734);
            this.GrpBxMainFrame.TabIndex = 2;
            this.GrpBxMainFrame.TabStop = false;
            this.GrpBxMainFrame.Visible = false;
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMain,
            this.MenuMe});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1484, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // MenuMain
            // 
            this.MenuMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMainLogin,
            this.MenuMainSignUp,
            this.MenuMainLogout,
            this.MenuMainQuit});
            this.MenuMain.Name = "MenuMain";
            this.MenuMain.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.MenuMain.Size = new System.Drawing.Size(46, 20);
            this.MenuMain.Text = "Main";
            // 
            // MenuMainLogin
            // 
            this.MenuMainLogin.Name = "MenuMainLogin";
            this.MenuMainLogin.Size = new System.Drawing.Size(114, 22);
            this.MenuMainLogin.Text = "Login";
            this.MenuMainLogin.Click += new System.EventHandler(this.MenuMainLogin_Click);
            // 
            // MenuMainSignUp
            // 
            this.MenuMainSignUp.Name = "MenuMainSignUp";
            this.MenuMainSignUp.Size = new System.Drawing.Size(114, 22);
            this.MenuMainSignUp.Text = "SignUp";
            this.MenuMainSignUp.Click += new System.EventHandler(this.MenuMainSignUp_Click);
            // 
            // MenuMainLogout
            // 
            this.MenuMainLogout.Enabled = false;
            this.MenuMainLogout.Name = "MenuMainLogout";
            this.MenuMainLogout.Size = new System.Drawing.Size(114, 22);
            this.MenuMainLogout.Text = "LogOut";
            this.MenuMainLogout.Click += new System.EventHandler(this.MenuMainLogout_Click);
            // 
            // MenuMainQuit
            // 
            this.MenuMainQuit.Name = "MenuMainQuit";
            this.MenuMainQuit.Size = new System.Drawing.Size(114, 22);
            this.MenuMainQuit.Text = "Exit";
            this.MenuMainQuit.Click += new System.EventHandler(this.MenuMainQuit_Click);
            // 
            // MenuMe
            // 
            this.MenuMe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMeMyFlow,
            this.MenuMeMyJourneys,
            this.MenuMeNewJourney,
            this.MenuMeNewEntry,
            this.MenuMeGoalReached});
            this.MenuMe.Enabled = false;
            this.MenuMe.Name = "MenuMe";
            this.MenuMe.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.MenuMe.Size = new System.Drawing.Size(36, 20);
            this.MenuMe.Text = "Me";
            // 
            // MenuMeMyFlow
            // 
            this.MenuMeMyFlow.Name = "MenuMeMyFlow";
            this.MenuMeMyFlow.Size = new System.Drawing.Size(146, 22);
            this.MenuMeMyFlow.Text = "MyFlow";
            // 
            // MenuMeMyJourneys
            // 
            this.MenuMeMyJourneys.Name = "MenuMeMyJourneys";
            this.MenuMeMyJourneys.Size = new System.Drawing.Size(146, 22);
            this.MenuMeMyJourneys.Text = "MyJourneys";
            // 
            // MenuMeNewJourney
            // 
            this.MenuMeNewJourney.Name = "MenuMeNewJourney";
            this.MenuMeNewJourney.Size = new System.Drawing.Size(146, 22);
            this.MenuMeNewJourney.Text = "&New Journey";
            this.MenuMeNewJourney.Click += new System.EventHandler(this.MenuMeNewJourney_Click);
            // 
            // MenuMeNewEntry
            // 
            this.MenuMeNewEntry.Name = "MenuMeNewEntry";
            this.MenuMeNewEntry.Size = new System.Drawing.Size(146, 22);
            this.MenuMeNewEntry.Text = "New Entry";
            // 
            // MenuMeGoalReached
            // 
            this.MenuMeGoalReached.Name = "MenuMeGoalReached";
            this.MenuMeGoalReached.Size = new System.Drawing.Size(146, 22);
            this.MenuMeGoalReached.Text = "Goal reached!";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.titleDataGridViewTextBoxColumn,
            this.startlocationDataGridViewTextBoxColumn,
            this.startdateDataGridViewTextBoxColumn,
            this.closedDataGridViewTextBoxColumn,
            this.visibilityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.journeysBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dice_travelDataSet
            // 
            this.dice_travelDataSet.DataSetName = "dice_travelDataSet";
            this.dice_travelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // journeysBindingSource
            // 
            this.journeysBindingSource.DataMember = "journeys";
            this.journeysBindingSource.DataSource = this.dice_travelDataSet;
            // 
            // journeysTableAdapter
            // 
            this.journeysTableAdapter.ClearBeforeFill = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startlocationDataGridViewTextBoxColumn
            // 
            this.startlocationDataGridViewTextBoxColumn.DataPropertyName = "start_location";
            this.startlocationDataGridViewTextBoxColumn.HeaderText = "start_location";
            this.startlocationDataGridViewTextBoxColumn.Name = "startlocationDataGridViewTextBoxColumn";
            this.startlocationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "start_date";
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            this.startdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // closedDataGridViewTextBoxColumn
            // 
            this.closedDataGridViewTextBoxColumn.DataPropertyName = "closed";
            this.closedDataGridViewTextBoxColumn.HeaderText = "closed";
            this.closedDataGridViewTextBoxColumn.Name = "closedDataGridViewTextBoxColumn";
            this.closedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // visibilityDataGridViewTextBoxColumn
            // 
            this.visibilityDataGridViewTextBoxColumn.DataPropertyName = "visibility";
            this.visibilityDataGridViewTextBoxColumn.HeaderText = "visibility";
            this.visibilityDataGridViewTextBoxColumn.Name = "visibilityDataGridViewTextBoxColumn";
            this.visibilityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1484, 761);
            this.Controls.Add(this.mainToolStripContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiceTravel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.mainToolStripContainer.ContentPanel.ResumeLayout(false);
            this.mainToolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.mainToolStripContainer.TopToolStripPanel.PerformLayout();
            this.mainToolStripContainer.ResumeLayout(false);
            this.mainToolStripContainer.PerformLayout();
            this.GrpBxNextDestinationData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctBxNextDestVisibility)).EndInit();
            this.GrpBxActiveJourneyData.ResumeLayout(false);
            this.GrpBxActiveJourneyData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxActiveJourneyVisibility)).EndInit();
            this.GrpBxUserData.ResumeLayout(false);
            this.GrpBxUserData.PerformLayout();
            this.GrpBxMainFrame.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_travelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journeysBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private UsersTable usersTable;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private UsersTableTableAdapters.usersTableAdapter usersTableAdapter;
        private System.Windows.Forms.ToolStripContainer mainToolStripContainer;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuMain;
        private System.Windows.Forms.ToolStripMenuItem MenuMainLogin;
        private System.Windows.Forms.ToolStripMenuItem MenuMainSignUp;
        private System.Windows.Forms.ToolStripMenuItem MenuMainLogout;
        private System.Windows.Forms.ToolStripMenuItem MenuMainQuit;
        public System.Windows.Forms.Label TxtUserDataBirthDate;
        public System.Windows.Forms.Label TxtUserDataLoginName;
        private System.Windows.Forms.Label TxtMainFormUserDataBirthDate;
        public System.Windows.Forms.GroupBox GrpBxUserData;
        public System.Windows.Forms.GroupBox GrpBxMainFrame;
        private System.Windows.Forms.ToolStripMenuItem MenuMe;
        private System.Windows.Forms.ToolStripMenuItem MenuMeMyFlow;
        private System.Windows.Forms.ToolStripMenuItem MenuMeMyJourneys;
        private System.Windows.Forms.ToolStripMenuItem MenuMeNewJourney;
        private System.Windows.Forms.ToolStripMenuItem MenuMeNewEntry;
        private System.Windows.Forms.ToolStripMenuItem MenuMeGoalReached;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox GrpBxActiveJourneyData;
        public System.Windows.Forms.Label TxtActiveJourneyInfo;
        private System.Windows.Forms.Button BtnActiveJourneyNewJourney;
        private System.Windows.Forms.Button BtnActiveJourneyDelete;
        private System.Windows.Forms.PictureBox PctBxActiveJourneyVisibility;
        private System.Windows.Forms.RichTextBox TxtActiveJourneyTitle;
        private System.Windows.Forms.GroupBox GrpBxNextDestinationData;
        private System.Windows.Forms.Button BtnNextDestCancel;
        private System.Windows.Forms.RichTextBox TxtNextDestTitle;
        private System.Windows.Forms.Button BtnNextDestReached;
        private System.Windows.Forms.PictureBox PctBxNextDestVisibility;
        private System.Windows.Forms.Button BtnNewEntry;
        private System.Windows.Forms.DataGridView dataGridView1;
        private dice_travelDataSet dice_travelDataSet;
        private System.Windows.Forms.BindingSource journeysBindingSource;
        private dice_travelDataSetTableAdapters.journeysTableAdapter journeysTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startlocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn closedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn visibilityDataGridViewTextBoxColumn;
    }
}

