using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace generateStringSet
{
    class generateStringSet
    {
        static string[] words = { "text ", "cat ", "bubble ", "frog " };
        static int value;
        static string result;
        static void Main(string[] args)
        {
            Console.Write("Enter integer value.\nk = ");
            value = int.Parse(Console.ReadLine());
            NestedLoops(value);
        }
        static string GenerateStrSet()
        {
            for (int i = 0; i <= value; i++)
            {
                for (int j = i + 1; j <= value; j++)
                {
                    result += (words[i] + words[j]);
                }
            }
            return result;
        }
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] loop;
        static void NestedLoops(int currentLoop)
        {
            loop = new int[words.Length];
            if (currentLoop == words.Length)
            {
                PrintLoops();
                return;
            }
            for (int counter = 1; counter <= value; counter++)
            {
                loop[currentLoop] = counter;
                NestedLoops(currentLoop + 1);
            }
        }
        static void PrintLoops()
        {
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write("{0} ", words[i]);
            }
            Console.WriteLine();
        }
    }
}
