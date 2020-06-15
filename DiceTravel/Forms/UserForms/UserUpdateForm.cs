using DiceTravel.Classes;
using DiceTravel.Util;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            User user = new User();
            User activeUser = ActiveUserStore.ActiveUser;
            user.Id = activeUser.Id;
            user.LoginName = activeUser.LoginName;
            if (InputUserUpdateFormPassword.Text == "")
            {
                user.Password = activeUser.Password;
            }
            else
            {
                user.Password = InputUserUpdateFormPassword.Text;
            }
            user.Surname = InputUserUpdateFormSurname.Text;
            user.Firstname = InputUserUpdateFormFirstName.Text;
            user.BirthDate = DatePickerUserUpdateFormBirthDate.Value.Date.ToString("yyy-MM-dd");

            try
            {
                Validation(user);
                user.UpdateItself();
                this.Close();
                Program.mainForm.MenuMainLogout_Click(this, new EventArgs());
                new LoginForm().Show();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "SignUp error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Validation(User user)
        {
            user.Validation();

            // itt ha nincs beírva semmi, akkor nem kerül frissítésre a jelszó, de ehhez mindkét helyen üresstringnek kell lennie.
            // if (InputUserUpdateFormPassword.Text == "") { throw new ValidationException("Missing Password!"); } 
            if (InputUserUpdateFormPassword.Text != InputUserUpdateFormPasswordAgain.Text) { throw new ValidationException("Different Passwords!"); }
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
