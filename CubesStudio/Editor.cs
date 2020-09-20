using CubesStudio.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CubesStudio
{
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private List<Shape> shapes = new List<Shape>();
        private Shape selected;

        private void Form1_Load(object sender, EventArgs e)
        {
            shapes.Add(new Rect(0, 0, 20, 20)
            {
                Stroke = Color.Red
            });

            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            foreach (var s in shapes)
            {
                s.Render(e.Graphics);
            }

            if (selected != default)
            {
                e.Graphics.DrawRectangle(Pens.Blue, selected.X, selected.Y, selected.Width, selected.Height);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Editor_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var s in shapes)
            {
                if (s.X < e.X && s.Y < e.Y && s.X + s.Width > e.X && s.Y + s.Height > e.Y)
                {
                    selected = s;
                    Refresh();
                    return;
                }
            }
            selected = default;
            Refresh();
        }
    }
}
