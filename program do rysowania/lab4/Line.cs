using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Line : Figure
    {
        public Line()
        { }

        public override void Draw(Graphics g, Pen pen, int startX, int startY, int endX, int endY)
        {
            g.DrawLine(pen, startX, startY, endX, endY);
        }
    }
}
