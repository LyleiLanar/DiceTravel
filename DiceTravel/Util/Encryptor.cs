using System;
using System.Security.Cryptography;
using System.Text;

namespace DiceTravel.Util
{

    /// <summary>
    /// This static class is responsible for the encryption.
    /// The methods are the implementations of various encrypting algorythms.
    /// </summary>
    static class Encryptor
    {
        /// <summary>
        /// Implements the MD5 algorythm with static salt.
        /// </summary>
        /// <returns>
        /// The encypted string value.
        /// </returns>
        /// <param name="value">A string value. This will be encrypted at the end of this process. </param>
        static public string MD5Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5Encryptor = new MD5CryptoServiceProvider())
            {
                string salt = "<>#&@";
                value += salt;

                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5Encryptor.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
    }
}
