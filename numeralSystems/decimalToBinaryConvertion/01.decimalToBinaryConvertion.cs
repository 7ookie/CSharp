using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace decimalToBinaryConvertion
{
    class decimalToBinaryConvertion
    {
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number. \nnumber = ");
            int num = int.Parse(Console.ReadLine());
            string result = string.Empty;
            int remainder;
            while(num > 0)
            {
                remainder = num % 2;
                num = num / 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("The binary representation of this number is: " + result);

            //next
            Console.Write("Enter decimal number. \nnumber = ");
            int digit = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(digit, 2);
            Console.WriteLine("The binary representation of this number is: " + result);
        }
    }
}
