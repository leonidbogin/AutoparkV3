using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoparkV3.Engines
{
    public class EngineDiesel : AbstractEngineCombustion
    {
        public EngineDiesel()
        {
            TypeName = "Diesel";
        }

        public EngineDiesel(float fuelConsumptionPer100, float engineCapacity, int fuelTankCapacity)
        {
            TypeName = "Diesel";
            FuelConsumptionPer100 = fuelConsumptionPer100;
            EngineCapacity = engineCapacity;
            FuelTankCapacity = fuelTankCapacity;
        }
    }
}
