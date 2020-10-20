namespace AutoparkV3.Engines
{
    public class EngineDiesel : EngineCE
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
