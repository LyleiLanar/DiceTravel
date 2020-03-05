using DiceTravel.Classes;
using System.Drawing;
using System.Windows.Forms;

namespace DiceTravel.Controls
{
    public partial class JourneyControl : FlowElementControl
    {
        public Journey Journey { get; }

        public JourneyControl(Journey journey)
        {
            Journey = journey;
            InitializeComponent();
            SetContent();
        }

        public void SetContent()
        {
            string userLoginName = User.GetUser_ById(Journey.UserId).LoginName;

            TxtJourneyUserLoginName.Text = userLoginName;
            TxtJourneyTitle.Text = Journey.Closed == 0 ? Journey.Title : Journey.Title + " (Closed)";
            TxtJourneyStartDate.Text = Journey.StartLocation + ", " + Journey.StartDate;

            if (Journey.Closed == 0)
            {
                BorderStyle = BorderStyle.FixedSingle;
            }

            switch (Journey.Visibility)
            {
                case 0:
                    PctBxJourneyVisibility.Image = Properties.Resources.icoVisibilityPrivate.ToBitmap();
                    break;

                case 1:
                    PctBxJourneyVisibility.Image = Properties.Resources.icoVisibilityFriends.ToBitmap();
                    break;

                case 2:
                    PctBxJourneyVisibility.Image = Properties.Resources.icoVisibilityPublic.ToBitmap();
                    break;

                default:
                    PctBxJourneyVisibility.Image = Properties.Resources.icoError.ToBitmap();
                    break;
            }
        }

        private void BtnJourneyOptions_Click(object sender, System.EventArgs e)
        {

        }

        private void JourneyControl_Click(object sender, System.EventArgs e)
        {
            Program.mainForm.FlowElementProvider.SetFlow_TripsByJourney(this.Journey.Id);
            Program.mainForm.DrawFlow();
        }
    }
}
