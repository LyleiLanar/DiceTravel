using DiceTravel.Classes;
using DiceTravel.Controls;
using DiceTravel.Forms.JourneyForms;
using DiceTravel.Forms.TripForms;
using DiceTravel.Util;
using System;
using System.Collections.Generic;
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
            GrpBxNextTripData.Visible = false;
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
            GrpBxNextTripData.Visible = true;
            GrpBxMainFrame.Visible = true;
            MenuMainLogout.Enabled = true;
            MenuMainLogin.Enabled = false;
            MenuMainSignUp.Enabled = false;
            MenuMe.Enabled = true;
        }
        public void UpdateData()
        {
            if (ActiveUserStore.IsThereActiveUser)
            {
                Program.mainForm.ChangeControlsAvailabilityAfterLogin();
                UpdateUserData();
                UpdateActiveJourneyData();
                UpdateNextDestiantionData();
            }
            else
            {
                Program.mainForm.ChangeControlsAvailabilityAfterLogout();
            }
        }
        private void UpdateUserData()
        {
            User user = ActiveUserStore.ActiveUser;

            TxtUserDataLoginName.Text = user.LoginName;
            TxtUserDataBirthDate.Text = user.BirthDate.Substring(0, 12);
        }

        //journeyData methods
        private void UpdateActiveJourneyData()
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
                BtnNextDestReached.Enabled = true;

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
                BtnNextDestReached.Enabled = false;
                PctBxActiveJourneyVisibility.Image = Properties.Resources.icoError.ToBitmap();
                PctBxNextDestVisibility.Image = Properties.Resources.icoError.ToBitmap();
            }
            TxtActiveJourneyInfo.Text = activeJourneyInfo;
            TxtActiveJourneyTitle.Text = activeJourneyTitle;
        }
        private void BtnMyJourneyDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All progress will be lost!\r\nAre you sure to delete this Journey?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Journey.GetJourney_ById(ActiveUserStore.GetActiveJourney().Id).DeleteItself();
            }
            Program.mainForm.UpdateData();
        }
        private void BtnNewJourney_Click(object sender, EventArgs e)
        {
            MenuMeNewJourney_Click(sender, e);
        }

        //tripData methods
        private void UpdateNextDestiantionData()
        {
            Journey activeJourney = ActiveUserStore.GetActiveJourney();
            if (activeJourney != null)
            {
                Trip activeTrip = ActiveUserStore.GetActiveJourney().GetLastTrip();
                if (activeTrip == null && activeJourney.Closed != 0)
                {
                    new TripCreateForm().Show();
                    UpdateData();
                }
                switch (activeTrip.Visibility)
                {
                    case 0:
                        PctBxNextDestVisibility.Image = Properties.Resources.icoVisibilityPrivate.ToBitmap();
                        break;

                    case 1:
                        PctBxNextDestVisibility.Image = Properties.Resources.icoVisibilityFriends.ToBitmap();
                        break;

                    case 2:
                        PctBxNextDestVisibility.Image = Properties.Resources.icoVisibilityPublic.ToBitmap();
                        break;

                    default:
                        PctBxNextDestVisibility.Image = Properties.Resources.icoError.ToBitmap();
                        break;
                }
                TxtNextDestTitle.Text = activeTrip.EndLocation;
            }
            else
            {
                TxtNextDestTitle.Text = "No active Journey!";
            }

        }
        private void BtnNextDestReached_Click(object sender, EventArgs e)
        {
            new TripCreateForm().Show();
        }

        //flowLayoutPanel
        public void UpdatePanelWithJourneyFlow()
        {
            FlowLayoutPanel.Controls.Clear();
            List<Journey> journeys = ActiveUserStore.ActiveUser.GetJourneys();

            List<JourneyControl> journeyControls = new List<JourneyControl>();

            foreach (Journey journey in journeys)
            {
                journeyControls.Add(new JourneyControl(journey));
                //FlowLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute));
            }

            for (int i = 0; i < journeyControls.Count; i++)
            {
                JourneyControl control = journeyControls[i];
                control.Name = $"JourneyControl_{i}";
                control.SetContent();
                control.Visible = true;
                FlowLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                FlowLayoutPanel.Controls.Add(control, 0, i);
            }
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

        private void MenuMeMyJourneys_Click(object sender, EventArgs e)
        {
            Program.mainForm.UpdatePanelWithJourneyFlow();
        }

        private void GrpBxMainFrame_Enter(object sender, EventArgs e)
        {

        }
    }
}
