namespace AutoparkV3.Engines

{
    public class EngineCE : Engine
    {
        public double EngineCapacity { get; set; }
        public double FuelConsumptionPer100 { get; set; }
        public int FuelTankCapacity { get; set; }

        public double GetMaxKilometers()
        {
            return FuelTankCapacity * 100 / FuelConsumptionPer100;
        }
    }
}
