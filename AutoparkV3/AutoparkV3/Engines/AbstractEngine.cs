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
        public float TaxCoefficient { get; set; } = 1.0f;

        public abstract float GetMaxKilometersOnOneTank();
    }
}
