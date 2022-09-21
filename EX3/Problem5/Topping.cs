using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    internal class Topping
    {
        private string type;
        private int weight;

        public string Type
        {
            get { return type; }
            set {
                if (value != "Meat" && value != "Veggies"
                    && value != "Cheese" && value != "Sauce")
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                type = value; 
            }
        }
        public int Weight
        {
            get { return weight; }
            set {
                if (value < 1 || value > 50)
                    throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
                weight = value; 
            }
        }

        public Topping(string type, int weight)
        {
            Type = type;
            Weight = weight;
        }

        public double totalCalories()
        {
            double modifier = 1;
            if(this.type == "Meat")
            {
                modifier = 1.2;
            } else if (this.type == "Veggies")
            {
                modifier = 0.8;
            }
            else if (this.type == "Cheese")
            {
                modifier = 1.1;
            }
            else if (this.type == "Sauce")
            {
                modifier = 0.9;
            }
            return 2*modifier*this.Weight;
        }
    }
}
