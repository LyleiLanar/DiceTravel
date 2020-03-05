namespace DiceTravel.Forms.JourneyForms
{
    partial class JourneyCreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JourneyCreateForm));
            this.TxtJourneyCreateFormTitle = new System.Windows.Forms.Label();
            this.TxtJourneyCreateJourneyTitle = new System.Windows.Forms.Label();
            this.TxtJourneyCreateJourneyStartLocation = new System.Windows.Forms.Label();
            this.InputJourneyCreateJourneyTitle = new System.Windows.Forms.TextBox();
            this.InputJourneyCreateJourneyStartLocation = new System.Windows.Forms.TextBox();
            this.GrpBxJourneyCreateVisibility = new System.Windows.Forms.GroupBox();
            this.RBtnJourneyCreateVisibilityPublic = new System.Windows.Forms.RadioButton();
            this.RBtnJourneyCreateVisibilityOnlyFriends = new System.Windows.Forms.RadioButton();
            this.RBtnJourneyCreateVisibilityPrivate = new System.Windows.Forms.RadioButton();
            this.BtnJourneyCreateStart = new System.Windows.Forms.Button();
            this.BtnJourneyCreateCancel = new System.Windows.Forms.Button();
            this.TxtJourneyCreateJourneyFirstDest = new System.Windows.Forms.Label();
            this.InputJourneyCreateJourneyFirstDest = new System.Windows.Forms.TextBox();
            this.GrpBxJourneyCreateVisibility.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtJourneyCreateFormTitle
            // 
            this.TxtJourneyCreateFormTitle.AutoSize = true;
            this.TxtJourneyCreateFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtJourneyCreateFormTitle.Location = new System.Drawing.Point(15, 9);
            this.TxtJourneyCreateFormTitle.Name = "TxtJourneyCreateFormTitle";
            this.TxtJourneyCreateFormTitle.Size = new System.Drawing.Size(196, 33);
            this.TxtJourneyCreateFormTitle.TabIndex = 0;
            this.TxtJourneyCreateFormTitle.Text = "New Journey";
            // 
            // TxtJourneyCreateJourneyTitle
            // 
            this.TxtJourneyCreateJourneyTitle.AutoSize = true;
            this.TxtJourneyCreateJourneyTitle.Location = new System.Drawing.Point(60, 59);
            this.TxtJourneyCreateJourneyTitle.Name = "TxtJourneyCreateJourneyTitle";
            this.TxtJourneyCreateJourneyTitle.Size = new System.Drawing.Size(33, 13);
            this.TxtJourneyCreateJourneyTitle.TabIndex = 1;
            this.TxtJourneyCreateJourneyTitle.Text = "Title: ";
            // 
            // TxtJourneyCreateJourneyStartLocation
            // 
            this.TxtJourneyCreateJourneyStartLocation.AutoSize = true;
            this.TxtJourneyCreateJourneyStartLocation.Location = new System.Drawing.Point(18, 85);
            this.TxtJourneyCreateJourneyStartLocation.Name = "TxtJourneyCreateJourneyStartLocation";
            this.TxtJourneyCreateJourneyStartLocation.Size = new System.Drawing.Size(75, 13);
            this.TxtJourneyCreateJourneyStartLocation.TabIndex = 2;
            this.TxtJourneyCreateJourneyStartLocation.Text = "Start location: ";
            // 
            // InputJourneyCreateJourneyTitle
            // 
            this.InputJourneyCreateJourneyTitle.Location = new System.Drawing.Point(99, 56);
            this.InputJourneyCreateJourneyTitle.MaxLength = 50;
            this.InputJourneyCreateJourneyTitle.Name = "InputJourneyCreateJourneyTitle";
            this.InputJourneyCreateJourneyTitle.Size = new System.Drawing.Size(100, 20);
            this.InputJourneyCreateJourneyTitle.TabIndex = 4;
            // 
            // InputJourneyCreateJourneyStartLocation
            // 
            this.InputJourneyCreateJourneyStartLocation.Location = new System.Drawing.Point(99, 82);
            this.InputJourneyCreateJourneyStartLocation.MaxLength = 20;
            this.InputJourneyCreateJourneyStartLocation.Name = "InputJourneyCreateJourneyStartLocation";
            this.InputJourneyCreateJourneyStartLocation.Size = new System.Drawing.Size(100, 20);
            this.InputJourneyCreateJourneyStartLocation.TabIndex = 5;
            // 
            // GrpBxJourneyCreateVisibility
            // 
            this.GrpBxJourneyCreateVisibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GrpBxJourneyCreateVisibility.Controls.Add(this.RBtnJourneyCreateVisibilityPublic);
            this.GrpBxJourneyCreateVisibility.Controls.Add(this.RBtnJourneyCreateVisibilityOnlyFriends);
            this.GrpBxJourneyCreateVisibility.Controls.Add(this.RBtnJourneyCreateVisibilityPrivate);
            this.GrpBxJourneyCreateVisibility.Location = new System.Drawing.Point(21, 145);
            this.GrpBxJourneyCreateVisibility.Name = "GrpBxJourneyCreateVisibility";
            this.GrpBxJourneyCreateVisibility.Size = new System.Drawing.Size(100, 90);
            this.GrpBxJourneyCreateVisibility.TabIndex = 6;
            this.GrpBxJourneyCreateVisibility.TabStop = false;
            this.GrpBxJourneyCreateVisibility.Text = "Visibility: ";
            // 
            // RBtnJourneyCreateVisibilityPublic
            // 
            this.RBtnJourneyCreateVisibilityPublic.AutoSize = true;
            this.RBtnJourneyCreateVisibilityPublic.Location = new System.Drawing.Point(6, 67);
            this.RBtnJourneyCreateVisibilityPublic.Name = "RBtnJourneyCreateVisibilityPublic";
            this.RBtnJourneyCreateVisibilityPublic.Size = new System.Drawing.Size(54, 17);
            this.RBtnJourneyCreateVisibilityPublic.TabIndex = 2;
            this.RBtnJourneyCreateVisibilityPublic.Text = "Public";
            this.RBtnJourneyCreateVisibilityPublic.UseVisualStyleBackColor = true;
            // 
            // RBtnJourneyCreateVisibilityOnlyFriends
            // 
            this.RBtnJourneyCreateVisibilityOnlyFriends.AutoSize = true;
            this.RBtnJourneyCreateVisibilityOnlyFriends.Location = new System.Drawing.Point(6, 43);
            this.RBtnJourneyCreateVisibilityOnlyFriends.Name = "RBtnJourneyCreateVisibilityOnlyFriends";
            this.RBtnJourneyCreateVisibilityOnlyFriends.Size = new System.Drawing.Size(83, 17);
            this.RBtnJourneyCreateVisibilityOnlyFriends.TabIndex = 1;
            this.RBtnJourneyCreateVisibilityOnlyFriends.Text = "Only Friends";
            this.RBtnJourneyCreateVisibilityOnlyFriends.UseVisualStyleBackColor = true;
            // 
            // RBtnJourneyCreateVisibilityPrivate
            // 
            this.RBtnJourneyCreateVisibilityPrivate.AutoSize = true;
            this.RBtnJourneyCreateVisibilityPrivate.Checked = true;
            this.RBtnJourneyCreateVisibilityPrivate.Location = new System.Drawing.Point(6, 19);
            this.RBtnJourneyCreateVisibilityPrivate.Name = "RBtnJourneyCreateVisibilityPrivate";
            this.RBtnJourneyCreateVisibilityPrivate.Size = new System.Drawing.Size(58, 17);
            this.RBtnJourneyCreateVisibilityPrivate.TabIndex = 0;
            this.RBtnJourneyCreateVisibilityPrivate.TabStop = true;
            this.RBtnJourneyCreateVisibilityPrivate.Text = "Private";
            this.RBtnJourneyCreateVisibilityPrivate.UseVisualStyleBackColor = true;
            // 
            // BtnJourneyCreateStart
            // 
            this.BtnJourneyCreateStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnJourneyCreateStart.Location = new System.Drawing.Point(127, 173);
            this.BtnJourneyCreateStart.Name = "BtnJourneyCreateStart";
            this.BtnJourneyCreateStart.Size = new System.Drawing.Size(95, 23);
            this.BtnJourneyCreateStart.TabIndex = 7;
            this.BtnJourneyCreateStart.Text = "Set goal";
            this.BtnJourneyCreateStart.UseVisualStyleBackColor = true;
            this.BtnJourneyCreateStart.Click += new System.EventHandler(this.BtnJourneyCreateStart_Click);
            // 
            // BtnJourneyCreateCancel
            // 
            this.BtnJourneyCreateCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnJourneyCreateCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnJourneyCreateCancel.Location = new System.Drawing.Point(127, 203);
            this.BtnJourneyCreateCancel.Name = "BtnJourneyCreateCancel";
            this.BtnJourneyCreateCancel.Size = new System.Drawing.Size(95, 23);
            this.BtnJourneyCreateCancel.TabIndex = 8;
            this.BtnJourneyCreateCancel.Text = "Cancel";
            this.BtnJourneyCreateCancel.UseVisualStyleBackColor = true;
            this.BtnJourneyCreateCancel.Click += new System.EventHandler(this.BtnJourneyCreateCancel_Click);
            // 
            // TxtJourneyCreateJourneyFirstDest
            // 
            this.TxtJourneyCreateJourneyFirstDest.AutoSize = true;
            this.TxtJourneyCreateJourneyFirstDest.Location = new System.Drawing.Point(10, 111);
            this.TxtJourneyCreateJourneyFirstDest.Name = "TxtJourneyCreateJourneyFirstDest";
            this.TxtJourneyCreateJourneyFirstDest.Size = new System.Drawing.Size(83, 13);
            this.TxtJourneyCreateJourneyFirstDest.TabIndex = 9;
            this.TxtJourneyCreateJourneyFirstDest.Text = "First destination:";
            // 
            // InputJourneyCreateJourneyFirstDest
            // 
            this.InputJourneyCreateJourneyFirstDest.Location = new System.Drawing.Point(99, 108);
            this.InputJourneyCreateJourneyFirstDest.MaxLength = 20;
            this.InputJourneyCreateJourneyFirstDest.Name = "InputJourneyCreateJourneyFirstDest";
            this.InputJourneyCreateJourneyFirstDest.Size = new System.Drawing.Size(100, 20);
            this.InputJourneyCreateJourneyFirstDest.TabIndex = 6;
            // 
            // JourneyCreateForm
            // 
            this.AcceptButton = this.BtnJourneyCreateStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnJourneyCreateCancel;
            this.ClientSize = new System.Drawing.Size(234, 247);
            this.Controls.Add(this.InputJourneyCreateJourneyFirstDest);
            this.Controls.Add(this.TxtJourneyCreateJourneyFirstDest);
            this.Controls.Add(this.BtnJourneyCreateCancel);
            this.Controls.Add(this.BtnJourneyCreateStart);
            this.Controls.Add(this.GrpBxJourneyCreateVisibility);
            this.Controls.Add(this.InputJourneyCreateJourneyStartLocation);
            this.Controls.Add(this.InputJourneyCreateJourneyTitle);
            this.Controls.Add(this.TxtJourneyCreateJourneyStartLocation);
            this.Controls.Add(this.TxtJourneyCreateJourneyTitle);
            this.Controls.Add(this.TxtJourneyCreateFormTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JourneyCreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JourneyCreateForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.JourneyCreateForm_FormClosed);
            this.Load += new System.EventHandler(this.JourneyCreateForm_Load);
            this.GrpBxJourneyCreateVisibility.ResumeLayout(false);
            this.GrpBxJourneyCreateVisibility.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtJourneyCreateFormTitle;
        private System.Windows.Forms.Label TxtJourneyCreateJourneyTitle;
        private System.Windows.Forms.Label TxtJourneyCreateJourneyStartLocation;
        private System.Windows.Forms.TextBox InputJourneyCreateJourneyTitle;
        private System.Windows.Forms.TextBox InputJourneyCreateJourneyStartLocation;
        private System.Windows.Forms.GroupBox GrpBxJourneyCreateVisibility;
        private System.Windows.Forms.RadioButton RBtnJourneyCreateVisibilityPublic;
        private System.Windows.Forms.RadioButton RBtnJourneyCreateVisibilityOnlyFriends;
        private System.Windows.Forms.RadioButton RBtnJourneyCreateVisibilityPrivate;
        private System.Windows.Forms.Button BtnJourneyCreateStart;
        private System.Windows.Forms.Button BtnJourneyCreateCancel;
        private System.Windows.Forms.Label TxtJourneyCreateJourneyFirstDest;
        private System.Windows.Forms.TextBox InputJourneyCreateJourneyFirstDest;
    }
}