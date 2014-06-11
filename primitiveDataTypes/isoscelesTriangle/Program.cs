using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace isoscelesTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  ©\n" + " ©©©\n" + "©©©©©\n");
            char copyCaracter = '\u00A9';
            byte row = 1;
            byte col = 1;
            for (row = 1; row <= 3; row++)
            {
                for (col = 1; col <= 5; col++)
                {
                    if ((row == 1 && col == 1) || (row == 2 && col == 1) || (row == 1 && col == 2) || 
                        (row == 1 && col == 4) || (row == 1 && col == 5) || (row == 2 && col == 5))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(copyCaracter);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
