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
                HighlightedColor = Color.FromArgb(178, 255, 102);
                OriginalColor = Color.FromArgb(0, 255, 0);
            }
            if (User.AreMakingFriendship(ActiveUserStore.ActiveUser, person))
            {
                BorderStyle = BorderStyle.FixedSingle;
                HighlightedColor = Color.FromArgb(51, 153, 255);
                OriginalColor = Color.FromArgb(153, 204, 255);
            }

            InitializeComponent();
            BackColor = OriginalColor;
            SetContent();
        }

        public void SetContent()
        {

            TxtPersonLoginName.Text = Person.LoginName;
            TxtPersonRealName.Text = Person.Surname + " " + Person.Firstname + " (ID" + Person.Id + ")";

            //A barátgombokkal kapcsolatos engedélyezések.
            Friendship friendship = Friendship.GetFriendshipByIds(ActiveUserStore.ActiveUser.Id, Person.Id);

            if (friendship == null)
            {
                BtnPersonKick.Enabled = false;
            }
            else
            {
                switch (friendship.Accepted)
                {
                    case 0:
                        if (friendship.SenderId == ActiveUserStore.ActiveUser.Id)
                        {
                            BtnPersonMakeFriend.Enabled = false;
                        }
                        break;

                    case 1:
                        BtnPersonMakeFriend.Enabled = false;
                        break;

                    default:
                        throw new Exception("No such accept value in this Friendship. (0: wait for accept, 1: accepted)");
                }
            }

        }
        private void BtnPersonMakeFriend_Click(object sender, EventArgs e)
        {
            Friendship friendship = Friendship.GetFriendshipByIds(ActiveUserStore.ActiveUser.Id, Person.Id);

            if (friendship == null)
            {
                int SenderId = ActiveUserStore.ActiveUser.Id;
                int GetterId = this.Person.Id;
                int Accepted = 0;

                new Friendship(SenderId, GetterId, Accepted).CreateItself();                   
            }
            else
            {
                switch (friendship.Accepted)
                {
                    case 0:
                        if (ActiveUserStore.ActiveUser.Id == friendship.SenderId) { break; }
                        friendship.Accepted = 1;
                        friendship.UpdateItself();
                        break;

                    case 1:
                        break;

                    default:
                        throw new Exception("No such accept value in this Friendship. (0: wait for accept, 1: accepted)");
                }
            }

            Program.MainForm.DrawFlow();
        }
        private void BtnPersonKick_Click(object sender, EventArgs e)
        {
            Friendship friendship = Friendship.GetFriendshipByIds(ActiveUserStore.ActiveUser.Id, Person.Id);

            if (friendship != null)
            {
                friendship.DeleteItself();
            }

            Program.MainForm.DrawFlow();
        }
        private void PersonControl_Click(object sender, EventArgs e)
        {
            Program.MainForm.FlowElementProvider.SetFlowStoryFlowByUser(Person.Id);
            Program.MainForm.DrawFlow();

        }
    }
}
