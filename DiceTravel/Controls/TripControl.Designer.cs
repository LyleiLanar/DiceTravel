namespace DiceTravel.Controls
{
    partial class TripControl
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
            this.TxtTripUserLoginName = new System.Windows.Forms.Label();
            this.TxtTripEndDate = new System.Windows.Forms.Label();
            this.TxtTripEndLocation = new System.Windows.Forms.Label();
            this.BtnTripBackToJourney = new System.Windows.Forms.Button();
            this.BtnTripOptions = new System.Windows.Forms.Button();
            this.PctBxTripVisibility = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PctBxTripVisibility)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtTripUserLoginName
            // 
            this.TxtTripUserLoginName.AutoSize = true;
            this.TxtTripUserLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtTripUserLoginName.Location = new System.Drawing.Point(42, 5);
            this.TxtTripUserLoginName.Name = "TxtTripUserLoginName";
            this.TxtTripUserLoginName.Size = new System.Drawing.Size(47, 16);
            this.TxtTripUserLoginName.TabIndex = 23;
            this.TxtTripUserLoginName.Text = "NAME";
            // 
            // TxtTripEndDate
            // 
            this.TxtTripEndDate.AutoSize = true;
            this.TxtTripEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtTripEndDate.Location = new System.Drawing.Point(42, 41);
            this.TxtTripEndDate.Name = "TxtTripEndDate";
            this.TxtTripEndDate.Size = new System.Drawing.Size(33, 15);
            this.TxtTripEndDate.TabIndex = 22;
            this.TxtTripEndDate.Text = "Date";
            // 
            // TxtTripEndLocation
            // 
            this.TxtTripEndLocation.AutoSize = true;
            this.TxtTripEndLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtTripEndLocation.Location = new System.Drawing.Point(41, 21);
            this.TxtTripEndLocation.Name = "TxtTripEndLocation";
            this.TxtTripEndLocation.Size = new System.Drawing.Size(66, 20);
            this.TxtTripEndLocation.TabIndex = 19;
            this.TxtTripEndLocation.Text = "START";
            // 
            // BtnTripBackToJourney
            // 
            this.BtnTripBackToJourney.BackColor = System.Drawing.SystemColors.Control;
            this.BtnTripBackToJourney.FlatAppearance.BorderSize = 0;
            this.BtnTripBackToJourney.Image = global::DiceTravel.Properties.Resources.icoBack;
            this.BtnTripBackToJourney.Location = new System.Drawing.Point(436, 11);
            this.BtnTripBackToJourney.Name = "BtnTripBackToJourney";
            this.BtnTripBackToJourney.Size = new System.Drawing.Size(42, 45);
            this.BtnTripBackToJourney.TabIndex = 24;
            this.BtnTripBackToJourney.UseVisualStyleBackColor = false;
            this.BtnTripBackToJourney.Click += new System.EventHandler(this.BtnTripBackToJourney_Click);
            // 
            // BtnTripOptions
            // 
            this.BtnTripOptions.BackColor = System.Drawing.SystemColors.Control;
            this.BtnTripOptions.FlatAppearance.BorderSize = 0;
            this.BtnTripOptions.Image = global::DiceTravel.Properties.Resources.icoSettings;
            this.BtnTripOptions.Location = new System.Drawing.Point(484, 11);
            this.BtnTripOptions.Name = "BtnTripOptions";
            this.BtnTripOptions.Size = new System.Drawing.Size(42, 45);
            this.BtnTripOptions.TabIndex = 21;
            this.BtnTripOptions.UseVisualStyleBackColor = false;
            // 
            // PctBxTripVisibility
            // 
            this.PctBxTripVisibility.Location = new System.Drawing.Point(3, 15);
            this.PctBxTripVisibility.Name = "PctBxTripVisibility";
            this.PctBxTripVisibility.Size = new System.Drawing.Size(33, 33);
            this.PctBxTripVisibility.TabIndex = 20;
            this.PctBxTripVisibility.TabStop = false;
            this.PctBxTripVisibility.WaitOnLoad = true;
            // 
            // TripControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnTripBackToJourney);
            this.Controls.Add(this.TxtTripUserLoginName);
            this.Controls.Add(this.TxtTripEndDate);
            this.Controls.Add(this.BtnTripOptions);
            this.Controls.Add(this.PctBxTripVisibility);
            this.Controls.Add(this.TxtTripEndLocation);
            this.Name = "TripControl";
            this.Size = new System.Drawing.Size(537, 70);
            this.Click += new System.EventHandler(this.TripControl_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PctBxTripVisibility)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtTripUserLoginName;
        private System.Windows.Forms.Label TxtTripEndDate;
        private System.Windows.Forms.Button BtnTripOptions;
        private System.Windows.Forms.PictureBox PctBxTripVisibility;
        private System.Windows.Forms.Label TxtTripEndLocation;
        private System.Windows.Forms.Button BtnTripBackToJourney;
    }
}
