using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseSentence
{
    class reverseSentence
    {
        static void Main(string[] args)
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";
            char[] reversed = sentence.Reverse().ToArray();
            char[] result = new char[reversed.Length];
            StringBuilder build = new StringBuilder();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (reversed[i].ToString() != " ")
                {
                    result[i] = reversed[i];
                }
                else if (reversed[i].ToString() == " ")
                {
                    build.Append(" ");   
                }
            }
            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}
