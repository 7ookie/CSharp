using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculateTriangleSurface
{
    class calculateTriangleSurface
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number from the choices:");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter two real numbers as follows:\nside\naltitude");
                    decimal side = decimal.Parse(Console.ReadLine());
                    decimal altitude = decimal.Parse(Console.ReadLine());
                    Console.WriteLine(CalculateSurface(side, altitude));
                    break;
                case 2:
                    Console.WriteLine("Enter three real numbers as follows:\nside\nside\nside");
                    decimal a = int.Parse(Console.ReadLine());
                    decimal b = int.Parse(Console.ReadLine());
                    decimal c = int.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Enter three real numbers as follows:\nside\nside\nangle");
                    decimal d = int.Parse(Console.ReadLine());
                    decimal e = int.Parse(Console.ReadLine());
                    decimal f = int.Parse(Console.ReadLine());
                    break;
                default: break;
            }
        }
        static decimal CalculateSurface(decimal side, decimal altitude)
        {
            return (side * altitude) / 2;
        }
        static decimal CalculateAreaWithTreeSides(decimal a, decimal b, decimal c)
        {
            decimal perimeter = (a + b + c) / 2;
            decimal result = (decimal)Math.Sqrt((double)(perimeter * (perimeter - a) * (perimeter - b) * (perimeter - c)));
            return result;
        }
        static double CalculateWithAngle(double a, double b, double alpha)
        {
            return (a * b * Math.Sin(Math.PI * alpha / 180) / 2);
        }
    }
}
