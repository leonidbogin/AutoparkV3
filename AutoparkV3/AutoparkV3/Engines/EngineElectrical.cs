namespace AutoparkV3.Engines
{
    public class EngineElectrical : Engine
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

        public double GetMaxKilometers()
        {
            return BatterySize / ElectricityConsumption;
        }
    }
}
