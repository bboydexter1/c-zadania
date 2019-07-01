using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Rectangle : Figure
    {
        public Rectangle()
        { }

        public override void Draw(Graphics g, Pen pen, int startX, int startY, int x, int y)
        {   if(startX < x && startY < y)
                g.DrawRectangle(pen, startX, startY, x- startX, y- startY);
            if (startX < x && startY > y)
                g.DrawRectangle(pen, startX, y, x - startX, startY - y);
            if (startX > x && startY > y)
                g.DrawRectangle(pen, x, y, startX - x,startY-y);
            if (startX > x && startY < y)
                g.DrawRectangle(pen, x, startY, startX - x, y - startY);
        }
    }
}
