using DiceTravel.Classes;
using DiceTravel.Controls;
using DiceTravel.EntityClasses;
using DiceTravel.Forms.EntryForms;
using DiceTravel.Forms.JourneyForms;
using DiceTravel.Forms.TripForms;
using DiceTravel.Forms.UserForms;
using DiceTravel.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DiceTravel
{
    public partial class MainForm : Form
    {
        public FlowElementProvider FlowElementProvider { get; }
        public MainForm()
        {
            InitializeComponent();
            FlowElementProvider = new FlowElementProvider();
        }

        /*********  MainForm Methods *********/
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
        private void ChangeControlsAvailabilityAfterLogout()
        {
            GrpBxUserData.Visible = false;
            GrpBxActiveJourneyData.Visible = false;
            GrpBxActiveTripData.Visible = false;
            GrpBxMainFrame.Visible = false;
            MenuMainLogout.Enabled = false;
            MenuMainLogin.Enabled = true;
            MenuMainSignUp.Enabled = true;
            MenuMe.Enabled = false;
            MenuTraveling.Enabled = false;
            MenuFriends.Enabled = false;
            BtnNewEntry.Visible = false;
        }
        private void ChangeControlsAvailabilityAfterLogin()
        {
            GrpBxUserData.Visible = true;
            GrpBxActiveJourneyData.Visible = true;
            GrpBxActiveTripData.Visible = true;
            GrpBxMainFrame.Visible = true;
            MenuMainLogout.Enabled = true;
            MenuMainLogin.Enabled = false;
            MenuMainSignUp.Enabled = false;
            MenuMe.Enabled = true;
            MenuTraveling.Enabled = true;
            MenuFriends.Enabled = true;
            BtnNewEntry.Visible = true;
        }

        /********* Menu ActionMethods *********/
        //MainMenu
        private void MenuMainSignUp_Click(object sender, EventArgs e)
        {
            SignUp();
        }
        private void MenuMainQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void MenuMainLogin_Click(object sender, EventArgs e)
        {
            LogIn();
        }
        public void MenuMainLogout_Click(object sender, EventArgs e)
        {
            LogOut();
        }

        //MeMenu
        private void MenuMeMyJourneys_Click(object sender, EventArgs e)
        {
            SetFlowMyJourneys();
        }
        private void MenuMeMyProfile_Click(object sender, EventArgs e)
        {
            MainForm.UpdateUserData();
        }
        private void MenuMeMyFlow_Click(object sender, EventArgs e)
        {
            SetFlowMyJourneys();
        }

        //TravelMenu
        private void MenuMeGoalReached_Click(object sender, EventArgs e)
        {
            GoalReached();
        }
        private void MenuMeNewJourney_Click(object sender, EventArgs e)
        {
            StartJourney();
        }
        private void MenuTravelingJourneyStart_Click(object sender, EventArgs e)
        {
            StartJourney();
        }

        //FriendsMenu

        //HelpMenu

        /*********  Data GroupBox Methods *********/
        //Common
        public void UpdateData()
        {
            if (ActiveUserStore.IsThereActiveUser)
            {
                Program.mainForm.ChangeControlsAvailabilityAfterLogin();
                this.UpdateActiveUser();
                UpdateActiveJourneyData();
                UpdateTripData();
                DrawFlow();
            }
            else
            {
                Program.mainForm.ChangeControlsAvailabilityAfterLogout();
            }
        }

        //userData
        private void UpdateActiveUser()
        {
            User user = ActiveUserStore.ActiveUser;

            TxtUserDataLoginName.Text = user.LoginName;
        }
        private void BtnMyDataModify_Click(object sender, EventArgs e)
        {
            UpdateUserData();
        }
        private void BtnInvitations_Click(object sender, EventArgs e)
        {
            Program.mainForm.FlowElementProvider.SetFlowInvitesFlow();
            Program.mainForm.DrawFlow();
        }

        //journeyData
        private void UpdateActiveJourneyData()
        {
            Journey activeJourney = ActiveUserStore.GetActiveJourney();
            string activeJourneyInfo;
            string activeJourneyTitle;

            if (activeJourney != null)
            {
                activeJourneyTitle = activeJourney.Title;
                activeJourneyInfo = $"Start: {activeJourney.StartLocation}";
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
            DeleteActiveJourney();
        }
        private void BtnNewJourney_Click(object sender, EventArgs e)
        {
            StartJourney();
        }
        private void BtnActiveJourneyModify_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //tripData
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
        private void BtnNewEntry_Click(object sender, EventArgs e)
        {
            CreatrEntry();
        }
        private void BtnNextTripModify_Click(object sender, EventArgs e)
        {
            TripUpdateForm tpf = new TripUpdateForm(ActiveUserStore.GetActiveJourney().GetLastTrip());
            tpf.Show();
        }
        private void BtnNextDestReached_Click(object sender, EventArgs e)
        {
            DestinationReached();
        }

        /*********  Flow Methods *********/
        //flowLayoutPanel
        public void DrawFlow()
        {
            FlowElementProvider.UpdateFlow();
            Program.mainForm.BtnInvitations.Visible = Friendship.GetUserRecievedInvitesByUserId(ActiveUserStore.ActiveUser.Id).Count != 0;

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

        }

        //RightSide Buttons and Search
        private void BtnMyJourney_Click(object sender, EventArgs e)
        {
            SetFlowMyJourneys();
        }
        private void BtnMyStoryFlow_Click(object sender, EventArgs e)
        {
            Program.mainForm.FlowElementProvider.SetFlowStoryFlowByUser(ActiveUserStore.ActiveUser.Id);
            Program.mainForm.DrawFlow();
        }
        private void BtnSearchUser_Click(object sender, EventArgs e)
        {
            Program.mainForm.FlowElementProvider.SetFlowPeopleFlowByLoginNameFragment(TxtSearchUser.Text);
            Program.mainForm.DrawFlow();
        }
        private void BtnFriends_Click(object sender, EventArgs e)
        {
            FlowElementProvider.SetFlowPeopleFlowByUserFriends();
            Program.mainForm.DrawFlow();
        }

        /*********  Command Methods *********/
        private static void DeleteActiveJourney()
        {
            if (MessageBox.Show("All progress will be lost!\r\nAre you sure to delete this Journey?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Journey.GetJourney_ById(ActiveUserStore.GetActiveJourney().Id).DeleteItself();
                Program.mainForm.FlowElementProvider.SetFlowJourneyFlowByUser(ActiveUserStore.ActiveUser.Id);
                Program.mainForm.UpdateData();
            }
        }
        private static void StartJourney()
        {
            if (ActiveUserStore.IsThereActiveUser && !ActiveUserStore.IsThereActiveJourney())
            {

                JourneyCreateForm journeyCreateForm = new JourneyCreateForm()
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
        private static void GoalReached()
        {
            new TripCreateForm().Show();
        }
        private static void DestinationReached()
        {
            new TripCreateForm().Show();
        }
        private static void CreatrEntry()
        {
            new EntryCreateForm().Show();
        }
        private static void UpdateUserData()
        {
            new UserUpdateForm().Show();
        }
        private static void SetFlowMyJourneys()
        {
            Program.mainForm.FlowElementProvider.SetFlowJourneyFlowByUser(ActiveUserStore.ActiveUser.Id);
            Program.mainForm.DrawFlow();
        }
        private static void LogOut()
        {
            ActiveUserStore.LogOutUser();
            Program.mainForm.ChangeControlsAvailabilityAfterLogout();
        }
        private static void LogIn()
        {
            new LoginForm().Show();
        }
        private static void SignUp()
        {
            new SignUpForm().Show();
        }
        private void MenuTravelingJourneyMod_Click(object sender, EventArgs e)
        {

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Program.mainForm.DrawFlow();
        }


    }
}
