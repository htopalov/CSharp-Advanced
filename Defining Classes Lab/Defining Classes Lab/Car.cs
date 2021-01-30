using System;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelConsumption = 10;
            FuelQuantity = 200;
        }
        public Car(string make, string model, int year) 
            :this()
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) 
            :this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption, Engine engine, Tire[] tires)
            : this(make,model,year,fuelQuantity,fuelConsumption)
        {
            Engine = engine;
            Tires = tires;
        }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public Engine Engine { get; set; }

        public Tire[] Tires { get; set; }

        public void Drive(double distance)
        {

            if (FuelConsumption * distance / 100 > FuelQuantity)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                FuelQuantity -= distance / 100 * FuelConsumption;
            }
        }
        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Make: {this.Make}\n");
            sb.Append($"Model: { this.Model}\n");
            sb.Append($"Year: {this.Year}\n");
            sb.Append($"HorsePowers: {this.Engine.HorsePower}\n");
            sb.Append($"FuelQuantity: {this.FuelQuantity}\n");
            return sb.ToString();
        }
    }
}
