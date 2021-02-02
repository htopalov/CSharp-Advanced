using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;
        private string str;
        private string make;
        private string model;
        private int horsePower;
        private string registrationNumber;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.Cars = new List<Car>(capacity);

        }


        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                this.make = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                this.model = value;
            }
        }
        public int HorsePower
        {
            get
            {
                return horsePower;
            }
            set
            {
                this.horsePower = value;
            }
        }
        public string RegistrationNumber
        {
            get
            {
                return registrationNumber;
            }
            set
            {
                this.registrationNumber = value;
            }
        }
        public List<Car> Cars 
        { 
            get
            {
                return cars;
            }
            set
            {
                this.cars = value;
            }
        }
        public int Count 
        { 
            get
            {
                return Cars.Count;
            }
        }
        public string AddCar(Car car)
        {
            if (Cars.Contains(car))
            {
                str = "Car with that registration number, already exists!";
            }
            else if (Cars.Count >= capacity)
            {
                str = "Parking is full!";
            }
            else
            {
                str = $"Successfully added new car {car.Make} {car.RegistrationNumber}";
                Cars.Add(car);
            }
            return str;

        }
        public string RemoveCar(string registrationNumber)
        {
            Car carToRemove = Cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
            if (carToRemove == null)
            {
                str = $"Car with that registration number, doesn't exist!";  
            }
            else
            {
                str = $"Successfully removed {carToRemove.RegistrationNumber}";
                Cars.Remove(carToRemove);
            }
            return str;
        }
        public Car GetCar(string registrationNumber)
        {
            Car carToGet = Cars.Find(x => x.RegistrationNumber == registrationNumber);
            return carToGet;
        }
        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (var number in RegistrationNumbers)
            {
               Cars.Remove(Cars.Find(x => x.RegistrationNumber == number));
            }
        }

    }
}
