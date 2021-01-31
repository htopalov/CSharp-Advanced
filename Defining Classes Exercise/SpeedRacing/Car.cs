using System;

namespace SpeedRacing
{
   public class Car
    {
        string model;
        double fuelAmount;
        double fuelConsumptionPerKilometer;
        double travelledDistance;

        public Car(string model,double fuelAmount, double fuelConsumption)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumption;
            this.TravelledDistance = 0;
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

        public double FuelAmount
        {
            get
            {
                return fuelAmount;
            }
            set
            {
                this.fuelAmount = value;
            }
        }

        public double FuelConsumptionPerKilometer
        {
            get
            {
                return fuelConsumptionPerKilometer;
            }
            set
            {
                this.fuelConsumptionPerKilometer = value;
            }
        }

        public double TravelledDistance
        {
            get
            {
                return travelledDistance;
            }
            set
            {
                this.travelledDistance = value;
            }
        }

        public void Drive(int kmDrive)
        {
            double litres = kmDrive * this.FuelConsumptionPerKilometer;
 
            if (this.FuelAmount >= litres)
            {
                this.FuelAmount -= litres;
                this.TravelledDistance += kmDrive;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
