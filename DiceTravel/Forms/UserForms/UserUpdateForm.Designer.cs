namespace DiceTravel.Forms.UserForms
{
    partial class UserUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUpdateForm));
            this.BtnSignUpCancel = new System.Windows.Forms.Button();
            this.BtnSignUpReg = new System.Windows.Forms.Button();
            this.DatePickerUserUpdateFormBirthDate = new System.Windows.Forms.DateTimePicker();
            this.InputUserUpdateFormPasswordAgain = new System.Windows.Forms.TextBox();
            this.TxtUserUpdateFormPasswordAgain = new System.Windows.Forms.Label();
            this.TxtUserUpdateFormBirthDate = new System.Windows.Forms.Label();
            this.TxtUserUpdateFormFirstName = new System.Windows.Forms.Label();
            this.InputUserUpdateFormFirstName = new System.Windows.Forms.TextBox();
            this.InputUserUpdateFormSurname = new System.Windows.Forms.TextBox();
            this.TxtUserUpdateFormSurname = new System.Windows.Forms.Label();
            this.BtnUserUpdateCancel = new System.Windows.Forms.Button();
            this.BtnUserUpdateSave = new System.Windows.Forms.Button();
            this.TxtUserUpdateFormPassword = new System.Windows.Forms.Label();
            this.TxtUserUpdateFormTitle = new System.Windows.Forms.Label();
            this.InputUserUpdateFormPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSignUpCancel
            // 
            this.BtnSignUpCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSignUpCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSignUpCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSignUpCancel.Location = new System.Drawing.Point(-507, 87);
            this.BtnSignUpCancel.MaximumSize = new System.Drawing.Size(250, 330);
            this.BtnSignUpCancel.Name = "BtnSignUpCancel";
            this.BtnSignUpCancel.Size = new System.Drawing.Size(250, 330);
            this.BtnSignUpCancel.TabIndex = 26;
            this.BtnSignUpCancel.Text = "Cancel";
            this.BtnSignUpCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSignUpReg
            // 
            this.BtnSignUpReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSignUpReg.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnSignUpReg.Location = new System.Drawing.Point(-424, 87);
            this.BtnSignUpReg.MaximumSize = new System.Drawing.Size(250, 330);
            this.BtnSignUpReg.Name = "BtnSignUpReg";
            this.BtnSignUpReg.Size = new System.Drawing.Size(250, 330);
            this.BtnSignUpReg.TabIndex = 24;
            this.BtnSignUpReg.Text = "SignUp";
            this.BtnSignUpReg.UseVisualStyleBackColor = true;
            // 
            // DatePickerUserUpdateFormBirthDate
            // 
            this.DatePickerUserUpdateFormBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerUserUpdateFormBirthDate.Location = new System.Drawing.Point(116, 176);
            this.DatePickerUserUpdateFormBirthDate.MaxDate = new System.DateTime(3000, 2, 19, 0, 0, 0, 0);
            this.DatePickerUserUpdateFormBirthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DatePickerUserUpdateFormBirthDate.Name = "DatePickerUserUpdateFormBirthDate";
            this.DatePickerUserUpdateFormBirthDate.Size = new System.Drawing.Size(100, 20);
            this.DatePickerUserUpdateFormBirthDate.TabIndex = 32;
            this.DatePickerUserUpdateFormBirthDate.Value = new System.DateTime(2020, 2, 19, 0, 0, 0, 0);
            // 
            // InputUserUpdateFormPasswordAgain
            // 
            this.InputUserUpdateFormPasswordAgain.Location = new System.Drawing.Point(116, 82);
            this.InputUserUpdateFormPasswordAgain.Name = "InputUserUpdateFormPasswordAgain";
            this.InputUserUpdateFormPasswordAgain.PasswordChar = '*';
            this.InputUserUpdateFormPasswordAgain.Size = new System.Drawing.Size(100, 20);
            this.InputUserUpdateFormPasswordAgain.TabIndex = 29;
            // 
            // TxtUserUpdateFormPasswordAgain
            // 
            this.TxtUserUpdateFormPasswordAgain.AutoSize = true;
            this.TxtUserUpdateFormPasswordAgain.Location = new System.Drawing.Point(25, 85);
            this.TxtUserUpdateFormPasswordAgain.Name = "TxtUserUpdateFormPasswordAgain";
            this.TxtUserUpdateFormPasswordAgain.Size = new System.Drawing.Size(89, 13);
            this.TxtUserUpdateFormPasswordAgain.TabIndex = 41;
            this.TxtUserUpdateFormPasswordAgain.Text = "Password again*:";
            // 
            // TxtUserUpdateFormBirthDate
            // 
            this.TxtUserUpdateFormBirthDate.AutoSize = true;
            this.TxtUserUpdateFormBirthDate.Location = new System.Drawing.Point(42, 182);
            this.TxtUserUpdateFormBirthDate.Name = "TxtUserUpdateFormBirthDate";
            this.TxtUserUpdateFormBirthDate.Size = new System.Drawing.Size(68, 13);
            this.TxtUserUpdateFormBirthDate.TabIndex = 40;
            this.TxtUserUpdateFormBirthDate.Text = "Date of birth:";
            // 
            // TxtUserUpdateFormFirstName
            // 
            this.TxtUserUpdateFormFirstName.AutoSize = true;
            this.TxtUserUpdateFormFirstName.Location = new System.Drawing.Point(58, 150);
            this.TxtUserUpdateFormFirstName.Name = "TxtUserUpdateFormFirstName";
            this.TxtUserUpdateFormFirstName.Size = new System.Drawing.Size(52, 13);
            this.TxtUserUpdateFormFirstName.TabIndex = 39;
            this.TxtUserUpdateFormFirstName.Text = "Surname:";
            // 
            // InputUserUpdateFormFirstName
            // 
            this.InputUserUpdateFormFirstName.Location = new System.Drawing.Point(116, 121);
            this.InputUserUpdateFormFirstName.MaxLength = 20;
            this.InputUserUpdateFormFirstName.Name = "InputUserUpdateFormFirstName";
            this.InputUserUpdateFormFirstName.Size = new System.Drawing.Size(100, 20);
            this.InputUserUpdateFormFirstName.TabIndex = 31;
            // 
            // InputUserUpdateFormSurname
            // 
            this.InputUserUpdateFormSurname.Location = new System.Drawing.Point(116, 147);
            this.InputUserUpdateFormSurname.MaxLength = 20;
            this.InputUserUpdateFormSurname.Name = "InputUserUpdateFormSurname";
            this.InputUserUpdateFormSurname.Size = new System.Drawing.Size(100, 20);
            this.InputUserUpdateFormSurname.TabIndex = 30;
            // 
            // TxtUserUpdateFormSurname
            // 
            this.TxtUserUpdateFormSurname.AutoSize = true;
            this.TxtUserUpdateFormSurname.Location = new System.Drawing.Point(54, 124);
            this.TxtUserUpdateFormSurname.Name = "TxtUserUpdateFormSurname";
            this.TxtUserUpdateFormSurname.Size = new System.Drawing.Size(61, 13);
            this.TxtUserUpdateFormSurname.TabIndex = 38;
            this.TxtUserUpdateFormSurname.Text = "First name: ";
            // 
            // BtnUserUpdateCancel
            // 
            this.BtnUserUpdateCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUserUpdateCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnUserUpdateCancel.Location = new System.Drawing.Point(63, 216);
            this.BtnUserUpdateCancel.Name = "BtnUserUpdateCancel";
            this.BtnUserUpdateCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnUserUpdateCancel.TabIndex = 36;
            this.BtnUserUpdateCancel.Text = "Cancel";
            this.BtnUserUpdateCancel.UseVisualStyleBackColor = true;
            this.BtnUserUpdateCancel.Click += new System.EventHandler(this.BtnUserUpdateCancel_Click);
            // 
            // BtnUserUpdateSave
            // 
            this.BtnUserUpdateSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUserUpdateSave.Location = new System.Drawing.Point(147, 216);
            this.BtnUserUpdateSave.Name = "BtnUserUpdateSave";
            this.BtnUserUpdateSave.Size = new System.Drawing.Size(75, 23);
            this.BtnUserUpdateSave.TabIndex = 34;
            this.BtnUserUpdateSave.Text = "Save";
            this.BtnUserUpdateSave.UseVisualStyleBackColor = true;
            this.BtnUserUpdateSave.Click += new System.EventHandler(this.BtnUserUpdateSave_Click);
            // 
            // TxtUserUpdateFormPassword
            // 
            this.TxtUserUpdateFormPassword.AutoSize = true;
            this.TxtUserUpdateFormPassword.Location = new System.Drawing.Point(54, 59);
            this.TxtUserUpdateFormPassword.Name = "TxtUserUpdateFormPassword";
            this.TxtUserUpdateFormPassword.Size = new System.Drawing.Size(60, 13);
            this.TxtUserUpdateFormPassword.TabIndex = 37;
            this.TxtUserUpdateFormPassword.Text = "Password*:";
            // 
            // TxtUserUpdateFormTitle
            // 
            this.TxtUserUpdateFormTitle.AutoSize = true;
            this.TxtUserUpdateFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtUserUpdateFormTitle.Location = new System.Drawing.Point(16, 10);
            this.TxtUserUpdateFormTitle.MaximumSize = new System.Drawing.Size(200, 33);
            this.TxtUserUpdateFormTitle.MinimumSize = new System.Drawing.Size(200, 33);
            this.TxtUserUpdateFormTitle.Name = "TxtUserUpdateFormTitle";
            this.TxtUserUpdateFormTitle.Size = new System.Drawing.Size(200, 33);
            this.TxtUserUpdateFormTitle.TabIndex = 33;
            this.TxtUserUpdateFormTitle.Text = "Me";
            this.TxtUserUpdateFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputUserUpdateFormPassword
            // 
            this.InputUserUpdateFormPassword.Location = new System.Drawing.Point(116, 56);
            this.InputUserUpdateFormPassword.Name = "InputUserUpdateFormPassword";
            this.InputUserUpdateFormPassword.PasswordChar = '*';
            this.InputUserUpdateFormPassword.Size = new System.Drawing.Size(100, 20);
            this.InputUserUpdateFormPassword.TabIndex = 28;
            // 
            // UserUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 251);
            this.Controls.Add(this.DatePickerUserUpdateFormBirthDate);
            this.Controls.Add(this.InputUserUpdateFormPasswordAgain);
            this.Controls.Add(this.TxtUserUpdateFormPasswordAgain);
            this.Controls.Add(this.TxtUserUpdateFormBirthDate);
            this.Controls.Add(this.TxtUserUpdateFormFirstName);
            this.Controls.Add(this.InputUserUpdateFormFirstName);
            this.Controls.Add(this.InputUserUpdateFormSurname);
            this.Controls.Add(this.TxtUserUpdateFormSurname);
            this.Controls.Add(this.BtnUserUpdateCancel);
            this.Controls.Add(this.BtnUserUpdateSave);
            this.Controls.Add(this.TxtUserUpdateFormPassword);
            this.Controls.Add(this.TxtUserUpdateFormTitle);
            this.Controls.Add(this.InputUserUpdateFormPassword);
            this.Controls.Add(this.BtnSignUpCancel);
            this.Controls.Add(this.BtnSignUpReg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 290);
            this.MinimizeBox = false;
            this.Name = "UserUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSignUpCancel;
        private System.Windows.Forms.Button BtnSignUpReg;
        public System.Windows.Forms.DateTimePicker DatePickerUserUpdateFormBirthDate;
        private System.Windows.Forms.TextBox InputUserUpdateFormPasswordAgain;
        private System.Windows.Forms.Label TxtUserUpdateFormPasswordAgain;
        private System.Windows.Forms.Label TxtUserUpdateFormBirthDate;
        private System.Windows.Forms.Label TxtUserUpdateFormFirstName;
        private System.Windows.Forms.TextBox InputUserUpdateFormFirstName;
        private System.Windows.Forms.TextBox InputUserUpdateFormSurname;
        private System.Windows.Forms.Label TxtUserUpdateFormSurname;
        private System.Windows.Forms.Button BtnUserUpdateCancel;
        private System.Windows.Forms.Button BtnUserUpdateSave;
        private System.Windows.Forms.Label TxtUserUpdateFormPassword;
        private System.Windows.Forms.Label TxtUserUpdateFormTitle;
        private System.Windows.Forms.TextBox InputUserUpdateFormPassword;
    }
}