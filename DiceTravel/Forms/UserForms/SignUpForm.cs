using DiceTravel.Util;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using DiceTravel.Classes;

namespace DiceTravel
{
    public partial class SignUpForm : Form
    {
        //Constructor
        public SignUpForm()
        {
            InitializeComponent();
        }

        //Methods
        private void BtnSignUpCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnSignUpReg_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.LoginName = InputSignUpLoginName.Text; ;
            user.Password = InputSignUpPassword.Text;
            user.Surname = InputSignUpSurname.Text;
            user.Firstname = InputSignUpFirstName.Text;
            user.BirthDate = DatePickerSignUpBirthDate.Value.Date.ToString("yyy-MM-dd");
            try
            {
                Validation(user);
                user.CreateItself();
                this.Close();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "SignUp error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Validation(User user)
        {
            user.Validation();

            string query = $"SELECT count(login_name) as t " +
                $"FROM dice_travel.users where login_name like @login_name;";

            MySqlCommand sqlCommand = Entity.CreateCommand(query);
            sqlCommand.Parameters.Add("@login_name", MySqlDbType.VarChar,20);
            sqlCommand.Parameters["@login_name"].Value = InputSignUpLoginName.Text;

            DataTable table = Entity.ReadQueryTable(sqlCommand);
            int sameLoginNamesAmount = Int32.Parse(table.Rows[0]["t"].ToString());

            if (sameLoginNamesAmount != 0) { throw new ValidationException("Used Login Name!"); }
            if (InputSignUpPassword.Text == "") { throw new ValidationException("Missing Password!"); }
            if (InputSignUpPassword.Text != InputSignUpPasswordAgain.Text) { throw new ValidationException("Different Passwords!"); }
        }

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainFormActivate();
        }
        private void SignUpForm_Load(object sender, EventArgs e)
        {
            Program.MainFormDeactivate();
        }
    }
}
