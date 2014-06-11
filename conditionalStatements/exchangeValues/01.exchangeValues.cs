using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exchangeValues
{
    class exchangeValues
    {
        static void Main(string[] args)
        {
            Console.Write("Enter two integer variables. If first is bigger they switch.\nvariable one = ");
            int varOne = int.Parse(Console.ReadLine());
            Console.Write("variable two = ");
            int varTwo = int.Parse(Console.ReadLine());
            int temp;
            if (varOne > varTwo)
            {
                temp = varOne;
                varOne = varTwo;
                Console.WriteLine("Variable one is {0} and variable two is {1}.", varOne, temp);
            }
            else if (varOne == varTwo)
            {
                Console.WriteLine("They are equal. {0} = {1}", varOne, varTwo);
            }
            else
            {
                Console.WriteLine("Variable one is {0} and variable two is {1}.", varOne, varTwo);
            }
        }
    }
}
