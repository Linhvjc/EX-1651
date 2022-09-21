using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    internal class Pizza
    {
        private string name;
        private List<Topping> toppings = new List<Topping>();
        private Dough dough;

        public string Name
        {
            get { return name; }
            set {
                value = value.Trim();
                if(value.Length > 15 || value.Length <1)
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                name = value;
                
            }
        }

        public List<Topping> Toppings
        {
            get { return toppings; }
            set { 
                //if(value.Count <0 || value.Count >10) 
                    //throw new ArgumentException("Number of toppings should be in range [0..10].");
                toppings = value; 
            }
        }
        public Dough Dough
        {
            get { return dough; }
            set { dough = value; }
        }

        public Pizza()
        {
        }

        public Pizza(string name, List<Topping> toppings, Dough dough)
        {
            Name = name;
            Toppings = toppings;
            Dough = dough;
        }

        public int numOfTopping()
        {
            int count = 0;
            foreach (Topping topping in Toppings)
            {
                count++;
            }
            return count;
        }

        public double totalCalories()
        {
            double total = 0;
            foreach (Topping topping in Toppings)
            {
                total += topping.totalCalories();
            }
            total += dough.totalCalories();
            return total;
        }

        public void AddTopping(Topping topping)
        {
            if (numOfTopping()+1 <0 || numOfTopping() + 1 > 10)
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            this.Toppings.Add(topping);
        }

        public override string ToString()
        {
            return $"{this.name} - {this.totalCalories()} Calories.";
        }
    }
}
