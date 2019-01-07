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
            HorizontalLine HLine = new HorizontalLine(3,3,'+',5);
            HLine.Draw();
            VerticalLine VLine = new VerticalLine(10, 10, '+', 4);
            VLine.Draw();
            Console.ReadLine();
        }
    }
}
