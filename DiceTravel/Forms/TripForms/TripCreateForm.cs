using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiceTravel.Util;
using DiceTravel.Classes;

namespace DiceTravel.Forms.TripForms
{
    public partial class TripCreateForm : Form
    {
        public TripCreateForm()
        {
            InitializeComponent();
        }

        private void BtnTripCreateStart_Click(object sender, EventArgs e)
        {
            Trip oldTrip = ActiveUserStore.GetActiveJourney().GetLastTrip();
            oldTrip.EndDate = DateTime.Now;
            oldTrip.UpdateItself();

            Trip newTrip = new Trip
            {
                JourneyId = ActiveUserStore.GetActiveJourney().Id,
                EndLocation = InputTripCreateTripEndLocation.Text,
                EndDate = DateTime.Parse(Properties.Settings.Default.nullDate)
            };

            try
            {
            newTrip.SerialNumber = Journey.GetJourney_ById(newTrip.JourneyId).GetLastTrip().SerialNumber+1;
            }
            catch (IndexOutOfRangeException)
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
                Program.mainForm.UpdateData();
                this.Dispose();
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
            Journey journey = ActiveUserStore.GetActiveJourney();
            Trip trip = journey.GetLastTrip();

            journey.Closed = 1;
            journey.UpdateItself();

            trip.EndDate = DateTime.Now;
            trip.UpdateItself();

            Program.mainForm.UpdateData();
            Program.mainForm.Activate();
            this.Dispose();
        }
    }
    }

