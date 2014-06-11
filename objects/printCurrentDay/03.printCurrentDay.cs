using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printCurrentDay
{
    class printCurrentDay
    {
        static void Main(string[] args)
        {
            Console.Write("The current day of week is: ");
            DateTime day = DateTime.Now;
            //variant one
            int dayOfWeek = (int)DateTime.Now.DayOfWeek;
            switch (dayOfWeek)
            {
                case 1: Console.WriteLine("Monday"); break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Thursday"); break;
                case 4: Console.WriteLine("Wednesday"); break;
                case 5: Console.WriteLine("Frisday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
                default:
                    break;
            }
            //variant two
            Console.WriteLine(day.DayOfWeek);
        }
    }
}
