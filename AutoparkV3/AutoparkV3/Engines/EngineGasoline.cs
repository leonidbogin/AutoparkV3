using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoparkV3.Engines
{
    public class EngineGasoline : AbstractEngineCombustion
    {
        public EngineGasoline()
        {
            TypeName = "Gasoline";
        }

        public EngineGasoline(float fuelConsumptionPer100, float engineCapacity, int fuelTankCapacity)
        {
            TypeName = "Gasoline";
            FuelConsumptionPer100 = fuelConsumptionPer100;
            EngineCapacity = engineCapacity;
            FuelTankCapacity = fuelTankCapacity;
        }
    }
}
