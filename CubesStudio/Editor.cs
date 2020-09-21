using CubesStudio.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        private int dragStartLength = 4;
        private int resizeBoundSize = 4;

        private Point dragOrigin;
        private Point dragOffset;
        private bool isInDrag = false;

        private Point mouseLoc;

        private ResizeState resizeState = ResizeState.Idle;
        private Point resizeOrigin;

        private void Form1_Load(object sender, EventArgs e)
        {
            shapes.Add(new Rect(100, 100, 200, 200)
            {
                Fill = Color.Teal
            });

            FillColorsBoxes();

            DoubleBuffered = true;

            renderBox.Refresh();
        }

        private void FillColorsBoxes()
        {
            var colors = new List<string>();
            foreach (var p in typeof(Color).GetProperties())
            {
                colors.Add(p.Name);
            }
            var colorArray = colors.SkipLast(9).ToArray();

            fillColorBox.Items.AddRange(colorArray);
            strokeColorBox.Items.AddRange(colorArray);
        }

        protected void renderBox_OnPaint(object sender, PaintEventArgs e)
        {
            foreach (var s in shapes.OrderBy(p=>p.Order))
            {
                s.Render(e.Graphics);
            }

            if (selected != default)
            {
                e.Graphics.DrawRectangle(Pens.Black, selected.X, selected.Y, selected.Width, selected.Height);

                void DrawBound(int x, int y)
                {
                    e.Graphics.FillRectangle(Brushes.Black, x - resizeBoundSize, y - resizeBoundSize, resizeBoundSize * 2, resizeBoundSize * 2);
                }

                DrawBound(selected.X, selected.Y);
                DrawBound(selected.X + selected.Width, selected.Y);
                DrawBound(selected.X, selected.Y + selected.Height);
                DrawBound(selected.X + selected.Width, selected.Y + selected.Height);

            }
        }

        private void Editor_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLoc = e.Location;
          
            // check resize actions
            if (selected != default)
            {
                bool CheckBoundEntrance(int x, int y) =>
                    x - resizeBoundSize < e.X &&
                        y - resizeBoundSize < e.Y &&
                        x + resizeBoundSize > e.X &&
                        y + resizeBoundSize > e.Y;

                if (CheckBoundEntrance(selected.X, selected.Y))
                    resizeState = ResizeState.TopLeft;

                if (CheckBoundEntrance(selected.X + selected.Width, selected.Y))
                    resizeState = ResizeState.TopRight;

                if (CheckBoundEntrance(selected.X, selected.Y + selected.Height))
                    resizeState = ResizeState.BottomLeft;

                if (CheckBoundEntrance(selected.X + selected.Width, selected.Y + selected.Height))
                    resizeState = ResizeState.BottomRight;

                resizeOrigin = e.Location;
                if (resizeState != ResizeState.Idle)
                    return;
            }

            // check selection actions
            shapeToolbar.Visible = false;
            selected = default;
            foreach (var s in shapes.OrderByDescending(p=>p.Order))
            {
                if (s.X < e.X && s.Y < e.Y && s.X + s.Width > e.X && s.Y + s.Height > e.Y)
                {
                    selected = s;
                    AdjustToolbarsValues();
                    shapeToolbar.Visible = true;

                    break;
                }
            }

            if (selected != default)
                dragOrigin = e.Location;

            renderBox.Refresh();
        }

        private void AdjustToolbarsValues()
        {
            fillColorBox.Text = selected.Fill.Name;
            strokeColorBox.Text = selected.Stroke.Name;
            strokeWidthBox.Text = selected.StrokeWidth.ToString();
        }

        private void Editor_MouseMove(object sender, MouseEventArgs e)
        {
            if(resizeState != ResizeState.Idle)
            {
                var xC = e.X - resizeOrigin.X;
                var yC = e.Y - resizeOrigin.Y;

                switch (resizeState)
                {
                    case ResizeState.TopLeft:
                        selected.X = selected.X + xC;
                        selected.Y = selected.Y + yC;
                        selected.Resize(selected.Width - xC, selected.Height-yC);
                        break;
                    case ResizeState.TopRight:
                        selected.Y = selected.Y + yC;
                        selected.Resize(selected.Width + xC, selected.Height-yC);
                        break;
                    case ResizeState.BottomLeft:
                        selected.X = selected.X + xC;
                        selected.Resize(selected.Width - xC, selected.Height+yC);
                        break;
                    case ResizeState.BottomRight:
                        selected.Resize(selected.Width + xC, selected.Height+yC);
                        break;
                }

                resizeOrigin = e.Location;
                renderBox.Refresh();
                return;
            }

            if (dragOrigin != default && !isInDrag)
            {
                var x = e.X - dragOrigin.X;
                var y = e.Y - dragOrigin.Y;
                if (Math.Sqrt(x * x + y * y) > dragStartLength)
                {
                    isInDrag = true;
                    dragOffset = new Point(e.X - selected.X, e.Y - selected.Y);
                }
            }
            if (isInDrag)
            {
                selected.X = e.X - dragOffset.X;
                selected.Y = e.Y - dragOffset.Y;
                renderBox.Refresh();
            }
        }

        private void Editor_MouseUp(object sender, MouseEventArgs e)
        {
            dragOrigin = default;
            isInDrag = false;
            resizeState = ResizeState.Idle;
        }

        private void editorMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Shape newShape = default;
            switch (e.ClickedItem.Text)
            {
                case "Rectangle":
                    newShape = new Rect(mouseLoc.X, mouseLoc.Y, 100, 100)
                    {
                        Fill = Color.Violet,
                        Stroke = Color.White
                    };
                    break;
                case "Ellipse":
                    newShape = new Ellipse(mouseLoc.X, mouseLoc.Y, 100, 100)
                    {
                        Fill = Color.Red,
                        Stroke = Color.White
                    };
                    break;
            }

            if(shapes.Count!=0)
                newShape.Order = shapes.Max(p => p.Order) + 1;

            shapes.Add(newShape);
            renderBox.Refresh();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "removeShapeButton":
                    shapes.Remove(selected);
                    selected = default;
                    shapeToolbar.Visible = false;
                    break;
                case "toBackButton":
                    selected.Order = shapes.Min(p => p.Order) - 1;
                    break;
                case "toFrontButton":
                    selected.Order = shapes.Max(p => p.Order) +1;
                    break;
                case "applyButton":
                    selected.Fill = (Color)typeof(Color).GetProperty(fillColorBox.Text).GetValue(null);
                    selected.Stroke = (Color)typeof(Color).GetProperty(strokeColorBox.Text).GetValue(null);
                    selected.SetStrokeWidth(int.Parse(strokeWidthBox.Text));
                    break;
            }
            renderBox.Refresh();
        }
    }
}
