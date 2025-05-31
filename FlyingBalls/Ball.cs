using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingBalls
{
    [Serializable]
    public class Ball
    {
        public static int Radius { get; set; } = 40;
        public static Random Random = new Random();
        public Point Center { get; set; }
        // 0 - red, 1 - blue, 2 - green, 3 - delete, -1 - out of window
        public int State { get; set; }

        public Ball(Point center)
        {
            Center = center;
            State = Random.Next(3);
        }

        public void Draw(Graphics g)
        {
            Color color;
            switch (State)
            {
                case 0: color = Color.Red; break;
                case 1: color = Color.Blue; break;
                default: color = Color.Green; break;
            }
            Brush brush = new SolidBrush(color);
            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
            brush.Dispose();
        }

        public void Move(int dx, int dy)
        {
            Center = new Point(Center.X + dx, Center.Y + dy);

        }

        public bool Hit(Point point)
        {
            double distance = Math.Sqrt(Math.Pow(Center.X - point.X, 2) + Math.Pow(Center.Y - point.Y, 2));
            if (distance < Radius)
            {
                State++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
