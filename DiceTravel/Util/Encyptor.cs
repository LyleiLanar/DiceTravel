﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DiceTravel.Util
{
    static class Encyptor
    {
        static public string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5Encriptor = new MD5CryptoServiceProvider())
            {
                string salt = "<>#&@";
                value += salt;

                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5Encriptor.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
    }
}
