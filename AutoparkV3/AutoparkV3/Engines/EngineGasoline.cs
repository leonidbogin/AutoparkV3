namespace AutoparkV3.Engines
{
    public class EngineGasoline : EngineCE
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
