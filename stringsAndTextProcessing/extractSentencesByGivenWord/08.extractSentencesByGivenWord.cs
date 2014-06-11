using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace extractSentencesByGivenWord
{
    class extractSentencesByGivenWord
    {
        static void Main(string[] args)
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight." +
                "So we are drinking all the day. We will move out of it in 5 days.";
            string[] result = text.Split('.');
            char[] trimer = new char[] { ' ' };
            
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i].Contains(" in ") || result[i].Contains("in ") || result[i].Contains(" in"))
                {
                    Console.WriteLine(result[i].Trim(trimer));
                }
            }
        }
    }
}
