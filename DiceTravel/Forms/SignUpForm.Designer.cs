namespace DiceTravel
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.InputSignUpLoginName = new System.Windows.Forms.TextBox();
            this.InputSignUpPassword = new System.Windows.Forms.TextBox();
            this.TxtSignUpTitle = new System.Windows.Forms.Label();
            this.TxtSignUpLoginName = new System.Windows.Forms.Label();
            this.TxtSignUpPassword = new System.Windows.Forms.Label();
            this.BtnSignUpReg = new System.Windows.Forms.Button();
            this.BtnSignUpBack = new System.Windows.Forms.Button();
            this.TxtSignUpSurname = new System.Windows.Forms.Label();
            this.InputSignUpSurname = new System.Windows.Forms.TextBox();
            this.InputSignUpFirstName = new System.Windows.Forms.TextBox();
            this.TxtSignUpFirstName = new System.Windows.Forms.Label();
            this.TxtSignUpBirthDate = new System.Windows.Forms.Label();
            this.TxtSignUpPasswordAgain = new System.Windows.Forms.Label();
            this.InputSignUpPasswordAgain = new System.Windows.Forms.TextBox();
            this.DatePickerSignUpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // InputSignUpLoginName
            // 
            this.InputSignUpLoginName.Location = new System.Drawing.Point(106, 58);
            this.InputSignUpLoginName.MaxLength = 20;
            this.InputSignUpLoginName.Name = "InputSignUpLoginName";
            this.InputSignUpLoginName.Size = new System.Drawing.Size(100, 20);
            this.InputSignUpLoginName.TabIndex = 0;
            // 
            // InputSignUpPassword
            // 
            this.InputSignUpPassword.Location = new System.Drawing.Point(106, 84);
            this.InputSignUpPassword.Name = "InputSignUpPassword";
            this.InputSignUpPassword.PasswordChar = '*';
            this.InputSignUpPassword.Size = new System.Drawing.Size(100, 20);
            this.InputSignUpPassword.TabIndex = 1;
            // 
            // TxtSignUpTitle
            // 
            this.TxtSignUpTitle.AutoSize = true;
            this.TxtSignUpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtSignUpTitle.Location = new System.Drawing.Point(17, 9);
            this.TxtSignUpTitle.MaximumSize = new System.Drawing.Size(200, 33);
            this.TxtSignUpTitle.MinimumSize = new System.Drawing.Size(200, 33);
            this.TxtSignUpTitle.Name = "TxtSignUpTitle";
            this.TxtSignUpTitle.Size = new System.Drawing.Size(200, 33);
            this.TxtSignUpTitle.TabIndex = 5;
            this.TxtSignUpTitle.Text = "Regisztráció";
            this.TxtSignUpTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtSignUpLoginName
            // 
            this.TxtSignUpLoginName.AutoSize = true;
            this.TxtSignUpLoginName.Location = new System.Drawing.Point(16, 61);
            this.TxtSignUpLoginName.Name = "TxtSignUpLoginName";
            this.TxtSignUpLoginName.Size = new System.Drawing.Size(88, 13);
            this.TxtSignUpLoginName.TabIndex = 6;
            this.TxtSignUpLoginName.Text = "Felhasználónév*:";
            // 
            // TxtSignUpPassword
            // 
            this.TxtSignUpPassword.AutoSize = true;
            this.TxtSignUpPassword.Location = new System.Drawing.Point(61, 87);
            this.TxtSignUpPassword.Name = "TxtSignUpPassword";
            this.TxtSignUpPassword.Size = new System.Drawing.Size(43, 13);
            this.TxtSignUpPassword.TabIndex = 7;
            this.TxtSignUpPassword.Text = "Jelszó*:";
            // 
            // BtnSignUpReg
            // 
            this.BtnSignUpReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSignUpReg.Location = new System.Drawing.Point(147, 256);
            this.BtnSignUpReg.Name = "BtnSignUpReg";
            this.BtnSignUpReg.Size = new System.Drawing.Size(75, 23);
            this.BtnSignUpReg.TabIndex = 6;
            this.BtnSignUpReg.Text = "Kész";
            this.BtnSignUpReg.UseVisualStyleBackColor = true;
            this.BtnSignUpReg.Click += new System.EventHandler(this.BtnSignUpReg_Click);
            // 
            // BtnSignUpBack
            // 
            this.BtnSignUpBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSignUpBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSignUpBack.Location = new System.Drawing.Point(64, 256);
            this.BtnSignUpBack.Name = "BtnSignUpBack";
            this.BtnSignUpBack.Size = new System.Drawing.Size(75, 23);
            this.BtnSignUpBack.TabIndex = 7;
            this.BtnSignUpBack.Text = "Vissza";
            this.BtnSignUpBack.UseVisualStyleBackColor = true;
            this.BtnSignUpBack.Click += new System.EventHandler(this.BtnSignUpBack_Click);
            // 
            // TxtSignUpSurname
            // 
            this.TxtSignUpSurname.AutoSize = true;
            this.TxtSignUpSurname.Location = new System.Drawing.Point(37, 152);
            this.TxtSignUpSurname.Name = "TxtSignUpSurname";
            this.TxtSignUpSurname.Size = new System.Drawing.Size(67, 13);
            this.TxtSignUpSurname.TabIndex = 10;
            this.TxtSignUpSurname.Text = "Vezetéknév:";
            // 
            // InputSignUpSurname
            // 
            this.InputSignUpSurname.Location = new System.Drawing.Point(106, 149);
            this.InputSignUpSurname.MaxLength = 20;
            this.InputSignUpSurname.Name = "InputSignUpSurname";
            this.InputSignUpSurname.Size = new System.Drawing.Size(100, 20);
            this.InputSignUpSurname.TabIndex = 3;
            // 
            // InputSignUpFirstName
            // 
            this.InputSignUpFirstName.Location = new System.Drawing.Point(106, 175);
            this.InputSignUpFirstName.MaxLength = 20;
            this.InputSignUpFirstName.Name = "InputSignUpFirstName";
            this.InputSignUpFirstName.Size = new System.Drawing.Size(100, 20);
            this.InputSignUpFirstName.TabIndex = 4;
            // 
            // TxtSignUpFirstName
            // 
            this.TxtSignUpFirstName.AutoSize = true;
            this.TxtSignUpFirstName.Location = new System.Drawing.Point(41, 178);
            this.TxtSignUpFirstName.Name = "TxtSignUpFirstName";
            this.TxtSignUpFirstName.Size = new System.Drawing.Size(63, 13);
            this.TxtSignUpFirstName.TabIndex = 14;
            this.TxtSignUpFirstName.Text = "Keresztnév:";
            // 
            // TxtSignUpBirthDate
            // 
            this.TxtSignUpBirthDate.AutoSize = true;
            this.TxtSignUpBirthDate.Location = new System.Drawing.Point(20, 210);
            this.TxtSignUpBirthDate.Name = "TxtSignUpBirthDate";
            this.TxtSignUpBirthDate.Size = new System.Drawing.Size(84, 13);
            this.TxtSignUpBirthDate.TabIndex = 15;
            this.TxtSignUpBirthDate.Text = "Születési dátum:";
            // 
            // TxtSignUpPasswordAgain
            // 
            this.TxtSignUpPasswordAgain.AutoSize = true;
            this.TxtSignUpPasswordAgain.Location = new System.Drawing.Point(41, 113);
            this.TxtSignUpPasswordAgain.Name = "TxtSignUpPasswordAgain";
            this.TxtSignUpPasswordAgain.Size = new System.Drawing.Size(63, 13);
            this.TxtSignUpPasswordAgain.TabIndex = 16;
            this.TxtSignUpPasswordAgain.Text = "Jelszó újra*:";
            // 
            // InputSignUpPasswordAgain
            // 
            this.InputSignUpPasswordAgain.Location = new System.Drawing.Point(106, 110);
            this.InputSignUpPasswordAgain.Name = "InputSignUpPasswordAgain";
            this.InputSignUpPasswordAgain.PasswordChar = '*';
            this.InputSignUpPasswordAgain.Size = new System.Drawing.Size(100, 20);
            this.InputSignUpPasswordAgain.TabIndex = 2;
            // 
            // DatePickerSignUpBirthDate
            // 
            this.DatePickerSignUpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerSignUpBirthDate.Location = new System.Drawing.Point(106, 204);
            this.DatePickerSignUpBirthDate.MaxDate = new System.DateTime(2020, 2, 19, 0, 0, 0, 0);
            this.DatePickerSignUpBirthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.DatePickerSignUpBirthDate.Name = "DatePickerSignUpBirthDate";
            this.DatePickerSignUpBirthDate.Size = new System.Drawing.Size(100, 20);
            this.DatePickerSignUpBirthDate.TabIndex = 5;
            this.DatePickerSignUpBirthDate.Value = new System.DateTime(2020, 2, 19, 0, 0, 0, 0);
            // 
            // SignUpForm
            // 
            this.AcceptButton = this.BtnSignUpReg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.BtnSignUpBack;
            this.ClientSize = new System.Drawing.Size(234, 291);
            this.Controls.Add(this.DatePickerSignUpBirthDate);
            this.Controls.Add(this.InputSignUpPasswordAgain);
            this.Controls.Add(this.TxtSignUpPasswordAgain);
            this.Controls.Add(this.TxtSignUpBirthDate);
            this.Controls.Add(this.TxtSignUpFirstName);
            this.Controls.Add(this.InputSignUpFirstName);
            this.Controls.Add(this.InputSignUpSurname);
            this.Controls.Add(this.TxtSignUpSurname);
            this.Controls.Add(this.BtnSignUpBack);
            this.Controls.Add(this.BtnSignUpReg);
            this.Controls.Add(this.TxtSignUpPassword);
            this.Controls.Add(this.TxtSignUpLoginName);
            this.Controls.Add(this.TxtSignUpTitle);
            this.Controls.Add(this.InputSignUpPassword);
            this.Controls.Add(this.InputSignUpLoginName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 330);
            this.MinimizeBox = false;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputSignUpLoginName;
        private System.Windows.Forms.TextBox InputSignUpPassword;
        private System.Windows.Forms.Label TxtSignUpLoginName;
        private System.Windows.Forms.Label TxtSignUpPassword;
        private System.Windows.Forms.Button BtnSignUpReg;
        private System.Windows.Forms.Label TxtSignUpTitle;
        private System.Windows.Forms.Button BtnSignUpBack;
        private System.Windows.Forms.Label TxtSignUpSurname;
        private System.Windows.Forms.TextBox InputSignUpSurname;
        private System.Windows.Forms.TextBox InputSignUpFirstName;
        private System.Windows.Forms.Label TxtSignUpFirstName;
        private System.Windows.Forms.Label TxtSignUpBirthDate;
        private System.Windows.Forms.Label TxtSignUpPasswordAgain;
        private System.Windows.Forms.TextBox InputSignUpPasswordAgain;
        private System.Windows.Forms.DateTimePicker DatePickerSignUpBirthDate;
    }
}