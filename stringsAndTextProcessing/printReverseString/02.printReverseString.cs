using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printReverseString
{
    class printReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string.");
            string word = Console.ReadLine();
            string reversed = string.Empty; //or "" instead string.Empty

            reversed = new string(word.ToCharArray().Reverse().ToArray()); //first way
            Console.WriteLine(reversed);

            char[] rev = new char[word.Length]; //second way
            rev = word.ToCharArray();
            Array.Reverse(rev);
            Console.WriteLine(rev);

            StringBuilder build = new StringBuilder(); //third way
            for (int i = word.Length - 1; i > -1; i--)
            {
                build.Append(word[i]);
            }
            Console.WriteLine(build);
        }
    }
}
