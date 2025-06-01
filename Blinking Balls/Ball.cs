using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blinking_Balls
{
    [Serializable]
    public class Ball
    {
        public static Random Random { get; set; } = new Random();
        public Color Color { get; set; }
        public int Radius { get; set; }
        public int Index { get; set; }
        public Color[] Colors { get; set; } = { Color.Red, Color.Yellow, Color.Green };

        public Point Center { get; set; }

        public Ball(Point center)
        {
            Color = Color.Red;
            Radius = Random.Next(20) + 10;
            Index = 0;
            Center = center;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, Center.X - Radius, Center.Y - Radius, Radius * 2, Radius * 2);
            brush.Dispose();
        }

        public void ChangeColor()
        {
            this.Color = Colors[Index];
            Index++;
            if (Index == 3)
            {
                Index = 0;
            }
        }

        public void Grow()
        {
            if (Radius + 5 < 50)
                this.Radius += 5;
        }
    }
}
