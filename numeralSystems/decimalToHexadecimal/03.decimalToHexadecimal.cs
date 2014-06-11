using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace decimalToHexadecimal
{
    class decimalToHexadecimal
    {
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number. \ndecimal number = ");
            int num = int.Parse(Console.ReadLine());
            int remainder = 0;
            string result = string.Empty;
            while (num > 0)
            {
                remainder = num % 16;
                num = num / 16;
                if (remainder < 10)
                {
                    result = remainder.ToString() + result;
                }
                switch (remainder)
                {
                    case 10: result = "A" + result; break;
                    case 11: result = "B" + result; break;
                    case 12: result = "C" + result; break;
                    case 13: result = "D" + result; break;
                    case 14: result = "E" + result; break;
                    case 15: result = "F" + result; break;
                    default:; break;
                }
            }
            Console.WriteLine("Hexadecimal representation: " + result);

            /*
            //decimal to hex
            Console.WriteLine("Enter decimal number.");
            int decValue = int.Parse(Console.ReadLine());
            string hexValue = decValue.ToString("x"); //x or X
            string gun = string.Format("{0:x}", decValue); //x or X
            Console.WriteLine(gun);
            Console.WriteLine(hexValue);
            
            */
        }
    }
}
