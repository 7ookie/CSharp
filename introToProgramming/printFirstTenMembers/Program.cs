using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace printFirstTenMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First ten members of the sequence are: ");
            for (sbyte a = 2; a <= 11; a++)
            {
                if (a % 2 == 0)
                {
                    Console.Write(a);
                }
                else
                {
                    Console.Write("," + (a * -1) + ",");
                }
            }
            Console.WriteLine();
        }
    }
}
