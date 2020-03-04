using DiceTravel.Classes;
using System;

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
        }
        static public void LogInUser(string loginName, string password)
        {
            ActiveUser = GetAuthenticatedUser(loginName, password);
        }
        static public bool IsThereActiveJourney()
        {
            return ActiveUser.IsThereActiveJourney();
        }
        static public Journey GetActiveJourney()
        {
            return ActiveUser.GetActiveJourney();
        }
        static public User GetAuthenticatedUser(string loginName, string password)
        {
            try
            {
                User user = User.GetUserBy_LoginName(loginName);
                try
                {
                    if (user.Password == password)
                    {
                        return user; 
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw new EntityCreationException("Wrong Login name or Password!");
            }
            return null;
        }

    }
}
