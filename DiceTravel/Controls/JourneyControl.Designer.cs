namespace DiceTravel.Controls
{
    partial class JourneyControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtJourneyTitle = new System.Windows.Forms.Label();
            this.TxtJourneyStartDate = new System.Windows.Forms.Label();
            this.TxtJourneyUserLoginName = new System.Windows.Forms.Label();
            this.BtnJourneyOptions = new System.Windows.Forms.Button();
            this.PctBxJourneyVisibility = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxJourneyVisibility)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtJourneyTitle
            // 
            this.TxtJourneyTitle.AutoSize = true;
            this.TxtJourneyTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtJourneyTitle.Location = new System.Drawing.Point(42, 21);
            this.TxtJourneyTitle.Name = "TxtJourneyTitle";
            this.TxtJourneyTitle.Size = new System.Drawing.Size(66, 20);
            this.TxtJourneyTitle.TabIndex = 0;
            this.TxtJourneyTitle.Text = "START";
            // 
            // TxtJourneyStartDate
            // 
            this.TxtJourneyStartDate.AutoSize = true;
            this.TxtJourneyStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtJourneyStartDate.Location = new System.Drawing.Point(43, 41);
            this.TxtJourneyStartDate.Name = "TxtJourneyStartDate";
            this.TxtJourneyStartDate.Size = new System.Drawing.Size(33, 15);
            this.TxtJourneyStartDate.TabIndex = 17;
            this.TxtJourneyStartDate.Text = "Date";
            // 
            // TxtJourneyUserLoginName
            // 
            this.TxtJourneyUserLoginName.AutoSize = true;
            this.TxtJourneyUserLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtJourneyUserLoginName.Location = new System.Drawing.Point(43, 5);
            this.TxtJourneyUserLoginName.Name = "TxtJourneyUserLoginName";
            this.TxtJourneyUserLoginName.Size = new System.Drawing.Size(47, 16);
            this.TxtJourneyUserLoginName.TabIndex = 18;
            this.TxtJourneyUserLoginName.Text = "NAME";
            // 
            // BtnJourneyOptions
            // 
            this.BtnJourneyOptions.BackColor = System.Drawing.SystemColors.Control;
            this.BtnJourneyOptions.FlatAppearance.BorderSize = 0;
            this.BtnJourneyOptions.Image = global::DiceTravel.Properties.Resources.icoSettings;
            this.BtnJourneyOptions.Location = new System.Drawing.Point(486, 11);
            this.BtnJourneyOptions.Name = "BtnJourneyOptions";
            this.BtnJourneyOptions.Size = new System.Drawing.Size(42, 45);
            this.BtnJourneyOptions.TabIndex = 16;
            this.BtnJourneyOptions.UseVisualStyleBackColor = false;
            this.BtnJourneyOptions.Click += new System.EventHandler(this.BtnJourneyOptions_Click);
            // 
            // PctBxJourneyVisibility
            // 
            this.PctBxJourneyVisibility.Location = new System.Drawing.Point(4, 15);
            this.PctBxJourneyVisibility.Name = "PctBxJourneyVisibility";
            this.PctBxJourneyVisibility.Size = new System.Drawing.Size(33, 33);
            this.PctBxJourneyVisibility.TabIndex = 15;
            this.PctBxJourneyVisibility.TabStop = false;
            this.PctBxJourneyVisibility.WaitOnLoad = true;
            // 
            // JourneyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.TxtJourneyUserLoginName);
            this.Controls.Add(this.TxtJourneyStartDate);
            this.Controls.Add(this.BtnJourneyOptions);
            this.Controls.Add(this.PctBxJourneyVisibility);
            this.Controls.Add(this.TxtJourneyTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "JourneyControl";
            this.Size = new System.Drawing.Size(537, 70);
            this.Click += new System.EventHandler(this.JourneyControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PctBxJourneyVisibility)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtJourneyTitle;
        private System.Windows.Forms.PictureBox PctBxJourneyVisibility;
        private System.Windows.Forms.Button BtnJourneyOptions;
        private System.Windows.Forms.Label TxtJourneyStartDate;
        private System.Windows.Forms.Label TxtJourneyUserLoginName;
    }
}
