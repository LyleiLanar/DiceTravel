namespace DiceTravel.Controls
{
    partial class EntryControl
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
            this.TxtEntryDate = new System.Windows.Forms.Label();
            this.TxtEntryTitle = new System.Windows.Forms.Label();
            this.TxtEntryComment = new System.Windows.Forms.RichTextBox();
            this.BtnEntryOptions = new System.Windows.Forms.Button();
            this.PctBxEntryVisibility = new System.Windows.Forms.PictureBox();
            this.BtnEntryBackToEntry = new System.Windows.Forms.Button();
            this.PctBxEntryImage = new System.Windows.Forms.PictureBox();
            this.TxtEntryUserLoginName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxEntryVisibility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxEntryImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtEntryDate
            // 
            this.TxtEntryDate.AutoSize = true;
            this.TxtEntryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtEntryDate.Location = new System.Drawing.Point(42, 52);
            this.TxtEntryDate.Name = "TxtEntryDate";
            this.TxtEntryDate.Size = new System.Drawing.Size(33, 15);
            this.TxtEntryDate.TabIndex = 22;
            this.TxtEntryDate.Text = "Date";
            // 
            // TxtEntryTitle
            // 
            this.TxtEntryTitle.AutoSize = true;
            this.TxtEntryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtEntryTitle.Location = new System.Drawing.Point(41, 21);
            this.TxtEntryTitle.Name = "TxtEntryTitle";
            this.TxtEntryTitle.Size = new System.Drawing.Size(66, 20);
            this.TxtEntryTitle.TabIndex = 19;
            this.TxtEntryTitle.Text = "START";
            // 
            // TxtEntryComment
            // 
            this.TxtEntryComment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtEntryComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEntryComment.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtEntryComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtEntryComment.Location = new System.Drawing.Point(17, 411);
            this.TxtEntryComment.Margin = new System.Windows.Forms.Padding(15, 3, 15, 15);
            this.TxtEntryComment.Name = "TxtEntryComment";
            this.TxtEntryComment.ReadOnly = true;
            this.TxtEntryComment.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TxtEntryComment.Size = new System.Drawing.Size(599, 33);
            this.TxtEntryComment.TabIndex = 23;
            this.TxtEntryComment.Text = "";
            this.TxtEntryComment.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.TxtEntryComment_ContentsResized);
            this.TxtEntryComment.MouseEnter += new System.EventHandler(this.TxtEntryComment_MouseEnter);
            this.TxtEntryComment.MouseLeave += new System.EventHandler(this.TxtEntryComment_MouseLeave);
            // 
            // BtnEntryOptions
            // 
            this.BtnEntryOptions.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEntryOptions.FlatAppearance.BorderSize = 0;
            this.BtnEntryOptions.Image = global::DiceTravel.Properties.Resources.icoSettings;
            this.BtnEntryOptions.Location = new System.Drawing.Point(574, 15);
            this.BtnEntryOptions.Name = "BtnEntryOptions";
            this.BtnEntryOptions.Size = new System.Drawing.Size(42, 45);
            this.BtnEntryOptions.TabIndex = 21;
            this.BtnEntryOptions.UseVisualStyleBackColor = false;
            this.BtnEntryOptions.Click += new System.EventHandler(this.BtnEntryOptions_Click);
            // 
            // PctBxEntryVisibility
            // 
            this.PctBxEntryVisibility.Location = new System.Drawing.Point(3, 15);
            this.PctBxEntryVisibility.Name = "PctBxEntryVisibility";
            this.PctBxEntryVisibility.Size = new System.Drawing.Size(33, 33);
            this.PctBxEntryVisibility.TabIndex = 20;
            this.PctBxEntryVisibility.TabStop = false;
            this.PctBxEntryVisibility.WaitOnLoad = true;
            // 
            // BtnEntryBackToEntry
            // 
            this.BtnEntryBackToEntry.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEntryBackToEntry.FlatAppearance.BorderSize = 0;
            this.BtnEntryBackToEntry.Image = global::DiceTravel.Properties.Resources.icoBack;
            this.BtnEntryBackToEntry.Location = new System.Drawing.Point(519, 15);
            this.BtnEntryBackToEntry.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.BtnEntryBackToEntry.Name = "BtnEntryBackToEntry";
            this.BtnEntryBackToEntry.Size = new System.Drawing.Size(42, 45);
            this.BtnEntryBackToEntry.TabIndex = 24;
            this.BtnEntryBackToEntry.UseVisualStyleBackColor = false;
            this.BtnEntryBackToEntry.Click += new System.EventHandler(this.BtnEntryBackToEntry_Click);
            // 
            // PctBxEntryImage
            // 
            this.PctBxEntryImage.Location = new System.Drawing.Point(17, 73);
            this.PctBxEntryImage.Margin = new System.Windows.Forms.Padding(15, 3, 15, 15);
            this.PctBxEntryImage.Name = "PctBxEntryImage";
            this.PctBxEntryImage.Size = new System.Drawing.Size(599, 330);
            this.PctBxEntryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PctBxEntryImage.TabIndex = 25;
            this.PctBxEntryImage.TabStop = false;
            this.PctBxEntryImage.Visible = false;
            // 
            // TxtEntryUserLoginName
            // 
            this.TxtEntryUserLoginName.AutoSize = true;
            this.TxtEntryUserLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtEntryUserLoginName.Location = new System.Drawing.Point(42, 5);
            this.TxtEntryUserLoginName.Name = "TxtEntryUserLoginName";
            this.TxtEntryUserLoginName.Size = new System.Drawing.Size(47, 16);
            this.TxtEntryUserLoginName.TabIndex = 26;
            this.TxtEntryUserLoginName.Text = "NAME";
            this.TxtEntryUserLoginName.Click += new System.EventHandler(this.TxtJourneyUserLoginName_Click);
            // 
            // EntryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.TxtEntryUserLoginName);
            this.Controls.Add(this.PctBxEntryImage);
            this.Controls.Add(this.BtnEntryBackToEntry);
            this.Controls.Add(this.TxtEntryComment);
            this.Controls.Add(this.TxtEntryDate);
            this.Controls.Add(this.BtnEntryOptions);
            this.Controls.Add(this.PctBxEntryVisibility);
            this.Controls.Add(this.TxtEntryTitle);
            this.Name = "EntryControl";
            this.Size = new System.Drawing.Size(630, 460);
            ((System.ComponentModel.ISupportInitialize)(this.PctBxEntryVisibility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxEntryImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TxtEntryDate;
        private System.Windows.Forms.Button BtnEntryOptions;
        private System.Windows.Forms.PictureBox PctBxEntryVisibility;
        private System.Windows.Forms.Label TxtEntryTitle;
        private System.Windows.Forms.RichTextBox TxtEntryComment;
        private System.Windows.Forms.Button BtnEntryBackToEntry;
        private System.Windows.Forms.PictureBox PctBxEntryImage;
        private System.Windows.Forms.Label TxtEntryUserLoginName;
    }
}
