using AutoparkV3.Vehicles;
using System;

namespace AutoparkV3
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleType[] types = new VehicleType[]
            {
                new VehicleType("Bus", 1.2f),
                new VehicleType("Car"),
                new VehicleType("Rink", 1.5f),
                new VehicleType("Tractor", 1.2f)
            };

            types[types.Length - 1].TaxCoefficient = 1.3f;

            int maxTaxIndex = 0;
            float averageTax = 0;

            Console.WriteLine("Display types:");
            for (int i = 0; i < types.Length; i++)
            {
                types[i].Display();
                if (types[maxTaxIndex].TaxCoefficient < types[i].TaxCoefficient)
                    maxTaxIndex = i;
                averageTax += types[i].TaxCoefficient;
            }
            averageTax /= types.Length;

            Console.WriteLine($"Maximum tax coefficient = {types[maxTaxIndex].TaxCoefficient}");
            Console.WriteLine($"Average tax coefficient = {averageTax}");

            Console.WriteLine("\nToString types:");
            foreach (var type in types)
                Console.WriteLine(" " + type);

            Console.ReadLine();
        }
    }
}
