using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace printSquareMatrix
{
    class printSquareMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer for rows.\nrows = ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter integer for cols.\ncols = ");
            int cols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, cols];
            //Console.WriteLine("Fill the matrix cells.");
            for (int row = 0; row < rows; row++)
            {
                int sum = row + 1;
                for (int col = 0; col < cols; col++)
                {
                    //Console.Write("matrix[{0}, {1}]", row, col);
                    //matrix[row, col] = int.Parse(Console.ReadLine());
                    matrix[row, col] = row + 1;
                    if (col != 0)
                    { 
                        sum += 4;
                        matrix[row, col] = sum;
                    }
                }
            }
            Console.WriteLine("Formatted matrix variant \"a\":");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }

            //variant b
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = row + 1;
                    
                }
            }
            Console.WriteLine("Formatted matrix variant \"b\":");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(" " + matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
