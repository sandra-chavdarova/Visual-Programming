using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntingBalls
{
    [Serializable]
    public class BlackBall
    {
        public int Radius { get; set; }
        public Color Color { get; set; } = Color.Black;
        public Point Center { get; set; }

        public BlackBall(Point center)
        {
            Radius = 25;
            Color = Color.Black;
            Center = new Point(center.X, center.Y);
        }

        public void Move(Point center)
        {
            Center = new Point(center.X, center.Y);
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
            brush.Dispose();
        }
    }
}
