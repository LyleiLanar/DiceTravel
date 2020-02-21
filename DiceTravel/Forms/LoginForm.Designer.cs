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
            this.btnSignUpBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLoginTitle
            // 
            this.txtLoginTitle.AutoSize = true;
            this.txtLoginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtLoginTitle.Location = new System.Drawing.Point(12, 9);
            this.txtLoginTitle.Name = "txtLoginTitle";
            this.txtLoginTitle.Size = new System.Drawing.Size(210, 33);
            this.txtLoginTitle.TabIndex = 0;
            this.txtLoginTitle.Text = "Bejelentkezés";
            // 
            // txtLoginLoginName
            // 
            this.txtLoginLoginName.AutoSize = true;
            this.txtLoginLoginName.Location = new System.Drawing.Point(24, 63);
            this.txtLoginLoginName.Name = "txtLoginLoginName";
            this.txtLoginLoginName.Size = new System.Drawing.Size(84, 13);
            this.txtLoginLoginName.TabIndex = 1;
            this.txtLoginLoginName.Text = "Felhasználónév:";
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.AutoSize = true;
            this.txtLoginPassword.Location = new System.Drawing.Point(73, 89);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(39, 13);
            this.txtLoginPassword.TabIndex = 2;
            this.txtLoginPassword.Text = "Jelszó:";
            // 
            // inputLoginLoginName
            // 
            this.inputLoginLoginName.Location = new System.Drawing.Point(114, 60);
            this.inputLoginLoginName.MaxLength = 20;
            this.inputLoginLoginName.Name = "inputLoginLoginName";
            this.inputLoginLoginName.Size = new System.Drawing.Size(100, 20);
            this.inputLoginLoginName.TabIndex = 3;
            // 
            // inputLoginPassword
            // 
            this.inputLoginPassword.Location = new System.Drawing.Point(114, 86);
            this.inputLoginPassword.Name = "inputLoginPassword";
            this.inputLoginPassword.PasswordChar = '*';
            this.inputLoginPassword.Size = new System.Drawing.Size(100, 20);
            this.inputLoginPassword.TabIndex = 4;
            // 
            // btnSignUpLogin
            // 
            this.btnSignUpLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignUpLogin.Location = new System.Drawing.Point(147, 126);
            this.btnSignUpLogin.Name = "btnSignUpLogin";
            this.btnSignUpLogin.Size = new System.Drawing.Size(75, 23);
            this.btnSignUpLogin.TabIndex = 7;
            this.btnSignUpLogin.Text = "Belépés";
            this.btnSignUpLogin.UseVisualStyleBackColor = true;
            this.btnSignUpLogin.Click += new System.EventHandler(this.BtnSignUpLogin_Click);
            // 
            // btnSignUpBack
            // 
            this.btnSignUpBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSignUpBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSignUpBack.Location = new System.Drawing.Point(66, 126);
            this.btnSignUpBack.Name = "btnSignUpBack";
            this.btnSignUpBack.Size = new System.Drawing.Size(75, 23);
            this.btnSignUpBack.TabIndex = 8;
            this.btnSignUpBack.Text = "Vissza";
            this.btnSignUpBack.UseVisualStyleBackColor = true;
            this.btnSignUpBack.Click += new System.EventHandler(this.BtnSignUpBack_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnSignUpLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.btnSignUpBack;
            this.ClientSize = new System.Drawing.Size(234, 161);
            this.Controls.Add(this.btnSignUpBack);
            this.Controls.Add(this.btnSignUpLogin);
            this.Controls.Add(this.inputLoginPassword);
            this.Controls.Add(this.inputLoginLoginName);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginLoginName);
            this.Controls.Add(this.txtLoginTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(250, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(250, 200);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bejelentkezés";
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
        private System.Windows.Forms.Button btnSignUpBack;
    }
}