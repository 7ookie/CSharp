using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace binaryToHexadecimal
{
    class binaryToHexadecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter binary number with lenght: 4, 8, 12, 16, 20, 24, 28, 32.\nbinary number: ");
            string num = Console.ReadLine();
            int check = int.Parse(num);
            string sum = string.Empty;
            StringBuilder builder = new StringBuilder();
            if (num.Length % 4 == 0)
            {
                for (int i = 0; i < num.Length; i += 4)
                {
                    switch (num.Substring(i, 4))
                    {
                        case "1010": builder.Append("A"); break;
                        case "1011": builder.Append("B"); break;
                        case "1100": builder.Append("C"); break;
                        case "1101": builder.Append("D"); break;
                        case "1110": builder.Append("E"); break;
                        case "1111": builder.Append("F"); break;
                        case "0000": builder.Append("0"); break;
                        case "0001": builder.Append("1"); break;
                        case "0010": builder.Append("2"); break;
                        case "0011": builder.Append("3"); break;
                        case "0100": builder.Append("4"); break;
                        case "0101": builder.Append("5"); break;
                        case "0110": builder.Append("6"); break;
                        case "0111": builder.Append("7"); break;
                        case "1000": builder.Append("8"); break;
                        case "1001": builder.Append("9"); break;
                        default: break;
                    }
                    sum += builder.ToString();
                }
            }
            else
            {
                Console.WriteLine("Try again.");
            }
            Console.WriteLine("Hexadecimal representation: " + sum);
        }
    }
}
