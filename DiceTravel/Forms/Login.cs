using System;
using System.Windows.Forms;

namespace DiceTravel
{
    public partial class Login : Form
    {
        private enum LoginError
        {
            NO_ERROR, MISSING_LOGINNAME, MISSING_PASSWORD, NOT_VALID_USER
        }

        private LoginError loginError;

        public Login()
        {
            InitializeComponent();
        }

        private void BtnSignUpBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            loginError = LoginError.NO_ERROR;
        }

        private void BtnSignUpLogin_Click(object sender, EventArgs e)
        {

            Program.LogInUser(inputLoginLoginName.Text, inputLoginPassword.Text);
            loginError = LoginError.NO_ERROR;

            if (Program.ActiveUser == null) { loginError = LoginError.NOT_VALID_USER; }
            if (inputLoginLoginName.Text == "") { loginError = LoginError.MISSING_LOGINNAME; }
            if (inputLoginPassword.Text == "") { loginError = LoginError.MISSING_PASSWORD; }

            switch (loginError)
            {
                case LoginError.NO_ERROR:
                    MessageBox.Show("Sikeres bejelentkezés", "Király!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    break;

                case LoginError.MISSING_LOGINNAME:
                    MessageBox.Show("Hiányzó felhasználónév!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case LoginError.MISSING_PASSWORD:
                    MessageBox.Show("Hiányzó jelszó!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case LoginError.NOT_VALID_USER:
                    MessageBox.Show("Nincs ilyen felhasználó!\r\nVagy elrontottad az adataidat!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                default:
                    MessageBox.Show("Ismeretlen hiba a regisztráció folyamán!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
            inputLoginLoginName.Text = "";
            inputLoginPassword.Text = "";

        }
    }
}
