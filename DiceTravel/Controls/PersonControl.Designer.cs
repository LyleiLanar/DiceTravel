namespace DiceTravel.Controls
{
    partial class PersonControl
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
            this.BtnPersonKick = new System.Windows.Forms.Button();
            this.TxtPersonLoginName = new System.Windows.Forms.Label();
            this.TxtPersonRealName = new System.Windows.Forms.Label();
            this.BtnPersonMakeFriend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnPersonKick
            // 
            this.BtnPersonKick.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPersonKick.FlatAppearance.BorderSize = 0;
            this.BtnPersonKick.Image = global::DiceTravel.Properties.Resources.icoDelete;
            this.BtnPersonKick.Location = new System.Drawing.Point(492, 5);
            this.BtnPersonKick.Name = "BtnPersonKick";
            this.BtnPersonKick.Size = new System.Drawing.Size(42, 45);
            this.BtnPersonKick.TabIndex = 21;
            this.BtnPersonKick.UseVisualStyleBackColor = false;
            this.BtnPersonKick.Click += new System.EventHandler(this.BtnPersonKick_Click);
            // 
            // TxtPersonLoginName
            // 
            this.TxtPersonLoginName.AutoSize = true;
            this.TxtPersonLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtPersonLoginName.Location = new System.Drawing.Point(3, 5);
            this.TxtPersonLoginName.Name = "TxtPersonLoginName";
            this.TxtPersonLoginName.Size = new System.Drawing.Size(117, 24);
            this.TxtPersonLoginName.TabIndex = 19;
            this.TxtPersonLoginName.Text = "LOGINAME";
            // 
            // TxtPersonRealName
            // 
            this.TxtPersonRealName.AutoSize = true;
            this.TxtPersonRealName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtPersonRealName.Location = new System.Drawing.Point(4, 34);
            this.TxtPersonRealName.Name = "TxtPersonRealName";
            this.TxtPersonRealName.Size = new System.Drawing.Size(82, 16);
            this.TxtPersonRealName.TabIndex = 23;
            this.TxtPersonRealName.Text = "REALNAME";
            // 
            // BtnPersonMakeFriend
            // 
            this.BtnPersonMakeFriend.BackColor = System.Drawing.SystemColors.Control;
            this.BtnPersonMakeFriend.FlatAppearance.BorderSize = 0;
            this.BtnPersonMakeFriend.Image = global::DiceTravel.Properties.Resources.icoFinished;
            this.BtnPersonMakeFriend.Location = new System.Drawing.Point(444, 5);
            this.BtnPersonMakeFriend.Name = "BtnPersonMakeFriend";
            this.BtnPersonMakeFriend.Size = new System.Drawing.Size(42, 45);
            this.BtnPersonMakeFriend.TabIndex = 24;
            this.BtnPersonMakeFriend.UseVisualStyleBackColor = false;
            this.BtnPersonMakeFriend.Click += new System.EventHandler(this.BtnPersonMakeFriend_Click);
            // 
            // PersonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.BtnPersonMakeFriend);
            this.Controls.Add(this.TxtPersonRealName);
            this.Controls.Add(this.BtnPersonKick);
            this.Controls.Add(this.TxtPersonLoginName);
            this.Name = "PersonControl";
            this.Size = new System.Drawing.Size(537, 56);
            this.Click += new System.EventHandler(this.PersonControl_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnPersonKick;
        private System.Windows.Forms.Label TxtPersonRealName;
        public System.Windows.Forms.Label TxtPersonLoginName;
        private System.Windows.Forms.Button BtnPersonMakeFriend;
    }
}
