using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace bonusScores
{
    class bonusScores
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number from one to nine including.\nnumber = ");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Multipy by  10." + num * 10);
                    break;
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Multipy by 100." + num * 100);
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("Multipy by 1000." + num * 1000);
                    break;
                default:
                    Console.WriteLine("Error! Wrong input. Try again.");
                    break;
            }
        }
    }
}
