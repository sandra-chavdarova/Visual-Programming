using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HuntingBalls
{
    [Serializable]
    public class Scene
    {
        public List<Ball> Balls { get; set; }
        public BlackBall BlackBall { get; set; } = null;

        public static Random Random { get; set; } = new Random();

        public int Height { get; set; }
        public int Width { get; set; }

        public Scene(List<Ball> balls, int height, int width)
        {
            Balls = balls;
            Height = height;
            Width = width;
        }

        public void AddBall()
        {
            Balls.Add(new Ball(new Point(Random.Next(Width + Ball.Radius), Random.Next(Height + Ball.Radius))));
        }

        public void Draw(Graphics g)
        {
            foreach (Ball ball in Balls)
            {
                ball.Draw(g);
            }
            if (BlackBall != null)
            {
                BlackBall.Draw(g);
            }
        }

        public void Click(Graphics g)
        {
            BlackBall.Draw(g);
        }

        public void Move()
        {
            foreach (Ball ball in Balls)
            {
                if ((ball.Direction == 2 && ball.Center.X + Ball.Radius >= Width) ||
                (ball.Direction == -2 && ball.Center.X - Ball.Radius <= 0) ||
                (ball.Direction == 1 && ball.Center.Y + Ball.Radius >= Height) ||
                (ball.Direction == -1 && ball.Center.Y - Ball.Radius <= 0))
                {
                    ball.Direction = -ball.Direction;
                }
                ball.Move();
            }
        }
    }
}
