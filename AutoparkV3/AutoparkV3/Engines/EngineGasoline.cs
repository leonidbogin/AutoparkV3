using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoparkV3.Engines
{
    public class EngineGasoline : AbstractEngineCE
    {
        public EngineGasoline()
        {
            Init();
        }

        public EngineGasoline(float engineCapacity, float fuelConsumptionPer100, int fuelTankCapacity)
        {
            Init();
            EngineCapacity = engineCapacity;
            FuelConsumptionPer100 = fuelConsumptionPer100;
            FuelTankCapacity = fuelTankCapacity;
        }

        private void Init()
        {
            TypeName = "Gasoline";
            TaxCoefficient = 1;
        }
    }
}
