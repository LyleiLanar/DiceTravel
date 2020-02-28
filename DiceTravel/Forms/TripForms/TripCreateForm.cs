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
            Trip newTrip = new Trip();
            newTrip.JourneyId = ActiveUserStore.GetActiveJourney().Id;
            newTrip.EndLocation = InputTripCreateTripEndLocation.Text;
            newTrip.EndDate = Properties.Settings.Default.nullDate;

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

                DBDriver.InsertRow(newTrip.GetTableQueryString(), newTrip.GetInsertSql());
                Program.mainForm.RefreshMainForm();
                this.Dispose();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Goal validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Validation(Trip newTrip)
        {
            newTrip.Validation();
            //nincs mit validálni egyelőre form szinten.
        }

        private void BtnTripCreateEndJourney_Click(object sender, EventArgs e)
        {
            //ide kell az update parancs. Update-elni kell az akctive Journey-t és close kell neki
            //a LastTrip dátumát be kell állítani
            //majd frissítjük a main formot
            //aktiváljuk a main formot
            //bezárjuk ezt a formot.
        }
    }
    }

