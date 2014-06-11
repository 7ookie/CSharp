using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calculateWithAccuracy
{
    class calculateWithAccuracy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate sum with accuracy 0.001.");
            double sum = 1;
            for (double z = 2; 1 / z >= 0.001; z++)
            {
                if (z % 2 == 0)
                {
                    sum = sum + 1 / z;
                }
                else
                {
                    sum = sum - 1 / z;
                } 
            }
            Console.WriteLine(Math.Round(sum, 3));
            Console.WriteLine("The sum with accuracy 0.001 is: {0:0.000}", sum);
        }
    }
}
