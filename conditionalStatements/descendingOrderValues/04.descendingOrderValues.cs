using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace descendingOrderValues
{
    class descendingOrderValues
    {
        static void Main(string[] args)
        {
            Console.Write("Enter three real numbers.\nnum one = ");
            double numOne = double.Parse(Console.ReadLine());
            Console.Write("num two = ");
            double numTwo = double.Parse(Console.ReadLine());
            Console.Write("num three = ");
            double numThree = double.Parse(Console.ReadLine());
            if (numOne > numTwo)
            {
                if (numTwo > numThree)
                {
                    Console.Write("Descending order: {0}, {1}, {2}", numOne, numTwo, numThree);
                }
                else if (numThree > numOne)
                {
                    Console.Write("Descending order: {0}, {1}, {2}", numThree, numOne, numTwo);
                }
                else
                {
                    Console.Write("Descending order: {0}, {1}, {2}", numOne, numThree, numTwo);
                }
            }
            else if (numThree > numTwo)
            {
                Console.Write("Descending order: {0}, {1}, {2}", numThree, numTwo, numOne);
            }
            else if (numOne > numThree)
            {
                Console.Write("Descending order: {0}, {1}, {2}", numTwo, numOne, numThree);
            }
            else
            {
                Console.Write("Descending order: {0}, {1}, {2}", numTwo, numThree, numOne);
            }
            Console.WriteLine();

            double[] array = { numOne, numTwo, numThree };
            Array.Sort(array);
            Array.Reverse(array);
            foreach (double index in array)
            {
                Console.WriteLine(index);
            }

            List<double> list = new List<double>();
            list.Add(numOne);
            list.Add(numTwo);
            list.Add(numThree);
            list.Sort();
            list.Reverse();
            foreach (double value in list)
            {
                Console.WriteLine(value);
            }
        }
    }
}
