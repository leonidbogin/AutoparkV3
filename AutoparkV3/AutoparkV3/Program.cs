using AutoparkV3.Engines;
using AutoparkV3.Enums;
using System;
using System.Net.Http.Headers;

namespace AutoparkV3
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleType[] types = new VehicleType[]
            {
                new VehicleType("Bus", 1f),
                new VehicleType("Car"),
                new VehicleType("Rink", 1.5f),
                new VehicleType("Tractor", 1.2f)
            };

            Vehicle[] vehicles = new Vehicle[]
            {
                new Vehicle(types[0], new EngineGasoline(8.1f, 2.0f, 75), "Volkswagen Crafter", "5427 AX-7", 2022, 2015, 376000, Color.Blue),
                new Vehicle(types[0], new EngineGasoline(8.5f, 2.18f, 75), "Mercedes-Benz Sprinter 515", "6427 AA-7", 2500, 2014, 227010, Color.White),
                new Vehicle(types[0], new EngineElectrical(), "Electric Bus E321", "6785 BA-7", 12080, 2019, 20451, Color.Green),
                new Vehicle(types[0], new EngineDiesel(12f, 3.0f, 220), "МАЗ 104 C", "2682 BC-7", 18000, 2005, 541900, Color.Brown),
                new Vehicle(types[0], new EngineDiesel(7f, 2.2f, 55), "Ford Transit", "7882 AX-7", 2100, 2011, 380000, Color.White),
                
                new Vehicle(types[1], new EngineDiesel(7.2f, 1.6f, 55), "Golf 5", "8682 AX-7", 1200, 2006, 230451, Color.Gray),
                new Vehicle(types[1], new EngineGasoline(6.9f, 1.6f, 50), "Mercedes-Benz E-Class W213", "3526 AF-7", 2300, 2018, 40451, Color.Black),
                new Vehicle(types[1], new EngineGasoline(6.0f, 2.0f, 54), "Audi A7 Type 4K8", "8682 AX-7", 2000, 2019, 35001, Color.Silver),
                new Vehicle(types[1], new EngineDiesel(5.1f, 2.0f, 57), "Land Rover Sport II", "0044 AX-7", 2500, 2014, 171545, Color.Red),
                new Vehicle(types[1], new EngineElectrical(25.0f, 70.0f), "Tesla Model S 70D", "E001 AA-7", 2200, 2019, 10454, Color.White),
                
                new Vehicle(types[2], new EngineDiesel(25f, 3.2f, 20), "Hamm HD 12 VV", null, 3000, 2016, null, Color.Yellow),
                
                new Vehicle(types[3], new EngineDiesel(23.5f, 4.75f, 130), "МТЗ МТЗ 892", null, 4150, 2018, 124150, Color.Red),
                new Vehicle(types[3], new EngineDiesel(20.1f, 4.75f, 135), "МТЗ Беларус-1025.4", "1145 AB-7", 1200, 2020, 10241, Color.Red)
            };

            for (int i = 0; i < vehicles.Length; i++)
            {
                Console.WriteLine(vehicles[i].ToString());
            }

            Console.ReadLine();
        }
    }
}
