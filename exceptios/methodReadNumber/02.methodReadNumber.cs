using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodReadNumber
{
    class methodReadNumber
    {
        static void Main(string[] args)
        {
            string start = "1";
            string end = "101";

            Console.WriteLine(ReadNumber(Convert.ToInt32(start), Convert.ToInt32(end)));

            for (int i = 0; i < 10; i++)
            {
                start = (ReadNumber(Convert.ToInt32(start), Convert.ToInt32(end)));
            }
        }
        static string ReadNumber(int start, int end)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                if (start <= num && num <= end)
                {
                    return num.ToString();
                }
            }
            catch (System.FormatException)
            {
               
            }
            return "Invalid input.";
        }
    }
}
