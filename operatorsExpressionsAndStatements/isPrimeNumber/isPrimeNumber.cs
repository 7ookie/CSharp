using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace isPrimeNumber
{
    class isPrimeNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Input positive integer. n = ");
            int n = int.Parse(Console.ReadLine());
            if (n == 2 || n == 3 || n == 5 || n == 7)
            {
                Console.WriteLine("Is prime.");
            }
            else if (((n % 2) == 0) || ((n % 3) == 0) || ((n % 5) == 0) || ((n % 7) == 0))
            {
                Console.WriteLine("Is not prime.");
            }
            else
            {
                Console.WriteLine("Is prime.");
            }
            
            Console.WriteLine("The prime numbers between 1 and 100 are:");
            bool prime = true;
            for (byte num = 0; num <= 100; num++)
            {
                for (byte val = 2; val <= num; val++)
                {
                    if (num != val && num % val == 0)
                    {
                        prime = false;
                    }
                }
                if (prime)
                {
                    Console.Write(num + " ");
                }
                prime = true;
            }
            Console.WriteLine();
        }
    }
}
