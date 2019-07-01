using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class FreeDraw : Figure
    {
        public FreeDraw()
        {
        }

        public override void Draw(Graphics g, Pen pen, int X, int Y, int width, int height)
        {
            g.DrawEllipse(pen, X, Y ,width,height);
        }
    }
}
