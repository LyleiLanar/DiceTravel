using System;
using System.Data;

namespace DiceTravel.Util
{
    static class UserAuthenticator
    {

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
