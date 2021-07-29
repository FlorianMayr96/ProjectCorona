using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Model
{
    public class AllData
    {
        public DateTime date { get; }
        public int Id { get; }
        public string country { get; }
        public double confirmedCases { get; }
        public double deaths { get; }
        public double recoverd { get; }
        public double hospitalizations { get; }
        public double intensiveCareUnit { get; }
        public double tests { get; }
        public double testsPCR { get; }
        public double testsAntigen { get; }
        public AllData(string[] data)
        {
            date = DateTime.Parse(data[0]);
            Id = int.Parse(data[1]);
            country = data[2];
            confirmedCases = double.Parse(data[3]);
            deaths = double.Parse(data[4]);
            recoverd = double.Parse(data[5]);
            hospitalizations = double.Parse(data[6]);
            intensiveCareUnit = double.Parse(data[7]);
            tests = double.Parse(data[8]);
            testsPCR = double.Parse(data[9]);
            testsAntigen = double.Parse(data[10]);

        }
    }
}
