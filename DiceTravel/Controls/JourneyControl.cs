using DiceTravel.Classes;
using System.Drawing;
using System.Windows.Forms;
using DiceTravel.Util;
using DiceTravel.Forms.JourneyForms;

namespace DiceTravel.Controls
{
    public partial class JourneyControl : FlowElementControl
    {
        public Journey Journey { get; }

        public JourneyControl(Journey journey) : base()
        {
            Journey = journey;
            if (Journey.Closed == 0)
            {
                BorderStyle = BorderStyle.FixedSingle;
                HighlightedColor = Color.LightSalmon;
                OriginalColor = Color.Salmon;
            }

            //ha privát a journey és nem a gazdája nézni akkor nem látható
            //ezt viszont db-ből kellene megoldani
            if (Journey.Visibility == 0 && ActiveUserStore.ActiveUser.Id != Journey.UserId)
            {
                this.Visible = false;
            }

            InitializeComponent();
            BackColor = OriginalColor;
            SetContent();
        }

        public void SetContent()
        {
            string userLoginName = User.GetUserById(Journey.UserId).LoginName;

            TxtJourneyUserLoginName.Text = userLoginName;
            TxtJourneyTitle.Text = Journey.Closed == 0 ? Journey.Title : Journey.Title + " (Closed)";
            TxtJourneyStartDate.Text = Journey.StartLocation + ", " + Journey.StartDate;

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
                    PctBxJourneyVisibility.Image = Properties.Resources.icoEmpty.ToBitmap();
                    break;
            }
        }

        private void BtnJourneyOptions_Click(object sender, System.EventArgs e)
        {
            new JourneyUpdateForm(Journey).Show();
 
        }

        private void JourneyControl_Click(object sender, System.EventArgs e)
        {
            Program.MainForm.FlowElementProvider.SetTripFlow(this.Journey.Id);
            Program.MainForm.DrawFlow();
        }

 
    }
}
