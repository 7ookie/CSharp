using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace convertFromAnyNumSystem
{
    class convertFromAnyNumSystem
    {
        static void Main(string[] args)
        {
            Console.Write("Enter binary, decimal or hexadecimal digit.\ndigit = ");
            string number = Console.ReadLine().ToUpper();
            Console.Write("Enter base for the entered digit. The must be >=2 or <=16.\nbase = ");
            int fromBase = int.Parse(Console.ReadLine());
            Console.Write("Enter the base you want to be convert it.\nconvert to base? = ");
            int toBase = int.Parse(Console.ReadLine());

            int result = 0;
            if (fromBase == 2 && toBase == 10) //binaty to decimal convertion
            {
                for (int i = 0; i < number.Length; i++)
                {
                    if (number[number.Length - i - 1] == '0')
                    {
                        continue;
                    }
                    result = result + (int)Math.Pow(2, i);
                }
                Console.WriteLine("Binary to decimal convertion:\ndecimal = " + result);
            }
            else if (fromBase == 16 && toBase == 10) //hexadecimal to decimal convertion
            {
                char[] array = number.ToCharArray();
                Array.Reverse(array);
                number = new string(array);
                int sum = 0;
                int hex = 1;
                int temp = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    temp = 0;
                    switch (number[i])
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
                        default: temp = int.Parse(Convert.ToString(number[i])); break;
                    }
                    sum += temp * hex;
                    hex *= 16;
                }
                Console.WriteLine("Decimal representation: " + sum);
            }

            /*
            Console.WriteLine("This program converts a number from one numeral system to another (2-16)");
            Console.Write("Please enter your number: ");
            string numberInput = Console.ReadLine();
            Console.Write("Please enter the base of the numeral system of your number: ");
            int fromBase = int.Parse(Console.ReadLine());
            Console.Write("Please enter the base that your number will be converted to: ");
            int toBase = int.Parse(Console.ReadLine());
            if (fromBase == toBase)
            {
                Console.WriteLine("The 2 bases that you entered are the same, number will not change");
            }
 
            else
            {
                char currentChar = new char();
                int digit = new int();
                int number = 0;
                for (int i = 0; i < numberInput.Length; i++)
                {
                    currentChar = numberInput[i];
                    if (currentChar >= 'a')
                    {
                        digit = currentChar - 'a' + 10;
                    }
                    else
                    {
                        digit = currentChar - '0';
                    }
                    number += (int)(digit * Math.Pow((double)fromBase, (numberInput.Length - i - 1)));
                }
 
                string numberOutput = string.Empty;
                while (number != 0)
                {
                    int remainder = number % toBase;
                    if (remainder <= 9)
                    {
                        numberOutput = remainder + numberOutput;
                    }
                    else
                    {
                        numberOutput = ((char)('A' + remainder - 10)) + numberOutput;
                    }
                    number /= toBase;
                }
                Console.WriteLine("The result is {0}", numberOutput);
            }
            */
        }
    }
}
