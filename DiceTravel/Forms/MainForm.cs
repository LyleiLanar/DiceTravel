using DiceTravel.Util;
using System;
using System.Windows.Forms;

namespace DiceTravel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MenuMainSignin_Click(object sender, EventArgs e)
        {
            SignUpForm si = new SignUpForm();
            si.Text = Properties.Settings.Default.projectName + " - Regisztráció";
            si.Show();
        }
        private void MenuMainQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MenuMainLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Text = Properties.Settings.Default.projectName + " - Belépés";
            login.Show();
        }
        private void MenuMainLogout_Click(object sender, EventArgs e)
        {
            ActiveUserStore.LogOutUser();
        }
        public void DeactivateControls()
        {
            GrpBxUserData.Visible = false;
            GrpBxMainFrame.Visible = false;
            MenuMainLogout.Enabled = false;
        }
        public void ActivateControls()
        {
            GrpBxUserData.Visible = true;
            GrpBxMainFrame.Visible = true;
            MenuMainLogout.Enabled = true;
        }
        public void RefreshMainFormUserData()
        {
            User user = ActiveUserStore.ActiveUser;

            if (ActiveUserStore.IsThereActiveUser)
            {
                Program.mainForm.ActivateControls();
                TxtUserDataLoginName.Text = user.LoginName;
                TxtUserDataRealName.Text = user.Surname + user.Firstname;
                TxtUserDataBirthDate.Text = user.BirthDate.Substring(0, 12);
            }
            else
            {
                Program.mainForm.DeactivateControls();
                TxtUserDataLoginName.Text = "-";
                TxtUserDataRealName.Text = "-";
                TxtUserDataBirthDate.Text = "-";
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Biztos kilépsz az alkalmazásból", "Megondoltad?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
