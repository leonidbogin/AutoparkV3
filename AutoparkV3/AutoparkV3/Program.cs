using AutoparkV3.Engines;
using AutoparkV3.Enums;
using AutoparkV3.Vehicles;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Activation;

namespace AutoparkV3
{
    class Program
    {
        static void Main(string[] args)
        {
            Collections collection = new Collections("types", "vehicles", "rents");
            collection.Print();

            Vehicle newVehicle = new Vehicle()
            {
                VehicleId = 1,
                Type = collection.Types.Find(e => e.TypeId == 2),
                Engine = new EngineDiesel(5.1f, 2.0f, 57), 
                ModelName = "Land Rover Sport II", 
                RegistrationNumber = "0044 AX-7", 
                Weight = 2500,
                YearManufacture = 2014,
                Mileage = 171545,
                Color = Color.Red
            };

            collection.Insert(8, newVehicle);
            collection.Delete(1);
            collection.Delete(4);

            collection.Print();

            IComparer<Vehicle> comparer = new VehicleComparer();
            collection.Sort(comparer);

            collection.Print();

            Console.ReadLine();
        }
    }
}
