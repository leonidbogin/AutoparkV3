using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoparkV3.Engines
{
    public class EngineElectrical : AbstractEngine
    {
        public float ElectricityConsumption { get; set; }           //kW
        public float BatterySize { get; set; }                      //kWh

        public EngineElectrical()
        {
            TypeName = "Electrical";
            TaxCoefficient = 0.1f;
        }

        public EngineElectrical(float electricityConsumption, float batterySize)
        {
            TypeName = "Electrical";
            ElectricityConsumption = electricityConsumption;
            BatterySize = batterySize;
        }

        public override float GetMaxKilometersOnOneTank()
        {
            return BatterySize / ElectricityConsumption;
        }
    }
}
