namespace AutoparkV3
{
    public class VehicleType
    {
        public string TypeName { get; set; }
        public float TaxCoefficient { get; set; }

        public VehicleType() { }

        public VehicleType(string typeName, float taxCoefficient = 1.0f) 
        {
            TypeName = typeName;
            TaxCoefficient = taxCoefficient;
        }
    }
}
