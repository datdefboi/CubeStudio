using System;
using System.Drawing;

namespace CubesStudio
{
    abstract class Shape
    {
        protected int strokeWidth;

        public int X { get; set; }
        public int Y { get; set; }

        public int Order { get; set; } = 0;

        protected int w, h;
        public int Width => w;
        public int Height => h;

        public Color Fill { get; set; } = Color.Transparent;
        public Color Stroke { get; set; } = Color.Transparent;
        public int StrokeWidth => strokeWidth;

        public Shape(int x, int y, int w, int h)
        {
            this.X = x;
            this.Y = y;
            this.w = w;
            this.h = h;
        }
        public void Resize(int width, int height)
        {
            if (width < 0 || height < 0)
                throw new ArgumentOutOfRangeException();

            this.w = width;
            this.h = height;
        }
        public void SetStrokeWidth(int sw)
        {
            if (sw < 0)
                throw new ArgumentOutOfRangeException();

            strokeWidth = sw;
        }

        public abstract void Render(Graphics g);
    }
}
