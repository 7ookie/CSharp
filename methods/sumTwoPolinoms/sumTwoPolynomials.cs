using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumTwoPolynomials
{
    class sumTwoPolynomials
    {
        static void Main(string[] args)
        {
            Console.Write("Enter lenght for the first polynomial. \nlenght = ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter polynomial elements. \nelement{i} = ");
                array[i] = int.Parse(Console.ReadLine());
            }/*
            Console.Write("Enter lenght for the first polynomial. \nlenght = ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter polynomial elements. \nelement{i} = ");
                array[i] = int.Parse(Console.ReadLine());
            }*/
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

    }
}
