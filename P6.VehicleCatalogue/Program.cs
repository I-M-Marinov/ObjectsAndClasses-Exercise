using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P6.VehicleCatalogue
{
    public class Vehicles
    {
        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Horsepower { get; set; }

        public Vehicles(string typeOfVehicle, string model, string color, string horsepower)
        {
            TypeOfVehicle = typeOfVehicle;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }

        public override string ToString()
        {
            StringBuilder stringBuild = new StringBuilder();
            stringBuild.AppendLine($"Type: {(this.TypeOfVehicle == "car" ? "Car" : "Truck")}");
            stringBuild.AppendLine($"Model: {this.Model}");
            stringBuild.AppendLine($"Color: {this.Color}");
            stringBuild.AppendLine($"Horsepower: {this.Horsepower}");
            return stringBuild.ToString().TrimEnd();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(" ").ToList();
            List<Vehicles> vehicles = new List<Vehicles>();

            while (input[0] != "End")
            {
                Vehicles vehicle = new Vehicles(input[0], input[1], input[2], input[3]);
                vehicles.Add(vehicle);
                input = Console.ReadLine().Split().ToList();
            }

            string model;
            while ((model = Console.ReadLine()) != "Close the Catalogue")
            {

                Vehicles print = vehicles.First(v => v.Model == model);
                Console.WriteLine($"{print}");
            }

            List<Vehicles> cars = new List<Vehicles>();
            List<Vehicles> trucks = new List<Vehicles>();
            double carsHorsePower = 0;
            double trucksHorsePower = 0;

            foreach (var item in vehicles)
            {
                
                

                if (item.TypeOfVehicle == "car")
                {
                    cars.Add(item);
                    carsHorsePower += double.Parse(item.Horsepower);
                }
                else if (item.TypeOfVehicle == "truck")
                {
                    trucks.Add(item);
                    trucksHorsePower += double.Parse(item.Horsepower);
                }
            }

            double averageHorsepowerCars = 0;
            double averageHorsepowerTrucks = 0;

            if (cars.Count == 0)
            {
                carsHorsePower = 0.00;
            }
            else
            { 
                averageHorsepowerCars = carsHorsePower / cars.Count;
            }

            if (trucks.Count == 0)
            {
                trucksHorsePower = 0.00;
            }
            else
            {
                averageHorsepowerTrucks = trucksHorsePower / trucks.Count;
            }
            
            Console.WriteLine($"Cars have average horsepower of: {averageHorsepowerCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageHorsepowerTrucks:f2}.");
        }
    }
}
