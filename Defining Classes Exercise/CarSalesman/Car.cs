using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private string weight;
        private string color;

        public Car(string model, Engine engine) 
        {
            this.Model = model;
            this.Engine = engine;
            this.Weight = "n/a";
            this.Color = "n/a";
        }
        public Car(string model, Engine engine, string weight)
            :this(model,engine)
        {
            this.Weight = weight;
        }
        public Car(string model, Engine engine, string weight, string color)
            :this(model,engine,weight)
        {
            this.Color = color;
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
        public Engine Engine 
        {
            get
            {
                return engine;
            }
            set
            {
                this.engine = value;
            }
        }
        public string Weight 
        {
            get
            {
                return weight;
            }
            set
            {
                this.weight = value;
            }
        }
        public string Color 
        {
            get
            {
                return color;
            }
            set
            {
                this.color = value;
            }
        }
    }
}
