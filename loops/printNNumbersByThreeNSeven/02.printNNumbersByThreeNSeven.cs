using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace printNNumbersByThreeNSeven
{
    class printNNumbersByThreeNSeven
    {
        static void Main(string[] args)
        {
            Console.Write("Not divisible by 3 and 7.\nn = ");
            ulong num = ulong.Parse(Console.ReadLine());
            for (ulong z = 1; z <= num; z++)
            {
                if ((z % 3 != 0) || (z % 7 != 0))
                {
                    Console.WriteLine(z);
                }
            }
            /*
            ulong counter = 1;
            while (counter <= num)
            {
                if (!(counter % 3 == 0 && counter % 7 == 0))
                {
                    Console.WriteLine(counter);
                }
                counter++;
            }
            */
        }
    }
}
