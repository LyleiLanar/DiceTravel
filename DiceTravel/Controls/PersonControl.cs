using DiceTravel.EntityClasses;
using DiceTravel.Util;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiceTravel.Controls
{
    public partial class PersonControl : FlowElementControl
    {

        private User Person { get; }
        public PersonControl(User person) : base()
        {
            Person = person;

            if (User.AreFriends(ActiveUserStore.ActiveUser, person))
            {
                BorderStyle = BorderStyle.FixedSingle;
                highlightedColor = Color.FromArgb(178, 255, 102);
                originalColor = Color.FromArgb(0, 255, 0);
            }
            if (User.AreMakingFriendship(ActiveUserStore.ActiveUser, person))
            {
                BorderStyle = BorderStyle.FixedSingle;
                highlightedColor = Color.FromArgb(51, 153, 255);
                originalColor = Color.FromArgb(153, 204, 255);
            }

            InitializeComponent();
            BackColor = originalColor;
            SetContent();
        }

        public void SetContent()
        {

            TxtPersonLoginName.Text = Person.LoginName;
            TxtPersonRealName.Text = Person.Surname + " " + Person.Firstname + " (ID" + Person.Id + ")";

            //A barátgombokkal kapcsolatos tiltások.
            if (User.AreFriends(ActiveUserStore.ActiveUser, Person) || User.AreMakingFriendship(ActiveUserStore.ActiveUser, Person))
            {
                BtnPersonMakeFriend.Enabled = false;
            }
            else
            {
                BtnPersonKick.Enabled = false;
            }
        }
        private void BtnPersonMakeFriend_Click(object sender, EventArgs e)
        {
            Friendship friendship = new Friendship();
            friendship.SenderId = ActiveUserStore.ActiveUser.Id;
            friendship.GetterId = this.Person.Id;
            friendship.Accepted = 0;

            friendship.CreateItself();

            Program.mainForm.FlowElementProvider.UpdateFlow();
            Program.mainForm.DrawFlow();
        }
    }
}
