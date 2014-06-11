using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace printMatrix
{
    class printMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer 0<=N<=20 to print matrix.\nN = ");
            int n = int.Parse(Console.ReadLine());
            if (n >= 0 && n <= 20)
            {
                for (int row = 1; row <= n; row++)
                {
                    for (int col = row; col < (n + row); col++)
                    {
                        Console.Write(col);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Your input don't satisfy the conditions.");
            }
        }
    }
}
