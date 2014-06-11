using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace printName
{
    class printName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            PrintName(Console.ReadLine());
        }
        static string PrintName(string name)
        {
            Console.WriteLine("Hellow \"{0}\"!", name);
            return name;
        }
    }
}
