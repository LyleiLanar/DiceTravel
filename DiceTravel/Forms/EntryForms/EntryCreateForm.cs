using DiceTravel.Classes;
using DiceTravel.Util;
using System;
using System.Windows.Forms;

namespace DiceTravel.Forms.EntryForms
{
    public partial class EntryCreateForm : Form
    {
        public EntryCreateForm()
        {
            InitializeComponent();
        }

        private void EntryCreateForm_Load(object sender, EventArgs e)
        {
            Program.MainFormDeactivate();
        }

        private void EntryCreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainFormActivate();
        }

        private void BtnEntryCreateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEntryCreateNew_Click(object sender, EventArgs e)
        {
            Entry entry = new Entry();
            Trip trip = ActiveUserStore.ActiveUser.GetActiveJourney().GetLastTrip();

            entry.TripId = trip.Id;
            entry.EntryDate = DateTime.Now;
            entry.Picture = null; //itt még ki kell dolgozni a kép ki és betöltést.
            entry.Comment = this.InputEntryCreateComment.Text;
            entry.Title = InputEntryCreateTitle.Text;

            if (RBtnEntryCreateVisibilityPrivate.Checked) { entry.Visibility = 0; }
            if (RBtnEntryCreateVisibilityOnlyFriends.Checked) { entry.Visibility = 1; }
            if (RBtnEntryCreateVisibilityPublic.Checked) { entry.Visibility = 2; }

            try
            {
                Validation(entry);
                entry.CreateItself();
                Program.mainForm.UpdateData();
                this.Close();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message,"Entry creation error!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void Validation(Entry entry)
        {
            entry.Validation();
        }
    }
}
