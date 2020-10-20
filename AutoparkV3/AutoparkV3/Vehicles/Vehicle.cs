using AutoparkV3.Enums;
using System;

namespace AutoparkV3.Vehicles
{
    public class Vehicle : IComparable<Vehicle>
    {
        public VehicleType Type { get; set; }
        public string ModelName { get; set; }
        public string RegistrationNumber { get; set; }
        public int Weight { get; set; }                    //Kg
        public int YearManufacture { get; set; }           //Year
        public int Mileage { get; set; }                  //Km
        public Color Color { get; set; }                   //Enums.Color

        public Vehicle() { }

        public Vehicle(VehicleType type, string modelName,
            string registrationNumber, int weight, int yearManufacture, int mileage, Color color) 
        {
            Type = type; 
            ModelName = modelName;
            RegistrationNumber = registrationNumber;
            Weight = weight;
            YearManufacture = yearManufacture;
            Mileage = mileage;
            Color = color;
        }

        public int CompareTo(Vehicle second)
        {
            if (GetCalcTaxPerMonth() < second.GetCalcTaxPerMonth()) return -1;
            else if (GetCalcTaxPerMonth() > second.GetCalcTaxPerMonth()) return 1;
            else return 0;
        }

        public double GetCalcTaxPerMonth()
        {
            return (Weight * 0.0013) + (Type.TaxCoefficient * 30) + 5;
        }

        public override string ToString() => $"{Type.TypeName};" +
            $"{ModelName};" +
            $"{RegistrationNumber ?? "none"};" +
            $"{Color};" +
            $"{Mileage};" +
            $"{Weight};" +
            $"{YearManufacture};" +
            GetCalcTaxPerMonth().ToString("0.00");
    }
}
