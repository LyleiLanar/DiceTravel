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
            ((System.ComponentModel.ISupportInitialize)(this.PctBxEntryVisibility)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtEntryDate
            // 
            this.TxtEntryDate.AutoSize = true;
            this.TxtEntryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtEntryDate.Location = new System.Drawing.Point(42, 84);
            this.TxtEntryDate.Name = "TxtEntryDate";
            this.TxtEntryDate.Size = new System.Drawing.Size(33, 15);
            this.TxtEntryDate.TabIndex = 22;
            this.TxtEntryDate.Text = "Date";
            // 
            // TxtEntryTitle
            // 
            this.TxtEntryTitle.AutoSize = true;
            this.TxtEntryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtEntryTitle.Location = new System.Drawing.Point(41, 13);
            this.TxtEntryTitle.Name = "TxtEntryTitle";
            this.TxtEntryTitle.Size = new System.Drawing.Size(66, 20);
            this.TxtEntryTitle.TabIndex = 19;
            this.TxtEntryTitle.Text = "START";
            // 
            // TxtEntryComment
            // 
            this.TxtEntryComment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtEntryComment.Cursor = System.Windows.Forms.Cursors.Default;
            this.TxtEntryComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtEntryComment.Location = new System.Drawing.Point(45, 36);
            this.TxtEntryComment.Margin = new System.Windows.Forms.Padding(6);
            this.TxtEntryComment.Name = "TxtEntryComment";
            this.TxtEntryComment.ReadOnly = true;
            this.TxtEntryComment.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TxtEntryComment.Size = new System.Drawing.Size(345, 45);
            this.TxtEntryComment.TabIndex = 23;
            this.TxtEntryComment.Text = "";
            this.TxtEntryComment.MouseEnter += new System.EventHandler(this.TxtEntryComment_MouseEnter);
            this.TxtEntryComment.MouseLeave += new System.EventHandler(this.TxtEntryComment_MouseLeave);
            // 
            // BtnEntryOptions
            // 
            this.BtnEntryOptions.BackColor = System.Drawing.SystemColors.Control;
            this.BtnEntryOptions.FlatAppearance.BorderSize = 0;
            this.BtnEntryOptions.Image = global::DiceTravel.Properties.Resources.icoSettings;
            this.BtnEntryOptions.Location = new System.Drawing.Point(484, 11);
            this.BtnEntryOptions.Name = "BtnEntryOptions";
            this.BtnEntryOptions.Size = new System.Drawing.Size(42, 45);
            this.BtnEntryOptions.TabIndex = 21;
            this.BtnEntryOptions.UseVisualStyleBackColor = false;
            // 
            // PctBxEntryVisibility
            // 
            this.PctBxEntryVisibility.Location = new System.Drawing.Point(6, 13);
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
            this.BtnEntryBackToEntry.Location = new System.Drawing.Point(436, 11);
            this.BtnEntryBackToEntry.Name = "BtnEntryBackToEntry";
            this.BtnEntryBackToEntry.Size = new System.Drawing.Size(42, 45);
            this.BtnEntryBackToEntry.TabIndex = 24;
            this.BtnEntryBackToEntry.UseVisualStyleBackColor = false;
            this.BtnEntryBackToEntry.Click += new System.EventHandler(this.BtnEntryBackToEntry_Click);
            // 
            // EntryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.BtnEntryBackToEntry);
            this.Controls.Add(this.TxtEntryComment);
            this.Controls.Add(this.TxtEntryDate);
            this.Controls.Add(this.BtnEntryOptions);
            this.Controls.Add(this.PctBxEntryVisibility);
            this.Controls.Add(this.TxtEntryTitle);
            this.Name = "EntryControl";
            this.Size = new System.Drawing.Size(535, 115);
            ((System.ComponentModel.ISupportInitialize)(this.PctBxEntryVisibility)).EndInit();
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
    }
}
