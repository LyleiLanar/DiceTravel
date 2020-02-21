using DiceTravel.Util;
using System;
using System.Data;
using System.Windows.Forms;

namespace DiceTravel
{
    public partial class SignUpForm : Form
    {
        private enum SignUpError
        {
            NO_ERROR, MISSING_LOGINNAME, MISSING_PASSWORD, NOT_SAME_PASSWORD, USED_LOGINNAME
        }

        private String sql;
        private string connString;
        private SignUpError signUpError;

        public SignUpForm()
        {
            InitializeComponent();
            this.sql = "";
            this.connString = Properties.Settings.Default.dice_travelConnString;
            this.signUpError = SignUpError.NO_ERROR;
        }

        private void BtnSignUpBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnSignUpReg_Click(object sender, EventArgs e)
        {
            String loginName = IinputSignUpLoginName.Text;
            String password = InputSignUpPassword.Text;

            signUpError = SignUpError.NO_ERROR;

            string countLoginNamesCommand = $"SELECT count(login_name) as t " +
                $"FROM dice_travel.users where login_name like '{loginName}';";
            DataTable countLoginNames = DBDriver.ReadQuery(countLoginNamesCommand);

            if (countLoginNames.Rows[0]["t"].ToString() != "0") { signUpError = SignUpError.USED_LOGINNAME; }
            if (loginName == "") { signUpError = SignUpError.MISSING_LOGINNAME; }
            if (password != InputSignUpPasswordAgain.Text) { signUpError = SignUpError.NOT_SAME_PASSWORD; }
            if (password == "") { signUpError = SignUpError.MISSING_PASSWORD; }

            switch (signUpError)
            {
                case SignUpError.NO_ERROR:

                    string surname = InputSignUpSurname.Text;
                    string firstname = InputSignUpFirstName.Text;
                    string birthDate = DatePickerSignUpBirthDate.Value.Date.ToString("yyy-MM-dd");
                    string queryString = "SELECT * FROM users";
                    string insertString = $"INSERT INTO `dice_travel`.`users` (`login_name`, `pswd`,`sur_name`,`first_name`,`birth_date`) " +
                        $"VALUES ('{loginName}', '{password}','{surname}','{firstname}','{birthDate}');";

                    DBDriver.InsertRow(queryString, insertString);

                    MessageBox.Show("Üdvözlünk a DiceTravelben! Kérlek jelentkezz be!", "Siker!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    break;

                case SignUpError.MISSING_LOGINNAME:
                    MessageBox.Show("Hiányzó felhasználónév!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case SignUpError.MISSING_PASSWORD:
                    MessageBox.Show("Hiányzó jelszó!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case SignUpError.NOT_SAME_PASSWORD:
                    MessageBox.Show("Nem egyeznek a jelszavak!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case SignUpError.USED_LOGINNAME:
                    MessageBox.Show("Foglalt felhasználónév!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                default:
                    MessageBox.Show("Ismeretlen hiba a regisztráció folyamán!", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }
    }
}
