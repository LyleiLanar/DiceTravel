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
            Program.mainForm.FlowElementProvider.ResetFlow();
        }
        static public void LogInUser(string loginName, string password)
        {
            ActiveUser = GetAuthenticatedUser(loginName, password);
            if (ActiveUser == null)
            {
                //ez nem tudom mi itt.
            }
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
                User user = User.GetUserByLoginName(loginName);
                try
                {
                    if (user.Password == password)
                    {
                        return user;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    throw new EntityCreationException("Wrong Login name or Password!"); ;
                }
            }
            catch (Exception)
            {
                throw new EntityCreationException("Wrong Login name or Password!");
            }
            throw new EntityCreationException("Wrong Login name or Password!");
        }

    }
}
