using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcNPrintSquareRoot
{
    class calcNPrintSquareRoot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number.");
            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    Console.WriteLine("Invalid number!");
                }
                else
                {
                    Console.WriteLine(Math.Sqrt(num));
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                Console.WriteLine("Good bye.");
            }
        }
    }
}
