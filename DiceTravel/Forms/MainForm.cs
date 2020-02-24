using DiceTravel.Util;
using DiceTravel.Forms.JourneyForms;
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

        private void MenuMainSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm si = new SignUpForm
            {
                Text = Properties.Settings.Default.projectName + " - Registration"            
            };

            si.DatePickerSignUpBirthDate.Value = DateTime.Now;
            si.DatePickerSignUpBirthDate.MaxDate = DateTime.Now;
            si.Show();
        }
        private void MenuMainQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MenuMainLogin_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm
            {
                Text = Properties.Settings.Default.projectName + " - LogIn"
            };
            login.Show();
        }
        private void MenuMainLogout_Click(object sender, EventArgs e)
        {
            ActiveUserStore.LogOutUser();
        }
        public void ChangeControlsAvailabilityAfterLogout()
        {
            GrpBxUserData.Visible = false;
            GrpBxMainFrame.Visible = false;
            MenuMainLogout.Enabled = false;
            MenuMainLogin.Enabled = true;
            MenuMainSignUp.Enabled = true;
            MenuMe.Enabled = false;
        }
        public void ChangeControlsAvailabilityAfterLogin()
        {
            GrpBxUserData.Visible = true;
            GrpBxMainFrame.Visible = true;
            MenuMainLogout.Enabled = true;
            MenuMainLogin.Enabled = false;
            MenuMainSignUp.Enabled = false;
            MenuMe.Enabled = true;
        }
        public void RefreshMainFormUserData()
        {
            User user = ActiveUserStore.ActiveUser;

            if (ActiveUserStore.IsThereActiveUser)
            {
                Program.mainForm.ChangeControlsAvailabilityAfterLogin();
                TxtUserDataLoginName.Text = user.LoginName;
                TxtUserDataRealName.Text = user.Surname + user.Firstname;
                TxtUserDataBirthDate.Text = user.BirthDate.Substring(0, 12);
                InputTest.Text = ActiveUserStore.GetActiveJourneyId().ToString();
            }
            else
            {
                Program.mainForm.ChangeControlsAvailabilityAfterLogout();
                TxtUserDataLoginName.Text = "-";
                TxtUserDataRealName.Text = "-";
                TxtUserDataBirthDate.Text = "-";
            }
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ActiveUserStore.LogOutUser();
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void MenuMeNewJourney_Click(object sender, EventArgs e)
        {
            if (ActiveUserStore.IsThereActiveUser && !ActiveUserStore.IsThereActiveJourney())
            {
                JourneyCreateForm journeyCreateForm = new JourneyCreateForm
                {
                    Text = Properties.Settings.Default.projectName + " - New Journey"
                   
                };
                journeyCreateForm.Show();
            }
            else
            {
                MessageBox.Show("You've already started a journey!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
