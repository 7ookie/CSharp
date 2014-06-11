using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace fallingRocks
{
    class fallingRocks
    {
        static void Main(string[] args)
        {

            //The solution is not mine and it is not complete for now. I try to understand it and write it by myself.
            /*
            Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight;
            DateTime startTime = DateTime.Now;
            double sleepTime = 50;
            
            Position dwarf = new Position(39, 24); //Position(int x, int y)
            Console.SetCursorPosition(dwarf.x, dwarf.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("0");
            Console.SetCursorPosition(dwarf.x + 1, dwarf.y);
            Console.Write(")");
            Console.SetCursorPosition(dwarf.x - 1, dwarf.y);
            Console.Write("(");

            List<Position> andRock = RocksArray();
            PrintRock(andRock, "&");
            List<Position> caretRock = RocksArray();
            PrintRock(caretRock, "^");
            List<Position> dashRock = RocksArray();
            PrintRock(dashRock, "-");
            List<Position> dollarRock = RocksArray();
            PrintRock(dollarRock, "$");
            List<Position> exclamationRock = RocksArray();
            PrintRock(exclamationRock, "!");
            List<Position> asteriskRock = RocksArray();
            PrintRock(asteriskRock, "*");
            List<Position> percentRock = RocksArray();
            PrintRock(percentRock, "%");
            List<Position> dotRock = RocksArray();
            PrintRock(dotRock, ".");
            List<Position> semicolonRock = RocksArray();
            PrintRock(semicolonRock, ";");
            List<Position> numberRock = RocksArray();
            PrintRock(numberRock, "#");
            List<Position> plusRock = RocksArray();
            PrintRock(plusRock, "+");
            List<Position> atRock = RocksArray();
            PrintRock(atRock, "@");

            int speedMeter = 1;
            Console.ReadKey();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey();
                    MoveDwarf(ref dwarf, pressedKey);
                }
            }
        }
        public static void MoveDwarf(ref Position dwarf, ConsoleKeyInfo pressedKey)
        { 
            
        }
        struct Position
        {
            public int x;
            public int y;
            public Position(int x, int y)
            { 
                this.x = x;
                this.y = y;
            }
        }
        private static List<Position> RocksArray()
        {
            Random randomGenerator = new Random(DateTime.Now.Millisecond);
            List<Position> rocks = new List<Position>();
            for (int i = 0; i < randomGenerator.Next(2, 7); i++)
            {
                rocks.Add(new Position(randomGenerator.Next(1, Console.WindowWidth - 1),
                                      (randomGenerator.Next(1, Console.WindowHeight - 13))));
            }
            return rocks;
        }
        private static void PrintRock(List<Position> rocks, string rock)
        {
            Random randomGenerator = new Random(DateTime.Now.Millisecond);
            ConsoleColor[] colours = 
            {
                ConsoleColor.Blue,
                ConsoleColor.Green,
                ConsoleColor.Yellow,
                ConsoleColor.White,
                ConsoleColor.Red,
                ConsoleColor.Cyan,
                ConsoleColor.Black //xoxo
            };

            for (int i = 0; i < rocks.Count; i++)
            {
                Console.SetCursorPosition(rocks[i].x, rocks[i].y);
                Console.ForegroundColor = colours[randomGenerator.Next(0, colours.Length)];
                Console.Write(rock);
            }
            */
        }
    }
}
