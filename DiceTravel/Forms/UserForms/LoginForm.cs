using DiceTravel.Util;
using System;
using System.Windows.Forms;

namespace DiceTravel
{
    public partial class LoginForm : Form
    {
        public LoginForm():this("Tündi")
        {
            ;
        }

        public LoginForm(string inputName)
        {
            InitializeComponent();
            InputLoginLoginName.Text = inputName;
            Text = Properties.Settings.Default.projectName + " - LogIn";
        }
        private void BtnSignUpCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnSignUpLogin_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validation();

                string encryptedPassword = Encyptor.Encrypt(InputLoginPassword.Text);

                ActiveUserStore.LogInUser(InputLoginLoginName.Text, encryptedPassword);
                Program.MainForm.UpdateData();

                this.Close();
            }
            catch (ValidationException ex)
            { MessageBox.Show(ex.Message, "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }

            catch (EntityCreationException ex)
            { MessageBox.Show(ex.Message, "Login Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        public void Validation()
        {
            if (InputLoginLoginName.Text == "" || InputLoginPassword.Text == "")
            { throw new ValidationException("Missing Login name or Password!"); }
        }

        private void BtnLoginSignUp_Click(object sender, EventArgs e)
        {
            this.Close();
            new SignUpForm().Show();
        }

        //MainForm Activation
        private void LoginForm_Load(object sender, EventArgs e)
        {
            Program.MainFormDeactivate();
        }
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainFormActivate();
        }

    }
}
