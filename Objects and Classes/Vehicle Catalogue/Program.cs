using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vehicle_Catalogue
{
    class Vehicle
    {
        public Vehicle()
        {
        }
        public string VehicleType { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            //return $"Type: {VehicleType}{Environment.NewLine}Model: {Model}{Environment.NewLine}Color: {Color}{Environment.NewLine}Horsepower: {HorsePower}";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {VehicleType}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {HorsePower}");
            return sb.ToString().TrimEnd();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();

            List<Vehicle> vehicleList = new List<Vehicle>();
            
            while (input != "End")
            {
                string vehicleType = input.Split()[0];
                string model = input.Split()[1];
                string color = input.Split()[2];
                int horsePower =int.Parse(input.Split()[3]);

                if (vehicleType == "car")
                {
                    vehicleType = "Car";
                }
                else
                {
                    vehicleType = "Truck";
                }

                Vehicle vehicle = new Vehicle();
                vehicle.VehicleType = vehicleType;
                vehicle.Model = model;
                vehicle.Color = color;
                vehicle.HorsePower = horsePower;
                vehicleList.Add(vehicle);

                input = Console.ReadLine();
            }

            string commands = Console.ReadLine();
            while (commands != "Close the Catalogue")
            {
                Vehicle currentVehicle = vehicleList.FirstOrDefault(x => x.Model == commands);
                Console.WriteLine(currentVehicle);

                commands = Console.ReadLine();
            }
            List<Vehicle> carsList = vehicleList.Where(x => x.VehicleType == "Car").ToList();
            List<Vehicle> truckList = vehicleList.Where(x => x.VehicleType == "Truck").ToList();

            double carAverageHP = carsList.Any() ? carsList.Average(x=>x.HorsePower) : 0.00;
            double truckAverageHP = truckList.Any() ? truckList.Average(x=>x.HorsePower) : 0.00;

            Console.WriteLine($"Cars have average horsepower of: {carAverageHP:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAverageHP:F2}.");
        }

    }
}
