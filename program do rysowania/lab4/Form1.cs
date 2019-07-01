using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        private bool _canDraw;
        private int _startX, _startY;
        Pen pen;
        Figure figureToDraw;

        public Form1()
        {
            InitializeComponent();
            pen = Pens.Red;
            figureToDraw = new FreeDraw();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _canDraw = true;

            _startX = e.X;
            _startY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            //The system is no longer allowed to draw rectangles
            if (_canDraw == true && figureToDraw.GetType() != typeof(FreeDraw))
            {
                Graphics g = panel1.CreateGraphics();
                figureToDraw.Draw(g, pen, _startX, _startY, e.X, e.Y);
            }
            _canDraw = false;
        }

        private void redBtn_Click(object sender, EventArgs e)
        {
            pen = Pens.Red;
        }

        private void blueBtn_Click(object sender, EventArgs e)
        {
            pen = Pens.Blue;
        }

        private void greenBtn_Click(object sender, EventArgs e)
        {
            pen = Pens.Green;
        }

        private void lineBtn_Click(object sender, EventArgs e)
        {
            figureToDraw = new Line();
        }

        private void recBtn_Click(object sender, EventArgs e)
        {
            figureToDraw = new Rectangle();
        }

        private void freeDrawBtn_Click(object sender, EventArgs e)
        {
            figureToDraw = new FreeDraw();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_canDraw == true && figureToDraw.GetType() == typeof(FreeDraw))
            {
                Graphics g = panel1.CreateGraphics();
                figureToDraw.Draw(g,pen, e.X, e.Y, 2, 2);//g.DrawEllipse(pen, e.X, e.Y ,2,2);
            }
        }
    }
}
