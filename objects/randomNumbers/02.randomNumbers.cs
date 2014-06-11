using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomNumbers
{
    class randomNumbers
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int nums = rnd.Next(100, 201);
                Console.WriteLine(i + " - " + nums);
            }
        }
    }
}
