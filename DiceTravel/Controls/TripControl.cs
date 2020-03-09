using DiceTravel.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiceTravel.Controls
{
    public partial class TripControl : FlowElementControl
    {
        private Trip Trip { get; }


        public TripControl(Trip trip): base()
        {
            if (trip.EndDate == DateTime.Parse(Properties.Settings.Default.nullDate))
            {
                BorderStyle = BorderStyle;
                BorderStyle = BorderStyle.FixedSingle;
                highlightedColor = Color.LightSalmon;
                originalColor = Color.Salmon;
            }

            Trip = trip;
            InitializeComponent();
            BackColor = originalColor;
            SetContent();
        }

        public void SetContent()
        {
            Journey journey = Journey.GetJourney_ById(Trip.JourneyId);
            string userLoginName = User.GetUser_ById(Journey.GetJourney_ById(Trip.JourneyId).UserId).LoginName;

            TxtTripUserLoginName.Text = userLoginName;
            TxtTripEndLocation.Text = journey.Title +": "+ Trip.EndLocation;
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
            Program.mainForm.FlowElementProvider.SetFlow_EntriesByTrip(Trip.Id);
            Program.mainForm.DrawFlow();
        }
    }
}
