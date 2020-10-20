using AutoparkV3.Engines;
using AutoparkV3.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoparkV3.Vehicles
{
    public class Collections
    {
        public List<VehicleType> Types { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public Collections(string typeFileName, string vehicleFileName, string rentFileName)
        {
            Types = LoadFromFile(typeFileName, CreateType);
            Vehicles = LoadFromFile(vehicleFileName, СreateVehicle);
            LoadRents(rentFileName);
        }

        private List<T> LoadFromFile<T>(string inFile, Func<string, T> createObject)
        {
            List<T> list = new List<T>();
            try
            {
                StreamReader sr = new StreamReader(inFile + ".csv");
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    list.Add(createObject(s));
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File {inFile} not found.");
            }
            return list;
        }

        private void LoadRents(string inFile)
        {
            try
            {
                StreamReader sr = new StreamReader(inFile + ".csv");
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    string[] split = s.Split(';', '\n');
                    Vehicles.Find(e => e.VehicleId == int.Parse(split[0]))
                        .RentAdd(DateTime.Parse(split[1]), float.Parse(split[2]));
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File {inFile} not found.");
            }
        }

        public VehicleType CreateType(string csvString)
        {
            string[] split = csvString.Split(';', '\n');

            VehicleType type = new VehicleType()
            {
                TypeId = int.Parse(split[0]),
                TypeName = split[1],
                TaxCoefficient = float.Parse(split[2])
            };

            return type;
        }

        public Vehicle СreateVehicle(string csvString)
        {
            string[] split = csvString.Split(';', '\n');

            Vehicle vehicle = new Vehicle()
            {
                VehicleId = int.Parse(split[0]),
                Type = Types.Find(e => e.TypeId == int.Parse(split[1])),
                ModelName = split[2],
                RegistrationNumber = split[3],
                Weight = int.Parse(split[4]),
                YearManufacture = int.Parse(split[5]),
                Mileage = int.Parse(split[6]),
                Color = (Color)Enum.Parse(typeof(Color),split[7])
            };
            switch (split[8])
            {
                case "Electrical":
                    vehicle.Engine = new EngineElectrical(float.Parse(split[9]), float.Parse(split[10]));
                    break;
                case "Gasoline":
                    vehicle.Engine = new EngineGasoline(float.Parse(split[9]), float.Parse(split[10]), int.Parse(split[11]));
                    break;
                case "Diesel":
                    vehicle.Engine = new EngineDiesel(float.Parse(split[9]), float.Parse(split[10]), int.Parse(split[11])); 
                    break;
                default:
                    vehicle.Engine = new EngineGasoline(); 
                    break;
            }

            return vehicle;
        }

        public void Insert(int index, Vehicle vehicle)
        {
            if (index > Vehicles.Count)
                index = Vehicles.Count;
            Vehicles.Insert(index, vehicle);
        }

        public int Delete(int index)
        {
            if (0 <= index && index < Vehicles.Count)
            {
                Vehicles.RemoveAt(index);
                return index;
            }
            else return -1;
        }

        public float SumTotalProfit()
        {
            float sumCosts = 0;
            foreach (Vehicle vehicle in Vehicles)
                sumCosts += vehicle.GetTotalProfit();
            return sumCosts;
        }

        public void Print()
        {
            const string format = "{0,-5}{1,-10}{2,-22}{3,-15}{4,-15}{5,-7}{6,-10}{7,-8}{8,-8}{9,-8}{10,-8}";
            Console.WriteLine(string.Format(" " + format,
                "Id","Type","ModelName","Number","Weight (kg)","Year","Mileage","Color","Income","Tax","Profit"));
            foreach (Vehicle vehicle in Vehicles)
            {
                Console.WriteLine(
                    string.Format(format,
                        vehicle.VehicleId,
                        vehicle.Type.TypeName,
                        vehicle.ModelName,
                        vehicle.RegistrationNumber,
                        vehicle.Weight,
                        vehicle.YearManufacture,
                        vehicle.Mileage,
                        vehicle.Color,
                        vehicle.GetTotalIncome().ToString("0.00"),
                        vehicle.GetCalcTaxPerMonth().ToString("0.00"),
                        vehicle.GetTotalProfit().ToString("0.00")));
            }
            Console.WriteLine(
                string.Format(format,
                    "Total",null,null,null,null,null,null,null,null,null,SumTotalProfit().ToString("0.00")));
            Console.WriteLine();
        }

        public void Sort(IComparer<Vehicle> comparator)
        {
            Vehicles.Sort(comparator);
        }
    }
}
