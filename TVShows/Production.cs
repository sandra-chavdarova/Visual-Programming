using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVShows
{
    public class Production
    {
        public string Name { get; set; }
        public int Code { get; set; }

        public Production(string name, int code)
        {
            Name = name;
            Code = code;
        }

        public override string ToString()
        {
            return string.Format("{0}", Name);
        }
    }
}
