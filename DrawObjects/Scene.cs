using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawObjects
{
    public class Scene
    {
        List<Shape> shapes = new List<Shape>();
        public Scene() { }

        public void Click(Point location, System.Windows.Forms.MouseButtons button)
        {
            foreach (Shape shape in shapes)
            {
                if (shape.Hit(location))
                    return;
            }


            if (button == MouseButtons.Left)
            {
                shapes.Add(new Circle(location, Color.Violet, 20));
            }
            else if (button == MouseButtons.Right)
            {
                shapes.Add(new Square(location, Color.Violet, 20));
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Shape shape in shapes)
            {
                shape.Draw(g);
            }
        }

        public void Pulse()
        {
            foreach (Shape shape in shapes)
            {
                shape.Pulse();
            }
        }
    }
}
