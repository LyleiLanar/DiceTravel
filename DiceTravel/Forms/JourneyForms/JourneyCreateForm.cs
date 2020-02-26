using DiceTravel.Classes;
using DiceTravel.Forms.TripForms;
using DiceTravel.Util;
using System;
using System.Windows.Forms;

namespace DiceTravel.Forms.JourneyForms
{
    public partial class JourneyCreateForm : Form
    {
        TripCreateForm newTrip;

        public JourneyCreateForm()
        {
            newTrip = new TripCreateForm();
            InitializeComponent();
        }

        private void BtnJourneyCreateCancel_Click(object sender, EventArgs e)
        {
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

            try
            {
                Validation(newJourney);
                newTrip.Show();

                DBDriver.InsertRow(newJourney.GetTableQueryString(), newJourney.GetInsertSql());
                Program.mainForm.RefreshMainForm();
                this.Dispose();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Journey creation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Validation(Journey newJourney)
        {
            newJourney.Validation();
            //nincs mit validálni egyelőre form szinten.
        }
    }
}
