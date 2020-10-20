using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoparkV3.Engines
{
    public abstract class AbstractEngine
    {
        public string TypeName { get; set; }
        public string ModelName { get; set; }
        public double TaxCoefficient { get; set; }

        public abstract double GetMaxKilometers();
    }
}
