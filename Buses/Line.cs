using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Programming
{
    public class Line
    {
        public string Destination { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Price { get; set; }

        public Line(string destination, int hour, int minute, int price)
        {
            Destination = destination;
            Hour = hour;
            Minute = minute;
            Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1} - {2} - {3} Ден.", Hour, Minute, Destination, Price);
        }
    }
}
