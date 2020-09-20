using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CubesStudio
{
    abstract class Shape
    {
        public int x, y, w, h;

        public Shape(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }

        public void MoveTo(int x, int y)
        {
            if (x < 0 || y < 0)
                throw new ArgumentOutOfRangeException();

            this.x = x;
            this.y = y;
        }

        public abstract void Render(Graphics g);
    }
}
