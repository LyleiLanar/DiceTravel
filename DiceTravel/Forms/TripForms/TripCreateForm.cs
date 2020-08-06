using DiceTravel.Classes;
using DiceTravel.Util;
using System;
using System.Windows.Forms;

namespace DiceTravel.Forms.TripForms
{
    public partial class TripCreateForm : Form
    {
        public TripCreateForm()
        {
            InitializeComponent();
        }

        private void BtnTripCreateTrip_Click(object sender, EventArgs e)
        {
            Journey activeJourney = ActiveUserStore.GetActiveJourney();
            Trip oldTrip = activeJourney.GetLastTrip();

            oldTrip.EndDate = DateTime.Now;
            oldTrip.UpdateItself();

            Trip newTrip = new Trip
            {
                JourneyId = activeJourney.Id,
                EndLocation = InputTripCreateTripEndLocation.Text,
                EndDate = DateTime.Parse(Properties.Settings.Default.nullDate)
            };

            try
            {
                newTrip.SerialNumber = oldTrip.SerialNumber + 1;
            }
            catch (IndexOutOfRangeException)
            {
                newTrip.SerialNumber = 0;
            }
            catch (NullReferenceException)
            {
                newTrip.SerialNumber = 0;
            }

            if (this.RBtnTripCreateVisibilityPrivate.Checked) { newTrip.Visibility = 0; }
            if (this.RBtnTripCreateVisibilityOnlyFriends.Checked) { newTrip.Visibility = 1; }
            if (this.RBtnTripCreateVisibilityPublic.Checked) { newTrip.Visibility = 2; }

            try
            {
                Validation(newTrip);
                newTrip.CreateItself();
                Program.MainForm.UpdateData();
                this.Close();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Trip validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Validation(Trip newTrip)
        {
            newTrip.Validation();
            //nincs mit validálni egyelőre form szinten.
        }

        private void BtnTripCreateEndJourney_Click(object sender, EventArgs e)
        {
            Journey activeJourney = ActiveUserStore.ActiveUser.GetActiveJourney();
            if (MessageBox.Show("You're going to close this Journey. If you do this, you can't edit the Trips and Entries anymore!\r\n" +
                "Are you sure to lock this Journey?", "Closing Journey!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                activeJourney.CloseItself();
                Program.MainForm.UpdateData();
                this.Close();
            }
        }

        private void BtnTripCreateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TripCreateForm_Load(object sender, EventArgs e)
        {
            Program.MainFormDeactivate();
        }
        private void TripCreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainFormActivate();
        }
    }
}

