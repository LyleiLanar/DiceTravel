using DiceTravel.Classes;
using DiceTravel.Forms.JourneyForms;
using DiceTravel.Forms.TripForms;
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
            Program.mainFormDeactivate();
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
            Program.mainFormDeactivate();
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
            Program.mainFormDeactivate();
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
            GrpBxNextDestinationData.Visible = false;
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
            GrpBxNextDestinationData.Visible = true;
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
                RefreshUserData();
                RefreshActiveJourneyData();
                RefreshNextDestiantionData();
            }
            else
            {
                Program.mainForm.ChangeControlsAvailabilityAfterLogout();
            }
        }
        private void RefreshUserData()
        {
            User user = ActiveUserStore.ActiveUser;

            TxtUserDataLoginName.Text = user.LoginName;
            TxtUserDataBirthDate.Text = user.BirthDate.Substring(0, 12);
        }
        private void RefreshActiveJourneyData()
        {
            Journey activeJourney = ActiveUserStore.GetActiveJourney();
            string activeJourneyInfo;
            string activeJourneyTitle;

            if (activeJourney != null)
            {
                activeJourneyTitle = activeJourney.Title;
                activeJourneyInfo = $"({activeJourney.StartLocation})";
                BtnActiveJourneyDelete.Enabled = true;
                BtnActiveJourneyNewJourney.Enabled = false;

                switch (activeJourney.Visibility)
                {
                    case 0:
                        PctBxActiveJourneyVisibility.Image = Properties.Resources.icoVisibilityPrivate.ToBitmap();
                        break;

                    case 1:
                        PctBxActiveJourneyVisibility.Image = Properties.Resources.icoVisibilityFriends.ToBitmap();
                        break;

                    case 2:
                        PctBxActiveJourneyVisibility.Image = Properties.Resources.icoVisibilityPublic.ToBitmap();
                        break;

                    default:
                        PctBxActiveJourneyVisibility.Image = Properties.Resources.icoError.ToBitmap();
                        break;
                }
            }
            else
            {
                activeJourneyTitle = "No active Journey!";
                activeJourneyInfo = "Start a new one!";
                BtnActiveJourneyDelete.Enabled = false;
                BtnActiveJourneyNewJourney.Enabled = true;
                PctBxActiveJourneyVisibility.Image = Properties.Resources.icoError.ToBitmap();
            }
            TxtActiveJourneyInfo.Text = activeJourneyInfo;
            TxtActiveJourneyTitle.Text = activeJourneyTitle;
        }
        private void RefreshNextDestiantionData()
        {
            Journey activeJourney = ActiveUserStore.GetActiveJourney();
            if (activeJourney != null)
            {
                Trip activeTrip = ActiveUserStore.GetActiveJourney().GetLastTrip();
                if (activeTrip == null && activeJourney.Closed != 0)
                {
                    new TripCreateForm().Show();
                    RefreshMainForm();
                }

                TxtNextDestTitle.Text = activeTrip.EndLocation;
            }
            else
            {
                TxtNextDestTitle.Text = "No active Journey!";
            }

        }

        //journey methods
        private void BtnMyJourneyDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All progress will be lost!\r\nAre you sure to delete this Journey?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Journey.GetJourney_ById(ActiveUserStore.GetActiveJourney().Id).DeleteItself();
            }
        }

        private void BtnNewJourney_Click(object sender, EventArgs e)
        {
            MenuMeNewJourney_Click(sender, e);
        }

        //misc methods
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?\r\nYou will be logged out!", "Are you sure? Really?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
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
