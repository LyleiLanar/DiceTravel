using DiceTravel.Classes;
using DiceTravel.Forms.JourneyForms;
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

        //mainMenu methods
        private void MenuMainSignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm
            {
                Text = Properties.Settings.Default.projectName + " - Registration"
            };

            signUpForm.DatePickerSignUpBirthDate.Value = DateTime.Now;
            signUpForm.DatePickerSignUpBirthDate.MaxDate = DateTime.Now;
            signUpForm.Show();
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

        //control availability methods
        public void ChangeControlsAvailabilityAfterLogout()
        {
            GrpBxUserData.Visible = false;
            GrpBxActiveJourneyData.Visible = false;
            GrpBxMainFrame.Visible = false;
            MenuMainLogout.Enabled = false;
            MenuMainLogin.Enabled = true;
            MenuMainSignUp.Enabled = true;
            MenuMe.Enabled = false;
        }
        public void ChangeControlsAvailabilityAfterLogin()
        {
            GrpBxUserData.Visible = true;
            GrpBxActiveJourneyData.Visible = true;
            GrpBxMainFrame.Visible = true;
            MenuMainLogout.Enabled = true;
            MenuMainLogin.Enabled = false;
            MenuMainSignUp.Enabled = false;
            MenuMe.Enabled = true;
        }
        public void RefreshMainForm()
        {
            if (ActiveUserStore.IsThereActiveUser)
            {
                Program.mainForm.ChangeControlsAvailabilityAfterLogin();
                RefreshMainFormActiveJourneyData();
                RefreshMainFormUserData();
            }
            else
            {
                Program.mainForm.ChangeControlsAvailabilityAfterLogout();
            }
        }
        private void RefreshMainFormActiveJourneyData()
        {
            Journey activeJourney = Journey.GetJourney_ById(ActiveUserStore.GetActiveJourneyId());

            if (activeJourney != null)
            {
                TxtUserDataJourneyTitle.Visible = true;
                TxtMainFormJourneyDataStartDate.Visible = true;
                TxtMainFormJourneyDataStartLocation.Visible = true;
                TxtMainFormJourneyDataVisibility.Visible = true;

                BtnMyJourneyDelete.Enabled = true;
                BtnNewJourney.Enabled = false;

                TxtUserDataJourneyTitle.Text = activeJourney.Title;
                TxtMainFormJourneyDataStartLocation.Text = activeJourney.StartLocation;
                TxtMainFormJourneyDataStartDate.Text = activeJourney.StartDate;
                TxtMainFormJourneyDataVisibility.Text = activeJourney.GetVisibilityAsString;
            }
            else
            {
                TxtUserDataJourneyTitle.Visible = false;
                TxtMainFormJourneyDataStartDate.Visible = false;
                TxtMainFormJourneyDataStartLocation.Visible = false;
                TxtMainFormJourneyDataVisibility.Visible = false;

                BtnMyJourneyDelete.Enabled = false;
                BtnNewJourney.Enabled = true;

            }
        }
        private void RefreshMainFormUserData()
        {
            User user = ActiveUserStore.ActiveUser;

            TxtUserDataLoginName.Text = user.LoginName;
            TxtUserDataBirthDate.Text = user.BirthDate.Substring(0, 12);
        }

        //journey methods
        private void BtnMyJourneyDelete_Click(object sender, EventArgs e)
        {
            Journey.GetJourney_ById(ActiveUserStore.GetActiveJourneyId()).DeleteItself();
        }

        private void BtnNewJourney_Click(object sender, EventArgs e)
        {
            MenuMeNewJourney_Click(sender, e);
        }

        //misc methods
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Are you sure? Really?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ActiveUserStore.LogOutUser();
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
