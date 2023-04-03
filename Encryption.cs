using System;
using System.Security.Cryptography;
using System.Text;

namespace InvenTrax1
{
    public abstract class Encryption
    {
        public static string Encrypt(string password)
        {
            string salt = "R}(fCSV7TaqSd+1.*Z*?]";
            byte[] saltBytes = Encoding.UTF8.GetBytes(salt);
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            byte[] saltedPasswordBytes = new byte[saltBytes.Length + passwordBytes.Length];
            saltBytes.CopyTo(saltedPasswordBytes, 0);
            passwordBytes.CopyTo(saltedPasswordBytes, saltBytes.Length);

            SHA256 sha256 = SHA256.Create();
            byte[] hashedBytes = sha256.ComputeHash(saltedPasswordBytes);

            string hashedPassword = Convert.ToBase64String(hashedBytes);
            return hashedPassword;
        }
    }
}