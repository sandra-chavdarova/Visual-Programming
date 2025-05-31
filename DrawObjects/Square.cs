using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawObjects
{
    public class Square : Shape
    {

        public int Size { get; set; }
        public int PulseCoef { get; set; } = 3;
        public Square(Point location, Color color, int Size) : base(color, location)
        {
            this.Size = Size;
            this.PulseCoef = PulseCoef;
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillRectangle(b, Location.X - Size / 2, Location.Y - Size / 2, Size, Size);
            b.Dispose();

            if (Selected)
            {
                Pen p = new Pen(Color.Green, 3);
                g.DrawRectangle(p, Location.X - Size / 2, Location.Y - Size / 2, Size, Size);
                p.Dispose();
            }
        }
        public override bool Hit(Point point)
        {
            Rectangle r = new Rectangle(Location.X - Size / 2, Location.Y - Size / 2, Size, Size);
            if (r.Contains(point))
            {
                Selected = !Selected;
                return true;
            }
            return false;
        }

        public override void Pulse()
        {
            if (Size >= 100 || Size <= 20)
            {
                PulseCoef *= -1;
            }
            Size += PulseCoef;
        }
    }
}
