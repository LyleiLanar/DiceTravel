using DiceTravel.Classes;
using DiceTravel.Util;
using System;
using System.Windows.Forms;

namespace DiceTravel.Forms.JourneyForms
{
    public partial class JourneyCreateForm : Form
    {
        public JourneyCreateForm()
        {
            InitializeComponent();
        }

        private void BtnJourneyCreateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnJourneyCreateStart_Click(object sender, EventArgs e)
        {
            int userId = ActiveUserStore.ActiveUser.Id;
            string title = $"{this.InputJourneyCreateJourneyTitle.Text}";
            string startLocation = $"{this.InputJourneyCreateJourneyStartLocation.Text}";
            string startDate = DateTime.Now.ToString("yyy-MM-dd HH:mm:ss");
            int closed = 0;
            int journeyVisibility = 0;

            if (this.RBtnJourneyCreateVisibilityPrivate.Checked) { journeyVisibility = 0; }
            if (this.RBtnJourneyCreateVisibilityOnlyFriends.Checked) { journeyVisibility = 1; }
            if (this.RBtnJourneyCreateVisibilityPublic.Checked) { journeyVisibility = 2; }

            Journey newJourney = new Journey(userId, title, startLocation, startDate, closed, journeyVisibility);
        
            try
            {
                Validation(newJourney);
                newJourney.CreateItself();
                newJourney = ActiveUserStore.GetActiveJourney();

                try
                {
                    int journeyId = newJourney.Id;
                    int serialNumber = 0;
                    string endLocation = InputJourneyCreateJourneyFirstDest.Text;
                    DateTime endDate = DateTime.Parse(Properties.Settings.Default.nullDate);
                    int tripVisibility = newJourney.Visibility;

                    Trip newTrip = new Trip(journeyId, serialNumber, endLocation, endDate, tripVisibility);

                    Validation(newTrip);
                    newTrip.CreateItself();

                    Program.MainForm.UpdateData();
                    this.Close();
                }
                catch (ValidationException ex)
                {
                    newJourney.DeleteItself();
                    MessageBox.Show(ex.Message, "Trip creation error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Journey creation error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void JourneyCreateForm_Load(object sender, EventArgs e)
        {
            Program.MainFormDeactivate();
        }
        private void JourneyCreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainFormActivate();
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