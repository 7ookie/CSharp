using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findSubstringFrequency
{
    class findSubstringFrequency
    {
        static void Main(string[] args)
        {
            string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight."
            + "So we are drinking all the day. We will move out of it in 5 days.";
            string keyword = "in";
            int index = text.ToLower().IndexOf(keyword);
            int counter = 0;
            while (index != -1)
            {
                index = text.ToLower().IndexOf(keyword, index + 1);
                if (index != 0)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
