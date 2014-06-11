using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace stringToUnicode
{
    class stringToUnicode
    {
        static void Main(string[] args)
        {
            string text = "Hi.";
            StringBuilder builder = new StringBuilder();
            foreach (char c in text)
            {
                builder.Append("\\u");
                builder.Append(String.Format("{0:x4}", (int)c));
            }
            Console.WriteLine(builder);
        }
    }
}
