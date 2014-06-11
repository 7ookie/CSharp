using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tickCount
{
    class printIsLeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year.");
            int num = int.Parse(Console.ReadLine());
            bool isLeap = DateTime.IsLeapYear(num);
            Console.WriteLine("Is leap year? {0}", isLeap);
        }
    }
}
