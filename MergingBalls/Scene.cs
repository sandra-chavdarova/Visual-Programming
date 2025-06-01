using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergingBalls
{
    [Serializable]
    public class Scene
    {
        public List<Ball> Balls { get; set; } = new List<Ball>();
        public int Width { get; set; }
        public int Height { get; set; }
        public Scene(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public void Draw(Graphics g)
        {
            foreach (Ball ball in Balls)
            {
                ball.Draw(g);
            }
        }

        public void Move()
        {
            foreach (Ball ball in Balls)
            {
                ball.Move();
                if (ball.Direction % 2 == 0) // up and down
                {
                    if (ball.Center.Y + 10 > this.Height - 10 || ball.Center.Y - 10 < 10)
                        ball.Direction = -ball.Direction;
                }
                else // left and right
                {
                    if (ball.Center.X + 10 > this.Width - 10 || ball.Center.X - 10 < 10)
                        ball.Direction = -ball.Direction;
                }
            }
        }

        public void AddBall(Point center)
        {
            Balls.Add(new Ball(center));
        }

        public void MergeBalls()
        {
            for (int i = 0; i < Balls.Count; i++)
            {
                Ball b1 = Balls[i];
                for (int j = i + 1; j < Balls.Count; j++)
                {
                    Ball b2 = Balls[j];
                    if (b1.AreMerged(b2))
                    {
                        int newRadius = (b1.Radius + b2.Radius) / 2;
                        Point newCenter = new Point((b1.Center.X + b2.Center.X) / 2, (b1.Center.Y + b2.Center.Y) / 2);

                        Balls.RemoveAt(j);

                        Balls[i].Center = newCenter;
                        Balls[i].Radius = newRadius;
                        Balls[i].Direction = 2;
                    }
                }
            }
        }
    }
}
