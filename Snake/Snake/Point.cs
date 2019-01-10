using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        private int x;
        private int y;
        private char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direct)
        {
            if (direct == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if(direct == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direct == Direction.DOWN)
            {
                y = y + offset;
            }
            else if (direct == Direction.UP)
            {
                y = y - offset;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
