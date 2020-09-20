using System;
using System.Drawing;

namespace CubesStudio
{
    abstract class Shape
    {
        protected int x, y, w, h;
        protected int strokeWidth;

        public int X => x;
        public int Y => y;
        public int Width => w;
        public int Height => h;

        public Color Fill { get; set; } = Color.Transparent;
        public Color Stroke { get; set; } = Color.Transparent;
        public int StrokeWidth => strokeWidth;

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
        public void SetStrokeWidth(int sw)
        {
            if (sw < 1)
                throw new ArgumentOutOfRangeException();

            strokeWidth = sw;
        }

        public abstract void Render(Graphics g);
    }
}
