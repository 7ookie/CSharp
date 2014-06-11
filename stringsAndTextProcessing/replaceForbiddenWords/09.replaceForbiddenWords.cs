using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace replaceForbiddenWords
{
    class replaceForbiddenWords
    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET" +
                " Framework 4.0 and is implemented as a dynamic language in CLR.";
            string words = ".NET, CLR, Microsoft";
            Console.WriteLine(Regex.Replace(text, words.Replace(", ", "|"), m => new string('*', m.Length)));
            Console.WriteLine();

            //secound way
            string[] forbidenwords = { ".NET", "CLR", "Microsoft" };
            foreach (var item in forbidenwords)
            {
                text = text.Replace(item, new String('*', item.Length));
            }
            Console.WriteLine(text);
            
        }
    }
}
