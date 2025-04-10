using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConferencePapers
{
    public class ConferencePaper
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public ConferencePaper(string name, int year)
        {
            Name = name;
            Year = year;
            ID = Guid.NewGuid().ToString();
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Year, Name);
        }
    }
}
