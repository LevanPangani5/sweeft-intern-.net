using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countries_REST_API
{
    public class Country
    {   
        public Name? Name { get; set; }
        public string? Region { get; set; }
        public string? Subregion { get; set; }
        public double[]? Latlng { get; set; }
        public double? Area { get; set; }
        public int? Population { get; set; }
    }

    public class Name
    {
        public string? Official { get; set; }
    }
}
