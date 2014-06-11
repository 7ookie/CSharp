using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bracketsCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string expr = Console.ReadLine();
            for (int i = 0; i < expr.Length; i++)
            {
                if (expr[i] == '(')
                {
                    counter++;
                }
                if (expr[i] == ')')
                {
                    counter--;
                }
            }
            if (counter != 0)
            {
                Console.WriteLine("Incorrect expression.");
            }
        }
    }
}
