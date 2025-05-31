using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Polygons
{
    [Serializable]
    public class Polygon
    {
        List<Point> Points { set; get; } = new List<Point>();
        public bool Completed { get; set; } = false;
        public Color Color { get; set; }
        public Point Cursor { get; set; }

        public Polygon(Color color)
        {
            Color = color;
        }

        public void AddPoint(Point p)
        {
            Cursor = p;
            if (NearStart() && Points.Count >= 3)
            {
                Points.Add(Points[0]);
                Completed = true;
            }
            else
            {
                Points.Add(p);
            }
        }

        private bool NearStart()
        {
            if (Points.Count > 2)
                return Math.Sqrt(Math.Pow(Cursor.X - Points[0].X, 2) + Math.Pow(Cursor.Y - Points[0].Y, 2)) < 10;
            else
                return false;
        }
        public void Draw(Graphics g)
        {
            if (Completed)
            {
                Pen pen = new Pen(Color.Black, 3);
                g.DrawPolygon(pen, Points.ToArray());
                pen.Dispose();

                Brush brush = new SolidBrush(this.Color);
                g.FillPolygon(brush, Points.ToArray());
                brush.Dispose();
            }
            else if (Points.Count >= 2)
            {
                Pen pen = new Pen(Color.Black, 2);
                g.DrawLines(pen, Points.ToArray());
                if (NearStart())
                {
                    g.DrawEllipse(pen, Points[0].X - 10, Points[0].Y - 10, 20, 20);
                }
                pen.Dispose();
            }
        }
    }
}
