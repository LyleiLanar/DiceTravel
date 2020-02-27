using DiceTravel.Util;
using System;
using System.Data;
using System.Windows.Forms;

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
            Program.mainFormActivate();
            this.Dispose();
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

                DBDriver.InsertRow(user.GetTableQueryString(), user.GetInsertSql());
                Program.mainFormActivate();
                this.Dispose();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "SignUp error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Validation(User user)
        {
            user.Validation();

            string queryString = $"SELECT count(login_name) as t " +
                $"FROM dice_travel.users where login_name like '{InputSignUpLoginName.Text}';";
            DataTable countLoginNames = DBDriver.ReadQuery(queryString);
            int sameLoginNamesAmount = Int32.Parse(countLoginNames.Rows[0]["t"].ToString());

            if (sameLoginNamesAmount != 0) { throw new ValidationException("Used Login Name!"); }
            if (InputSignUpPassword.Text == "") { throw new ValidationException("Missing Password!"); }
            if (InputSignUpPassword.Text != InputSignUpPasswordAgain.Text) { throw new ValidationException("Different Passwords!"); }
        }
    }
}
