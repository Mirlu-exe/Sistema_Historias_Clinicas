using System;

namespace Utilidades
{
    public class SlowEqualsImplementation
    {
        public static bool SlowEquals(byte[] a, byte[] b)
        {
            int diff = a.Length ^ b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
            {
                diff |= a[i] ^ b[i];
            }
            return diff == 0;
        }

        public static bool SlowEquals(string a, string b)
        {
            return SlowEquals(Convert.FromBase64String(a), Convert.FromBase64String(b));
        }
    }
}
