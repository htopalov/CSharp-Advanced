using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        private string displacement;
        private string efficiency;

        public Engine(string model,int power)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = "n/a";
            this.Efficiency = "n/a";
        }
        public Engine(string model, int power, string displacement)
            :this(model,power)
        {
            this.Displacement = displacement;
        }
        public Engine(string model, int power, string displacement, string efficiency)
            :this(model,power,displacement)
        {
            this.Efficiency = efficiency;
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
        public int Power 
        { 
            get
            {
                return power;
            }
            set
            {
                this.power = value;
            }
        }
        public string Displacement 
        { 
            get
            {
                return displacement;
            }
            set
            {
                this.displacement = value;
            }
        }
        public string Efficiency 
        { 
            get
            {
                return efficiency;
            }
            set
            {
                this.efficiency = value;
            }
        }
    }
}
