﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace askDigitShowName
{
    class askDigitShowName
    {
        static void Main(string[] args)
        {
            Console.Write("Enter digit(0-9).\ndigit = ");
            int digit = int.Parse(Console.ReadLine());
            switch(digit)
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("two"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("four"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;
                default: Console.WriteLine("Error!!! Enter digit(0-9)."); break;
            }
        }
    }
}