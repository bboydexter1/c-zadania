using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public abstract class Figure
    {
        public int startPointX;
        public int startPointY;

        public Figure()
        {
        }

        public abstract void Draw(Graphics g, Pen pen, int startX, int startY, int x, int y);
    }
}
