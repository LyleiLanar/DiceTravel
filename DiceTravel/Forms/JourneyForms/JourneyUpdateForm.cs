using DiceTravel.Classes;
using DiceTravel.Util;
using System;
using System.Windows.Forms;

namespace DiceTravel.Forms.JourneyForms
{
    public partial class JourneyUpdateForm : Form
    {
        private Journey Journey { get; }
        public JourneyUpdateForm(Journey journey)
        {
            InitializeComponent();
            Journey = journey;

            this.Text = journey.Title + "edit";

            InputJourneyUpdateStartLocation.Text = Journey.StartLocation;
            InputJourneyUpdateTitle.Text = Journey.Title;

            switch (Journey.Visibility)
            {
                case 0:
                    this.RBtnJourneyUpdateVisibilityPrivate.Checked = true;
                    break;

                case 1:
                    this.RBtnJourneyUpdateVisibilityOnlyFriends.Checked = true;
                    break;

                case 2:
                    this.RBtnJourneyUpdateVisibilityPublic.Checked = true;
                    break;

                default:
                    throw new Exception("No such visibility!");
            }
        }

        private void BtnJourneyUpdateOk_Click(object sender, EventArgs e)
        {
            Journey.StartLocation = InputJourneyUpdateStartLocation.Text;
            Journey.Title = InputJourneyUpdateTitle.Text;

            if (this.RBtnJourneyUpdateVisibilityPrivate.Checked) { Journey.Visibility = 0; }
            if (this.RBtnJourneyUpdateVisibilityOnlyFriends.Checked) { Journey.Visibility = 1; }
            if (this.RBtnJourneyUpdateVisibilityPublic.Checked) { Journey.Visibility = 2; }

            Journey.UpdateItself();

            Program.mainForm.UpdateData();
            this.Close();

        }
        private void BtnJourneyUpdateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void JourneyUpdateForm_Load(object sender, EventArgs e)
        {
            Program.MainFormDeactivate();
        }
        private void JourneyUpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainFormActivate();
        }

        private void BtnJourneyUpdateDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All progress will be lost!\r\nAre you sure to delete this Journey?", "Attention!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Journey.DeleteItself();
                Program.mainForm.FlowElementProvider.SetFlow_JourneyFlow_ByUser(ActiveUserStore.ActiveUser.Id);
                Program.mainForm.UpdateData();
                this.Close();
            }
        }
    }
}
