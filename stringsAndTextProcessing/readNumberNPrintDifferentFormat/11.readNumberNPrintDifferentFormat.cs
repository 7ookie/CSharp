using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace readNumberNPrintDifferentFormat
{
    class readNumberNPrintDifferentFormat
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("{0:0.00}".PadLeft(17), (double)num);
            Console.WriteLine(num.ToString("X").PadLeft(15));
            Console.WriteLine("{0:0.0%}".PadLeft(15), num);
            Console.WriteLine(num.ToString("G1", CultureInfo.InvariantCulture).PadLeft(15));
        }
    }
}
