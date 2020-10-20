using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoparkV3.Engines

{
    public abstract class AbstractEngineCE : AbstractEngine
    {
        public float EngineCapacity { get; set; }
        public float FuelConsumptionPer100 { get; set; }
        public int FuelTankCapacity { get; set; }

        public override float GetMaxKilometers()
        {
            return FuelTankCapacity * 100 / FuelConsumptionPer100;
        }
    }
}
