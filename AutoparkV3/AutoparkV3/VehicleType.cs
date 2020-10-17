namespace AutoparkV3
{
    public class VehicleType
    {
        public string TypeName { get; set; }

        public VehicleType() { }

        public VehicleType(string typeName) 
        {
            TypeName = typeName;
        }
    }
}
