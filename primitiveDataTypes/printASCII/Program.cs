using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace printASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 127; i++)
            {
                Console.WriteLine("{0} = {1}", i, (char)i);
            }
        }
    }
}
