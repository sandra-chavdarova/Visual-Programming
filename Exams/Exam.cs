using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams
{
    public class Exam
    {
        public int Year { get; set; }
        public string Month { get; set; }
        public string Comment1 { get; set; }
        public string Comment2 { get; set; }
        public int Points1 { get; set; }
        public int Points2 { get; set; }

        public Exam(int year, string month)
        {
            Year = year;
            Month = month;
            Comment1 = "";
            Comment2 = "";
            Points1 = 0;
            Points2 = 0;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Month, Year);
        }
    }
}
