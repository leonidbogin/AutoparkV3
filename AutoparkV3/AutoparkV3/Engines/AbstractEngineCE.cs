using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoparkV3.Engines

{
    public abstract class AbstractEngineCE : AbstractEngine
    {
        public double EngineCapacity { get; set; }
        public double FuelConsumptionPer100 { get; set; }
        public int FuelTankCapacity { get; set; }

        public override double GetMaxKilometers()
        {
            return FuelTankCapacity * 100 / FuelConsumptionPer100;
        }
    }
}
