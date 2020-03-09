﻿using DiceTravel.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DiceTravel.Controls
{
    public partial class EntryControl : FlowElementControl
    {
        private Entry Entry { get;}

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
            BackColor = highlightedColor;
        }

        private void TxtEntryComment_MouseLeave(object sender, EventArgs e)
        {
            BackColor = originalColor;
        }
    }
}