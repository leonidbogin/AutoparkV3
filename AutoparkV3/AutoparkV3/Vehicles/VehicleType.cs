using System;

namespace AutoparkV3.Vehicles
{
    public class VehicleType
    {
        public string TypeName { get; set; }
        public double TaxCoefficient { get; set; }

        public VehicleType() { }

        public VehicleType(string typeName, double taxCoefficient = 1) 
        {
            TypeName = typeName;
            TaxCoefficient = taxCoefficient;
        }

        public void Display()
        {
            Console.WriteLine($" TypeName = {TypeName};");
            Console.WriteLine($" TaxCoefficient = {TaxCoefficient};");
            Console.WriteLine();
        }

        public override string ToString() => $"{TypeName};{TaxCoefficient}";
    }
}
