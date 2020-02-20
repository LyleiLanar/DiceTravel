namespace DiceTravel
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.inputSignUpLoginName = new System.Windows.Forms.TextBox();
            this.inputSignUpPassword = new System.Windows.Forms.TextBox();
            this.txtSignUpTitle = new System.Windows.Forms.Label();
            this.txtSignUpLoginName = new System.Windows.Forms.Label();
            this.txtSignUpPassword = new System.Windows.Forms.Label();
            this.btnSignUpReg = new System.Windows.Forms.Button();
            this.btnSignUpBack = new System.Windows.Forms.Button();
            this.txtSignUpSurname = new System.Windows.Forms.Label();
            this.inputSignUpSurname = new System.Windows.Forms.TextBox();
            this.inputSignUpFirstName = new System.Windows.Forms.TextBox();
            this.txtSignUpFirstName = new System.Windows.Forms.Label();
            this.txtSignUpBirthDate = new System.Windows.Forms.Label();
            this.txtSignUpPasswordAgain = new System.Windows.Forms.Label();
            this.inputSignUpPasswordAgain = new System.Windows.Forms.TextBox();
            this.datePickerSignUpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // inputSignUpLoginName
            // 
            this.inputSignUpLoginName.Location = new System.Drawing.Point(106, 58);
            this.inputSignUpLoginName.MaxLength = 20;
            this.inputSignUpLoginName.Name = "inputSignUpLoginName";
            this.inputSignUpLoginName.Size = new System.Drawing.Size(100, 20);
            this.inputSignUpLoginName.TabIndex = 0;
            // 
            // inputSignUpPassword
            // 
            this.inputSignUpPassword.Location = new System.Drawing.Point(106, 84);
            this.inputSignUpPassword.Name = "inputSignUpPassword";
            this.inputSignUpPassword.PasswordChar = '*';
            this.inputSignUpPassword.Size = new System.Drawing.Size(100, 20);
            this.inputSignUpPassword.TabIndex = 1;
            // 
            // txtSignUpTitle
            // 
            this.txtSignUpTitle.AutoSize = true;
            this.txtSignUpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtSignUpTitle.Location = new System.Drawing.Point(17, 9);
            this.txtSignUpTitle.MaximumSize = new System.Drawing.Size(200, 33);
            this.txtSignUpTitle.MinimumSize = new System.Drawing.Size(200, 33);
            this.txtSignUpTitle.Name = "txtSignUpTitle";
            this.txtSignUpTitle.Size = new System.Drawing.Size(200, 33);
            this.txtSignUpTitle.TabIndex = 5;
            this.txtSignUpTitle.Text = "Regisztráció";
            this.txtSignUpTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSignUpLoginName
            // 
            this.txtSignUpLoginName.AutoSize = true;
            this.txtSignUpLoginName.Location = new System.Drawing.Point(16, 61);
            this.txtSignUpLoginName.Name = "txtSignUpLoginName";
            this.txtSignUpLoginName.Size = new System.Drawing.Size(88, 13);
            this.txtSignUpLoginName.TabIndex = 6;
            this.txtSignUpLoginName.Text = "Felhasználónév*:";
            // 
            // txtSignUpPassword
            // 
            this.txtSignUpPassword.AutoSize = true;
            this.txtSignUpPassword.Location = new System.Drawing.Point(61, 87);
            this.txtSignUpPassword.Name = "txtSignUpPassword";
            this.txtSignUpPassword.Size = new System.Drawing.Size(43, 13);
            this.txtSignUpPassword.TabIndex = 7;
            this.txtSignUpPassword.Text = "Jelszó*:";
            // 
            // btnSignUpReg
            // 
            this.btnSignUpReg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignUpReg.Location = new System.Drawing.Point(147, 256);
            this.btnSignUpReg.Name = "btnSignUpReg";
            this.btnSignUpReg.Size = new System.Drawing.Size(75, 23);
            this.btnSignUpReg.TabIndex = 6;
            this.btnSignUpReg.Text = "Kész";
            this.btnSignUpReg.UseVisualStyleBackColor = true;
            this.btnSignUpReg.Click += new System.EventHandler(this.btnSignInReg_Click);
            // 
            // btnSignUpBack
            // 
            this.btnSignUpBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignUpBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSignUpBack.Location = new System.Drawing.Point(64, 256);
            this.btnSignUpBack.Name = "btnSignUpBack";
            this.btnSignUpBack.Size = new System.Drawing.Size(75, 23);
            this.btnSignUpBack.TabIndex = 7;
            this.btnSignUpBack.Text = "Vissza";
            this.btnSignUpBack.UseVisualStyleBackColor = true;
            this.btnSignUpBack.Click += new System.EventHandler(this.btnSignInBack_Click);
            // 
            // txtSignUpSurname
            // 
            this.txtSignUpSurname.AutoSize = true;
            this.txtSignUpSurname.Location = new System.Drawing.Point(37, 152);
            this.txtSignUpSurname.Name = "txtSignUpSurname";
            this.txtSignUpSurname.Size = new System.Drawing.Size(67, 13);
            this.txtSignUpSurname.TabIndex = 10;
            this.txtSignUpSurname.Text = "Vezetéknév:";
            // 
            // inputSignUpSurname
            // 
            this.inputSignUpSurname.Location = new System.Drawing.Point(106, 149);
            this.inputSignUpSurname.MaxLength = 20;
            this.inputSignUpSurname.Name = "inputSignUpSurname";
            this.inputSignUpSurname.Size = new System.Drawing.Size(100, 20);
            this.inputSignUpSurname.TabIndex = 3;
            // 
            // inputSignUpFirstName
            // 
            this.inputSignUpFirstName.Location = new System.Drawing.Point(106, 175);
            this.inputSignUpFirstName.MaxLength = 20;
            this.inputSignUpFirstName.Name = "inputSignUpFirstName";
            this.inputSignUpFirstName.Size = new System.Drawing.Size(100, 20);
            this.inputSignUpFirstName.TabIndex = 4;
            // 
            // txtSignUpFirstName
            // 
            this.txtSignUpFirstName.AutoSize = true;
            this.txtSignUpFirstName.Location = new System.Drawing.Point(41, 178);
            this.txtSignUpFirstName.Name = "txtSignUpFirstName";
            this.txtSignUpFirstName.Size = new System.Drawing.Size(63, 13);
            this.txtSignUpFirstName.TabIndex = 14;
            this.txtSignUpFirstName.Text = "Keresztnév:";
            // 
            // txtSignUpBirthDate
            // 
            this.txtSignUpBirthDate.AutoSize = true;
            this.txtSignUpBirthDate.Location = new System.Drawing.Point(20, 210);
            this.txtSignUpBirthDate.Name = "txtSignUpBirthDate";
            this.txtSignUpBirthDate.Size = new System.Drawing.Size(84, 13);
            this.txtSignUpBirthDate.TabIndex = 15;
            this.txtSignUpBirthDate.Text = "Születési dátum:";
            // 
            // txtSignUpPasswordAgain
            // 
            this.txtSignUpPasswordAgain.AutoSize = true;
            this.txtSignUpPasswordAgain.Location = new System.Drawing.Point(41, 113);
            this.txtSignUpPasswordAgain.Name = "txtSignUpPasswordAgain";
            this.txtSignUpPasswordAgain.Size = new System.Drawing.Size(63, 13);
            this.txtSignUpPasswordAgain.TabIndex = 16;
            this.txtSignUpPasswordAgain.Text = "Jelszó újra*:";
            // 
            // inputSignUpPasswordAgain
            // 
            this.inputSignUpPasswordAgain.Location = new System.Drawing.Point(106, 110);
            this.inputSignUpPasswordAgain.Name = "inputSignUpPasswordAgain";
            this.inputSignUpPasswordAgain.PasswordChar = '*';
            this.inputSignUpPasswordAgain.Size = new System.Drawing.Size(100, 20);
            this.inputSignUpPasswordAgain.TabIndex = 2;
            // 
            // datePickerSignUpBirthDate
            // 
            this.datePickerSignUpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerSignUpBirthDate.Location = new System.Drawing.Point(106, 204);
            this.datePickerSignUpBirthDate.MaxDate = new System.DateTime(2020, 2, 19, 0, 0, 0, 0);
            this.datePickerSignUpBirthDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.datePickerSignUpBirthDate.Name = "datePickerSignUpBirthDate";
            this.datePickerSignUpBirthDate.Size = new System.Drawing.Size(100, 20);
            this.datePickerSignUpBirthDate.TabIndex = 5;
            this.datePickerSignUpBirthDate.Value = new System.DateTime(2020, 2, 19, 0, 0, 0, 0);
            // 
            // SignUp
            // 
            this.AcceptButton = this.btnSignUpReg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnSignUpBack;
            this.ClientSize = new System.Drawing.Size(234, 291);
            this.Controls.Add(this.datePickerSignUpBirthDate);
            this.Controls.Add(this.inputSignUpPasswordAgain);
            this.Controls.Add(this.txtSignUpPasswordAgain);
            this.Controls.Add(this.txtSignUpBirthDate);
            this.Controls.Add(this.txtSignUpFirstName);
            this.Controls.Add(this.inputSignUpFirstName);
            this.Controls.Add(this.inputSignUpSurname);
            this.Controls.Add(this.txtSignUpSurname);
            this.Controls.Add(this.btnSignUpBack);
            this.Controls.Add(this.btnSignUpReg);
            this.Controls.Add(this.txtSignUpPassword);
            this.Controls.Add(this.txtSignUpLoginName);
            this.Controls.Add(this.txtSignUpTitle);
            this.Controls.Add(this.inputSignUpPassword);
            this.Controls.Add(this.inputSignUpLoginName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 330);
            this.MinimizeBox = false;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputSignUpLoginName;
        private System.Windows.Forms.TextBox inputSignUpPassword;
        private System.Windows.Forms.Label txtSignUpLoginName;
        private System.Windows.Forms.Label txtSignUpPassword;
        private System.Windows.Forms.Button btnSignUpReg;
        private System.Windows.Forms.Label txtSignUpTitle;
        private System.Windows.Forms.Button btnSignUpBack;
        private System.Windows.Forms.Label txtSignUpSurname;
        private System.Windows.Forms.TextBox inputSignUpSurname;
        private System.Windows.Forms.TextBox inputSignUpFirstName;
        private System.Windows.Forms.Label txtSignUpFirstName;
        private System.Windows.Forms.Label txtSignUpBirthDate;
        private System.Windows.Forms.Label txtSignUpPasswordAgain;
        private System.Windows.Forms.TextBox inputSignUpPasswordAgain;
        private System.Windows.Forms.DateTimePicker datePickerSignUpBirthDate;
    }
}