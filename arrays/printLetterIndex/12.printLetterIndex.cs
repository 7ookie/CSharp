using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace printLetterIndex
{
    class printLetterIndex
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word: ");
            string word = Console.ReadLine();
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz".ToCharArray();
            for (int i = 0; i < word.Length; i++)
            {
                for (int z = 0; z < alpha.Length; z++)
                {
                    if (word[i] == alpha[z])
                    {
                        Console.WriteLine("Letter {0} index {1}", i, z);
                    }
                }
            }
        }
    }
}
