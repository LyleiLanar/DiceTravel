using MySql.Data.MySqlClient;
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

        private void BtnSignInBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnSignInReg_Click(object sender, EventArgs e)
        {
            sql = "SELECT * FROM users";
            DataTable table = new DataTable();
            MySqlDataAdapter dptr = new MySqlDataAdapter(sql, connString);
            String loginName = IinputSignUpLoginName.Text;
            String password = InputSignUpPassword.Text;

            signUpError = SignUpError.NO_ERROR;

            //meg kell vizsgálni, hogy van-e már ilyen nevű felhasználó.
            DataTable loginNames = new DataTable();
            string isOtherNameSQL = $"SELECT count(login_name) as t FROM dice_travel.users where login_name like '{loginName}';";
            MySqlDataAdapter nameDptr = new MySqlDataAdapter(isOtherNameSQL, connString);
            nameDptr.Fill(loginNames);

            if (loginNames.Rows[0]["t"].ToString() != "0") { signUpError = SignUpError.USED_LOGINNAME; }
            if (loginName == "") { signUpError = SignUpError.MISSING_LOGINNAME; }
            if (password != InputSignUpPasswordAgain.Text) { signUpError = SignUpError.NOT_SAME_PASSWORD; }
            if (password == "") { signUpError = SignUpError.MISSING_PASSWORD; }

            switch (signUpError)
            {
                case SignUpError.NO_ERROR:
                    dptr.Fill(table);
                    DataRow newRow = table.NewRow();
                    table.Rows.Add(newRow);
                    dptr.InsertCommand = new MySqlCommand($"INSERT INTO `dice_travel`.`users` (`login_name`, `pswd`,`sur_name`,`first_name`,`birth_date`) VALUES ('{loginName}', '{password}','{InputSignUpSurname.Text}','{InputSignUpFirstName.Text}','{DatePickerSignUpBirthDate.Value.Date.ToString("yyy-MM-dd")}');", new MySqlConnection(connString));
                    dptr.InsertCommand.Dispose();
                    dptr.Update(table);
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
