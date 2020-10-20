namespace AutoparkV3.Engines
{
    public class EngineElectrical : Engine
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

        public float GetMaxKilometers()
        {
            return BatterySize / ElectricityConsumption;
        }
    }
}
