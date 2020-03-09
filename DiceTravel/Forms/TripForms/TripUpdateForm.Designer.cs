namespace DiceTravel.Forms.TripForms
{
    partial class TripUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TripUpdateForm));
            this.BtnTripUpdateTrip = new System.Windows.Forms.Button();
            this.GrpBxTripUpdateVisibility = new System.Windows.Forms.GroupBox();
            this.RBtnTripCreateUpdatePublic = new System.Windows.Forms.RadioButton();
            this.RBtnTripCreateUpdateOnlyFriends = new System.Windows.Forms.RadioButton();
            this.RBtnTripCreateUpdatePrivate = new System.Windows.Forms.RadioButton();
            this.TxtTripUpdateFormTitle = new System.Windows.Forms.Label();
            this.BtnTripUpdateCancel = new System.Windows.Forms.Button();
            this.InputTripUpdateEndLocation = new System.Windows.Forms.TextBox();
            this.TxtTripUpdateTripEndLocation_Label = new System.Windows.Forms.Label();
            this.GrpBxTripUpdateVisibility.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnTripUpdateTrip
            // 
            this.BtnTripUpdateTrip.Location = new System.Drawing.Point(126, 96);
            this.BtnTripUpdateTrip.Name = "BtnTripUpdateTrip";
            this.BtnTripUpdateTrip.Size = new System.Drawing.Size(95, 23);
            this.BtnTripUpdateTrip.TabIndex = 21;
            this.BtnTripUpdateTrip.Text = "Modify!";
            this.BtnTripUpdateTrip.UseVisualStyleBackColor = true;
            this.BtnTripUpdateTrip.Click += new System.EventHandler(this.BtnTripUpdateTrip_Click);
            // 
            // GrpBxTripUpdateVisibility
            // 
            this.GrpBxTripUpdateVisibility.Controls.Add(this.RBtnTripCreateUpdatePublic);
            this.GrpBxTripUpdateVisibility.Controls.Add(this.RBtnTripCreateUpdateOnlyFriends);
            this.GrpBxTripUpdateVisibility.Controls.Add(this.RBtnTripCreateUpdatePrivate);
            this.GrpBxTripUpdateVisibility.Location = new System.Drawing.Point(17, 83);
            this.GrpBxTripUpdateVisibility.Name = "GrpBxTripUpdateVisibility";
            this.GrpBxTripUpdateVisibility.Size = new System.Drawing.Size(100, 90);
            this.GrpBxTripUpdateVisibility.TabIndex = 20;
            this.GrpBxTripUpdateVisibility.TabStop = false;
            this.GrpBxTripUpdateVisibility.Text = "Visibility: ";
            // 
            // RBtnTripCreateUpdatePublic
            // 
            this.RBtnTripCreateUpdatePublic.AutoSize = true;
            this.RBtnTripCreateUpdatePublic.Location = new System.Drawing.Point(6, 67);
            this.RBtnTripCreateUpdatePublic.Name = "RBtnTripCreateUpdatePublic";
            this.RBtnTripCreateUpdatePublic.Size = new System.Drawing.Size(54, 17);
            this.RBtnTripCreateUpdatePublic.TabIndex = 2;
            this.RBtnTripCreateUpdatePublic.Text = "Public";
            this.RBtnTripCreateUpdatePublic.UseVisualStyleBackColor = true;
            // 
            // RBtnTripCreateUpdateOnlyFriends
            // 
            this.RBtnTripCreateUpdateOnlyFriends.AutoSize = true;
            this.RBtnTripCreateUpdateOnlyFriends.Location = new System.Drawing.Point(6, 43);
            this.RBtnTripCreateUpdateOnlyFriends.Name = "RBtnTripCreateUpdateOnlyFriends";
            this.RBtnTripCreateUpdateOnlyFriends.Size = new System.Drawing.Size(83, 17);
            this.RBtnTripCreateUpdateOnlyFriends.TabIndex = 1;
            this.RBtnTripCreateUpdateOnlyFriends.Text = "Only Friends";
            this.RBtnTripCreateUpdateOnlyFriends.UseVisualStyleBackColor = true;
            // 
            // RBtnTripCreateUpdatePrivate
            // 
            this.RBtnTripCreateUpdatePrivate.AutoSize = true;
            this.RBtnTripCreateUpdatePrivate.Checked = true;
            this.RBtnTripCreateUpdatePrivate.Location = new System.Drawing.Point(6, 19);
            this.RBtnTripCreateUpdatePrivate.Name = "RBtnTripCreateUpdatePrivate";
            this.RBtnTripCreateUpdatePrivate.Size = new System.Drawing.Size(58, 17);
            this.RBtnTripCreateUpdatePrivate.TabIndex = 0;
            this.RBtnTripCreateUpdatePrivate.TabStop = true;
            this.RBtnTripCreateUpdatePrivate.Text = "Private";
            this.RBtnTripCreateUpdatePrivate.UseVisualStyleBackColor = true;
            // 
            // TxtTripUpdateFormTitle
            // 
            this.TxtTripUpdateFormTitle.AutoSize = true;
            this.TxtTripUpdateFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtTripUpdateFormTitle.Location = new System.Drawing.Point(30, 9);
            this.TxtTripUpdateFormTitle.Name = "TxtTripUpdateFormTitle";
            this.TxtTripUpdateFormTitle.Size = new System.Drawing.Size(171, 33);
            this.TxtTripUpdateFormTitle.TabIndex = 17;
            this.TxtTripUpdateFormTitle.Text = "Modify Trip";
            this.TxtTripUpdateFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnTripUpdateCancel
            // 
            this.BtnTripUpdateCancel.Location = new System.Drawing.Point(127, 150);
            this.BtnTripUpdateCancel.Name = "BtnTripUpdateCancel";
            this.BtnTripUpdateCancel.Size = new System.Drawing.Size(95, 23);
            this.BtnTripUpdateCancel.TabIndex = 23;
            this.BtnTripUpdateCancel.Text = "Cancel";
            this.BtnTripUpdateCancel.UseVisualStyleBackColor = true;
            // 
            // InputTripUpdateEndLocation
            // 
            this.InputTripUpdateEndLocation.Location = new System.Drawing.Point(95, 57);
            this.InputTripUpdateEndLocation.MaxLength = 20;
            this.InputTripUpdateEndLocation.Name = "InputTripUpdateEndLocation";
            this.InputTripUpdateEndLocation.Size = new System.Drawing.Size(100, 20);
            this.InputTripUpdateEndLocation.TabIndex = 19;
            // 
            // TxtTripUpdateTripEndLocation_Label
            // 
            this.TxtTripUpdateTripEndLocation_Label.AutoSize = true;
            this.TxtTripUpdateTripEndLocation_Label.Location = new System.Drawing.Point(14, 60);
            this.TxtTripUpdateTripEndLocation_Label.Name = "TxtTripUpdateTripEndLocation_Label";
            this.TxtTripUpdateTripEndLocation_Label.Size = new System.Drawing.Size(75, 13);
            this.TxtTripUpdateTripEndLocation_Label.TabIndex = 18;
            this.TxtTripUpdateTripEndLocation_Label.Text = "Goal location: ";
            // 
            // TripUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 204);
            this.Controls.Add(this.BtnTripUpdateTrip);
            this.Controls.Add(this.GrpBxTripUpdateVisibility);
            this.Controls.Add(this.TxtTripUpdateFormTitle);
            this.Controls.Add(this.BtnTripUpdateCancel);
            this.Controls.Add(this.InputTripUpdateEndLocation);
            this.Controls.Add(this.TxtTripUpdateTripEndLocation_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 243);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 243);
            this.Name = "TripUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TripUpdateForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TripUpdateForm_FormClosed);
            this.Load += new System.EventHandler(this.TripUpdateForm_Load);
            this.GrpBxTripUpdateVisibility.ResumeLayout(false);
            this.GrpBxTripUpdateVisibility.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnTripUpdateTrip;
        private System.Windows.Forms.GroupBox GrpBxTripUpdateVisibility;
        private System.Windows.Forms.RadioButton RBtnTripCreateUpdatePublic;
        private System.Windows.Forms.RadioButton RBtnTripCreateUpdateOnlyFriends;
        private System.Windows.Forms.RadioButton RBtnTripCreateUpdatePrivate;
        private System.Windows.Forms.Label TxtTripUpdateFormTitle;
        private System.Windows.Forms.Button BtnTripUpdateCancel;
        private System.Windows.Forms.TextBox InputTripUpdateEndLocation;
        private System.Windows.Forms.Label TxtTripUpdateTripEndLocation_Label;
    }
}