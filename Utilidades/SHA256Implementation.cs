using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    public class SHA256Implementation
    {
        public static string EncriptText(string plainText, string saltBase64)
        {

            using (SHA256 sha256Hash = SHA256.Create())
            {

                byte[] plainTextAsBytes = Encoding.UTF8.GetBytes(plainText);
                byte[] saltAsBytes = Convert.FromBase64String(saltBase64);

                List<byte> passwordWithSaltBytes = new List<byte>();

                passwordWithSaltBytes.AddRange(saltAsBytes);
                passwordWithSaltBytes.AddRange(plainTextAsBytes);
                byte[] hashBytes = sha256Hash.ComputeHash(passwordWithSaltBytes.ToArray());

                return Convert.ToBase64String(hashBytes);
            }
        }


        public static HashWithSaltResult CreateEncriptHashWithSalt(string plainText, string salt)
        {

            using (SHA256 sha256Hash = SHA256.Create())
            {

                RNGCryptoServiceProvider randomNumberProvider = new RNGCryptoServiceProvider();
                salt = Get128BitString(salt);
                byte[] plainTextAsBytes = Encoding.UTF8.GetBytes(plainText);
                byte[] saltAsBytes = Encoding.UTF8.GetBytes(salt);
                byte[] randomBytes = new byte[32];
                randomNumberProvider.GetBytes(randomBytes);

                List<byte> passwordWithSaltBytes = new List<byte>();

                passwordWithSaltBytes.AddRange(saltAsBytes);
                passwordWithSaltBytes.AddRange(randomBytes);

                //result salt
                saltAsBytes = sha256Hash.ComputeHash(passwordWithSaltBytes.ToArray());
                passwordWithSaltBytes.Clear();
                passwordWithSaltBytes.AddRange(saltAsBytes);
                passwordWithSaltBytes.AddRange(plainTextAsBytes);
                byte[] hashBytes = sha256Hash.ComputeHash(passwordWithSaltBytes.ToArray());

                HashWithSaltResult result = new HashWithSaltResult(Convert.ToBase64String(saltAsBytes), Convert.ToBase64String(hashBytes));
                return result;
            }
        }

        private static string Get128BitString(string keyToConvert)
        {
            StringBuilder b = new StringBuilder();
            for (int i = 0; i < 32; i++)
            {
                b.Append(keyToConvert[i % keyToConvert.Length]);
            }
            keyToConvert = b.ToString();

            return keyToConvert;
        }
    }


    public class HashWithSaltResult
    {
        public string Salt { get; }
        public string Digest { get; }

        public HashWithSaltResult(string salt, string digest)
        {
            Salt = salt;
            Digest = digest;
        }
    }
}
