using DiceTravel.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceTravel.Forms.EntryForms
{
    public partial class EntryUpdateForm : Form
    {
        public Entry Entry { get;  }

        public EntryUpdateForm(Entry entry)
        {
            InitializeComponent();
            Entry = entry;
            Trip Trip = Trip.GetTripById(Entry.TripId);
            Journey journey = Journey.GetJourneyById(Trip.JourneyId);

            BtnEntryUpdateDelete.BackColor = Color.Red;


            InputEntryUpdateComment.Text = Entry.Comment;
            InputEntryUpdateTitle.Text = Entry.Title;

            switch (Entry.Visibility)
            {
                case 0:
                    this.RBtnEntryUpdateVisibilityPrivate.Checked = true;
                    break;

                case 1:
                    this.RBtnEntryUpdateVisibilityOnlyFriends.Checked = true;
                    break;

                case 2:
                    this.RBtnEntryUpdateVisibilityPublic.Checked = true;
                    break;

                default:
                    throw new Exception("No such visibility!");
            }

            if (journey.Closed == 1)
            {
                InputEntryUpdateComment.Enabled = false;
                InputEntryUpdateTitle.Enabled = false;
                BtnEntryUpdateDelete.Enabled = false;
                BtnEntryUpdateDelete.BackColor = SystemColors.Control;
            }
        }

        private void BtnEntryUpdateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnEntryUpdateUpdate_Click(object sender, EventArgs e)
        {
            Entry.Title = InputEntryUpdateTitle.Text;
            Entry.Comment = InputEntryUpdateComment.Text;

            if (this.RBtnEntryUpdateVisibilityPrivate.Checked) { Entry.Visibility = 0; }
            if (this.RBtnEntryUpdateVisibilityOnlyFriends.Checked) { Entry.Visibility = 1; }
            if (this.RBtnEntryUpdateVisibilityPublic.Checked) { Entry.Visibility = 2; }

            Entry.UpdateItself();

            Program.MainForm.UpdateData();
            this.Close();
        }

        //MainForm Activation
        private void EntryUpdateForm_Load(object sender, EventArgs e)
        {
            Program.MainFormDeactivate();
        }
        private void EntryUpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainFormActivate();
        }
        private void BtnEntryUpdateDelete_Click(object sender, EventArgs e)
        {
            Entry.DeleteItself();
            Program.MainForm.UpdateData();
            this.Close();
        }
    }
}
