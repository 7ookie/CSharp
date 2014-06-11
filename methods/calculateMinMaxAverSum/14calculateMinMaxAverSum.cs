using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculateMinMaxAverSum
{
    class calculateMinMaxAverSum
    {
        static void Main(string[] args)
        {
            /*int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }*/
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("min - " + Minimum(arr)); 
            Console.WriteLine("max - " + Maximum(arr));
            Console.WriteLine("average - " + Average(arr));
            Console.WriteLine("sum - " + Sum(arr));
        }
        static int Minimum(params int[] numbers)
        {
            int min = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length > 0)
                {
                    if (numbers[i] < min)
                    {
                        min = numbers[i];
                    }
                }
                else
                {
                    return 0;
                }
            }
            return min;
        }
        static int Maximum(params int[] numbers)
        {
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length > 0)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i]; 
                    }
                }
                else
                {
                    return 0;
                }
            }
            return max;
        }
        static double Average(params int[] numbers)
        {
            double average = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                average += numbers[i];
            }
            average = (average / (numbers.Length));
            return average;
        }
        static int Sum(params int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
    }
}
