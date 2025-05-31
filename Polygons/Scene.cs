using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polygons
{
    [Serializable]
    public class Scene
    {
        List<Polygon> Polygons { get; set; } = new List<Polygon>();
        public Color Color { get; set; }
        public Polygon active { get; set; }

        public Scene(Color color)
        {
            Color = color;
            active = new Polygon(this.Color);
        }
        public void AddPoint(Point point)
        {
            active.AddPoint(point);
            if (active.Completed)
            {
                Polygons.Add(active);
                active = new Polygon(this.Color);
            }
        }

        public void Draw(Graphics g)
        {
            active.Draw(g);
            foreach (Polygon p in Polygons)
            {
                p.Draw(g);
            }
        }

        public void UpdateCursor(Point point)
        {
            active.Cursor = point;
        }
    }
}
