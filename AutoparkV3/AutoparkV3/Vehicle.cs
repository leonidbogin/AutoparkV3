using AutoparkV3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoparkV3
{
    public class Vehicle
    {
        public VehicleType Type { get; set; }
        public string ModelName { get; set; }
        public string RegistrationNumber { get; set; }
        public int Weight { get; set; }                    //Kg
        public int YearManufacture { get; set; }           //Year
        public int? Mileage { get; set; }                  //Km
        public Color Color { get; set; }                    //Enums.Color

        public Vehicle() { }

        public Vehicle(VehicleType type, string modelName, string registrationNumber, int weight, int yearManufacture, int? mileage, Color color) 
        {
            Type = type;
            ModelName = modelName;
            RegistrationNumber = registrationNumber;
            Weight = weight;
            YearManufacture = yearManufacture;
            Mileage = mileage;
            Color = color;
        }

        public override string ToString() => $"{Type.TypeName};" +
            $"{ModelName};" +
            $"{RegistrationNumber ?? "none"};" +
            $"{Color};" +
            $"{(Mileage.HasValue ? Mileage.Value.ToString() : "none")};" +
            $"{Weight};" +
            $"{YearManufacture}";
    }
}
