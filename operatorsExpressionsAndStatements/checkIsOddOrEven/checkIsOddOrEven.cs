using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace checkIsOddOrEven
{
    class checkIsOddOrEven
    {
        static void Main(string[] args)
        {
            Console.Write("Input integer: ");
            int num = int.Parse(Console.ReadLine());
            if ((num % 2) == 0)
            {
                Console.WriteLine("It's even.");
            }
            else
            {
                Console.WriteLine("It's odd.");
            }
        }
    }
}
