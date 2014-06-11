using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace reverseDigit
{
    class reverseDigit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumber(number.ToString()));
            Console.WriteLine(ReverseNumber(number));

            decimal digit = decimal.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumber(digit));
        }
        static decimal ReverseNumber(decimal num) //include negative numbers
        {
            return decimal.Parse(new string(num.ToString().ToCharArray().Reverse().ToArray()));
        }
        static string ReverseNumber(string num)
        {
            char[] array = num.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        static int ReverseNumber(int num)
        {
            int remainder = 0;
            string result = string.Empty;
            while (num != 0)
            {
                remainder = num % 10;
                num /= 10;
                result += remainder.ToString(); //reverse
                //result = remainder.ToString() + result; //straight
            }
            return Convert.ToInt32(result);
        }
    }
}
