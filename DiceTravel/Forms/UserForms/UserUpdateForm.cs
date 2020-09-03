using DiceTravel.Util;
using System;
using System.Windows.Forms;

namespace DiceTravel.Forms.UserForms
{
    public partial class UserUpdateForm : Form
    {
        //Constructor
        public UserUpdateForm()
        {
            InitializeComponent();

            User activeUser = ActiveUserStore.ActiveUser;
            TxtUserUpdateFormTitle.Text = activeUser.LoginName;

            InputUserUpdateFormSurname.Text = activeUser.Surname;
            InputUserUpdateFormFirstName.Text = activeUser.Firstname;
            DatePickerUserUpdateFormBirthDate.Text = activeUser.BirthDate;
        }

        //Methods
        private void BtnUserUpdateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnUserUpdateSave_Click(object sender, EventArgs e)
        {
            //itt lesznek bajok, szóval meg kell nézni még

            int id;
            string loginName, encryptedPassword, surname, firstname, birthDate;

            id = ActiveUserStore.ActiveUser.Id;
            loginName = ActiveUserStore.ActiveUser.LoginName;


            if (InputUserUpdateFormPassword.Text.Length == 0)
            {
                encryptedPassword = ActiveUserStore.ActiveUser.Password;
            }
            else
            {
                encryptedPassword = Encyptor.Encrypt(InputUserUpdateFormPassword.Text);
            }

            surname = InputUserUpdateFormSurname.Text;
            firstname = InputUserUpdateFormFirstName.Text;
            birthDate = DatePickerUserUpdateFormBirthDate.Value.Date.ToString("yyy-MM-dd");

            User updatingUser = new User(encryptedPassword, loginName, surname, firstname, birthDate)
            {
                Id = id
            };

            try
            {
                Validation(updatingUser);
                updatingUser.UpdateItself();
                this.Close();
                Program.MainForm.LogOut();
                MessageBox.Show("Your modifications have been saved! Please login again!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Program.MainForm.LogIn();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "SignUp error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Validation(User user)
        {
            user.Validation();

            // itt ha nincs beírva semmi, akkor nem kerül frissítésre a jelszó, de ehhez mindkét helyen üresstringnek kell lennie.
            // if (InputUserUpdateFormPassword.Text == "") { throw new ValidationException("Missing Password!"); } 
            if (InputUserUpdateFormPassword.Text != InputUserUpdateFormPasswordAgain.Text) { throw new ValidationException("Different Passwords!"); }
        }

        //MainForm Activation
        private void UserUpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainFormActivate();
        }
        private void UserUpdateForm_Load(object sender, EventArgs e)
        {
            Program.MainFormDeactivate();
        }
    }
}
