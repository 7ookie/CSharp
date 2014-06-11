using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursiveNNestedLoops
{
    class RecursiveNNestedLoops
    {
        static int numberOfLoops;
        static int[] loops;
        static void Main(string[] args)
        {
            Console.Write("Enter integer number.\nnumber = ");
            numberOfLoops = int.Parse(Console.ReadLine());
            loops = new int[numberOfLoops];
            NestedLoops(0);
        }
        static void NestedLoops(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                PrintLoops();
                return;
            }
            for (int i = 1; i <= numberOfLoops; i++)
            {
                loops[currentLoop] = i;
                NestedLoops(currentLoop + 1);
            }
        }
        static void PrintLoops()
        {
            for (int i = 0; i < numberOfLoops; i++)
            {
                Console.Write("{0} ", loops[i]);
            }
            Console.WriteLine();
        }
        
    }
}
