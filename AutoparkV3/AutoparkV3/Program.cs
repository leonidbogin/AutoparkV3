using AutoparkV3.Engines;
using AutoparkV3.Enums;
using AutoparkV3.Vehicles;
using System;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Activation;

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

            Vehicle[] vehicles = new Vehicle[]
            {
                new Vehicle(types[0], new EngineGasoline(2, 8.1f, 75), "Volkswagen Crafter", "5427 AX-7", 2022, 2015, 376000, Color.Blue),
                new Vehicle(types[0], new EngineGasoline(2.18f, 8.5f, 75), "Volkswagen Crafter", "6427 AA-7", 2500, 2014, 227010, Color.White),
                new Vehicle(types[0], new EngineElectrical(50, 150), "Electric Bus E321", "6785 BA-7", 12080, 2019, 20451, Color.Green),
                new Vehicle(types[1], new EngineDiesel(1.6f, 7.2f, 55), "Golf 5", "8682 AX-7", 1200, 2006, 230451, Color.Gray),
                new Vehicle(types[1], new EngineElectrical(25, 70), "Tesla Model S 70D", "E001 AA-7", 2200, 2019, 10454, Color.White),
                new Vehicle(types[2], new EngineDiesel(3.2f, 25, 20), "Hamm HD 12 VV", null, 3000, 2016, null, Color.Yellow),
                new Vehicle(types[3], new EngineDiesel(4.75f, 20.1f, 135), "МТЗ Беларус-1025.4", "1145 AB-7", 1200, 2020, 10241, Color.Red)
            };

            DisplayVehicles(vehicles);

            for (int i = 0; i < vehicles.Length; i++)
                for (int j = i+1; j < vehicles.Length; j++)
                    if (vehicles[i].Equals(vehicles[j]))
                    {
                        Console.WriteLine("\nFound equals vehicles:");
                        Console.WriteLine(" " + vehicles[i]);
                        Console.WriteLine(" " + vehicles[j]);
                    }

            Console.ReadLine();
        }

        private static void DisplayVehicles(Vehicle[] vehicles)
        {
            foreach (var vehicle in vehicles)
                Console.WriteLine(vehicle);
        }
    }
}
