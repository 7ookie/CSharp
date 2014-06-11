using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace modifyBit
{
    class modifyBit
    {
        static void Main(string[] args)
        {
            Console.Write("Modify bit. \nEnter integer = ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter \"0\" or \"1\" = ");
            byte bit = byte.Parse(Console.ReadLine());
            Console.Write("Enter bit position = ");
            byte position = byte.Parse(Console.ReadLine());

            int mask = bit << position;
            if (bit == 0)
            {
                number = number & (~(1 << position)); //0
                Console.WriteLine(number);
            }
            else
            {
                number = number | (1 << position); //1
                Console.WriteLine(number);
            }
        }
    }
}
