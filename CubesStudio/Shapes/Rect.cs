using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CubesStudio.Shapes
{
    class Rect : Shape
    {
        public Rect(int x, int y, int w, int h) : base(x, y, w, h) { }

        public override void Render(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Fill), X, Y, w, h);
            g.DrawRectangle(new Pen(Stroke, strokeWidth), X, Y, w, h);
        }
    }
}
