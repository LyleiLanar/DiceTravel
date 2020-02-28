using DiceTravel.Classes;

namespace DiceTravel.Util
{
    static public class ActiveUserStore
    {
        static public User ActiveUser { get; private set; }

        static public bool IsThereActiveUser
        {
            get
            {
                if (ActiveUser != null)
                {
                    return true;
                }
                return false;
            }
        }
        static public void LogOutUser()
        {
            ActiveUser = null;
            Program.mainForm.ChangeControlsAvailabilityAfterLogout();
        }
        static public void LogInUser(string loginName, string password)
        {
            ActiveUser = UserAuthenticator.GetAuthenticatedUser(loginName, password);
            Program.mainForm.UpdateData();
        }
        static public bool IsThereActiveJourney()
        {
            return ActiveUser.IsThereActiveJourney();
        }
        static public Journey GetActiveJourney()
        {
            return ActiveUser.GetActiveJourney();
        }
    }
}
