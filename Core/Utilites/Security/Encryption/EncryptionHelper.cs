using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilites.Security.Encryption
{
    public static class EncryptionHelper
    {
        public static byte[] Encrypt(byte[] data, byte[] pass)
        {
            //byte[] data = UTF8Encoding.UTF8.GetBytes(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(pass);
                //byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(pass));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return results;
                    //return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        public static byte[] Decrypt(byte[] data, byte[] pass)
        {
            //byte[] data = Convert.FromBase64String(text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(pass);
                //byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(pass));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return results;
                    //return UTF8Encoding.UTF8.GetString(results);
                }
            }
        }
    }
}
