using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace hellowWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Hellow";
            string b = "World";
            object c = "Hellow" + " " + "World";
            string d = (string)c;
            Console.WriteLine(d);
        }
    }
}
