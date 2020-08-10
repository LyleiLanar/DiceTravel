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

            int journeyId = activeJourney.Id;
            int serialNumber;
            string endLocation = InputTripCreateTripEndLocation.Text;
            DateTime endDate = DateTime.Parse(Properties.Settings.Default.nullDate);
            int visibility = 2;

            try
            {
                serialNumber = oldTrip.SerialNumber + 1;
            }
            catch (IndexOutOfRangeException)
            {
                serialNumber = 0;
            }
            catch (NullReferenceException)
            {
                serialNumber = 0;
            }

            if (this.RBtnTripCreateVisibilityPrivate.Checked) { visibility = 0; }
            if (this.RBtnTripCreateVisibilityOnlyFriends.Checked) { visibility = 1; }
            if (this.RBtnTripCreateVisibilityPublic.Checked) { visibility = 2; }

            Trip newTrip = new Trip(journeyId, serialNumber, endLocation, endDate, visibility);

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
        private void Validation(Trip newTrip)
        {
            newTrip.Validation();
            //nincs mit validálni egyelőre form szinten.
        }

        //MainForm Activation
        private void TripCreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainFormActivate();
        }
        private void TripCreateForm_Load(object sender, EventArgs e)
        {
            Program.MainFormDeactivate();
        }
       
    }
}

