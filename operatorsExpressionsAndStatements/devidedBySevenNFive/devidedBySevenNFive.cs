using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace devidedBySevenNFive
{
    class devidedBySevenNFive
    {
        static void Main(string[] args)
        {
            Console.Write("Input integer: ");
            int num = int.Parse(Console.ReadLine());
            if ((num % 5) == 0 && (num % 7) == 0)
            {
                bool a = true;
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
