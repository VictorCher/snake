﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direct;
        public Snake(Point head, int Lenght, Direction _direct)
        {
            direct = _direct;
            pList = new List<Point>();
            for(int i = 0; i < Lenght; i++)
            {
                Point p = new Point(head);
                p.Move(i, direct);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);
            tail.Clear();
            head.Draw();
            
        }
        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direct);
            return nextPoint;
        }
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.RightArrow) direct = Direction.RIGHT;
            else if (key == ConsoleKey.LeftArrow) direct = Direction.LEFT;
            else if (key == ConsoleKey.UpArrow) direct = Direction.UP;
            else if (key == ConsoleKey.DownArrow) direct = Direction.DOWN;
        }
    }
}
