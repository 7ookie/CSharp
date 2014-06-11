using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace trimProject
{
    class trimProject
    {
        static void Main(string[] args)
        {
            string text = ".... .. We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. "
            + "So we are drinking all the day. We will move out of it in 5 days.";
            char[] trimer = new char[] { ' ', '.' };
            string result = text.Trim(trimer);
            Console.WriteLine(result);
            Console.WriteLine();

            //collector
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            /*
            string collector = "numbers: ";
            for (int i = 0; i < 200000; i++)
            {
                collector += i;
            }
            */
            StringBuilder build = new StringBuilder();
            for (int i = 0; i < 200000; i++)
            {
                build.Append(i);
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);

            
            StringBuilder rev = new StringBuilder();
            for (int i = text.Length - 1; i > 0; i--)
            {
                rev.Append(text[i]);
            }
            Console.WriteLine(rev);
            Console.WriteLine();
            Console.WriteLine(ExtractCapitals(text));
        }
        public static string ExtractCapitals(string wrd)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < wrd.Length; i++)
            {
                char ch = wrd[i];
                if (char.IsUpper(ch))
                {
                    result.Append(wrd[i]);
                }
            }
            return result.ToString();
        }
    }
}
