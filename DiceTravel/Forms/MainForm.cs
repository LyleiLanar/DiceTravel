using DiceTravel.Classes;
using DiceTravel.Controls;
using DiceTravel.Forms.JourneyForms;
using DiceTravel.Forms.TripForms;
using DiceTravel.Forms.EntryForms;
using DiceTravel.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DiceTravel.Forms.UserForms;

namespace DiceTravel
{
    public partial class MainForm : Form
    {
        public FlowElementProvider FlowElementProvider { get; }
        public MainForm()
        {
            FlowElementProvider = new FlowElementProvider();
            InitializeComponent();
        }

        //mainMenu Mainmethods
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
            Application.Exit();
        }
        private void MenuMainLogin_Click(object sender, EventArgs e)
        {

            LoginForm login = new LoginForm
            {
                Text = Properties.Settings.Default.projectName + " - LogIn"
            };

            login.Show();

        }
        public void MenuMainLogout_Click(object sender, EventArgs e)
        {
            ActiveUserStore.LogOutUser();
            Program.mainForm.ChangeControlsAvailabilityAfterLogout();
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
        public void UpdateData()
        {
            if (ActiveUserStore.IsThereActiveUser)
            {
                Program.mainForm.ChangeControlsAvailabilityAfterLogin();
                UpdateUserData();
                UpdateActiveJourneyData();
                UpdateTripData();
                DrawFlow();
            }
            else
            {
                Program.mainForm.ChangeControlsAvailabilityAfterLogout();
            }
        }

        //userData Formmethods
        private void UpdateUserData()
        {
            User user = ActiveUserStore.ActiveUser;

            TxtUserDataLoginName.Text = user.LoginName;
        }

        //control availability methods
        public void ChangeControlsAvailabilityAfterLogout()
        {
            GrpBxUserData.Visible = false;
            GrpBxActiveJourneyData.Visible = false;
            GrpBxActiveTripData.Visible = false;
            GrpBxMainFrame.Visible = false;
            MenuMainLogout.Enabled = false;
            MenuMainLogin.Enabled = true;
            MenuMainSignUp.Enabled = true;
            MenuMe.Enabled = false;
            BtnNewEntry.Visible = false;
        }
        public void ChangeControlsAvailabilityAfterLogin()
        {
            GrpBxUserData.Visible = true;
            GrpBxActiveJourneyData.Visible = true;
            GrpBxActiveTripData.Visible = true;
            GrpBxMainFrame.Visible = true;
            MenuMainLogout.Enabled = true;
            MenuMainLogin.Enabled = false;
            MenuMainSignUp.Enabled = false;
            MenuMe.Enabled = true;
            BtnNewEntry.Visible = true;
        }

        //journeyData Formmethods
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
                BtnNextTripReached.Enabled = true;
                BtnActiveJourneyDelete.Enabled = true;
                BtnNewEntry.Enabled = true;
                BtnNextTripModify.Enabled = true;

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
                        PctBxActiveJourneyVisibility.Image = Properties.Resources.icoEmpty.ToBitmap();
                        break;
                }
            }
            else
            {
                activeJourneyTitle = "No active Journey!";
                activeJourneyInfo = "Start a new one!";
                BtnActiveJourneyDelete.Enabled = false;
                BtnActiveJourneyNewJourney.Enabled = true;
                BtnNextTripReached.Enabled = false;
                BtnActiveJourneyDelete.Enabled = false;
                BtnNewEntry.Enabled = false;
                BtnNextTripModify.Enabled = false;
                PctBxActiveJourneyVisibility.Image = Properties.Resources.icoEmpty.ToBitmap();
                PctBxNextTripVisibility.Image = Properties.Resources.icoEmpty.ToBitmap();
            }
            TxtActiveJourneyInfo.Text = activeJourneyInfo;
            TxtActiveJourneyTitle.Text = activeJourneyTitle;
        }
        private void BtnMyJourneyDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All progress will be lost!\r\nAre you sure to delete this Journey?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Journey.GetJourney_ById(ActiveUserStore.GetActiveJourney().Id).DeleteItself();
                Program.mainForm.FlowElementProvider.SetFlow_JourneyFlow_ByUser(ActiveUserStore.ActiveUser.Id);
                Program.mainForm.UpdateData();
            }
        }
        private void BtnNewJourney_Click(object sender, EventArgs e)
        {
            MenuMeNewJourney_Click(sender, e);
        }

        //tripData Formmethods
        private void UpdateTripData()
        {
            Journey activeJourney = ActiveUserStore.GetActiveJourney();
            if (activeJourney != null)
            {
                Trip activeTrip = ActiveUserStore.GetActiveJourney().GetLastTrip();

                if (activeTrip == null && activeJourney.Closed != 1)
                {
                    new TripCreateForm().Show();
                }
                else
                {
                    switch (activeTrip.Visibility)
                    {
                        case 0:
                            PctBxNextTripVisibility.Image = Properties.Resources.icoVisibilityPrivate.ToBitmap();
                            break;

                        case 1:
                            PctBxNextTripVisibility.Image = Properties.Resources.icoVisibilityFriends.ToBitmap();
                            break;

                        case 2:
                            PctBxNextTripVisibility.Image = Properties.Resources.icoVisibilityPublic.ToBitmap();
                            break;

                        default:
                            PctBxNextTripVisibility.Image = Properties.Resources.icoEmpty.ToBitmap();
                            break;
                    }

                    TxtNextTripTitle.Text = activeTrip.EndLocation;
                    BtnNextTripModify.Enabled = true;
                }
            }
            else
            {
                TxtNextTripTitle.Text = "No active Journey!";
            }

        }
        private void BtnNextDestReached_Click(object sender, EventArgs e)
        {
            new TripCreateForm().Show();
        }

        //flowLayoutPanel
        public void DrawFlow()
        {
            FlowContainer.Visible = false;
            FlowElementProvider.UpdateFlow();
            FlowLayoutPanel.Controls.Clear();
            List<FlowElementControl> controls = new List<FlowElementControl>();
            controls.AddRange(FlowElementProvider.FlowElements);

            for (int i = 0; i < controls.Count; i++)
            {
                FlowElementControl control = controls[i];
                FlowLayoutPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                FlowLayoutPanel.Controls.Add(control, 0, i);
            }

            TxtFlowDataFlowTitle.Text = FlowElementProvider.FlowTitle;
            FlowContainer.Visible = true;
        }

        //misc methods
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?\r\nYou will be logged out!", "Are you sure? Really?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                ActiveUserStore.LogOutUser();
            }
            else
            {
                e.Cancel = true;
            }
        }
        public void MenuMeMyJourneys_Click(object sender, EventArgs e)
        {
            Program.mainForm.FlowElementProvider.SetFlow_JourneyFlow_ByUser(ActiveUserStore.ActiveUser.Id);
            Program.mainForm.DrawFlow();
        }

        private void BtnMyJourney_Click(object sender, EventArgs e)
        {
            MenuMeMyJourneys_Click(sender, e);
        }

        private void BtnNextTripModify_Click(object sender, EventArgs e)
        {           
            new TripUpdateForm(ActiveUserStore.GetActiveJourney().GetLastTrip()).Show();
        }

        private void MenuMeGoalReached_Click(object sender, EventArgs e)
        {
            new TripCreateForm().Show();
        }

        private void BtnNewEntry_Click(object sender, EventArgs e)
        {
            new EntryCreateForm().Show(); 
        }

        private void BtnAllEntries_Click(object sender, EventArgs e)
        {
            Program.mainForm.FlowElementProvider.SetFlow_StoryFlow_ByUser(ActiveUserStore.ActiveUser.Id);
            Program.mainForm.DrawFlow();
        }

        private void MenuMeMyProfile_Click(object sender, EventArgs e)
        {
           new UserUpdateForm().Show();
        }
    }
}
