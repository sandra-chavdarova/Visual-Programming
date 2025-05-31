using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawObjects
{
    public abstract class Shape
    {
        public Color Color { get; set; }
        public Point Location { get; set; }
        public bool Selected { get; set; } = false;

        public Shape(Color color, Point location)
        {
            Color = color;
            Location = location;
        }

        public abstract void Draw(Graphics g);
        public abstract bool Hit(Point point);
        public abstract void Pulse();
    }
}
