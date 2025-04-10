using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVShows
{
    public class Series
    {
        public Production Production { get; set; }
        public string Name { get; set; }
        public float Rating { get; set; }
        public int Seasons { get; set; }

        public Series(Production production, string name, float rating, int seasons)
        {
            Production = production;
            Name = name;
            Rating = rating;
            Seasons = seasons;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} ({2}) S: {3}", Production.Name, Name, Rating, Seasons);
        }
    }
}
