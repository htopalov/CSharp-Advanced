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
                if ((engineIndex >= 0 && engineIndex < engineList.Count) && (tireIndex >= 0 && tireIndex < tireList.Count))
                {
                    // not finished....tireList[tireIndex] is problematic, but it's too late...tomorrow finishig with that
                    //and whats left after that.... filtering and adding some more commands....
                    var car = new Car(make, model, year, fuelQuantity, fuelConsumption, engineList[engineIndex], tireList[tireIndex]);
                    carList.Add(car);
                }

                finalInput = Console.ReadLine();
            }
        }
    }
}
