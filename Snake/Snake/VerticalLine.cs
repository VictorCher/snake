using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int x, int y, char sym, int length)
        {
            length = length + y;
            pList = new List<Point>();
            for (int i = y; i < length; i++)
            {
                Point p = new Point(x, i, sym);
                pList.Add(p);
            }
        }
    }
}
