using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
   public class Bakery
    {
        private List<Employee> data;
        public Bakery(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Employee>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        
        public int Count { get { return data.Count; } }
        public void Add(Employee employee)
        {
            if (data.Count < Capacity)
            {
                data.Add(employee);
            }
        }
        public bool Remove(string name)
        { 
              Employee employee = data.FirstOrDefault(x => x.Name == name);
            if (employee != null)
            {
                data.Remove(employee);
                return true;     
            }
            else
            {
                return false;
            }
        }
        public Employee GetOldestEmployee()
        {
            return data.OrderByDescending(x => x.Age).FirstOrDefault();
        }
        public Employee GetEmployee(string name)
        {
            return data.FirstOrDefault(x => x.Name == name);
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Employees working at Bakery {this.Name}:");
            foreach (var employee in data)
            {
                sb.AppendLine(employee.ToString());
            }
            return sb.ToString();
        }
    }
}
