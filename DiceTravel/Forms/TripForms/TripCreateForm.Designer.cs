namespace DiceTravel.Forms.TripForms
{
    partial class TripCreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TripCreateForm));
            this.TxtTripCreateFormTitle = new System.Windows.Forms.Label();
            this.BtnTripCreateEndJourney = new System.Windows.Forms.Button();
            this.BtnTripCreateDestination = new System.Windows.Forms.Button();
            this.GrpBxTripCreateVisibility = new System.Windows.Forms.GroupBox();
            this.RBtnTripCreateVisibilityPublic = new System.Windows.Forms.RadioButton();
            this.RBtnTripCreateVisibilityOnlyFriends = new System.Windows.Forms.RadioButton();
            this.RBtnTripCreateVisibilityPrivate = new System.Windows.Forms.RadioButton();
            this.InputTripCreateTripEndLocation = new System.Windows.Forms.TextBox();
            this.TxtTripCreateTripEndLocation_Label = new System.Windows.Forms.Label();
            this.GrpBxTripCreateVisibility.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtTripCreateFormTitle
            // 
            this.TxtTripCreateFormTitle.AutoSize = true;
            this.TxtTripCreateFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtTripCreateFormTitle.Location = new System.Drawing.Point(18, 9);
            this.TxtTripCreateFormTitle.Name = "TxtTripCreateFormTitle";
            this.TxtTripCreateFormTitle.Size = new System.Drawing.Size(199, 33);
            this.TxtTripCreateFormTitle.TabIndex = 1;
            this.TxtTripCreateFormTitle.Text = "What\'s Next?";
            this.TxtTripCreateFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnTripCreateEndJourney
            // 
            this.BtnTripCreateEndJourney.Location = new System.Drawing.Point(124, 142);
            this.BtnTripCreateEndJourney.Name = "BtnTripCreateEndJourney";
            this.BtnTripCreateEndJourney.Size = new System.Drawing.Size(95, 23);
            this.BtnTripCreateEndJourney.TabIndex = 15;
            this.BtnTripCreateEndJourney.Text = "End journey";
            this.BtnTripCreateEndJourney.UseVisualStyleBackColor = true;
            this.BtnTripCreateEndJourney.Click += new System.EventHandler(this.BtnTripCreateEndJourney_Click);
            // 
            // BtnTripCreateDestination
            // 
            this.BtnTripCreateDestination.Location = new System.Drawing.Point(124, 94);
            this.BtnTripCreateDestination.Name = "BtnTripCreateDestination";
            this.BtnTripCreateDestination.Size = new System.Drawing.Size(95, 23);
            this.BtnTripCreateDestination.TabIndex = 14;
            this.BtnTripCreateDestination.Text = "Go here!";
            this.BtnTripCreateDestination.UseVisualStyleBackColor = true;
            this.BtnTripCreateDestination.Click += new System.EventHandler(this.BtnTripCreateStart_Click);
            // 
            // GrpBxTripCreateVisibility
            // 
            this.GrpBxTripCreateVisibility.Controls.Add(this.RBtnTripCreateVisibilityPublic);
            this.GrpBxTripCreateVisibility.Controls.Add(this.RBtnTripCreateVisibilityOnlyFriends);
            this.GrpBxTripCreateVisibility.Controls.Add(this.RBtnTripCreateVisibilityPrivate);
            this.GrpBxTripCreateVisibility.Location = new System.Drawing.Point(18, 81);
            this.GrpBxTripCreateVisibility.Name = "GrpBxTripCreateVisibility";
            this.GrpBxTripCreateVisibility.Size = new System.Drawing.Size(100, 90);
            this.GrpBxTripCreateVisibility.TabIndex = 13;
            this.GrpBxTripCreateVisibility.TabStop = false;
            this.GrpBxTripCreateVisibility.Text = "Visibility: ";
            // 
            // RBtnTripCreateVisibilityPublic
            // 
            this.RBtnTripCreateVisibilityPublic.AutoSize = true;
            this.RBtnTripCreateVisibilityPublic.Location = new System.Drawing.Point(6, 67);
            this.RBtnTripCreateVisibilityPublic.Name = "RBtnTripCreateVisibilityPublic";
            this.RBtnTripCreateVisibilityPublic.Size = new System.Drawing.Size(54, 17);
            this.RBtnTripCreateVisibilityPublic.TabIndex = 2;
            this.RBtnTripCreateVisibilityPublic.Text = "Public";
            this.RBtnTripCreateVisibilityPublic.UseVisualStyleBackColor = true;
            // 
            // RBtnTripCreateVisibilityOnlyFriends
            // 
            this.RBtnTripCreateVisibilityOnlyFriends.AutoSize = true;
            this.RBtnTripCreateVisibilityOnlyFriends.Location = new System.Drawing.Point(6, 43);
            this.RBtnTripCreateVisibilityOnlyFriends.Name = "RBtnTripCreateVisibilityOnlyFriends";
            this.RBtnTripCreateVisibilityOnlyFriends.Size = new System.Drawing.Size(83, 17);
            this.RBtnTripCreateVisibilityOnlyFriends.TabIndex = 1;
            this.RBtnTripCreateVisibilityOnlyFriends.Text = "Only Friends";
            this.RBtnTripCreateVisibilityOnlyFriends.UseVisualStyleBackColor = true;
            // 
            // RBtnTripCreateVisibilityPrivate
            // 
            this.RBtnTripCreateVisibilityPrivate.AutoSize = true;
            this.RBtnTripCreateVisibilityPrivate.Checked = true;
            this.RBtnTripCreateVisibilityPrivate.Location = new System.Drawing.Point(6, 19);
            this.RBtnTripCreateVisibilityPrivate.Name = "RBtnTripCreateVisibilityPrivate";
            this.RBtnTripCreateVisibilityPrivate.Size = new System.Drawing.Size(58, 17);
            this.RBtnTripCreateVisibilityPrivate.TabIndex = 0;
            this.RBtnTripCreateVisibilityPrivate.TabStop = true;
            this.RBtnTripCreateVisibilityPrivate.Text = "Private";
            this.RBtnTripCreateVisibilityPrivate.UseVisualStyleBackColor = true;
            // 
            // InputTripCreateTripEndLocation
            // 
            this.InputTripCreateTripEndLocation.Location = new System.Drawing.Point(96, 55);
            this.InputTripCreateTripEndLocation.MaxLength = 20;
            this.InputTripCreateTripEndLocation.Name = "InputTripCreateTripEndLocation";
            this.InputTripCreateTripEndLocation.Size = new System.Drawing.Size(100, 20);
            this.InputTripCreateTripEndLocation.TabIndex = 12;
            // 
            // TxtTripCreateTripEndLocation_Label
            // 
            this.TxtTripCreateTripEndLocation_Label.AutoSize = true;
            this.TxtTripCreateTripEndLocation_Label.Location = new System.Drawing.Point(15, 58);
            this.TxtTripCreateTripEndLocation_Label.Name = "TxtTripCreateTripEndLocation_Label";
            this.TxtTripCreateTripEndLocation_Label.Size = new System.Drawing.Size(75, 13);
            this.TxtTripCreateTripEndLocation_Label.TabIndex = 10;
            this.TxtTripCreateTripEndLocation_Label.Text = "Goal location: ";
            // 
            // TripCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 181);
            this.Controls.Add(this.BtnTripCreateEndJourney);
            this.Controls.Add(this.BtnTripCreateDestination);
            this.Controls.Add(this.GrpBxTripCreateVisibility);
            this.Controls.Add(this.InputTripCreateTripEndLocation);
            this.Controls.Add(this.TxtTripCreateTripEndLocation_Label);
            this.Controls.Add(this.TxtTripCreateFormTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TripCreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TripCreateForm";
            this.GrpBxTripCreateVisibility.ResumeLayout(false);
            this.GrpBxTripCreateVisibility.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtTripCreateFormTitle;
        private System.Windows.Forms.Button BtnTripCreateEndJourney;
        private System.Windows.Forms.Button BtnTripCreateDestination;
        private System.Windows.Forms.GroupBox GrpBxTripCreateVisibility;
        private System.Windows.Forms.RadioButton RBtnTripCreateVisibilityPublic;
        private System.Windows.Forms.RadioButton RBtnTripCreateVisibilityOnlyFriends;
        private System.Windows.Forms.RadioButton RBtnTripCreateVisibilityPrivate;
        private System.Windows.Forms.TextBox InputTripCreateTripEndLocation;
        private System.Windows.Forms.Label TxtTripCreateTripEndLocation_Label;
    }
}