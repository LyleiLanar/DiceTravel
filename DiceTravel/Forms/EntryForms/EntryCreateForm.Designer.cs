namespace DiceTravel.Forms.EntryForms
{
    partial class EntryCreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryCreateForm));
            this.GrpBxEntryCreateVisibility = new System.Windows.Forms.GroupBox();
            this.RBtnEntryCreateVisibilityPublic = new System.Windows.Forms.RadioButton();
            this.RBtnEntryCreateVisibilityOnlyFriends = new System.Windows.Forms.RadioButton();
            this.RBtnEntryCreateVisibilityPrivate = new System.Windows.Forms.RadioButton();
            this.InputEntryCreateComment = new System.Windows.Forms.TextBox();
            this.TxtEntryCreateJourneyTitle = new System.Windows.Forms.Label();
            this.TxtEntryCreateFormTitle = new System.Windows.Forms.Label();
            this.BtnEntryCreateCancel = new System.Windows.Forms.Button();
            this.BtnEntryCreateNew = new System.Windows.Forms.Button();
            this.InputEntryCreateTitle = new System.Windows.Forms.TextBox();
            this.TxtEntryCreateTitle_label = new System.Windows.Forms.Label();
            this.GrpBxEntryCreateVisibility.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrpBxEntryCreateVisibility
            // 
            this.GrpBxEntryCreateVisibility.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.GrpBxEntryCreateVisibility.Controls.Add(this.RBtnEntryCreateVisibilityPublic);
            this.GrpBxEntryCreateVisibility.Controls.Add(this.RBtnEntryCreateVisibilityOnlyFriends);
            this.GrpBxEntryCreateVisibility.Controls.Add(this.RBtnEntryCreateVisibilityPrivate);
            this.GrpBxEntryCreateVisibility.Location = new System.Drawing.Point(22, 172);
            this.GrpBxEntryCreateVisibility.Name = "GrpBxEntryCreateVisibility";
            this.GrpBxEntryCreateVisibility.Size = new System.Drawing.Size(100, 90);
            this.GrpBxEntryCreateVisibility.TabIndex = 15;
            this.GrpBxEntryCreateVisibility.TabStop = false;
            this.GrpBxEntryCreateVisibility.Text = "Visibility: ";
            // 
            // RBtnEntryCreateVisibilityPublic
            // 
            this.RBtnEntryCreateVisibilityPublic.AutoSize = true;
            this.RBtnEntryCreateVisibilityPublic.Location = new System.Drawing.Point(6, 67);
            this.RBtnEntryCreateVisibilityPublic.Name = "RBtnEntryCreateVisibilityPublic";
            this.RBtnEntryCreateVisibilityPublic.Size = new System.Drawing.Size(54, 17);
            this.RBtnEntryCreateVisibilityPublic.TabIndex = 2;
            this.RBtnEntryCreateVisibilityPublic.Text = "Public";
            this.RBtnEntryCreateVisibilityPublic.UseVisualStyleBackColor = true;
            // 
            // RBtnEntryCreateVisibilityOnlyFriends
            // 
            this.RBtnEntryCreateVisibilityOnlyFriends.AutoSize = true;
            this.RBtnEntryCreateVisibilityOnlyFriends.Location = new System.Drawing.Point(6, 43);
            this.RBtnEntryCreateVisibilityOnlyFriends.Name = "RBtnEntryCreateVisibilityOnlyFriends";
            this.RBtnEntryCreateVisibilityOnlyFriends.Size = new System.Drawing.Size(83, 17);
            this.RBtnEntryCreateVisibilityOnlyFriends.TabIndex = 1;
            this.RBtnEntryCreateVisibilityOnlyFriends.Text = "Only Friends";
            this.RBtnEntryCreateVisibilityOnlyFriends.UseVisualStyleBackColor = true;
            // 
            // RBtnEntryCreateVisibilityPrivate
            // 
            this.RBtnEntryCreateVisibilityPrivate.AutoSize = true;
            this.RBtnEntryCreateVisibilityPrivate.Checked = true;
            this.RBtnEntryCreateVisibilityPrivate.Location = new System.Drawing.Point(6, 19);
            this.RBtnEntryCreateVisibilityPrivate.Name = "RBtnEntryCreateVisibilityPrivate";
            this.RBtnEntryCreateVisibilityPrivate.Size = new System.Drawing.Size(58, 17);
            this.RBtnEntryCreateVisibilityPrivate.TabIndex = 0;
            this.RBtnEntryCreateVisibilityPrivate.TabStop = true;
            this.RBtnEntryCreateVisibilityPrivate.Text = "Private";
            this.RBtnEntryCreateVisibilityPrivate.UseVisualStyleBackColor = true;
            // 
            // InputEntryCreateComment
            // 
            this.InputEntryCreateComment.Location = new System.Drawing.Point(12, 80);
            this.InputEntryCreateComment.MaxLength = 512;
            this.InputEntryCreateComment.Multiline = true;
            this.InputEntryCreateComment.Name = "InputEntryCreateComment";
            this.InputEntryCreateComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InputEntryCreateComment.Size = new System.Drawing.Size(211, 82);
            this.InputEntryCreateComment.TabIndex = 13;
            // 
            // TxtEntryCreateJourneyTitle
            // 
            this.TxtEntryCreateJourneyTitle.AutoSize = true;
            this.TxtEntryCreateJourneyTitle.Location = new System.Drawing.Point(12, 64);
            this.TxtEntryCreateJourneyTitle.Name = "TxtEntryCreateJourneyTitle";
            this.TxtEntryCreateJourneyTitle.Size = new System.Drawing.Size(34, 13);
            this.TxtEntryCreateJourneyTitle.TabIndex = 11;
            this.TxtEntryCreateJourneyTitle.Text = "Story:";
            // 
            // TxtEntryCreateFormTitle
            // 
            this.TxtEntryCreateFormTitle.AutoSize = true;
            this.TxtEntryCreateFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtEntryCreateFormTitle.Location = new System.Drawing.Point(42, 9);
            this.TxtEntryCreateFormTitle.Name = "TxtEntryCreateFormTitle";
            this.TxtEntryCreateFormTitle.Size = new System.Drawing.Size(158, 33);
            this.TxtEntryCreateFormTitle.TabIndex = 10;
            this.TxtEntryCreateFormTitle.Text = "New Entry";
            // 
            // BtnEntryCreateCancel
            // 
            this.BtnEntryCreateCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEntryCreateCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnEntryCreateCancel.Location = new System.Drawing.Point(128, 239);
            this.BtnEntryCreateCancel.Name = "BtnEntryCreateCancel";
            this.BtnEntryCreateCancel.Size = new System.Drawing.Size(95, 23);
            this.BtnEntryCreateCancel.TabIndex = 18;
            this.BtnEntryCreateCancel.Text = "Cancel";
            this.BtnEntryCreateCancel.UseVisualStyleBackColor = true;
            this.BtnEntryCreateCancel.Click += new System.EventHandler(this.BtnEntryCreateCancel_Click);
            // 
            // BtnEntryCreateNew
            // 
            this.BtnEntryCreateNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnEntryCreateNew.Location = new System.Drawing.Point(128, 185);
            this.BtnEntryCreateNew.Name = "BtnEntryCreateNew";
            this.BtnEntryCreateNew.Size = new System.Drawing.Size(95, 23);
            this.BtnEntryCreateNew.TabIndex = 17;
            this.BtnEntryCreateNew.Text = "Save";
            this.BtnEntryCreateNew.UseVisualStyleBackColor = true;
            this.BtnEntryCreateNew.Click += new System.EventHandler(this.BtnEntryCreateNew_Click);
            // 
            // InputEntryCreateTitle
            // 
            this.InputEntryCreateTitle.Location = new System.Drawing.Point(93, 54);
            this.InputEntryCreateTitle.MaxLength = 50;
            this.InputEntryCreateTitle.Name = "InputEntryCreateTitle";
            this.InputEntryCreateTitle.Size = new System.Drawing.Size(130, 20);
            this.InputEntryCreateTitle.TabIndex = 20;
            // 
            // TxtEntryCreateTitle_label
            // 
            this.TxtEntryCreateTitle_label.AutoSize = true;
            this.TxtEntryCreateTitle_label.Location = new System.Drawing.Point(54, 57);
            this.TxtEntryCreateTitle_label.Name = "TxtEntryCreateTitle_label";
            this.TxtEntryCreateTitle_label.Size = new System.Drawing.Size(33, 13);
            this.TxtEntryCreateTitle_label.TabIndex = 19;
            this.TxtEntryCreateTitle_label.Text = "Title: ";
            // 
            // EntryCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 273);
            this.Controls.Add(this.InputEntryCreateTitle);
            this.Controls.Add(this.TxtEntryCreateTitle_label);
            this.Controls.Add(this.GrpBxEntryCreateVisibility);
            this.Controls.Add(this.InputEntryCreateComment);
            this.Controls.Add(this.TxtEntryCreateJourneyTitle);
            this.Controls.Add(this.TxtEntryCreateFormTitle);
            this.Controls.Add(this.BtnEntryCreateCancel);
            this.Controls.Add(this.BtnEntryCreateNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntryCreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntryCreateForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EntryCreateForm_FormClosed);
            this.Load += new System.EventHandler(this.EntryCreateForm_Load);
            this.GrpBxEntryCreateVisibility.ResumeLayout(false);
            this.GrpBxEntryCreateVisibility.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpBxEntryCreateVisibility;
        private System.Windows.Forms.RadioButton RBtnEntryCreateVisibilityPublic;
        private System.Windows.Forms.RadioButton RBtnEntryCreateVisibilityOnlyFriends;
        private System.Windows.Forms.RadioButton RBtnEntryCreateVisibilityPrivate;
        private System.Windows.Forms.TextBox InputEntryCreateComment;
        private System.Windows.Forms.Label TxtEntryCreateJourneyTitle;
        private System.Windows.Forms.Label TxtEntryCreateFormTitle;
        private System.Windows.Forms.Button BtnEntryCreateCancel;
        private System.Windows.Forms.Button BtnEntryCreateNew;
        private System.Windows.Forms.TextBox InputEntryCreateTitle;
        private System.Windows.Forms.Label TxtEntryCreateTitle_label;
    }
}