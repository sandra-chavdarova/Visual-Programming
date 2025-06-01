using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergingBalls
{
    [Serializable]
    public class Ball
    {
        public Color Color { get; set; }
        public int Radius { get; set; }
        public Point Center { get; set; }
        public int Direction { get; set; }
        public static Random Random { get; set; } = new Random();

        public Ball(Point center)
        {
            this.Center = center;
            this.Color = Color.Red;
            this.Direction = Random.Next(1, 3); // 1 - right, 2 - down, opposite for opposite direction
            this.Radius = Random.Next(20, 40);
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
            brush.Dispose();
        }

        public void Move()
        {
            switch (Direction)
            {
                case 1: Center = new Point(Center.X + 10, Center.Y); break;
                case -1: Center = new Point(Center.X - 10, Center.Y); break;
                case 2: Center = new Point(Center.X, Center.Y + 10); break;
                default: Center = new Point(Center.X, Center.Y - 10); break;
            }
        }

        public bool AreMerged(Ball ball)
        {
            double distance = Math.Sqrt(Math.Pow(this.Center.X - ball.Center.X, 2) + Math.Pow(this.Center.Y - ball.Center.Y, 2));
            return distance < 2 * this.Radius + ball.Radius - 10; // to overlap
        }
    }
}
