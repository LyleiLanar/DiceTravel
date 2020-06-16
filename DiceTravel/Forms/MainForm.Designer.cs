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
            this.mainToolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.GrpBxActiveTripData = new System.Windows.Forms.GroupBox();
            this.BtnNewEntry = new System.Windows.Forms.Button();
            this.BtnNextTripModify = new System.Windows.Forms.Button();
            this.TxtNextTripTitle = new System.Windows.Forms.RichTextBox();
            this.BtnNextTripReached = new System.Windows.Forms.Button();
            this.PctBxNextTripVisibility = new System.Windows.Forms.PictureBox();
            this.GrpBxActiveJourneyData = new System.Windows.Forms.GroupBox();
            this.BtnActiveJourneyModify = new System.Windows.Forms.Button();
            this.TxtActiveJourneyTitle = new System.Windows.Forms.RichTextBox();
            this.PctBxActiveJourneyVisibility = new System.Windows.Forms.PictureBox();
            this.BtnActiveJourneyNewJourney = new System.Windows.Forms.Button();
            this.BtnActiveJourneyDelete = new System.Windows.Forms.Button();
            this.TxtActiveJourneyInfo = new System.Windows.Forms.Label();
            this.GrpBxUserData = new System.Windows.Forms.GroupBox();
            this.TxtUserDataLoginName = new System.Windows.Forms.Label();
            this.GrpBxMainFrame = new System.Windows.Forms.GroupBox();
            this.FlowWindow = new System.Windows.Forms.Panel();
            this.FlowLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.FlowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAllEntries = new System.Windows.Forms.Button();
            this.BtnMyJourney = new System.Windows.Forms.Button();
            this.TxtFlowDataFlowTitle = new System.Windows.Forms.Label();
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
            this.MenuMeMyProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MainFormToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.usersTable = new DiceTravel.UsersTable();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new DiceTravel.UsersTableTableAdapters.usersTableAdapter();
            this.journeysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dice_travelDataSet = new DiceTravel.dice_travelDataSet();
            this.journeysTableAdapter = new DiceTravel.dice_travelDataSetTableAdapters.journeysTableAdapter();
            this.journeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtSearchUser = new System.Windows.Forms.TextBox();
            this.BtnSearchUser = new System.Windows.Forms.Button();
            this.mainToolStripContainer.ContentPanel.SuspendLayout();
            this.mainToolStripContainer.TopToolStripPanel.SuspendLayout();
            this.mainToolStripContainer.SuspendLayout();
            this.GrpBxActiveTripData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxNextTripVisibility)).BeginInit();
            this.GrpBxActiveJourneyData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxActiveJourneyVisibility)).BeginInit();
            this.GrpBxUserData.SuspendLayout();
            this.GrpBxMainFrame.SuspendLayout();
            this.FlowWindow.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.journeysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_travelDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // mainToolStripContainer
            // 
            // 
            // mainToolStripContainer.ContentPanel
            // 
            this.mainToolStripContainer.ContentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainToolStripContainer.ContentPanel.Controls.Add(this.GrpBxActiveTripData);
            this.mainToolStripContainer.ContentPanel.Controls.Add(this.GrpBxActiveJourneyData);
            this.mainToolStripContainer.ContentPanel.Controls.Add(this.GrpBxUserData);
            this.mainToolStripContainer.ContentPanel.Controls.Add(this.GrpBxMainFrame);
            this.mainToolStripContainer.ContentPanel.Size = new System.Drawing.Size(889, 837);
            this.mainToolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainToolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.mainToolStripContainer.Name = "mainToolStripContainer";
            this.mainToolStripContainer.Size = new System.Drawing.Size(889, 861);
            this.mainToolStripContainer.TabIndex = 0;
            this.mainToolStripContainer.Text = "mainToolStripContainer";
            // 
            // mainToolStripContainer.TopToolStripPanel
            // 
            this.mainToolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
            // 
            // GrpBxActiveTripData
            // 
            this.GrpBxActiveTripData.BackColor = System.Drawing.SystemColors.Control;
            this.GrpBxActiveTripData.Controls.Add(this.BtnNewEntry);
            this.GrpBxActiveTripData.Controls.Add(this.BtnNextTripModify);
            this.GrpBxActiveTripData.Controls.Add(this.TxtNextTripTitle);
            this.GrpBxActiveTripData.Controls.Add(this.BtnNextTripReached);
            this.GrpBxActiveTripData.Controls.Add(this.PctBxNextTripVisibility);
            this.GrpBxActiveTripData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GrpBxActiveTripData.Location = new System.Drawing.Point(3, 183);
            this.GrpBxActiveTripData.Name = "GrpBxActiveTripData";
            this.GrpBxActiveTripData.Size = new System.Drawing.Size(230, 93);
            this.GrpBxActiveTripData.TabIndex = 4;
            this.GrpBxActiveTripData.TabStop = false;
            this.GrpBxActiveTripData.Text = "Next destination";
            this.GrpBxActiveTripData.Visible = false;
            // 
            // BtnNewEntry
            // 
            this.BtnNewEntry.BackColor = System.Drawing.SystemColors.Control;
            this.BtnNewEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnNewEntry.Image = global::DiceTravel.Properties.Resources.icoAddEntry;
            this.BtnNewEntry.Location = new System.Drawing.Point(138, 46);
            this.BtnNewEntry.Name = "BtnNewEntry";
            this.BtnNewEntry.Size = new System.Drawing.Size(40, 40);
            this.BtnNewEntry.TabIndex = 5;
            this.MainFormToolTip.SetToolTip(this.BtnNewEntry, "Add new entry to your Trip");
            this.BtnNewEntry.UseVisualStyleBackColor = false;
            this.BtnNewEntry.Visible = false;
            this.BtnNewEntry.Click += new System.EventHandler(this.BtnNewEntry_Click);
            // 
            // BtnNextTripModify
            // 
            this.BtnNextTripModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnNextTripModify.BackColor = System.Drawing.SystemColors.Control;
            this.BtnNextTripModify.Enabled = false;
            this.BtnNextTripModify.Image = global::DiceTravel.Properties.Resources.icoSettings;
            this.BtnNextTripModify.Location = new System.Drawing.Point(185, 47);
            this.BtnNextTripModify.Name = "BtnNextTripModify";
            this.BtnNextTripModify.Size = new System.Drawing.Size(40, 40);
            this.BtnNextTripModify.TabIndex = 16;
            this.MainFormToolTip.SetToolTip(this.BtnNextTripModify, "Modify Trip");
            this.BtnNextTripModify.UseVisualStyleBackColor = false;
            this.BtnNextTripModify.Click += new System.EventHandler(this.BtnNextTripModify_Click);
            // 
            // TxtNextTripTitle
            // 
            this.TxtNextTripTitle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TxtNextTripTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNextTripTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtNextTripTitle.Location = new System.Drawing.Point(12, 19);
            this.TxtNextTripTitle.Multiline = false;
            this.TxtNextTripTitle.Name = "TxtNextTripTitle";
            this.TxtNextTripTitle.ReadOnly = true;
            this.TxtNextTripTitle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
            this.TxtNextTripTitle.Size = new System.Drawing.Size(210, 25);
            this.TxtNextTripTitle.TabIndex = 19;
            this.TxtNextTripTitle.Text = "TITLE";
            // 
            // BtnNextTripReached
            // 
            this.BtnNextTripReached.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnNextTripReached.BackColor = System.Drawing.SystemColors.Control;
            this.BtnNextTripReached.Enabled = false;
            this.BtnNextTripReached.Image = global::DiceTravel.Properties.Resources.icoFinished;
            this.BtnNextTripReached.Location = new System.Drawing.Point(92, 47);
            this.BtnNextTripReached.Name = "BtnNextTripReached";
            this.BtnNextTripReached.Size = new System.Drawing.Size(40, 40);
            this.BtnNextTripReached.TabIndex = 17;
            this.MainFormToolTip.SetToolTip(this.BtnNextTripReached, "I\'m here!");
            this.BtnNextTripReached.UseVisualStyleBackColor = false;
            this.BtnNextTripReached.Click += new System.EventHandler(this.BtnNextDestReached_Click);
            // 
            // PctBxNextTripVisibility
            // 
            this.PctBxNextTripVisibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.PctBxNextTripVisibility.Location = new System.Drawing.Point(12, 47);
            this.PctBxNextTripVisibility.Name = "PctBxNextTripVisibility";
            this.PctBxNextTripVisibility.Size = new System.Drawing.Size(40, 40);
            this.PctBxNextTripVisibility.TabIndex = 18;
            this.PctBxNextTripVisibility.TabStop = false;
            this.PctBxNextTripVisibility.WaitOnLoad = true;
            // 
            // GrpBxActiveJourneyData
            // 
            this.GrpBxActiveJourneyData.BackColor = System.Drawing.SystemColors.Control;
            this.GrpBxActiveJourneyData.Controls.Add(this.BtnActiveJourneyModify);
            this.GrpBxActiveJourneyData.Controls.Add(this.TxtActiveJourneyTitle);
            this.GrpBxActiveJourneyData.Controls.Add(this.PctBxActiveJourneyVisibility);
            this.GrpBxActiveJourneyData.Controls.Add(this.BtnActiveJourneyNewJourney);
            this.GrpBxActiveJourneyData.Controls.Add(this.BtnActiveJourneyDelete);
            this.GrpBxActiveJourneyData.Controls.Add(this.TxtActiveJourneyInfo);
            this.GrpBxActiveJourneyData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GrpBxActiveJourneyData.Location = new System.Drawing.Point(5, 62);
            this.GrpBxActiveJourneyData.Name = "GrpBxActiveJourneyData";
            this.GrpBxActiveJourneyData.Size = new System.Drawing.Size(228, 115);
            this.GrpBxActiveJourneyData.TabIndex = 3;
            this.GrpBxActiveJourneyData.TabStop = false;
            this.GrpBxActiveJourneyData.Text = "Active journey";
            this.GrpBxActiveJourneyData.Visible = false;
            // 
            // BtnActiveJourneyModify
            // 
            this.BtnActiveJourneyModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnActiveJourneyModify.BackColor = System.Drawing.SystemColors.Control;
            this.BtnActiveJourneyModify.Enabled = false;
            this.BtnActiveJourneyModify.Image = global::DiceTravel.Properties.Resources.icoSettings;
            this.BtnActiveJourneyModify.Location = new System.Drawing.Point(182, 69);
            this.BtnActiveJourneyModify.Name = "BtnActiveJourneyModify";
            this.BtnActiveJourneyModify.Size = new System.Drawing.Size(40, 40);
            this.BtnActiveJourneyModify.TabIndex = 20;
            this.MainFormToolTip.SetToolTip(this.BtnActiveJourneyModify, "Modify Trip");
            this.BtnActiveJourneyModify.UseVisualStyleBackColor = false;
            // 
            // TxtActiveJourneyTitle
            // 
            this.TxtActiveJourneyTitle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TxtActiveJourneyTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtActiveJourneyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtActiveJourneyTitle.Location = new System.Drawing.Point(12, 19);
            this.TxtActiveJourneyTitle.Multiline = false;
            this.TxtActiveJourneyTitle.Name = "TxtActiveJourneyTitle";
            this.TxtActiveJourneyTitle.ReadOnly = true;
            this.TxtActiveJourneyTitle.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TxtActiveJourneyTitle.Size = new System.Drawing.Size(211, 25);
            this.TxtActiveJourneyTitle.TabIndex = 15;
            this.TxtActiveJourneyTitle.Text = "TITLE";
            // 
            // PctBxActiveJourneyVisibility
            // 
            this.PctBxActiveJourneyVisibility.Location = new System.Drawing.Point(12, 69);
            this.PctBxActiveJourneyVisibility.Name = "PctBxActiveJourneyVisibility";
            this.PctBxActiveJourneyVisibility.Size = new System.Drawing.Size(40, 40);
            this.PctBxActiveJourneyVisibility.TabIndex = 14;
            this.PctBxActiveJourneyVisibility.TabStop = false;
            this.PctBxActiveJourneyVisibility.WaitOnLoad = true;
            // 
            // BtnActiveJourneyNewJourney
            // 
            this.BtnActiveJourneyNewJourney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActiveJourneyNewJourney.BackColor = System.Drawing.SystemColors.Control;
            this.BtnActiveJourneyNewJourney.Enabled = false;
            this.BtnActiveJourneyNewJourney.Image = global::DiceTravel.Properties.Resources.icoStart;
            this.BtnActiveJourneyNewJourney.Location = new System.Drawing.Point(90, 69);
            this.BtnActiveJourneyNewJourney.Name = "BtnActiveJourneyNewJourney";
            this.BtnActiveJourneyNewJourney.Size = new System.Drawing.Size(40, 40);
            this.BtnActiveJourneyNewJourney.TabIndex = 13;
            this.MainFormToolTip.SetToolTip(this.BtnActiveJourneyNewJourney, "Start new Journey!");
            this.BtnActiveJourneyNewJourney.UseVisualStyleBackColor = false;
            this.BtnActiveJourneyNewJourney.Click += new System.EventHandler(this.BtnNewJourney_Click);
            // 
            // BtnActiveJourneyDelete
            // 
            this.BtnActiveJourneyDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnActiveJourneyDelete.BackColor = System.Drawing.SystemColors.Control;
            this.BtnActiveJourneyDelete.Enabled = false;
            this.BtnActiveJourneyDelete.Image = global::DiceTravel.Properties.Resources.icoDelete;
            this.BtnActiveJourneyDelete.Location = new System.Drawing.Point(136, 69);
            this.BtnActiveJourneyDelete.Name = "BtnActiveJourneyDelete";
            this.BtnActiveJourneyDelete.Size = new System.Drawing.Size(40, 40);
            this.BtnActiveJourneyDelete.TabIndex = 12;
            this.BtnActiveJourneyDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MainFormToolTip.SetToolTip(this.BtnActiveJourneyDelete, "Delete active Journey");
            this.BtnActiveJourneyDelete.UseVisualStyleBackColor = false;
            this.BtnActiveJourneyDelete.Click += new System.EventHandler(this.BtnMyJourneyDelete_Click);
            // 
            // TxtActiveJourneyInfo
            // 
            this.TxtActiveJourneyInfo.AutoSize = true;
            this.TxtActiveJourneyInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtActiveJourneyInfo.Location = new System.Drawing.Point(8, 44);
            this.TxtActiveJourneyInfo.Name = "TxtActiveJourneyInfo";
            this.TxtActiveJourneyInfo.Size = new System.Drawing.Size(70, 20);
            this.TxtActiveJourneyInfo.TabIndex = 7;
            this.TxtActiveJourneyInfo.Text = "Location";
            this.TxtActiveJourneyInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrpBxUserData
            // 
            this.GrpBxUserData.BackColor = System.Drawing.SystemColors.Control;
            this.GrpBxUserData.Controls.Add(this.TxtUserDataLoginName);
            this.GrpBxUserData.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GrpBxUserData.Location = new System.Drawing.Point(3, 3);
            this.GrpBxUserData.Name = "GrpBxUserData";
            this.GrpBxUserData.Size = new System.Drawing.Size(229, 53);
            this.GrpBxUserData.TabIndex = 1;
            this.GrpBxUserData.TabStop = false;
            this.GrpBxUserData.Text = "MyData";
            this.GrpBxUserData.Visible = false;
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
            this.GrpBxMainFrame.BackColor = System.Drawing.SystemColors.Control;
            this.GrpBxMainFrame.Controls.Add(this.BtnSearchUser);
            this.GrpBxMainFrame.Controls.Add(this.TxtSearchUser);
            this.GrpBxMainFrame.Controls.Add(this.FlowWindow);
            this.GrpBxMainFrame.Controls.Add(this.BtnAllEntries);
            this.GrpBxMainFrame.Controls.Add(this.BtnMyJourney);
            this.GrpBxMainFrame.Controls.Add(this.TxtFlowDataFlowTitle);
            this.GrpBxMainFrame.Location = new System.Drawing.Point(238, 3);
            this.GrpBxMainFrame.Name = "GrpBxMainFrame";
            this.GrpBxMainFrame.Size = new System.Drawing.Size(640, 822);
            this.GrpBxMainFrame.TabIndex = 2;
            this.GrpBxMainFrame.TabStop = false;
            this.GrpBxMainFrame.Visible = false;
            // 
            // FlowWindow
            // 
            this.FlowWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlowWindow.AutoScroll = true;
            this.FlowWindow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FlowWindow.Controls.Add(this.FlowLayoutPanel);
            this.FlowWindow.Controls.Add(this.FlowContainer);
            this.FlowWindow.Location = new System.Drawing.Point(6, 43);
            this.FlowWindow.Name = "FlowWindow";
            this.FlowWindow.Size = new System.Drawing.Size(571, 773);
            this.FlowWindow.TabIndex = 11;
            // 
            // FlowLayoutPanel
            // 
            this.FlowLayoutPanel.AutoScroll = true;
            this.FlowLayoutPanel.AutoSize = true;
            this.FlowLayoutPanel.ColumnCount = 1;
            this.FlowLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FlowLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FlowLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FlowLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FlowLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.FlowLayoutPanel.MinimumSize = new System.Drawing.Size(50, 50);
            this.FlowLayoutPanel.Name = "FlowLayoutPanel";
            this.FlowLayoutPanel.RowCount = 1;
            this.FlowLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FlowLayoutPanel.Size = new System.Drawing.Size(50, 50);
            this.FlowLayoutPanel.TabIndex = 0;
            // 
            // FlowContainer
            // 
            this.FlowContainer.AutoScroll = true;
            this.FlowContainer.AutoSize = true;
            this.FlowContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowContainer.BackColor = System.Drawing.SystemColors.Control;
            this.FlowContainer.Location = new System.Drawing.Point(3, 3);
            this.FlowContainer.Name = "FlowContainer";
            this.FlowContainer.Size = new System.Drawing.Size(0, 0);
            this.FlowContainer.TabIndex = 8;
            // 
            // BtnAllEntries
            // 
            this.BtnAllEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAllEntries.BackColor = System.Drawing.SystemColors.Control;
            this.BtnAllEntries.Image = global::DiceTravel.Properties.Resources.icoEntry;
            this.BtnAllEntries.Location = new System.Drawing.Point(583, 99);
            this.BtnAllEntries.Name = "BtnAllEntries";
            this.BtnAllEntries.Size = new System.Drawing.Size(50, 50);
            this.BtnAllEntries.TabIndex = 10;
            this.MainFormToolTip.SetToolTip(this.BtnAllEntries, "My Entries");
            this.BtnAllEntries.UseVisualStyleBackColor = false;
            this.BtnAllEntries.Click += new System.EventHandler(this.BtnAllEntries_Click);
            // 
            // BtnMyJourney
            // 
            this.BtnMyJourney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMyJourney.BackColor = System.Drawing.SystemColors.Control;
            this.BtnMyJourney.Image = global::DiceTravel.Properties.Resources.icoMyJourneys;
            this.BtnMyJourney.Location = new System.Drawing.Point(583, 43);
            this.BtnMyJourney.Name = "BtnMyJourney";
            this.BtnMyJourney.Size = new System.Drawing.Size(50, 50);
            this.BtnMyJourney.TabIndex = 9;
            this.MainFormToolTip.SetToolTip(this.BtnMyJourney, "My journyes");
            this.BtnMyJourney.UseVisualStyleBackColor = false;
            this.BtnMyJourney.Click += new System.EventHandler(this.BtnMyJourney_Click);
            // 
            // TxtFlowDataFlowTitle
            // 
            this.TxtFlowDataFlowTitle.AutoSize = true;
            this.TxtFlowDataFlowTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtFlowDataFlowTitle.Location = new System.Drawing.Point(6, 16);
            this.TxtFlowDataFlowTitle.Name = "TxtFlowDataFlowTitle";
            this.TxtFlowDataFlowTitle.Size = new System.Drawing.Size(125, 24);
            this.TxtFlowDataFlowTitle.TabIndex = 7;
            this.TxtFlowDataFlowTitle.Text = "FLOWTITLE";
            this.TxtFlowDataFlowTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMain,
            this.MenuMe,
            this.journeyToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(889, 24);
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
            this.MenuMeGoalReached,
            this.MenuMeMyProfile});
            this.MenuMe.Enabled = false;
            this.MenuMe.Name = "MenuMe";
            this.MenuMe.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.MenuMe.Size = new System.Drawing.Size(36, 20);
            this.MenuMe.Text = "Me";
            // 
            // MenuMeMyFlow
            // 
            this.MenuMeMyFlow.Name = "MenuMeMyFlow";
            this.MenuMeMyFlow.Size = new System.Drawing.Size(180, 22);
            this.MenuMeMyFlow.Text = "MyFlow";
            // 
            // MenuMeMyJourneys
            // 
            this.MenuMeMyJourneys.Name = "MenuMeMyJourneys";
            this.MenuMeMyJourneys.Size = new System.Drawing.Size(180, 22);
            this.MenuMeMyJourneys.Text = "MyJourneys";
            this.MenuMeMyJourneys.Click += new System.EventHandler(this.MenuMeMyJourneys_Click);
            // 
            // MenuMeNewJourney
            // 
            this.MenuMeNewJourney.Name = "MenuMeNewJourney";
            this.MenuMeNewJourney.Size = new System.Drawing.Size(180, 22);
            this.MenuMeNewJourney.Text = "&New Journey";
            this.MenuMeNewJourney.Click += new System.EventHandler(this.MenuMeNewJourney_Click);
            // 
            // MenuMeNewEntry
            // 
            this.MenuMeNewEntry.Name = "MenuMeNewEntry";
            this.MenuMeNewEntry.Size = new System.Drawing.Size(180, 22);
            this.MenuMeNewEntry.Text = "New Entry";
            // 
            // MenuMeGoalReached
            // 
            this.MenuMeGoalReached.Name = "MenuMeGoalReached";
            this.MenuMeGoalReached.Size = new System.Drawing.Size(180, 22);
            this.MenuMeGoalReached.Text = "Goal reached!";
            this.MenuMeGoalReached.Click += new System.EventHandler(this.MenuMeGoalReached_Click);
            // 
            // MenuMeMyProfile
            // 
            this.MenuMeMyProfile.Name = "MenuMeMyProfile";
            this.MenuMeMyProfile.Size = new System.Drawing.Size(180, 22);
            this.MenuMeMyProfile.Text = "MyProfile";
            this.MenuMeMyProfile.Click += new System.EventHandler(this.MenuMeMyProfile_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            // journeysBindingSource
            // 
            this.journeysBindingSource.DataMember = "journeys";
            this.journeysBindingSource.DataSource = this.dice_travelDataSet;
            // 
            // dice_travelDataSet
            // 
            this.dice_travelDataSet.DataSetName = "dice_travelDataSet";
            this.dice_travelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // journeysTableAdapter
            // 
            this.journeysTableAdapter.ClearBeforeFill = true;
            // 
            // journeyToolStripMenuItem
            // 
            this.journeyToolStripMenuItem.Name = "journeyToolStripMenuItem";
            this.journeyToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.journeyToolStripMenuItem.Text = "Journey";
            // 
            // TxtSearchUser
            // 
            this.TxtSearchUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSearchUser.Location = new System.Drawing.Point(377, 16);
            this.TxtSearchUser.Name = "TxtSearchUser";
            this.TxtSearchUser.Size = new System.Drawing.Size(199, 20);
            this.TxtSearchUser.TabIndex = 12;
            // 
            // BtnSearchUser
            // 
            this.BtnSearchUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearchUser.Location = new System.Drawing.Point(583, 14);
            this.BtnSearchUser.Name = "BtnSearchUser";
            this.BtnSearchUser.Size = new System.Drawing.Size(50, 23);
            this.BtnSearchUser.TabIndex = 13;
            this.BtnSearchUser.Text = "Search";
            this.BtnSearchUser.UseVisualStyleBackColor = true;
            this.BtnSearchUser.Click += new System.EventHandler(this.BtnSearchUser_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(889, 861);
            this.Controls.Add(this.mainToolStripContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DiceTravel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mainToolStripContainer.ContentPanel.ResumeLayout(false);
            this.mainToolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.mainToolStripContainer.TopToolStripPanel.PerformLayout();
            this.mainToolStripContainer.ResumeLayout(false);
            this.mainToolStripContainer.PerformLayout();
            this.GrpBxActiveTripData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PctBxNextTripVisibility)).EndInit();
            this.GrpBxActiveJourneyData.ResumeLayout(false);
            this.GrpBxActiveJourneyData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxActiveJourneyVisibility)).EndInit();
            this.GrpBxUserData.ResumeLayout(false);
            this.GrpBxUserData.PerformLayout();
            this.GrpBxMainFrame.ResumeLayout(false);
            this.GrpBxMainFrame.PerformLayout();
            this.FlowWindow.ResumeLayout(false);
            this.FlowWindow.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.journeysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice_travelDataSet)).EndInit();
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
        public System.Windows.Forms.Label TxtUserDataLoginName;
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
        private System.Windows.Forms.GroupBox GrpBxActiveTripData;
        private System.Windows.Forms.Button BtnNextTripModify;
        private System.Windows.Forms.RichTextBox TxtNextTripTitle;
        private System.Windows.Forms.Button BtnNextTripReached;
        private System.Windows.Forms.PictureBox PctBxNextTripVisibility;
        private System.Windows.Forms.Button BtnNewEntry;
        private dice_travelDataSet dice_travelDataSet;
        private System.Windows.Forms.BindingSource journeysBindingSource;
        private dice_travelDataSetTableAdapters.journeysTableAdapter journeysTableAdapter;
        public System.Windows.Forms.Label TxtFlowDataFlowTitle;
        public System.Windows.Forms.TableLayoutPanel FlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel FlowContainer;
        private System.Windows.Forms.Button BtnMyJourney;
        private System.Windows.Forms.ToolTip MainFormToolTip;
        private System.Windows.Forms.Button BtnAllEntries;
        private System.Windows.Forms.Button BtnActiveJourneyModify;
        private System.Windows.Forms.ToolStripMenuItem MenuMeMyProfile;
        private System.Windows.Forms.ToolStripMenuItem journeyToolStripMenuItem;
        private System.Windows.Forms.Button BtnSearchUser;
        public System.Windows.Forms.TextBox TxtSearchUser;
        public System.Windows.Forms.Panel FlowWindow;
    }
}

