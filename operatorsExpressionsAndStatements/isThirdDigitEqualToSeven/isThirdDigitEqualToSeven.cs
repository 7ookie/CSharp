using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace isThirdDigitEqualToSeven
{
    class isThirdDigitEqualToSeven
    {
        static void Main(string[] args)
        {
            Console.Write("Input integer: ");
            int num = int.Parse(Console.ReadLine());
            if (((num / 100) % 10) == 7) 
            {
                Console.WriteLine("The third digith is seven.");
            }
            else
            {
                Console.WriteLine("The third digith is not seven.");
            }
            
        }
    }
}
