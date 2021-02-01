namespace RawData
{
    public class Tire
    {
        private int age;
        private double pressure;

        public Tire(double pressure,int age)
        {
            this.Age = age;
            this.Pressure = pressure;
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                this.age = value;
            }
        }
        public double Pressure 
        {
            get
            {
                return pressure;
            }
            set
            {
                this.pressure = value;
            }
        }
    }
}
