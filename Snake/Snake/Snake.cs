using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        //List<Point> pList = new List<Point>();
        public Snake(Point head, int Lenght, Direction direct)
        {
            pList = new List<Point>();
            for(int i = 0; i < Lenght; i++)
            {
                Point p = new Point(head);
                p.Move(i, direct);
                pList.Add(p);
            }
        }
      
    }
}
