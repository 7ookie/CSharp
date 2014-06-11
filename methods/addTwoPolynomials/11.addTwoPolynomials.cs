using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace addTwoPolynomials
{
    class addTwoPolynomials
    {
        static decimal[] polinomialOne = { 1, 1, 1 };
        static decimal[] polinomialTwo = { 3, 3, 3, 3 };
        static void Main(string[] args)
        {
            int maxLenght = 0;
            maxLenght = polinomialTwo.Length;
            if (polinomialOne.Length>polinomialTwo.Length)
            {
                maxLenght = polinomialOne.Length;
            }
            decimal[] result = new decimal[maxLenght];
            Console.WriteLine("Sum polinomials.");
            result = SumPolinomials(polinomialOne, polinomialTwo);// invoke SumPolinomials
            PrintPolinomial(result);//invoke PrintPolinomial
            Console.WriteLine();

            Console.WriteLine("Substract polinomials.");
            result = Subtraction(polinomialOne, polinomialTwo);
            PrintPolinomial(result);
            Console.WriteLine();

            Console.WriteLine("Multiply polinomials.");
            result = MultiplyArray(polinomialOne, polinomialTwo);
            PrintPolinomial(result);
            Console.WriteLine();
        }
        static decimal[] SumPolinomials(decimal[] arrayOne, decimal[] arrayTwo)
        {
            int minLenght = 0;
            int maxLenght = 0;
            //int max = Math.Max(arrayOne.Length, arrayTwo.Length);
            //int min = Math.Min(arrayOne.Length, arrayTwo.Length);
            maxLenght = arrayTwo.Length;
            minLenght = arrayOne.Length;
            if (arrayOne.Length > arrayTwo.Length)
            {
                maxLenght = arrayOne.Length;
                minLenght = arrayTwo.Length;
            }
            decimal[] result = new decimal[maxLenght];
            if (minLenght > -1) //check for empty array
            {
                for (int i = 0; i <= maxLenght - 1; i++)
                {
                    if (minLenght > i)
                    {
                         result[i] = arrayOne[i] + arrayTwo[i];
                    }
                    else if (polinomialOne.Length - 1 < i)
                    {
                        result[i] = polinomialTwo[i];
                    }
                    else if (polinomialTwo.Length - 1 < i)
                    {
                        result[i] = polinomialOne[i];
                    }
                   
                }
            }
            else
            {
                Console.WriteLine("Enter value different of zero.");
            }
            Array.Reverse(result);
            return result;
        }
        static decimal[] PrintPolinomial(decimal[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + "x^" + i + "\t");
            }
            return array;
        }
        static decimal[] Subtraction(decimal[] arrOne, decimal[] arrTwo)
        {
            int minLenght = Math.Min(arrOne.Length, arrTwo.Length);
            int maxLenght = Math.Max(arrOne.Length, arrTwo.Length);
            decimal[] subResult = new decimal[maxLenght];
            for (int i = 0; i <= maxLenght - 1; i++)
            {
                if (minLenght > i)
                {
                    subResult[i] = arrOne[i] - arrTwo[i];
                }
                else if (arrOne.Length - 1 < i)
                {
                    subResult[i] = - arrTwo[i];
                }
                else if (arrTwo.Length - 1 < i)
                {
                    subResult[i] = arrOne[i];
                }
            }
            Array.Reverse(subResult);
            return subResult;
        }
        static decimal[] MultiplyArray(decimal[] array, decimal[] arrayOne)
        {
            int minLenght = Math.Min(array.Length, arrayOne.Length);
            int maxLenght = Math.Max(array.Length, arrayOne.Length);
            decimal[] multiply = new decimal[maxLenght];
            for (int i = 0; i <= maxLenght - 1; i++)
            {
                if (minLenght > i)
                {
                    multiply[i] = array[i] * arrayOne[i];
                }
                else if (array.Length - 1 < i)
                {
                    multiply[i] = arrayOne[i];
                }
                else if (arrayOne.Length - 1 < i)
                {
                    multiply[i] = array[i];
                }
                   
            }
            return multiply;
        }
    }
}
