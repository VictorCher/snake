using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int x, int y, char sym, int length)
        {
            length = length + x;
            pList = new List<Point>();
            for(int i = x; i < length; i++)
            {
                Point p = new Point(i, y, sym);
                pList.Add(p);
            }
        }

        
    }
}
