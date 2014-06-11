using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hexadecimalToDecimal
{
    class hexadecimalToDecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hexadecimal number.\nhexadecimal number: ");
            string num = Console.ReadLine();
            char[] array = num.ToCharArray();
            Array.Reverse(array);
            num = new string(array);
            int sum = 0;
            int hex = 1;
            int temp = 0;
            for (int i = 0; i < num.Length; i++)
            {
                temp = 0;
                switch (num[i])
                {
                    case 'a': temp += 10; break;
                    case 'A': temp += 10; break;
                    case 'b': temp += 11; break;
                    case 'B': temp += 11; break;
                    case 'c': temp += 12; break;
                    case 'C': temp += 12; break;
                    case 'd': temp += 13; break;
                    case 'D': temp += 13; break;
                    case 'e': temp += 14; break;
                    case 'E': temp += 14; break;
                    case 'f': temp += 15; break;
                    case 'F': temp += 15; break;
                    default: temp = int.Parse(Convert.ToString(num[i])); break;
                }
                sum += temp * hex;
                hex *= 16;
            }
            Console.WriteLine("Decimal representation: " + sum);
            
            /*
            //hex to decimal
            Console.WriteLine("Enter hexadecimal number.");
            string digit = Console.ReadLine();
            int decNum = Convert.ToInt32(digit, 16);
            Console.WriteLine(decNum);
            */
        }
    }
}
