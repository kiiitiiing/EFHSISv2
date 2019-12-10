using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFHSIS.Models.GraphModels
{
    public class Graph
    {
        public class PieChart
        {
            public string name { get; set; }
            public string label { get; set; }
            public int y { get; set; }
            public int total { get; set; }
            public Boolean exploded { get; set; }
        }

        public class BarChart
        {
            public string label { get; set; }
            public int y { get; set; }
        }

    }
}
