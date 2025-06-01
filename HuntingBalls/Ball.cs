using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuntingBalls
{
    [Serializable]
    public class Ball
    {
        public static Random Random = new Random();
        public Color Color { get; set; }
        public static int Radius { get; set; } = 15;
        public int Direction { get; set; } // 2 - right, -2 - left, 1 - down, -1 - up
        public int Offset { get; set; }
        public Point Center { get; set; }

        public Ball(Point center)
        {
            Color = Color.Red;
            Offset = 15;
            int[] directions = { 2, -2, 1, -1 };
            Direction = directions[Random.Next(directions.Length)];
            Center = center;
        }

        public void Move()
        {
            switch (Direction)
            {
                case 2: Center = new Point(Center.X + Offset, Center.Y); break;
                case -2: Center = new Point(Center.X - Offset, Center.Y); break;
                case 1: Center = new Point(Center.X, Center.Y + Offset); break;
                default: Center = new Point(Center.X, Center.Y - Offset); break;
            }
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
            brush.Dispose();
        }

        public bool Hit(Point point)
        {
            double distance = Math.Sqrt(Math.Pow(Center.X - point.X, 2) + Math.Pow(Center.Y - point.Y, 2));
            return distance < Radius + 25;
        }
    }
}
