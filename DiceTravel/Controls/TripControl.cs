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
                highlightedColor = SystemColors.ControlDarkDark;
                originalColor = SystemColors.ControlDark;
            }

            Trip = trip;
            InitializeComponent();
            BackColor = originalColor;
            SetContent();
        }

        public void SetContent()
        {
            string userLoginName = User.GetUser_ById(Journey.GetJourney_ById(Trip.JourneyId).UserId).LoginName;

            TxtTripUserLoginName.Text = userLoginName;
            TxtTripEndLocation.Text = Trip.EndLocation;
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
    }
}
