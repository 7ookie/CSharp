using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace returnMaximaElement
{
    class returnMaximaElement
    {
        static void Main(string[] args)
        {
            string str = "hipo";
            string n = "bob";
            Console.WriteLine(IsMirror(str));
            Console.WriteLine(IsMirror(n));
            double number = 15;
            Console.WriteLine("{0:0.000}", number);
            Console.WriteLine(Math.Round(number, 1));
        }
        static bool IsMirror(string mirror)
        {
            char[] a = mirror.ToArray();
            char[] b = mirror.ToArray();
            Array.Reverse(b);
            bool ask = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[i])
                {
                    ask = true;
                }
            }
            return ask;
        }
    }
}
