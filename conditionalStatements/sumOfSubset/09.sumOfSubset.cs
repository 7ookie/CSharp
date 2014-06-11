using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sumOfSubset
{
    class sumOfSubset
    {
        static void Main(string[] args)
        {
            Console.Write("Enter five integer numbers. Is there sum of some subset equal to zero?\na = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d = ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("e = ");
            int e = int.Parse(Console.ReadLine());
            if(a + b == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}", a, b);
            }
            else if(a + c == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}", a, c);
            }
            else if(a + d == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}", a, d);
            }
            else if(a + e == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}", a, e);
            }
            else if(b + c == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}", b, c);
            }
            else if(b + d == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}", b, d);
            }
            else if(b + e == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}", b, e);
            }
            else if(c + d == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}", c, d);
            }
            else if(c + e == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}", c, e);
            }
            else if(d + e == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}", d, e);
            }
            else if(a + b + c == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}", a, b, c);
            }
            else if(a + b + d == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}", a, b, d);
            }
            else if(a + b + e == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}", a, b, e);
            }
            else if(b + c + d == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}", b, c, d);
            }
            else if(b + c + e == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}", b, c, e);
            }
            else if(c + d + e == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}", c, d, e);
            }
            else if (a + b + c == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}", a, b, c);
            }
            else if (a + b + d == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}", a, b, d);
            }
            else if (a + b + e == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}", a, b, e);
            }
            else if (a + c + d == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}", a, c, d);
            }
            else if (a + d + e == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}", a, d, e);
            }
            else if (a + c + e == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}", a, c, e);
            }
            else if (b + c + d == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}", b, c, d);
            }
            else if (b + d + e == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}", b, d, e);
            }
            else if (c + d + e == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}", c, d, e);
            }
            else if (b + c + e == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}", b, c, e);
            }
            else if (a + b + c + d == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}, {3}", a, b, c, d);
            }
            else if (a + b + d + e == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}, {3}", a, b, d, e);
            }
            else if (a + c + d + e == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}, {3}", a, c, d, e);
            }
            else if (a + b + c + e == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}, {3}", a, b, c, e);
            }
            else if (b + c + d + e == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}, {3}", b, c, d, e);
            }
            else if (a + b + c + d + e == 0)
            {
                Console.WriteLine("Subset with zero sum. {0}, {1}, {2}, {3}, {4}", a, b, c, d, e);
            }
            else
            {
                Console.WriteLine("There is no such subset.");
            }
        }
    }
}
