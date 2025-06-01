using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blinking_Balls
{
    [Serializable]
    public class Scene
    {
        List<Ball> Balls { get; set; } = new List<Ball>();
        public static Random Random { get; set; } = new Random();
        public Ball Selected { get; set; } = null;
        public Scene()
        {

        }

        public void Click(Point Location, System.Windows.Forms.MouseButtons button)
        {
            if (button == MouseButtons.Left)
            {
                Balls.Add(new Ball(Location)); // Add Ball
            }
            else if (button == MouseButtons.Right)
            {
                foreach (Ball ball in Balls)
                {
                    double distance = Math.Sqrt(Math.Pow(ball.Center.X - Location.X, 2) + Math.Pow(ball.Center.Y - Location.Y, 2));
                    if (distance <= ball.Radius)
                    {
                        Selected = ball;
                        return;
                    }
                }

                Selected = null; // Deselect if no ball was clicked
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Ball ball in Balls)
            {
                ball.Draw(g);
            }
        }

        public void Grow()
        {
            foreach (Ball ball in Balls)
            {
                ball.Grow();
            }
        }

        public void ChangeColor()
        {
            foreach (Ball ball in Balls)
            {
                ball.ChangeColor();
            }
        }

        public void RemoveTouchingBalls()
        {
            for (int i = 0; i < Balls.Count; i++)
            {
                for (int j = i + 1; j < Balls.Count; j++)
                {
                    Ball b1 = Balls[i];
                    Ball b2 = Balls[j];
                    double distance = Math.Sqrt(Math.Pow(b1.Center.X - b2.Center.X, 2) + Math.Pow(b1.Center.Y - b2.Center.Y, 2));
                    if (distance <= b1.Radius + b2.Radius)
                    {
                        Balls.RemoveAt(j);
                        Balls.RemoveAt(i);
                        if (b1 == Selected || b2 == Selected)
                            Selected = null;
                        return;
                    }
                }
            }
        }
    }
}
