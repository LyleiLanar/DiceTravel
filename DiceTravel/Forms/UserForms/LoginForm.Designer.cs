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
            this.txtLoginTitle = new System.Windows.Forms.Label();
            this.txtLoginLoginName = new System.Windows.Forms.Label();
            this.txtLoginPassword = new System.Windows.Forms.Label();
            this.inputLoginLoginName = new System.Windows.Forms.TextBox();
            this.inputLoginPassword = new System.Windows.Forms.TextBox();
            this.btnSignUpLogin = new System.Windows.Forms.Button();
            this.btnSignUpCancel = new System.Windows.Forms.Button();
            this.btnLoginSignUp = new System.Windows.Forms.Button();
            this.txtLoginSignUp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLoginTitle
            // 
            this.txtLoginTitle.AutoSize = true;
            this.txtLoginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLoginTitle.Location = new System.Drawing.Point(70, 9);
            this.txtLoginTitle.Name = "txtLoginTitle";
            this.txtLoginTitle.Size = new System.Drawing.Size(91, 33);
            this.txtLoginTitle.TabIndex = 0;
            this.txtLoginTitle.Text = "Login";
            // 
            // txtLoginLoginName
            // 
            this.txtLoginLoginName.AutoSize = true;
            this.txtLoginLoginName.Location = new System.Drawing.Point(43, 63);
            this.txtLoginLoginName.Name = "txtLoginLoginName";
            this.txtLoginLoginName.Size = new System.Drawing.Size(65, 13);
            this.txtLoginLoginName.TabIndex = 1;
            this.txtLoginLoginName.Text = "Login name:";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.AutoSize = true;
            this.txtLoginPassword.Location = new System.Drawing.Point(49, 89);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(59, 13);
            this.txtLoginPassword.TabIndex = 2;
            this.txtLoginPassword.Text = "Password: ";
            // 
            // inputLoginLoginName
            // 
            this.inputLoginLoginName.Location = new System.Drawing.Point(114, 60);
            this.inputLoginLoginName.MaxLength = 20;
            this.inputLoginLoginName.Name = "inputLoginLoginName";
            this.inputLoginLoginName.Size = new System.Drawing.Size(100, 20);
            this.inputLoginLoginName.TabIndex = 3;
            this.inputLoginLoginName.Text = "Patrik";
            // 
            // inputLoginPassword
            // 
            this.inputLoginPassword.Location = new System.Drawing.Point(114, 86);
            this.inputLoginPassword.Name = "inputLoginPassword";
            this.inputLoginPassword.PasswordChar = '*';
            this.inputLoginPassword.Size = new System.Drawing.Size(100, 20);
            this.inputLoginPassword.TabIndex = 4;
            this.inputLoginPassword.Text = "1234";
            // 
            // btnSignUpLogin
            // 
            this.btnSignUpLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignUpLogin.Location = new System.Drawing.Point(139, 122);
            this.btnSignUpLogin.Name = "btnSignUpLogin";
            this.btnSignUpLogin.Size = new System.Drawing.Size(75, 23);
            this.btnSignUpLogin.TabIndex = 7;
            this.btnSignUpLogin.Text = "Enter";
            this.btnSignUpLogin.UseVisualStyleBackColor = true;
            this.btnSignUpLogin.Click += new System.EventHandler(this.BtnSignUpLogin_Click);
            // 
            // btnSignUpCancel
            // 
            this.btnSignUpCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignUpCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSignUpCancel.Location = new System.Drawing.Point(58, 122);
            this.btnSignUpCancel.Name = "btnSignUpCancel";
            this.btnSignUpCancel.Size = new System.Drawing.Size(75, 23);
            this.btnSignUpCancel.TabIndex = 8;
            this.btnSignUpCancel.Text = "Cancel";
            this.btnSignUpCancel.UseVisualStyleBackColor = true;
            this.btnSignUpCancel.Click += new System.EventHandler(this.BtnSignUpCancel_Click);
            // 
            // btnLoginSignUp
            // 
            this.btnLoginSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoginSignUp.Location = new System.Drawing.Point(9, 38);
            this.btnLoginSignUp.Name = "btnLoginSignUp";
            this.btnLoginSignUp.Size = new System.Drawing.Size(193, 23);
            this.btnLoginSignUp.TabIndex = 9;
            this.btnLoginSignUp.Text = "SignUp Now!";
            this.btnLoginSignUp.UseVisualStyleBackColor = true;
            // 
            // txtLoginSignUp
            // 
            this.txtLoginSignUp.AutoSize = true;
            this.txtLoginSignUp.Location = new System.Drawing.Point(6, 16);
            this.txtLoginSignUp.Name = "txtLoginSignUp";
            this.txtLoginSignUp.Size = new System.Drawing.Size(133, 13);
            this.txtLoginSignUp.TabIndex = 10;
            this.txtLoginSignUp.Text = "If you have not an Acount:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtLoginSignUp);
            this.groupBox1.Controls.Add(this.btnLoginSignUp);
            this.groupBox1.Location = new System.Drawing.Point(10, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 67);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnSignUpLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnSignUpCancel;
            this.ClientSize = new System.Drawing.Size(234, 230);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSignUpCancel);
            this.Controls.Add(this.btnSignUpLogin);
            this.Controls.Add(this.inputLoginPassword);
            this.Controls.Add(this.inputLoginLoginName);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginLoginName);
            this.Controls.Add(this.txtLoginTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtLoginTitle;
        private System.Windows.Forms.Label txtLoginLoginName;
        private System.Windows.Forms.Label txtLoginPassword;
        private System.Windows.Forms.TextBox inputLoginLoginName;
        private System.Windows.Forms.TextBox inputLoginPassword;
        private System.Windows.Forms.Button btnSignUpLogin;
        private System.Windows.Forms.Button btnSignUpCancel;
        private System.Windows.Forms.Button btnLoginSignUp;
        private System.Windows.Forms.Label txtLoginSignUp;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}