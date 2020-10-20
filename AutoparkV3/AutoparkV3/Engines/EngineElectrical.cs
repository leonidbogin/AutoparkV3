using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoparkV3.Engines
{
    public class EngineElectrical : AbstractEngine
    {
        public double ElectricityConsumption { get; set; }           //kW
        public double BatterySize { get; set; }                      //kWh

        public EngineElectrical()
        {
            Init();
        }

        public EngineElectrical(double electricityConsumption, double batterySize)
        {
            Init();
            ElectricityConsumption = electricityConsumption;
            BatterySize = batterySize;
        }

        private void Init()
        {
            TypeName = "Electrical";
            TaxCoefficient = 0.1;
        }

        public override double GetMaxKilometers()
        {
            return BatterySize / ElectricityConsumption;
        }
    }
}
