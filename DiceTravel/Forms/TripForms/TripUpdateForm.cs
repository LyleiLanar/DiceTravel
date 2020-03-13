using DiceTravel.Classes;
using DiceTravel.Util;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiceTravel.Forms.TripForms
{
    public partial class TripUpdateForm : Form
    {
        private Trip Trip { get; }
        public TripUpdateForm(Trip trip)
        {
            InitializeComponent();
            Trip = trip;
            Journey journey = Journey.GetJourney_ById(Trip.JourneyId);

            if (Trip.EndDate == DateTime.Parse(Properties.Settings.Default.nullDate)) { BtnTripUpdateDelete.Enabled = false; }
            else { BtnTripUpdateDelete.BackColor = Color.Red; }

            this.Text = journey.Title + ": " + Trip.EndLocation + " update";
            this.InputTripUpdateEndLocation.Text = Trip.EndLocation;

            switch (Trip.Visibility)
            {
                case 0:
                    this.RBtnTripCreateUpdatePrivate.Checked = true;
                    break;

                case 1:
                    this.RBtnTripCreateUpdateOnlyFriends.Checked = true;
                    break;

                case 2:
                    this.RBtnTripCreateUpdatePublic.Checked = true;
                    break;

                default:
                    throw new Exception("No such visibility!");
            }


            if (journey.Closed == 1)
            {                
                InputTripUpdateEndLocation.Enabled = false;
                BtnTripUpdateDelete.Enabled = false;
                BtnTripUpdateDelete.BackColor = SystemColors.Control;
            }
        }

        private void BtnTripUpdateTrip_Click(object sender, EventArgs e)
        {
            Trip.EndLocation = this.InputTripUpdateEndLocation.Text;

            if (this.RBtnTripCreateUpdatePrivate.Checked) { Trip.Visibility = 0; }
            if (this.RBtnTripCreateUpdateOnlyFriends.Checked) { Trip.Visibility = 1; }
            if (this.RBtnTripCreateUpdatePublic.Checked) { Trip.Visibility = 2; }

            Trip.UpdateItself();

            Program.mainForm.UpdateData();
            this.Close();
        }
        private void TripUpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainFormActivate();
        }
        private void TripUpdateForm_Load(object sender, EventArgs e)
        {
            Program.MainFormDeactivate();
        }
        private void BtnTripUpdateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnTripUpdateDelete_Click(object sender, EventArgs e)
        {
            Trip.DeleteItself();
            Program.mainForm.UpdateData();
            this.Close();
        }
    }
}
