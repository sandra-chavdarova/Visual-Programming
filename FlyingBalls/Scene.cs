using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FlyingBalls
{
    [Serializable]
    public class Scene
    {
        List<Ball> Balls { get; set; }

        public static Random Random { get; set; } = new Random();
        public int Height { get; set; }
        public int Width { get; set; }
        public int Hits { get; set; } = 0;
        public int Misses { get; set; } = 0;

        public Scene(int height, int width)
        {
            Balls = new List<Ball>();
            this.Height = height;
            this.Width = width;
        }

        public void AddBall()
        {
            Balls.Add(new Ball(new Point(-2 * Ball.Radius, Random.Next(2 * Ball.Radius, Height - 2 * Ball.Radius))));
        }

        public void Move()
        {
            foreach (Ball ball in Balls)
            {
                ball.Move(5, 0);
            }

            foreach (Ball ball in Balls)
            {
                if (ball.Center.X - Ball.Radius > Width)
                {
                    ball.State = -1;
                }
            }

            for (int i = 0; i < Balls.Count; i++)
            {
                if (Balls[i].State == -1)
                {
                    Misses++;
                    Balls.RemoveAt(i);
                }
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Ball ball in Balls)
            {
                ball.Draw(g);
            }
        }

        public void Hit(Point location)
        {
            foreach (Ball ball in Balls)
            {
                ball.Hit(location);
            }
            for (int i = 0; i < Balls.Count; i++)
            {
                if (Balls[i].State == 3)
                {
                    Hits++;
                    Balls.RemoveAt(i);
                }
            }
        }
    }
}
