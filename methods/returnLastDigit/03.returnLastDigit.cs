using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace returnLastDigit
{
    class returnLastDigit
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer number.\ninteger = ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("The last digit is: {0}", ReturnDigit(num));
        }
        static string ReturnDigit(int number)
        {
            int result = number % 10;
            string exit = string.Empty;
            switch (result)
            {
                case 0: exit = "zero"; break;
                case 1: exit = "one"; break;
                case 2: exit = "two"; break; 
                case 3: exit = "tree"; break;
                case 4: exit = "four"; break;
                case 5: exit = "five"; break;
                case 6: exit = "six"; break;
                case 7: exit = "seven"; break;
                case 8: exit = "eight"; break;
                case 9: exit = "nine"; break;
            }
            return exit;
        }
        /*
        static string[] digitNames = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        static string GetDigitName(int n)
        {
            return digitNames[n];
        }
        static int GetLastDigit(int n)
        {
            return n % 10;
        }
        */
    }
}
