using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Tire[]> tireList = new List<Tire[]>();

            string tireInput = Console.ReadLine();
            while (tireInput != "No more tires")
            {
                string[] splitted = tireInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var currTires = new Tire[4]
                {
                    new Tire(int.Parse(splitted[0]), double.Parse(splitted[1])),
                    new Tire(int.Parse(splitted[2]), double.Parse(splitted[3])),
                    new Tire(int.Parse(splitted[4]), double.Parse(splitted[5])),
                    new Tire(int.Parse(splitted[6]), double.Parse(splitted[7]))
                };

                tireList.Add(currTires);
                tireInput = Console.ReadLine();
            }

            List<Engine> engineList = new List<Engine>();

            string engineInput = Console.ReadLine();
            while (engineInput != "Engines done")
            {
                string[] splitted = engineInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var engine = new Engine(int.Parse(splitted[0]), double.Parse(splitted[1]));
                engineList.Add(engine);
                engineInput = Console.ReadLine();
            }


            List<Car> carList = new List<Car>();
            string finalInput = Console.ReadLine();
            while (finalInput != "Show special")
            {
                string[] splittedCarData = finalInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = splittedCarData[0];
                string model = splittedCarData[1];
                int year = int.Parse(splittedCarData[2]);
                double fuelQuantity = double.Parse(splittedCarData[3]);
                double fuelConsumption = double.Parse(splittedCarData[4]);
                int engineIndex = int.Parse(splittedCarData[5]);
                int tireIndex = int.Parse(splittedCarData[6]);
                var currentCar = new Car(make, model, year, fuelQuantity, fuelConsumption, engineList[engineIndex], tireList[tireIndex]);
                carList.Add(currentCar);

                finalInput = Console.ReadLine();
            }
            carList = carList
                .Where(x => x.Year >= 2017 && x.Engine.HorsePower > 330 && x.Tires.Sum(y => y.Pressure) >= 9 && x.Tires.Sum(y => y.Pressure) <= 10).ToList();

            foreach (var car in carList)
            {
                    car.Drive(20);
                    Console.WriteLine(car.WhoAmI());
            }
        }
    }
}
