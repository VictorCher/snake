using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine HLine1 = new HorizontalLine(0, 0,'+', 80);
            HLine1.Draw();
            HorizontalLine HLine2 = new HorizontalLine(0, 24, '+', 80);
            HLine2.Draw();
            VerticalLine VLine1 = new VerticalLine(0, 1, '+', 23);
            VLine1.Draw();
            VerticalLine VLine2 = new VerticalLine(79, 1, '+', 23);
            VLine2.Draw();

            Point p = new Point(15, 15, '*');
            Snake worm = new Snake(p, 5, Direction.DOWN);
            worm.Draw();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    worm.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                worm.Move();
            }
        }
    }
}
