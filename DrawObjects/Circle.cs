using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawObjects
{
    public class Circle : Shape
    {
        public int Radius { get; set; }
        public int PulseCoef { get; set; } = 3;

        public Circle(Point location, Color color, int radius) : base(color, location)
        {
            Radius = radius;
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Location.X - Radius, Location.Y - Radius, Radius * 2, Radius * 2);
            b.Dispose();

            if (Selected)
            {
                Pen p = new Pen(Color.Green);
                g.DrawEllipse(p, Location.X - Radius, Location.Y - Radius, 2 * Radius, 2 * Radius);
                p.Dispose();
            }
        }
        public override bool Hit(Point point)
        {
            if (Math.Sqrt(Math.Pow(Location.X - point.X, 2) + Math.Pow(Location.Y - point.Y, 2)) <= Radius)
            {
                Selected = !Selected;
                return true;
            }
            return false;
        }
        public override void Pulse()
        {
            if (Radius >= 50 || Radius <= 10)
            {
                PulseCoef *= -1;
            }
            Radius += PulseCoef;
        }
    }
}
