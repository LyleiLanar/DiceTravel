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
using System.Diagnostics;
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
            LogIn();
        }

        //MeMenu
        private void MenuMeMyJourneys_Click(object sender, EventArgs e)
        {
            SetFlowJourneyFlowByUserId(ActiveUserStore.ActiveUser.Id);
            Program.MainForm.DrawFlow();
        }
        private void MenuMeMyProfile_Click(object sender, EventArgs e)
        {
            Program.MainForm.UpdateUserData();
        }
        private void MenuMeMyFlow_Click(object sender, EventArgs e)
        {
            SetFlowStoryFlowByUserId(ActiveUserStore.ActiveUser.Id);
            Program.MainForm.DrawFlow();
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
                Program.MainForm.ChangeControlsAvailabilityAfterLogin();
                this.UpdateActiveUser();
                UpdateActiveJourneyData();
                UpdateTripData();
                DrawFlow();
            }
            else
            {
                Program.MainForm.ChangeControlsAvailabilityAfterLogout();
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
            Program.MainForm.FlowElementProvider.SetInvitesFlow();
            Program.MainForm.DrawFlow();
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
                BtnActiveJourneyModify.Enabled = true;

                MenuTravelingJourneyStart.Enabled = false;
                MenuTravelingJourneyMod.Enabled = true;
                MenuTravelingJourneyDel.Enabled = true;
                MenuTravelingDest.Enabled = true;
                MenuTravelingNewEntry.Enabled = true;

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
                BtnActiveJourneyModify.Enabled = false;

                MenuTravelingJourneyStart.Enabled = true;
                MenuTravelingJourneyMod.Enabled = false;
                MenuTravelingJourneyDel.Enabled = false;
                MenuTravelingDest.Enabled = false;
                MenuTravelingNewEntry.Enabled = false;

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
            UpdateActiveJourney();
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
            UpdateActiveTrip();
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
            Program.MainForm.BtnInvitations.Visible = Friendship.GetRecievedFriendshipInvitesByUserId(ActiveUserStore.ActiveUser.Id).Count != 0;

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
            SetFlowStoriesOfFriends();
        }
        private void BtnMyStoryFlow_Click(object sender, EventArgs e)
        {
            Program.MainForm.FlowElementProvider.SetStoryFlow(ActiveUserStore.ActiveUser.Id);
            Program.MainForm.DrawFlow();
        }
        private void BtnSearchUser_Click(object sender, EventArgs e)
        {
            Program.MainForm.FlowElementProvider.SetPeopleFlow(TxtSearchUser.Text);
            Program.MainForm.DrawFlow();
        }
        private void BtnFriends_Click(object sender, EventArgs e)
        {
            SetFlowFriendsOfActiveUser();
        }

        /*********  Command Methods *********/
        private void UpdateActiveJourney()
        {
            new JourneyUpdateForm(ActiveUserStore.GetActiveJourney()).Show();
        }
        private void DeleteActiveJourney()
        {
            if (MessageBox.Show("All progress will be lost!\r\nAre you sure to delete this Journey?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Journey.GetJourneyById(ActiveUserStore.GetActiveJourney().Id).DeleteItself();
                FlowElementProvider.SetJourneyFlow(ActiveUserStore.ActiveUser.Id);
                UpdateData();
            }
        }
        private void StartJourney()
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
        private void GoalReached()
        {
            new TripCreateForm().Show();
        }
        private void DestinationReached()
        {
            new TripCreateForm().Show();
        }
        private void UpdateActiveTrip()
        {
            new TripUpdateForm(ActiveUserStore.GetActiveJourney().GetLastTrip()).Show();
        }
        private void CreatrEntry()
        {
            new EntryCreateForm().Show();
        }
        private void UpdateUserData()
        {
            new UserUpdateForm().Show();
        }
        private void SetFlowJourneyFlowByUserId(int userId)
        {
            FlowElementProvider.SetJourneyFlow(userId);
        }
        private void SetFlowStoryFlowByUserId(int userId)
        {
            FlowElementProvider.SetStoryFlow(userId);
        }
        private void SetFlowFriendsOfActiveUser()
        {
            FlowElementProvider.SetFriendFlow();
            DrawFlow();
        }
        private void SetFlowStoriesOfFriends()
        {
            FlowElementProvider.SetFlowStoriesOfFriends();
            DrawFlow();
        }
        public void LogOut()
        {
            ActiveUserStore.LogOutUser();
            Program.MainForm.ChangeControlsAvailabilityAfterLogout();
        }
        public void LogIn()
        {
            new LoginForm().Show();
        }
        private void SignUp()
        {
            new SignUpForm().Show();
        }

        //rendezni való metódusok
        private void MenuTravelingJourneyMod_Click(object sender, EventArgs e)
        {
            UpdateActiveJourney();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            Program.MainForm.DrawFlow();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            LogIn();
        }

        private void MenuTravelingJourneyDel_Click(object sender, EventArgs e)
        {
            DeleteActiveJourney();
        }

        private void MenuTravelingDestDone_Click(object sender, EventArgs e)
        {
            GoalReached();
        }

        private void MenuTravelingDestMod_Click(object sender, EventArgs e)
        {
            UpdateActiveTrip();
        }

        private void MenuTravelingNewEntry_Click(object sender, EventArgs e)
        {
            CreatrEntry();
        }

        private void MenuFriendsMyFriends_Click(object sender, EventArgs e)
        {
            SetFlowFriendsOfActiveUser();
        }

        private void MenuHelpAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("nincs kész!", "Inforamtion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MenuHelpManual_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://drive.google.com/file/d/1lkJwu_nYrN63BbEKmltTThOfka98hF-9/view?usp=sharing");
            Process.Start(sInfo);
        }

        private void MenuFriendsSearch_Click(object sender, EventArgs e)
        {
            TxtSearchUser.Focus();
            TxtSearchUser.BorderStyle = BorderStyle.Fixed3D;
        }

        private void MenuFriendsEntries_Click(object sender, EventArgs e)
        {
            SetFlowStoriesOfFriends();
        }

        private void TxtActiveJourneyTitle_Click(object sender, EventArgs e)
        {
            Program.MainForm.FlowElementProvider.SetTripFlow(ActiveUserStore.GetActiveJourney().Id);
            DrawFlow();
        }

        private void TxtNextTripTitle_Click(object sender, EventArgs e)
        {
                Program.MainForm.FlowElementProvider.SetEntryFlow(ActiveUserStore.GetActiveJourney().GetLastTrip().Id);
                DrawFlow();            
        }

        private void TxtSearchUser_TextChanged(object sender, EventArgs e)
        {
            if (TxtSearchUser.Text.Length >2)
            {
                BtnSearchUser.Enabled = true;
            }
            else
            {
                BtnSearchUser.Enabled = false;
            }
        }

        private void TxtSearchUser_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13 && TxtSearchUser.Text.Length > 2)
            {
                BtnSearchUser_Click(TxtSearchUser, new EventArgs());
            }
        }
    }
}
