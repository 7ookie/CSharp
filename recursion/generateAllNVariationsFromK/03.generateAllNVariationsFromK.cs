﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace generateAllNVariationsFromK
{
    class generateAllNVariationsFromK
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loops;

        static void Main(string[] args)
        {
            Console.Write("N = ");
            numberOfIterations = int.Parse(Console.ReadLine());
            Console.Write("K = ");
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
            for (int counter = 1; counter <= numberOfIterations; counter++)
            {
                loops[currentLoop] = counter;
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
