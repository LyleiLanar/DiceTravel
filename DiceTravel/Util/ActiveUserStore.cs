using System.Data;

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
            Program.mainForm.RefreshMainForm();
        }
        static public bool IsThereActiveJourney()
        {

            int userId = ActiveUserStore.ActiveUser.Id;
            string queryString = $"SELECT count(*) as db FROM dice_travel.journeys WHERE closed = 0 AND user_id = {userId};";

            DataTable table = DBDriver.ReadQuery(queryString);

            if (table.Rows[0]["db"].ToString() == "0")
            {
                return false;
            }
            return true;

        }
        static public int GetActiveJourneyId()
        {
            int activeJourneyId = -1;

            if (IsThereActiveJourney())
            {
                int userId = ActiveUserStore.ActiveUser.Id;
                string queryString = $"SELECT id FROM dice_travel.journeys WHERE user_id = {userId};";

                DataTable table = DBDriver.ReadQuery(queryString);
                activeJourneyId = (int)table.Rows[0]["id"];
            }
            return activeJourneyId;
        }
    }
}
