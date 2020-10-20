using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoparkV3.Engines
{
    public class EngineDiesel : AbstractEngineCE
    {
        public EngineDiesel()
        {
            Init();
        }

        public EngineDiesel(double engineCapacity, double fuelConsumptionPer100, int fuelTankCapacity)
        {
            Init();
            EngineCapacity = engineCapacity;
            FuelConsumptionPer100 = fuelConsumptionPer100;
            FuelTankCapacity = fuelTankCapacity;
        }

        private void Init()
        {
            TypeName = "Diesel";
            TaxCoefficient = 1.2;
        }
    }
}
