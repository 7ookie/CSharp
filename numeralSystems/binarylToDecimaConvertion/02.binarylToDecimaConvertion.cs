using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binarylToDecimaConvertion
{
    class binarylToDecimaConvertion
    {
        static void Main(string[] args)
        {
            Console.Write("Input binary digit to see it decimal representation.\nbinary = ");
            string num = Console.ReadLine();
            Console.WriteLine("Binary to decimal convertion:\ndecimal = " + Convert.ToInt32(num, 2));

            Console.Write("Input binary digit to see it decimal representation.\nbinary = ");
            string number = Console.ReadLine();
            int result = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[number.Length - i - 1] == '0')
                {
                    continue;
                }
                result = result + (int)Math.Pow(2, i);
            }
            Console.WriteLine("Binary to decimal convertion:\ndecimal = " + result);
        }
    }
}
