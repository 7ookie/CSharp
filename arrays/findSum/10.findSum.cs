using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace findSum
{
    class findSum
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Enter integer number to set array lenght.");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter array elements.");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            */
            int[] array = { 4, 3, 1, 4, 2, 5, 8 };
            Console.Write("Input integer.\nnum = ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int safe = 0;
            int secSafe = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int w = i; w < array.Length; w++)
                {
                    sum += array[w];
                    if (num == sum)
                    {
                        safe = i;
                        secSafe = w;
                        Console.Write("The sum is: {");
                        for (int s = safe; s <= secSafe; s++)
                        {
                            Console.Write(array[s]);
                            if(s < secSafe)
                            {
                                Console.Write(",");
                            }
                        }
                        Console.Write("}\n");
                    }
                }
                sum = 0;
            }
        }
    }
}
