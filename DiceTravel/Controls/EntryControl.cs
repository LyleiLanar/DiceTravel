﻿using DiceTravel.Classes;
using DiceTravel.Forms.EntryForms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DiceTravel.Controls
{
    public partial class EntryControl : FlowElementControl
    {
        private Entry Entry { get; }

        public EntryControl(Entry entry)
        {
            Entry = entry;

            InitializeComponent();
            SetContent();
        }

        public void SetContent()
        {
            TxtEntryComment.Text = Entry.Comment;
            TxtEntryDate.Text = Entry.EntryDate.ToString();
            TxtEntryTitle.Text = Entry.Title;

            TxtEntryUserLoginName.Text = User.GetUserById(Journey.GetJourneyById(Trip.GetTripById(Entry.TripId).JourneyId).UserId).LoginName;

            if (Entry.Picture != null)
            {
                MemoryStream ms = new MemoryStream(Entry.Picture);
                PctBxEntryImage.Image = Image.FromStream(ms);
                PctBxEntryImage.Visible = true;
            }
            else
            {
                PctBxEntryImage.Visible = false;
                TxtEntryComment.Location = PctBxEntryImage.Location;
            }


            switch (Entry.Visibility)
            {
                case 0:
                    PctBxEntryVisibility.Image = Properties.Resources.icoVisibilityPrivate.ToBitmap();
                    break;

                case 1:
                    PctBxEntryVisibility.Image = Properties.Resources.icoVisibilityFriends.ToBitmap();
                    break;

                case 2:
                    PctBxEntryVisibility.Image = Properties.Resources.icoVisibilityPublic.ToBitmap();
                    break;

                default:
                    PctBxEntryVisibility.Image = Properties.Resources.icoEmpty.ToBitmap();
                    break;
            }
        }

        private void TxtEntryComment_MouseEnter(object sender, EventArgs e)
        {
            BackColor = HighlightedColor;
        }

        private void TxtEntryComment_MouseLeave(object sender, EventArgs e)
        {
            BackColor = OriginalColor;
        }

        private void BtnEntryBackToEntry_Click(object sender, EventArgs e)
        {
            Journey journey = Journey.GetJourneyById(Trip.GetTripById(Entry.TripId).JourneyId);
            Program.MainForm.FlowElementProvider.SetTripFlow(journey.Id);
            Program.MainForm.DrawFlow();
        }

        private void BtnEntryOptions_Click(object sender, EventArgs e)
        {
            new EntryUpdateForm(Entry).Show();
        }

        private void TxtJourneyUserLoginName_Click(object sender, EventArgs e)
        {

        }

        private void TxtEntryComment_ContentsResized(object sender, System.Windows.Forms.ContentsResizedEventArgs e)
        {
            ((RichTextBox)sender).Height = e.NewRectangle.Height + 5;
        }
    }
}
