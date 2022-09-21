using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Chicken
    {
        private string name;
        private int age;
        
        public string Name
        {
            get { return name; }
            set {
                value = value.Trim();
                if (value.Length == 0) throw new ArgumentException("Name cannot be empty.");
                name = value; 
            }
        }
        public int Age
        {
            get { return age; }
            set {
                if (value < 0 || value > 15) throw new ArgumentException("Age should be between 0 and 15.");
                age = value; 
            }
        }
        public Chicken(string name, int age)
        {
            Name = name;
            Age = age;
        }

        private int CalculProductPerDay()
        {
            return 1;
        }
        public void ProductPerDay()
        {
            Console.WriteLine($"Chicken {this.Name}(age {this.Age}) can produce {CalculProductPerDay()} eggs per day.");
        }
    }
}
