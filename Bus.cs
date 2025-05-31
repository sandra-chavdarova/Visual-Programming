using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Programming
{
    public class Bus
    {
        public string Name { get; set; }
        public string Plates { get; set; }
        public bool Local { get; set; }
        public List<Line> Lines { get; set; } = new List<Line>();

        public Bus(string name, string plates, bool local)
        {
            Name = name;
            Plates = plates;
            Local = local;
        }

        public override string ToString()
        {
            if (Local)
                return string.Format("{0} - {1} - L", Name, Plates);
            else
                return string.Format("{0} - {1} - M", Name, Plates);
        }
    }
}
