using DiceTravel.Classes;

namespace DiceTravel.Controls
{
    public partial class TripControl : FlowElementControl
    {
        private Trip Trip { get; }


        public TripControl(Trip trip)
        {
            Trip = trip;
            InitializeComponent();
            SetContent();
        }

        public void SetContent()
        {

            string userLoginName = User.GetUser_ById(Journey.GetJourney_ById(Trip.JourneyId).UserId).LoginName;

            TxtTripUserLoginName.Text = userLoginName;
            TxtTripEndLocation.Text = Trip.EndLocation;
            TxtTripEndDate.Text = Trip.EndDate == Properties.Settings.Default.nullDate ? "in progress..." : $"Reached: {Trip.EndDate}";

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
                    PctBxTripVisibility.Image = Properties.Resources.icoError.ToBitmap();
                    break;
            }
        }
    }
}
