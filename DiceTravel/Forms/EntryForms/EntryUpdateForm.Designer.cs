namespace DiceTravel.Forms.EntryForms
{
    partial class EntryUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryUpdateForm));
            this.GrpBxEntryUpdateVisibility = new System.Windows.Forms.GroupBox();
            this.RBtnEntryUpdateVisibilityPublic = new System.Windows.Forms.RadioButton();
            this.RBtnEntryUpdateVisibilityOnlyFriends = new System.Windows.Forms.RadioButton();
            this.RBtnEntryUpdateVisibilityPrivate = new System.Windows.Forms.RadioButton();
            this.InputEntryUpdateTitle = new System.Windows.Forms.TextBox();
            this.TxtEntryUpdateTitle_label = new System.Windows.Forms.Label();
            this.InputEntryUpdateComment = new System.Windows.Forms.TextBox();
            this.TxtEntryUpdateJourneyTitle = new System.Windows.Forms.Label();
            this.TxtEntryUpdateFormTitle = new System.Windows.Forms.Label();
            this.BtnEntryUpdateCancel = new System.Windows.Forms.Button();
            this.BtnEntryUpdateUpdate = new System.Windows.Forms.Button();
            this.BtnEntryUpdateDelete = new System.Windows.Forms.Button();
            this.GrpBxEntryUpdateVisibility.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBxEntryUpdateVisibility
            // 
            this.GrpBxEntryUpdateVisibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GrpBxEntryUpdateVisibility.Controls.Add(this.RBtnEntryUpdateVisibilityPublic);
            this.GrpBxEntryUpdateVisibility.Controls.Add(this.RBtnEntryUpdateVisibilityOnlyFriends);
            this.GrpBxEntryUpdateVisibility.Controls.Add(this.RBtnEntryUpdateVisibilityPrivate);
            this.GrpBxEntryUpdateVisibility.Location = new System.Drawing.Point(22, 173);
            this.GrpBxEntryUpdateVisibility.Name = "GrpBxEntryUpdateVisibility";
            this.GrpBxEntryUpdateVisibility.Size = new System.Drawing.Size(100, 90);
            this.GrpBxEntryUpdateVisibility.TabIndex = 24;
            this.GrpBxEntryUpdateVisibility.TabStop = false;
            this.GrpBxEntryUpdateVisibility.Text = "Visibility: ";
            // 
            // RBtnEntryUpdateVisibilityPublic
            // 
            this.RBtnEntryUpdateVisibilityPublic.AutoSize = true;
            this.RBtnEntryUpdateVisibilityPublic.Location = new System.Drawing.Point(6, 67);
            this.RBtnEntryUpdateVisibilityPublic.Name = "RBtnEntryUpdateVisibilityPublic";
            this.RBtnEntryUpdateVisibilityPublic.Size = new System.Drawing.Size(54, 17);
            this.RBtnEntryUpdateVisibilityPublic.TabIndex = 2;
            this.RBtnEntryUpdateVisibilityPublic.Text = "Public";
            this.RBtnEntryUpdateVisibilityPublic.UseVisualStyleBackColor = true;
            // 
            // RBtnEntryUpdateVisibilityOnlyFriends
            // 
            this.RBtnEntryUpdateVisibilityOnlyFriends.AutoSize = true;
            this.RBtnEntryUpdateVisibilityOnlyFriends.Location = new System.Drawing.Point(6, 43);
            this.RBtnEntryUpdateVisibilityOnlyFriends.Name = "RBtnEntryUpdateVisibilityOnlyFriends";
            this.RBtnEntryUpdateVisibilityOnlyFriends.Size = new System.Drawing.Size(83, 17);
            this.RBtnEntryUpdateVisibilityOnlyFriends.TabIndex = 1;
            this.RBtnEntryUpdateVisibilityOnlyFriends.Text = "Only Friends";
            this.RBtnEntryUpdateVisibilityOnlyFriends.UseVisualStyleBackColor = true;
            // 
            // RBtnEntryUpdateVisibilityPrivate
            // 
            this.RBtnEntryUpdateVisibilityPrivate.AutoSize = true;
            this.RBtnEntryUpdateVisibilityPrivate.Checked = true;
            this.RBtnEntryUpdateVisibilityPrivate.Location = new System.Drawing.Point(6, 19);
            this.RBtnEntryUpdateVisibilityPrivate.Name = "RBtnEntryUpdateVisibilityPrivate";
            this.RBtnEntryUpdateVisibilityPrivate.Size = new System.Drawing.Size(58, 17);
            this.RBtnEntryUpdateVisibilityPrivate.TabIndex = 0;
            this.RBtnEntryUpdateVisibilityPrivate.TabStop = true;
            this.RBtnEntryUpdateVisibilityPrivate.Text = "Private";
            this.RBtnEntryUpdateVisibilityPrivate.UseVisualStyleBackColor = true;
            // 
            // InputEntryUpdateTitle
            // 
            this.InputEntryUpdateTitle.Location = new System.Drawing.Point(93, 55);
            this.InputEntryUpdateTitle.MaxLength = 50;
            this.InputEntryUpdateTitle.Name = "InputEntryUpdateTitle";
            this.InputEntryUpdateTitle.Size = new System.Drawing.Size(130, 20);
            this.InputEntryUpdateTitle.TabIndex = 28;
            // 
            // TxtEntryUpdateTitle_label
            // 
            this.TxtEntryUpdateTitle_label.AutoSize = true;
            this.TxtEntryUpdateTitle_label.Location = new System.Drawing.Point(54, 58);
            this.TxtEntryUpdateTitle_label.Name = "TxtEntryUpdateTitle_label";
            this.TxtEntryUpdateTitle_label.Size = new System.Drawing.Size(33, 13);
            this.TxtEntryUpdateTitle_label.TabIndex = 27;
            this.TxtEntryUpdateTitle_label.Text = "Title: ";
            // 
            // InputEntryUpdateComment
            // 
            this.InputEntryUpdateComment.Location = new System.Drawing.Point(12, 81);
            this.InputEntryUpdateComment.MaxLength = 512;
            this.InputEntryUpdateComment.Multiline = true;
            this.InputEntryUpdateComment.Name = "InputEntryUpdateComment";
            this.InputEntryUpdateComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputEntryUpdateComment.Size = new System.Drawing.Size(211, 82);
            this.InputEntryUpdateComment.TabIndex = 23;
            // 
            // TxtEntryUpdateJourneyTitle
            // 
            this.TxtEntryUpdateJourneyTitle.AutoSize = true;
            this.TxtEntryUpdateJourneyTitle.Location = new System.Drawing.Point(12, 65);
            this.TxtEntryUpdateJourneyTitle.Name = "TxtEntryUpdateJourneyTitle";
            this.TxtEntryUpdateJourneyTitle.Size = new System.Drawing.Size(34, 13);
            this.TxtEntryUpdateJourneyTitle.TabIndex = 22;
            this.TxtEntryUpdateJourneyTitle.Text = "Story:";
            // 
            // TxtEntryUpdateFormTitle
            // 
            this.TxtEntryUpdateFormTitle.AutoSize = true;
            this.TxtEntryUpdateFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtEntryUpdateFormTitle.Location = new System.Drawing.Point(42, 10);
            this.TxtEntryUpdateFormTitle.Name = "TxtEntryUpdateFormTitle";
            this.TxtEntryUpdateFormTitle.Size = new System.Drawing.Size(158, 33);
            this.TxtEntryUpdateFormTitle.TabIndex = 21;
            this.TxtEntryUpdateFormTitle.Text = "New Entry";
            // 
            // BtnEntryUpdateCancel
            // 
            this.BtnEntryUpdateCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEntryUpdateCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnEntryUpdateCancel.Location = new System.Drawing.Point(128, 202);
            this.BtnEntryUpdateCancel.Name = "BtnEntryUpdateCancel";
            this.BtnEntryUpdateCancel.Size = new System.Drawing.Size(95, 23);
            this.BtnEntryUpdateCancel.TabIndex = 26;
            this.BtnEntryUpdateCancel.Text = "Cancel";
            this.BtnEntryUpdateCancel.UseVisualStyleBackColor = true;
            this.BtnEntryUpdateCancel.Click += new System.EventHandler(this.BtnEntryUpdateCancel_Click);
            // 
            // BtnEntryUpdateUpdate
            // 
            this.BtnEntryUpdateUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEntryUpdateUpdate.Location = new System.Drawing.Point(128, 173);
            this.BtnEntryUpdateUpdate.Name = "BtnEntryUpdateUpdate";
            this.BtnEntryUpdateUpdate.Size = new System.Drawing.Size(95, 23);
            this.BtnEntryUpdateUpdate.TabIndex = 25;
            this.BtnEntryUpdateUpdate.Text = "Update";
            this.BtnEntryUpdateUpdate.UseVisualStyleBackColor = true;
            this.BtnEntryUpdateUpdate.Click += new System.EventHandler(this.BtnEntryUpdateUpdate_Click);
            // 
            // BtnEntryUpdateDelete
            // 
            this.BtnEntryUpdateDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEntryUpdateDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnEntryUpdateDelete.Location = new System.Drawing.Point(128, 240);
            this.BtnEntryUpdateDelete.Name = "BtnEntryUpdateDelete";
            this.BtnEntryUpdateDelete.Size = new System.Drawing.Size(95, 23);
            this.BtnEntryUpdateDelete.TabIndex = 29;
            this.BtnEntryUpdateDelete.Text = "Delete";
            this.BtnEntryUpdateDelete.UseVisualStyleBackColor = true;
            this.BtnEntryUpdateDelete.Click += new System.EventHandler(this.BtnEntryUpdateDelete_Click);
            // 
            // EntryUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 273);
            this.Controls.Add(this.BtnEntryUpdateDelete);
            this.Controls.Add(this.GrpBxEntryUpdateVisibility);
            this.Controls.Add(this.InputEntryUpdateTitle);
            this.Controls.Add(this.TxtEntryUpdateTitle_label);
            this.Controls.Add(this.InputEntryUpdateComment);
            this.Controls.Add(this.TxtEntryUpdateJourneyTitle);
            this.Controls.Add(this.TxtEntryUpdateFormTitle);
            this.Controls.Add(this.BtnEntryUpdateCancel);
            this.Controls.Add(this.BtnEntryUpdateUpdate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 312);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 312);
            this.Name = "EntryUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntryUpdateForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EntryUpdateForm_FormClosed);
            this.Load += new System.EventHandler(this.EntryUpdateForm_Load);
            this.GrpBxEntryUpdateVisibility.ResumeLayout(false);
            this.GrpBxEntryUpdateVisibility.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBxEntryUpdateVisibility;
        private System.Windows.Forms.RadioButton RBtnEntryUpdateVisibilityPublic;
        private System.Windows.Forms.RadioButton RBtnEntryUpdateVisibilityOnlyFriends;
        private System.Windows.Forms.RadioButton RBtnEntryUpdateVisibilityPrivate;
        private System.Windows.Forms.TextBox InputEntryUpdateTitle;
        private System.Windows.Forms.Label TxtEntryUpdateTitle_label;
        private System.Windows.Forms.TextBox InputEntryUpdateComment;
        private System.Windows.Forms.Label TxtEntryUpdateJourneyTitle;
        private System.Windows.Forms.Label TxtEntryUpdateFormTitle;
        private System.Windows.Forms.Button BtnEntryUpdateCancel;
        private System.Windows.Forms.Button BtnEntryUpdateUpdate;
        private System.Windows.Forms.Button BtnEntryUpdateDelete;
    }
}