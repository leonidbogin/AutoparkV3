namespace AutoparkV3.Engines

{
    public class EngineCE : Engine
    {
        public float EngineCapacity { get; set; }
        public float FuelConsumptionPer100 { get; set; }
        public int FuelTankCapacity { get; set; }

        public float GetMaxKilometers()
        {
            return FuelTankCapacity * 100 / FuelConsumptionPer100;
        }
    }
}
