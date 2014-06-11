using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace usersChoiceInputs
{
    class usersChoiceInputs
    {
        static void Main(string[] args)
        {
            Console.Write("Pick input as follows:\n1 for int\n2 for double\n3 for string\nInput: ");
            //start:
            //for (; ; )
            //{
                byte choice = byte.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1: int integer = int.Parse(Console.ReadLine());
                        Console.WriteLine("Increace it with 1. " + (integer + 1));
                        break;
                    case 2: double real = double.Parse(Console.ReadLine());
                        Console.WriteLine("Increace it with 1. " + (real + 1));
                        break;
                    case 3: string some = Console.ReadLine();
                        Console.WriteLine("Append *. " + (some + "*"));
                        break;
                    default: Console.WriteLine("Wrong input! Try again.");
                        //goto start;
                        break;
                }
            //}
        }
    }
}
