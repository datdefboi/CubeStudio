using CubesStudio.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CubesStudio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Shape> shapes = new List<Shape>();

        private void Form1_Load(object sender, EventArgs e)
        {
            shapes.Add(new Rectangle(0, 0, 20, 20));
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            foreach(var s in shapes)
            {
                s.Render(e.Graphics);
            }
        }
    }
}
