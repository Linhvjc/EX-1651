using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    internal class Product
    {
        private string name;
        private int cost;
        public string Name
        {
            get { return name; }
            set { 
                value = value.Trim();
                if (value.Length == 0) throw new ArgumentException("Name cannot be an empty string");
                name = value; 
            }
        }
        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public Product()
        {
        }
        public Product(string name, int cost)
        {
            Name = name;
            Cost = cost;
        }

        
    }
}
