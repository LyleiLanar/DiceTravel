using DiceTravel.Classes;
using DiceTravel.Forms.TripForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiceTravel.Controls
{
    public partial class TripControl : FlowElementControl
    {
        private Trip Trip { get; }


        public TripControl(Trip trip) : base()
        {
            InitializeComponent();

            Trip = trip;
            if (Trip.EndDate == DateTime.Parse(Properties.Settings.Default.nullDate))
            {
                BorderStyle = BorderStyle;
                BorderStyle = BorderStyle.FixedSingle;
                HighlightedColor = Color.LightSalmon;
                OriginalColor = Color.Salmon;
            }

            BackColor = OriginalColor;
            SetContent();
        }

        public void SetContent()
        {
            Journey journey = Journey.GetJourneyById(Trip.JourneyId);
            string userLoginName = User.GetUserById(Journey.GetJourneyById(Trip.JourneyId).UserId).LoginName;

            TxtTripUserLoginName.Text = userLoginName;
            TxtTripEndLocation.Text = journey.Title + ": " + Trip.EndLocation;
            TxtTripEndDate.Text = Trip.EndDate == DateTime.Parse(Properties.Settings.Default.nullDate) ? "in progress..." : $"Reached: {Trip.EndDate}";

            switch (Trip.Visibility)
            {
                case 0:
                    PctBxTripVisibility.Image = Properties.Resources.icoVisibilityPrivate.ToBitmap();
                    break;

                case 1:
                    PctBxTripVisibility.Image = Properties.Resources.icoVisibilityFriends.ToBitmap();
                    break;

                case 2:
                    PctBxTripVisibility.Image = Properties.Resources.icoVisibilityPublic.ToBitmap();
                    break;

                default:
                    PctBxTripVisibility.Image = Properties.Resources.icoEmpty.ToBitmap();
                    break;
            }
        }

        private void TripControl_Click(object sender, EventArgs e)
        {
            Program.MainForm.FlowElementProvider.SetFlowEntryFlowByTrip(Trip.Id);
            Program.MainForm.DrawFlow();
        }

        private void BtnTripBackToJourney_Click(object sender, EventArgs e)
        {
            User user = User.GetUserById(Journey.GetJourneyById(Trip.JourneyId).UserId);
            Program.MainForm.FlowElementProvider.SetFlowJourneyFlowByUser(user.Id);
            Program.MainForm.DrawFlow();
        }

        private void BtnTripOptions_Click(object sender, EventArgs e)
        {
            new TripUpdateForm(Trip).Show();
        }
    }
}
