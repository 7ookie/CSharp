using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace twentyCharacters
{
    class twentyCharacters
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string between 0 and 20 characters include.");
            string str = Console.ReadLine();
            
            //first way

            if (str.Length > 20)
            {
                Console.WriteLine("The string must be less than 20 characters include.");
            }
            else if (str.Length == 20)
            {
                Console.WriteLine(str);
            }
            else if (str.Length < 20)
            {
                Console.WriteLine(str.PadRight(20, '*'));
            }

            // second way

            if (str.Length < 20)
            {
                str = str.Insert(str.Length, new string('*', 20 - str.Length));
                // another way to cut Console.WriteLine(userInput.Remove(20));
                Console.WriteLine(str);
            }
            
            //third way

            StringBuilder build = new StringBuilder();
            for (int i = str.Length; i < 20; i++)
            {
                build.Append('*');
            }
            Console.WriteLine(str + build);
        }
    }
}
