namespace EqualityLogic
{
    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }
        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            var item = obj as Person;
            if (item == null)
            {
                return false;
            }
            return this.Name.Equals(item.Name) && this.Age.Equals(item.Age);
        }
    }
}
