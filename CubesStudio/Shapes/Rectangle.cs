using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CubesStudio.Shapes
{
    class Rectangle : Shape
    {
        public Rectangle(int x, int y, int w, int h) : base(x, y, w, h) { }

        public override void Render(Graphics g)
        {
            g.FillRectangle(Brushes.Black, x, y, w, h);
        }
    }
}
