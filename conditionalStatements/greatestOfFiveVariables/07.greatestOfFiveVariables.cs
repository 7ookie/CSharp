using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace greatestOfFiveVariables
{
    class greatestOfFiveVariables
    {
        static void Main(string[] args)
        {
            Console.Write("Enter five variables to find the biggest one.\nfirst = ");
            double first = double.Parse(Console.ReadLine());
            Console.Write("second = ");
            double second = double.Parse(Console.ReadLine());
            Console.Write("third = ");
            double third = double.Parse(Console.ReadLine());
            Console.Write("forth = ");
            double forth = double.Parse(Console.ReadLine());
            Console.Write("fifth = ");
            double fifth = double.Parse(Console.ReadLine());
            if ((first > second) && (first > third) && (first > forth) && (first > fifth))
            {
                Console.WriteLine("The bigges is: " + first);
            }
            else if ((second > first) && (second > third) && (second > forth) && (second > fifth))
            {
                Console.WriteLine("The bigges is: " + second);
            }
            else if ((third > first) && (third > second) && (third > forth) && (third > fifth))
            {
                Console.WriteLine("The bigges is: " + third);
            }
            else if ((forth > first) && (forth > second) && (forth > third) && (forth > fifth))
            {
                Console.WriteLine("The bigges is: " + forth);
            }
            else
            {
                Console.WriteLine("The bigges is: " + fifth);
            }
            Console.WriteLine(Math.Max(first, Math.Max(second, Math.Max(third, Math.Max(forth, fifth)))));
        }
    }
}
