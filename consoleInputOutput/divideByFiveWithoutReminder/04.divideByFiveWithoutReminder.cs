using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace divideByFiveWithoutReminder
{
    class divideByFiveWithoutReminder
    {
        static void Main(string[] args)
        {
            Console.Write("Input two numbers to find out how many numbers between them is divided" +
                              " by five without reminder. \na = " );
            int numOne = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int numTwo = int.Parse(Console.ReadLine());
            int numMin = Math.Min(numOne, numTwo);
            int numMax = Math.Max(numOne, numTwo);
            int counter = 0;
            for (int z = numMin; z <= numMax; z++)
            {
                if ((z % 5) == 0)
                {
                    counter = counter + 1;
                }
            }
            Console.WriteLine("The numbers divided by five without reminder are: " + counter);
        }
    }
}
