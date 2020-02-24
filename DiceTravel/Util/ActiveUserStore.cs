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
            Program.mainForm.DeactivateControls();

        }
        static public void LogInUser(string loginName, string password)
        {
            ActiveUser = User.GetAuthenticatedUser(loginName, password);
            Program.mainForm.RefreshMainFormUserData();
        }
    
    }
}
