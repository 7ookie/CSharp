using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encodeNDecodeString
{
    class encodeNDecodeString
    {
        static void Main(string[] args)
        {
            string str = "Visula studio Ultimate";
            string key = "%0jgZ#.";
            Console.WriteLine(Encrypt(str, key));
            Console.WriteLine(Decrypt((Encrypt(str, key)), key));
        }
        static string Encrypt(string str, string key)
        {
            char[] strArray = str.ToCharArray();
            char[] keyArray = new char[key.Length];
            StringBuilder encrypted = new StringBuilder();
            if (keyArray.Length < strArray.Length)
            {
                Array.Resize(ref keyArray, strArray.Length);
            }
            for (int i = 0, k = 0; i < keyArray.Length; k++, i++)
            {
                if (!(k < key.Length))
                {
                    k = 0;
                }
                keyArray[i] = key[k];
            }
            for (int i = 0; i < strArray.Length; i++)
            {
                encrypted.Append((char)(strArray[i] ^ keyArray[i]));
            }
            return encrypted.ToString();
        }
        static string Decrypt(string str, string key)
        {
            return Encrypt(str, key).ToString();
        }
    }
}
