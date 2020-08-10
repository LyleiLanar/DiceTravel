using DiceTravel.Classes;
using DiceTravel.Util;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiceTravel.Forms.EntryForms
{
    public partial class EntryCreateForm : Form
    {
        public EntryCreateForm()
        {
            InitializeComponent();
            this.Width = 250;
        }


        private void BtnEntryCreateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEntryCreateNew_Click(object sender, EventArgs e)
        {
            Trip trip = ActiveUserStore.ActiveUser.GetActiveJourney().GetLastTrip();

            //int id = trip.Id;
            int tripId = trip.Id;
            DateTime entryDate = DateTime.Now;
            byte[] picture = null;
            string title = InputEntryCreateTitle.Text;
            string comment = InputEntryCreateComment.Text;
            int visibility = 0;


            if (!string.IsNullOrEmpty(InputEntryCreateAddImage.Text))
            {
                picture = Util.ImageHandler.GetImageBin(InputEntryCreateAddImage.Text);
            }

            if (RBtnEntryCreateVisibilityPrivate.Checked) { visibility = 0; }
            if (RBtnEntryCreateVisibilityOnlyFriends.Checked) { visibility = 1; }
            if (RBtnEntryCreateVisibilityPublic.Checked) { visibility = 2; }

            Entry entry = new Entry(tripId, entryDate, picture, title, comment, visibility);

            try
            {
                Validation(entry);
                entry.CreateItself();
                Program.MainForm.UpdateData();
                this.Close();
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "Entry creation error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Validation(Entry entry)
        {
            entry.Validation();
        }

        private void BtnEntryCreateAddImage_Click(object sender, EventArgs e)
        {
            //felhasznált kódrészlet: https://www.c-sharpcorner.com/UploadFile/deepak.sharma00/how-to-save-images-in-mysql-database-using-C-Sharp/
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Image files | *.jpg";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        InputEntryCreateAddImage.Text = openFileDialog.FileName;
                        PctrBxEntryCreateAddImage.Image = Image.FromFile(openFileDialog.FileName);
                        this.Width = 640;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //MainForm Activation
        private void EntryCreateForm_Load(object sender, EventArgs e)
        {
            Program.MainFormDeactivate();
        }
        private void EntryCreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.MainFormActivate();
        }


    }
}
