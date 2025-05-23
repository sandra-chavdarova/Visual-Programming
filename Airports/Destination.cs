﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Destination
    {
        public string Name { get; set; }
        public int Distance { get; set; }
        public int Price { get; set; }

        public Destination(string name, int distance, int price)
        {
            Name = name;
            Distance = distance;
            Price = price;
        }

        public override string ToString()
        {
            return string.Format("{0}\t{1}km - {2} EUR", Name, Distance, Price);
        }
    }
}
