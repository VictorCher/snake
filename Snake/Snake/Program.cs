using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine HLine1 = new HorizontalLine(1, 1,'+', 10);
            HLine1.Draw();
            HorizontalLine HLine2 = new HorizontalLine(1, 10, '+', 10);
            HLine2.Draw();
            VerticalLine VLine1 = new VerticalLine(1, 2, '+', 8);
            VLine1.Draw();
            VerticalLine VLine2 = new VerticalLine(10, 2, '+', 8);
            VLine2.Draw();

            Point p = new Point(15, 15, '*');
            Snake worm = new Snake(p, 5, Direction.DOWN);
            worm.Draw();

            Console.ReadLine();
        }
    }
}
