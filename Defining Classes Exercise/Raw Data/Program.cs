using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carList = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] currentCarData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = currentCarData[0];
                int engineSpeed = int.Parse(currentCarData[1]);
                int enginePower = int.Parse(currentCarData[2]);
                int cargoWeight = int.Parse(currentCarData[3]);
                string cargoType = currentCarData[4];
                double tirePressure1 = double.Parse(currentCarData[5]);
                int tireAge1 = int.Parse(currentCarData[6]);
                double tirePressure2 = double.Parse(currentCarData[7]);
                int tireAge2 = int.Parse(currentCarData[8]);
                double tirePressure3 = double.Parse(currentCarData[9]);
                int tireAge3 = int.Parse(currentCarData[10]);
                double tirePressure4 = double.Parse(currentCarData[11]);
                int tireAge4 = int.Parse(currentCarData[12]);
                Tire[] currentTires = new Tire[4];
                currentTires[0] = new Tire(tirePressure1, tireAge1);
                currentTires[1] = new Tire(tirePressure2, tireAge2);
                currentTires[2] = new Tire(tirePressure3, tireAge3);
                currentTires[3] = new Tire(tirePressure4, tireAge4);
                Engine currentEngine = new Engine(engineSpeed, enginePower);
                Cargo currentCargo = new Cargo(cargoWeight, cargoType);
                Car currentCar = new Car(model, currentEngine, currentCargo, currentTires);
                carList.Add(currentCar);
            }
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                carList = carList.Where(x => x.Cargo.CargoType == "fragile")
                    .Where(x =>
                    {
                        bool isLowPressure = false;
                        foreach (var tire in x.Tires)
                        {
                            if (tire.Pressure < 1)
                            {
                                isLowPressure = true;
                            }
                        }
                        return isLowPressure;
                    })
                    .ToList();
            }
            else if (command == "flamable")
            {
                carList = carList.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250).ToList();
            }
            foreach (var car in carList)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
