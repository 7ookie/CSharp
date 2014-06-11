using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace printKMaxSumElements
{
    class printKMaxSumElements
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer number \"k\".\nk = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("\"k\" must be smaller than \"n\"!\nn = ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter array elements.");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            int bestSum = 0;
            for (int s = 0; s <= array.Length - k; s++)
            {
                for (int a = s; a < (k + s); a++)
                {
                    sum += array[a];
                }
                if (bestSum < sum)
                {
                    bestSum = sum;
                }
                sum = 0;
            }
            Console.WriteLine("The maximal sum of tree row array elements is: {0}", bestSum);
        }
    }
}
