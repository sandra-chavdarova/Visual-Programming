using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lines
{
    public class Scene
    {
        public List<Line> lines = new List<Line>();
        public Point PreviousLocation { get; set; } = Point.Empty;
        public Color Color { get; set; } = Color.Black;
        public int Thickness { get; set; } = 1;
        public Point Cursor { get; set; }
        public bool DrawPosition { get; set; } = true;
        public int Width { get; set; }
        public int Height { get; set; }

        public Scene(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Click(Point location)
        {
            if (PreviousLocation != Point.Empty)
            {
                // first click
                lines.Add(new Line(PreviousLocation, location, Color, Thickness));
            }
            PreviousLocation = location;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 1);
            if (DrawPosition)
            {
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawLine(pen, Cursor.X, 0, Cursor.X, Height);
                g.DrawLine(pen, 0, Cursor.Y, Width, Cursor.Y);
            }
            pen.Dispose();

            foreach (Line line in lines)
            {
                line.Draw(g);
            }
        }
    }
}
