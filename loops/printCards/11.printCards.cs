using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace printCards
{
    class printCards
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print all cards except jockers.");
            for (int colors = 1; colors <= 4; colors++)
            {
                for (int cards = 2; cards <= 14; cards++)
                {
                    switch (cards)
                    {
                        case 2: Console.Write("two".PadRight(5)); break;
                        case 3: Console.Write("three".PadRight(5)); break;
                        case 4: Console.Write("four".PadRight(5)); break;
                        case 5: Console.Write("five".PadRight(5)); break;
                        case 6: Console.Write("six".PadRight(5)); break;
                        case 7: Console.Write("seven".PadRight(5)); break;
                        case 8: Console.Write("eight".PadRight(5)); break;
                        case 9: Console.Write("nine".PadRight(5)); break;
                        case 10: Console.Write("ten".PadRight(5)); break;
                        case 11: Console.Write("jack".PadRight(5)); break;
                        case 12: Console.Write("queen".PadRight(5)); break;
                        case 13: Console.Write("king".PadRight(5)); break;
                        case 14: Console.Write("ace".PadRight(5)); break;
                        default: break;
                    }
                    switch (colors)
                    {
                        case 1: Console.Write(" club".PadLeft(8)); break;
                        case 2: Console.Write(" diamond".PadLeft(8)); break;
                        case 3: Console.Write(" heart".PadLeft(8)); break;
                        case 4: Console.Write(" spade".PadLeft(8)); break;
                        default: break;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
