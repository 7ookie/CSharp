using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace textChange
{
    class textChange
    {
        static void Main(string[] args)
        {
            string text = "We are living in an <upcase>yellow submarine</upcase>. We don't have anything else. Inside the submarine is very tight."
            + "So we are drinking all the day. We <upcase>will move out</upcase> of it in 5 days.";
            Console.WriteLine(Regex.Replace(text, "<upcase>(.*?)</upcase>", m => m.Groups[1].Value.ToUpper()));
        }
    }
}
