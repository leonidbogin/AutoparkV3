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
            Init();
        }

        public EngineElectrical(float electricityConsumption, float batterySize)
        {
            Init();
            ElectricityConsumption = electricityConsumption;
            BatterySize = batterySize;
        }

        private void Init()
        {
            TypeName = "Electrical";
            TaxCoefficient = 0.1f;
        }

        public override float GetMaxKilometers()
        {
            return BatterySize / ElectricityConsumption;
        }
    }
}
