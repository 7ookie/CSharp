using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace maxSum
{
    class maxSum
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter integer number to set array lenght.");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter array elements.");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            //int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8}; //11 {2, -1, 6, 4}
            int sum = 0;
            int bestSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int z = i; z < array.Length; z++)
                {
                    sum += array[z];
                    if (bestSum < sum)
                    {
                        bestSum = sum;
                    }
                }
                sum = 0;
            }
            Console.WriteLine("The best sum is: {0}", bestSum);
        }
    }
}
