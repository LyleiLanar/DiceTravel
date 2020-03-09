using DiceTravel.Classes;
using DiceTravel.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceTravel.Forms.TripForms
{
    public partial class TripUpdateForm : Form
    {

        private readonly Trip trip;

        public TripUpdateForm()
        {
            InitializeComponent();

            Journey activeJourney = ActiveUserStore.ActiveUser.GetActiveJourney();
            trip = activeJourney.GetLastTrip();

            this.InputTripUpdateEndLocation.Text = trip.EndLocation;

            switch (trip.Visibility)
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

        }
        private void BtnTripUpdateTrip_Click(object sender, EventArgs e)
        {
            trip.EndLocation = this.InputTripUpdateEndLocation.Text;

            if (this.RBtnTripCreateUpdatePrivate.Checked) { trip.Visibility = 0; }
            if (this.RBtnTripCreateUpdateOnlyFriends.Checked) { trip.Visibility = 1; }
            if (this.RBtnTripCreateUpdatePublic.Checked) { trip.Visibility = 2; }

            trip.UpdateItself();

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
    }
}
