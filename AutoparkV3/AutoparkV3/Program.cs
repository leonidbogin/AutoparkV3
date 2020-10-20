using AutoparkV3.Enums;
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
                new VehicleType("Bus", 1.2),
                new VehicleType("Car"),
                new VehicleType("Rink", 1.5),
                new VehicleType("Tractor", 1.2)
            };

            Vehicle[] vehicles = new Vehicle[]
            {
                new Vehicle(types[0], "Volkswagen Crafter", "5427 AX-7", 2022, 2015, 376000, Color.Blue),
                new Vehicle(types[0], "Mercedes-Benz Sprinter 515", "6427 AA-7", 2500, 2014, 227010, Color.White),
                new Vehicle(types[0], "Electric Bus E321", "6785 BA-7", 12080, 2019, 20451, Color.Green),
                new Vehicle(types[1], "Golf 5", "8682 AX-7", 1200, 2006, 230451, Color.Gray),
                new Vehicle(types[1], "Tesla Model S 70D", "E001 AA-7", 2200, 2019, 10454, Color.White),
                new Vehicle(types[2], "Hamm HD 12 VV", null, 3000, 2016, 100, Color.Yellow),
                new Vehicle(types[3], "МТЗ Беларус-1025.4", "1145 AB-7", 1200, 2020, 10241, Color.Red)
            };

            Console.WriteLine("ToString vehicles:");
            DisplayVehicle(vehicles);

            Array.Sort(vehicles);

            Console.WriteLine("\nToString vehicles after sort:");
            DisplayVehicle(vehicles);

            int maxTaxIndex = 0;
            for (int i = 1; i < vehicles.Length; i++)
                if (vehicles[maxTaxIndex].GetCalcTaxPerMonth() < vehicles[i].GetCalcTaxPerMonth())
                    maxTaxIndex = i;
            Console.WriteLine($"\nMaximum tax = {vehicles[maxTaxIndex].GetCalcTaxPerMonth():0.00}");

            Console.ReadLine();
        }

        private static void DisplayVehicle(Vehicle[] vehicles)
        {
            foreach (var vehicle in vehicles)
                Console.WriteLine(" " + vehicle);
        }
    }
}
