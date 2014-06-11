
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskEleven
{
    class taskEleven
    {
        static string number = "12345.67";
        /*
        static string a = "2";
        static string b = "3";
        static string c = "4.5";
        */
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case (1):
                    Console.WriteLine(PrintReverseDigit(number)); break;
                case (2): 
                    Console.WriteLine(MeanQuantity(number)); break;
                case (3):
                    string a = Console.ReadLine();
                    string b = Console.ReadLine();
                    string c = Console.ReadLine();
                    Console.WriteLine(LinearEquation(a, b, c)); break;
                default: Console.WriteLine("Enter integer number between 1 and 3 include."); break;
            }
            /*
            //(PrintReverseDigit(number+2) prints 27654321 (PrintReverseDigit(number)+2) prints 7654323
            Console.WriteLine(PrintReverseDigit(number)); 
            //mean quantity
            Console.WriteLine(MeanQuantity(number));
            //mean quantity
            Console.WriteLine(LinearEquation(a, b, c));
            */
        }
        static decimal PrintReverseDigit(string number)
        {
            char[] arr = number.ToCharArray();
            number = new string(arr);
            decimal check;
            check = Convert.ToDecimal(number);
            decimal reversed;
            if (check < 0)
            {
                return 0;
            }
            else
            {
                char[] array = number.ToCharArray();
                Array.Reverse(array);
                number = new string(array);
                reversed = Convert.ToDecimal(number);
            }
            return reversed;
        }
        static decimal MeanQuantity(string number)
        {
            decimal quantity;
            quantity = Convert.ToDecimal(number);
            if (quantity == 0)
            {
                return 0;
            }
            quantity = quantity / 2;
            return quantity;
        }
        static decimal LinearEquation(string a, string b, string c)
        {
            decimal one;
            decimal two;
            decimal tree;
            one = Convert.ToDecimal(a);
            if (one == 0)
            {
                return 0;
            }
            two = Convert.ToDecimal(b);
            tree = Convert.ToDecimal(c);
            return ((one * two) + tree);
        }
    }
}
