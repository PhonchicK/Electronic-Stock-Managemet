using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilites.Security.Hashing
{
    public static class PasswordHashingHelper
    {
        public static byte[] HashPassword(string password)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                return md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(password));
            }
        }

        public static bool VerifyPassword(byte[] hashedPassword, string password)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                return hashedPassword == HashPassword(password);
            }
        }
    }
}
