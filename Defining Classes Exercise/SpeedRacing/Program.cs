using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> carList = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);
                Car car = new Car(model, fuelAmount, fuelConsumption);
                carList.Add(car);
            }
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] splitted = command.Split();
                string currentModel = splitted[1];
                int kmToDrive = int.Parse(splitted[2]);
                Car currentCar = carList.Where(x => x.Model == currentModel).ToList().First();
                currentCar.Drive(kmToDrive);
                command = Console.ReadLine();
            }
            foreach (var item in carList)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelledDistance}");
            }


        }
    }
}
