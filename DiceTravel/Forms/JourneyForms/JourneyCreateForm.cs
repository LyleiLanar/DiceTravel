using DiceTravel.Classes;
using DiceTravel.Forms.TripForms;
using DiceTravel.Util;
using System;
using System.Windows.Forms;

namespace DiceTravel.Forms.JourneyForms
{
    public partial class JourneyCreateForm : Form
    {
        TripCreateForm tripCreateFrom;

        public JourneyCreateForm()
        {
            tripCreateFrom = new TripCreateForm();
            InitializeComponent();
        }

        private void BtnJourneyCreateCancel_Click(object sender, EventArgs e)
        {
            Program.mainFormActivate();
            this.Dispose();
        }
        private void BtnJourneyCreateStart_Click(object sender, EventArgs e)
        {
            Journey newJourney = new Journey
            {
                UserId = ActiveUserStore.ActiveUser.Id,
                Title = $"{this.InputJourneyCreateJourneyTitle.Text}",
                StartDate = DateTime.Now.ToString("yyy-MM-dd HH:mm:ss"),
                Closed = 0,
                StartLocation = $"{this.InputJourneyCreateJourneyStartLocation.Text}",
                Visibility = 0
            };

            if (this.RBtnJourneyCreateVisibilityPrivate.Checked) { newJourney.Visibility = 0; }
            if (this.RBtnJourneyCreateVisibilityOnlyFriends.Checked) { newJourney.Visibility = 1; }
            if (this.RBtnJourneyCreateVisibilityPublic.Checked) { newJourney.Visibility = 2; }

            Trip newTrip = new Trip()
            {
                EndLocation = InputJourneyCreateJourneyFirstDest.Text,
                EndDate = Properties.Settings.Default.nullDate,
                Visibility = newJourney.Visibility,
            };

            try
            {
                Validation(newJourney);
                DBDriver.InsertRow(newJourney.GetTableQueryString(), newJourney.GetInsertSql());
                try
                {
                    newTrip.JourneyId = ActiveUserStore.GetActiveJourney().Id;
                    Validation(newTrip);
                    DBDriver.InsertRow(newTrip.GetTableQueryString(), newTrip.GetInsertSql());
                    Program.mainForm.RefreshMainForm();
                    Program.mainFormActivate();
                    this.Dispose();
                }
                catch (ValidationException ex)
                {
                    newJourney.DeleteItself();
                    MessageBox.Show(ex.Message, "Journey creation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Journey creation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Validation(Journey newJourney)
        {
            newJourney.Validation();
        }
        private void Validation(Trip newTrip)
        {
            newTrip.Validation();
        }
    }

}
