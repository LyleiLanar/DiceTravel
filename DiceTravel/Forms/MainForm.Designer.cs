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
            this.GrpBxUserData = new System.Windows.Forms.GroupBox();
            this.InputTest = new System.Windows.Forms.TextBox();
            this.TxtMainFormUserDataBirthDate = new System.Windows.Forms.Label();
            this.TxtMainFormUserDataName = new System.Windows.Forms.Label();
            this.TxtUserDataBirthDate = new System.Windows.Forms.Label();
            this.TxtUserDataRealName = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.mainToolStripContainer.ContentPanel.SuspendLayout();
            this.mainToolStripContainer.TopToolStripPanel.SuspendLayout();
            this.mainToolStripContainer.SuspendLayout();
            this.GrpBxUserData.SuspendLayout();
            this.menuStrip.SuspendLayout();
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
            // GrpBxUserData
            // 
            this.GrpBxUserData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBxUserData.Controls.Add(this.InputTest);
            this.GrpBxUserData.Controls.Add(this.TxtMainFormUserDataBirthDate);
            this.GrpBxUserData.Controls.Add(this.TxtMainFormUserDataName);
            this.GrpBxUserData.Controls.Add(this.TxtUserDataBirthDate);
            this.GrpBxUserData.Controls.Add(this.TxtUserDataRealName);
            this.GrpBxUserData.Controls.Add(this.TxtUserDataLoginName);
            this.GrpBxUserData.Location = new System.Drawing.Point(3, 3);
            this.GrpBxUserData.Name = "GrpBxUserData";
            this.GrpBxUserData.Size = new System.Drawing.Size(284, 731);
            this.GrpBxUserData.TabIndex = 1;
            this.GrpBxUserData.TabStop = false;
            this.GrpBxUserData.Text = "MyData";
            this.GrpBxUserData.Visible = false;
            // 
            // InputTest
            // 
            this.InputTest.Location = new System.Drawing.Point(83, 164);
            this.InputTest.Name = "InputTest";
            this.InputTest.Size = new System.Drawing.Size(100, 20);
            this.InputTest.TabIndex = 7;
            // 
            // TxtMainFormUserDataBirthDate
            // 
            this.TxtMainFormUserDataBirthDate.AutoSize = true;
            this.TxtMainFormUserDataBirthDate.Location = new System.Drawing.Point(6, 99);
            this.TxtMainFormUserDataBirthDate.Name = "TxtMainFormUserDataBirthDate";
            this.TxtMainFormUserDataBirthDate.Size = new System.Drawing.Size(65, 13);
            this.TxtMainFormUserDataBirthDate.TabIndex = 6;
            this.TxtMainFormUserDataBirthDate.Text = "Date of birth";
            // 
            // TxtMainFormUserDataName
            // 
            this.TxtMainFormUserDataName.AutoSize = true;
            this.TxtMainFormUserDataName.Location = new System.Drawing.Point(6, 57);
            this.TxtMainFormUserDataName.Name = "TxtMainFormUserDataName";
            this.TxtMainFormUserDataName.Size = new System.Drawing.Size(38, 13);
            this.TxtMainFormUserDataName.TabIndex = 5;
            this.TxtMainFormUserDataName.Text = "Name:";
            // 
            // TxtUserDataBirthDate
            // 
            this.TxtUserDataBirthDate.AutoSize = true;
            this.TxtUserDataBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtUserDataBirthDate.Location = new System.Drawing.Point(5, 112);
            this.TxtUserDataBirthDate.Name = "TxtUserDataBirthDate";
            this.TxtUserDataBirthDate.Size = new System.Drawing.Size(14, 20);
            this.TxtUserDataBirthDate.TabIndex = 4;
            this.TxtUserDataBirthDate.Text = "-";
            this.TxtUserDataBirthDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtUserDataRealName
            // 
            this.TxtUserDataRealName.AutoSize = true;
            this.TxtUserDataRealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtUserDataRealName.Location = new System.Drawing.Point(6, 70);
            this.TxtUserDataRealName.Name = "TxtUserDataRealName";
            this.TxtUserDataRealName.Size = new System.Drawing.Size(14, 20);
            this.TxtUserDataRealName.TabIndex = 2;
            this.TxtUserDataRealName.Text = "-";
            this.TxtUserDataRealName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TxtUserDataLoginName
            // 
            this.TxtUserDataLoginName.AutoSize = true;
            this.TxtUserDataLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtUserDataLoginName.Location = new System.Drawing.Point(6, 16);
            this.TxtUserDataLoginName.Name = "TxtUserDataLoginName";
            this.TxtUserDataLoginName.Size = new System.Drawing.Size(20, 25);
            this.TxtUserDataLoginName.TabIndex = 1;
            this.TxtUserDataLoginName.Text = "-";
            this.TxtUserDataLoginName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GrpBxMainFrame
            // 
            this.GrpBxMainFrame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBxMainFrame.Location = new System.Drawing.Point(293, 3);
            this.GrpBxMainFrame.Name = "GrpBxMainFrame";
            this.GrpBxMainFrame.Size = new System.Drawing.Size(1188, 734);
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
            this.MenuMainLogin.Size = new System.Drawing.Size(180, 22);
            this.MenuMainLogin.Text = "Login";
            this.MenuMainLogin.Click += new System.EventHandler(this.MenuMainLogin_Click);
            // 
            // MenuMainSignUp
            // 
            this.MenuMainSignUp.Name = "MenuMainSignUp";
            this.MenuMainSignUp.Size = new System.Drawing.Size(180, 22);
            this.MenuMainSignUp.Text = "SignUp";
            this.MenuMainSignUp.Click += new System.EventHandler(this.MenuMainSignUp_Click);
            // 
            // MenuMainLogout
            // 
            this.MenuMainLogout.Enabled = false;
            this.MenuMainLogout.Name = "MenuMainLogout";
            this.MenuMainLogout.Size = new System.Drawing.Size(180, 22);
            this.MenuMainLogout.Text = "LogOut";
            this.MenuMainLogout.Click += new System.EventHandler(this.MenuMainLogout_Click);
            // 
            // MenuMainQuit
            // 
            this.MenuMainQuit.Name = "MenuMainQuit";
            this.MenuMainQuit.Size = new System.Drawing.Size(180, 22);
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
            this.MenuMeMyFlow.Size = new System.Drawing.Size(180, 22);
            this.MenuMeMyFlow.Text = "MyFlow";
            // 
            // MenuMeMyJourneys
            // 
            this.MenuMeMyJourneys.Name = "MenuMeMyJourneys";
            this.MenuMeMyJourneys.Size = new System.Drawing.Size(180, 22);
            this.MenuMeMyJourneys.Text = "MyJourneys";
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
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
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
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.mainToolStripContainer.ContentPanel.ResumeLayout(false);
            this.mainToolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.mainToolStripContainer.TopToolStripPanel.PerformLayout();
            this.mainToolStripContainer.ResumeLayout(false);
            this.mainToolStripContainer.PerformLayout();
            this.GrpBxUserData.ResumeLayout(false);
            this.GrpBxUserData.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        public System.Windows.Forms.Label TxtUserDataBirthDate;
        public System.Windows.Forms.Label TxtUserDataRealName;
        private System.Windows.Forms.Label TxtMainFormUserDataBirthDate;
        private System.Windows.Forms.Label TxtMainFormUserDataName;
        public System.Windows.Forms.GroupBox GrpBxUserData;
        public System.Windows.Forms.GroupBox GrpBxMainFrame;
        private System.Windows.Forms.ToolStripMenuItem MenuMe;
        private System.Windows.Forms.ToolStripMenuItem MenuMeMyFlow;
        private System.Windows.Forms.ToolStripMenuItem MenuMeMyJourneys;
        private System.Windows.Forms.ToolStripMenuItem MenuMeNewJourney;
        private System.Windows.Forms.ToolStripMenuItem MenuMeNewEntry;
        private System.Windows.Forms.ToolStripMenuItem MenuMeGoalReached;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox InputTest;
    }
}

