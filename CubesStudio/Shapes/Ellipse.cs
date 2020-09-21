using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CubesStudio.Shapes
{
    class Ellipse : Shape
    {
        public Ellipse(int x, int y, int w, int h) : base(x, y, w, h) { }

        public override void Render(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Fill), X, Y, w, h);
            g.DrawEllipse(new Pen(Stroke, strokeWidth), X, Y, w, h);
        }
    }
}
