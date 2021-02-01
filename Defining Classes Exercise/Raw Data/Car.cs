namespace RawData
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private Tire[] tires;
        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
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
        public Cargo Cargo 
        {
            get
            {
                return cargo;
            }
            set
            {
                this.cargo = value;
            }
        }
        public Tire[] Tires 
        {
            get
            {
                return tires;
            }
            set
            {
                this.tires = value;
            }
        }
    }
}
