using DiceTravel.Util;
using System;
using System.Windows.Forms;

namespace DiceTravel
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void BtnSignUpCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void BtnSignUpLogin_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validation();
                ActiveUserStore.LogInUser(inputLoginLoginName.Text, inputLoginPassword.Text);
                this.Dispose();
            }
            catch (ValidationException ex)
            { MessageBox.Show(ex.Message, "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            catch (EntityCreationException ex)
            { MessageBox.Show(ex.Message, "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        public void Validation()
        {
            if (inputLoginLoginName.Text == "" || inputLoginPassword.Text == "")
            { throw new ValidationException("Missing Login name or Password!"); }

        }
    }
}
