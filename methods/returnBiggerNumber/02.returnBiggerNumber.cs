using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace returnBiggerNumber
{
    class returnBiggerNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer.\nInteger: ");
            int intOne = int.Parse(Console.ReadLine());
            Console.Write("Enter integer.\nInteger: ");
            int intTwo = int.Parse(Console.ReadLine());
            Console.Write("The bigges number is: {0}\n", GetMax(intOne, intTwo));

            Console.Write("Enter integer.\nInteger: ");
            int intTree = int.Parse(Console.ReadLine());            
            Console.Write("The bigges number is: {0}\n", GetMax(intOne, intTwo, intTree));
            //Console.Write("The bigges number is: {0}\n", GetMax(intOne, intTwo), intTree);
        }
        static int GetMax(int numOne, int numTwo)
        {
            int maxNum = numOne;
            if (numTwo > numOne)
            {
                maxNum = numTwo;
            }
            return maxNum;
            //return numOne > numTwo ? numOne : numTwo;
        }
        static int GetMax(int numOne, int numTwo, int numTree)
        {
            return (Math.Max(numOne, Math.Max(numTwo, numTree)));
        }
    }
}
