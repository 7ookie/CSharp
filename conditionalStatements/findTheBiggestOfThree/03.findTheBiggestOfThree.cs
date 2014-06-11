using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace findTheBiggestOfThree
{
    class findTheBiggestOfThree
    {
        static void Main(string[] args)
        {
            Console.Write("Enter three integer variables to find out which is the biggest one.\ninteger one = ");
            int intOne = int.Parse(Console.ReadLine());
            Console.Write("integer two = ");
            int intTwo = int.Parse(Console.ReadLine());
            Console.Write("integer three = ");
            int intThree = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(intOne, Math.Max(intTwo, intThree)));

            if ((intOne > intTwo) && (intOne > intThree))
            {
                Console.WriteLine("The biggest is: " + intOne);
            }
            else if ((intTwo > intOne) && (intTwo > intThree))
            {
                Console.WriteLine("The biggest is: " + intTwo);
            }
            else if ((intThree > intOne) && (intThree > intTwo))
            {
                Console.WriteLine("The biggest is: " + intThree);
            }
            else 
            {
                Console.WriteLine("They are equal.");
            }
        }
    }
}
