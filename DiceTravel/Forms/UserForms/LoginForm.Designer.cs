namespace DiceTravel
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.TxtLoginTitle = new System.Windows.Forms.Label();
            this.TxtLoginLoginName = new System.Windows.Forms.Label();
            this.TxtLoginPassword = new System.Windows.Forms.Label();
            this.InputLoginLoginName = new System.Windows.Forms.TextBox();
            this.InputLoginPassword = new System.Windows.Forms.TextBox();
            this.BtnSignUpLogin = new System.Windows.Forms.Button();
            this.BtnSignUpCancel = new System.Windows.Forms.Button();
            this.BtnLoginSignUp = new System.Windows.Forms.Button();
            this.TxtLoginSignUp = new System.Windows.Forms.Label();
            this.GrpBxSignUp = new System.Windows.Forms.GroupBox();
            this.GrpBxSignUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtLoginTitle
            // 
            this.TxtLoginTitle.AutoSize = true;
            this.TxtLoginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TxtLoginTitle.Location = new System.Drawing.Point(70, 9);
            this.TxtLoginTitle.Name = "TxtLoginTitle";
            this.TxtLoginTitle.Size = new System.Drawing.Size(91, 33);
            this.TxtLoginTitle.TabIndex = 0;
            this.TxtLoginTitle.Text = "Login";
            // 
            // TxtLoginLoginName
            // 
            this.TxtLoginLoginName.AutoSize = true;
            this.TxtLoginLoginName.Location = new System.Drawing.Point(43, 63);
            this.TxtLoginLoginName.Name = "TxtLoginLoginName";
            this.TxtLoginLoginName.Size = new System.Drawing.Size(65, 13);
            this.TxtLoginLoginName.TabIndex = 1;
            this.TxtLoginLoginName.Text = "Login name:";
            // 
            // TxtLoginPassword
            // 
            this.TxtLoginPassword.AutoSize = true;
            this.TxtLoginPassword.Location = new System.Drawing.Point(49, 89);
            this.TxtLoginPassword.Name = "TxtLoginPassword";
            this.TxtLoginPassword.Size = new System.Drawing.Size(59, 13);
            this.TxtLoginPassword.TabIndex = 2;
            this.TxtLoginPassword.Text = "Password: ";
            // 
            // InputLoginLoginName
            // 
            this.InputLoginLoginName.Location = new System.Drawing.Point(114, 60);
            this.InputLoginLoginName.MaxLength = 20;
            this.InputLoginLoginName.Name = "InputLoginLoginName";
            this.InputLoginLoginName.Size = new System.Drawing.Size(100, 20);
            this.InputLoginLoginName.TabIndex = 3;
            // 
            // InputLoginPassword
            // 
            this.InputLoginPassword.Location = new System.Drawing.Point(114, 86);
            this.InputLoginPassword.Name = "InputLoginPassword";
            this.InputLoginPassword.PasswordChar = '*';
            this.InputLoginPassword.Size = new System.Drawing.Size(100, 20);
            this.InputLoginPassword.TabIndex = 4;
            this.InputLoginPassword.Text = "1234";
            // 
            // BtnSignUpLogin
            // 
            this.BtnSignUpLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSignUpLogin.Location = new System.Drawing.Point(139, 122);
            this.BtnSignUpLogin.Name = "BtnSignUpLogin";
            this.BtnSignUpLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnSignUpLogin.TabIndex = 7;
            this.BtnSignUpLogin.Text = "Enter";
            this.BtnSignUpLogin.UseVisualStyleBackColor = true;
            this.BtnSignUpLogin.Click += new System.EventHandler(this.BtnSignUpLogin_Click);
            // 
            // BtnSignUpCancel
            // 
            this.BtnSignUpCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSignUpCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSignUpCancel.Location = new System.Drawing.Point(58, 122);
            this.BtnSignUpCancel.Name = "BtnSignUpCancel";
            this.BtnSignUpCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnSignUpCancel.TabIndex = 8;
            this.BtnSignUpCancel.Text = "Cancel";
            this.BtnSignUpCancel.UseVisualStyleBackColor = true;
            this.BtnSignUpCancel.Click += new System.EventHandler(this.BtnSignUpCancel_Click);
            // 
            // BtnLoginSignUp
            // 
            this.BtnLoginSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLoginSignUp.Location = new System.Drawing.Point(9, 38);
            this.BtnLoginSignUp.Name = "BtnLoginSignUp";
            this.BtnLoginSignUp.Size = new System.Drawing.Size(193, 23);
            this.BtnLoginSignUp.TabIndex = 9;
            this.BtnLoginSignUp.Text = "SignUp Now!";
            this.BtnLoginSignUp.UseVisualStyleBackColor = true;
            this.BtnLoginSignUp.Click += new System.EventHandler(this.BtnLoginSignUp_Click);
            // 
            // TxtLoginSignUp
            // 
            this.TxtLoginSignUp.AutoSize = true;
            this.TxtLoginSignUp.Location = new System.Drawing.Point(6, 16);
            this.TxtLoginSignUp.Name = "TxtLoginSignUp";
            this.TxtLoginSignUp.Size = new System.Drawing.Size(133, 13);
            this.TxtLoginSignUp.TabIndex = 10;
            this.TxtLoginSignUp.Text = "If you have not an Acount:";
            // 
            // GrpBxSignUp
            // 
            this.GrpBxSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBxSignUp.Controls.Add(this.TxtLoginSignUp);
            this.GrpBxSignUp.Controls.Add(this.BtnLoginSignUp);
            this.GrpBxSignUp.Location = new System.Drawing.Point(10, 151);
            this.GrpBxSignUp.Name = "GrpBxSignUp";
            this.GrpBxSignUp.Size = new System.Drawing.Size(212, 67);
            this.GrpBxSignUp.TabIndex = 11;
            this.GrpBxSignUp.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.BtnSignUpLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.BtnSignUpCancel;
            this.ClientSize = new System.Drawing.Size(234, 230);
            this.Controls.Add(this.GrpBxSignUp);
            this.Controls.Add(this.BtnSignUpCancel);
            this.Controls.Add(this.BtnSignUpLogin);
            this.Controls.Add(this.InputLoginPassword);
            this.Controls.Add(this.InputLoginLoginName);
            this.Controls.Add(this.TxtLoginPassword);
            this.Controls.Add(this.TxtLoginLoginName);
            this.Controls.Add(this.TxtLoginTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.GrpBxSignUp.ResumeLayout(false);
            this.GrpBxSignUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TxtLoginTitle;
        private System.Windows.Forms.Label TxtLoginLoginName;
        private System.Windows.Forms.Label TxtLoginPassword;
        private System.Windows.Forms.TextBox InputLoginLoginName;
        private System.Windows.Forms.TextBox InputLoginPassword;
        private System.Windows.Forms.Button BtnSignUpLogin;
        private System.Windows.Forms.Button BtnSignUpCancel;
        private System.Windows.Forms.Button BtnLoginSignUp;
        private System.Windows.Forms.Label TxtLoginSignUp;
        private System.Windows.Forms.GroupBox GrpBxSignUp;
    }
}