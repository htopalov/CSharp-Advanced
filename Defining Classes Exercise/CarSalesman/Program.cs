using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carCollection = new List<Car>();
            List<Engine> engineList = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                string[] engineInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string engineModel = engineInput[0];
                int enginePower = int.Parse(engineInput[1]);
                string engineDisplacement = string.Empty;
                string engineEfficiency = string.Empty;
                int engineDisplacementAsInt = 0;
                Engine currentEngine = new Engine(engineModel, enginePower);
                if (engineInput.Length == 3)
                {
                    bool isDisplacement = int.TryParse(engineInput[2], out engineDisplacementAsInt);
                    if (isDisplacement)
                    {
                        currentEngine = new Engine(engineModel, enginePower, engineDisplacementAsInt.ToString());
                    }
                    else
                    {
                        engineEfficiency = engineInput[2];
                        engineDisplacement = engineEfficiency;
                        currentEngine = new Engine(engineModel, enginePower, "n/a", engineEfficiency);
                    }     
                }
                else if (engineInput.Length == 4)
                {
                    engineDisplacement = engineInput[2];
                    engineEfficiency = engineInput[3];
                    currentEngine = new Engine(engineModel, enginePower, engineDisplacement,engineEfficiency);
                }
                engineList.Add(currentEngine);
            }
            int m = int.Parse(Console.ReadLine());
            for (int j = 0; j < m; j++)
            {
                string[] carInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = carInput[0];
                string modelOfEngine = carInput[1];
                Engine carEngine = engineList.Find(x => x.Model == modelOfEngine);
                string carWeight = string.Empty;
                string carColor = string.Empty;
                int carWeightAsInt = 0;
                Car currentCar = new Car(carModel, carEngine);
                if (carInput.Length == 3)
                {
                    bool isWeight = int.TryParse(carInput[2], out carWeightAsInt);
                    if (isWeight)
                    {
                        currentCar = new Car(carModel, carEngine, carWeightAsInt.ToString());
                    }
                    else
                    {
                        carColor = carInput[2];
                        carWeight = carColor;
                        currentCar = new Car(carModel, carEngine, "n/a" , carWeight);
                    }
                }
                else if(carInput.Length == 4)
                {
                    carWeight = carInput[2];
                    carColor = carInput[3];
                    currentCar = new Car(carModel, carEngine, carWeight, carColor);
                }
                carCollection.Add(currentCar);
            }
            foreach (var car in carCollection)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
