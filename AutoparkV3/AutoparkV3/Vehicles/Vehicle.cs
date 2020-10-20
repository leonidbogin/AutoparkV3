using AutoparkV3.Engines;
using AutoparkV3.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoparkV3.Vehicles
{
    public class Vehicle : IComparable<Vehicle>
    {
        public VehicleType Type { get; set; }
        public Engine Engine { get; set; }
        public string ModelName { get; set; }
        public string RegistrationNumber { get; set; }
        public int Weight { get; set; }                    //Kg
        public int YearManufacture { get; set; }           //Year
        public int? Mileage { get; set; }                  //Km
        public Color Color { get; set; }                   //Enums.Color

        public Vehicle() { }

        public Vehicle(VehicleType type, Engine engine, string modelName,
            string registrationNumber, int weight, int yearManufacture, int? mileage, Color color) 
        {
            Type = type;
            Engine = engine;  
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

        public override bool Equals(object obj)
        {
            Vehicle second = (Vehicle)obj;
            if (ModelName.Equals(second.ModelName)
                && Type.Equals(second.Type))
            {
                return true;
            }
            else return false;
        }

        public float GetCalcTaxPerMonth()
        {
            return (Weight * 0.0013f) + (Type.TaxCoefficient * Engine.TaxCoefficient * 30) + 5;
        }

        public override string ToString() => $"{Type.TypeName};" +
            $"{ModelName};" +
            $"{RegistrationNumber ?? "none"};" +
            $"{Color};" +
            $"{(Mileage.HasValue ? Mileage.Value.ToString() : "none")};" +
            $"{Weight};" +
            $"{YearManufacture};" +
            GetCalcTaxPerMonth().ToString("0.00");
    }
}
