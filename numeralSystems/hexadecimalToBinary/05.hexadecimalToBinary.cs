using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hexadecimalToBinary
{
    class hexadecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Enter hexadecimal number: ");
            string num = Console.ReadLine();
            string sum = string.Empty;
            int number = 0;
            for (int i = 0; i < num.Length; i++)
            {
                number = 0;
                switch (num[i])
                {
                    case '0': number += 0000; break;
                    case '1': number += 0001; break;
                    case '2': number += 0010; break;
                    case '3': number += 0011; break;
                    case '4': number += 0100; break;
                    case '5': number += 0101; break;
                    case '6': number += 0110; break;
                    case '7': number += 0111; break;
                    case '8': number += 1000; break;
                    case '9': number += 1001; break;
                    case 'a': number += 1010; break;
                    case 'A': number += 1010; break;
                    case 'b': number += 1011; break;
                    case 'B': number += 1011; break;
                    case 'c': number += 1100; break;
                    case 'C': number += 1100; break;
                    case 'd': number += 1101; break;
                    case 'D': number += 1101; break;
                    case 'e': number += 1110; break;
                    case 'E': number += 1110; break;
                    case 'f': number += 1111; break;
                    case 'F': number += 1111; break;
                    default: break;
                }
                sum += number.ToString();
            }
            Console.WriteLine("It's binary representation is: {0}", sum);
        }
    }
}
