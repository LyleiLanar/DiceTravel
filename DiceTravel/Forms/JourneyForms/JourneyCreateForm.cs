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
            this.Dispose();
        }

        private void BtnJourneyCreateStart_Click(object sender, EventArgs e)
        {
            string userId = $"{ActiveUserStore.ActiveUser.Id}";
            string title = $"{this.InputJourneyCreateJourneyTitle.Text}";
            string startLocation = $"{this.InputJourneyCreateJourneyStartLocation.Text}";
            string startDate = $"{DateTime.Now}";
            string visibility = "0";

            if (this.RBtnJourneyCreateVisibilityPrivate.Checked) { visibility = "0"; }
            if (this.RBtnJourneyCreateVisibilityOnlyFriends.Checked) { visibility = "1"; }
            if (this.RBtnJourneyCreateVisibilityPublic.Checked) { visibility = "3"; }

            string queryString = "SELECT * FROM journeys";
            string insertCommand = $"INSERT INTO `dice_travel`.`journeys` (`user_id`, `title`,`start_location`,`visibility`) " +
                        $"VALUES ('{userId}', '{title}','{startLocation}','{visibility}');";

            DBDriver.InsertRow(queryString, insertCommand);
            Program.mainForm.RefreshMainFormUserData();
            this.Dispose();
        }
    }
}
