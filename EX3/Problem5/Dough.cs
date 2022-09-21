using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    internal class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private int weight;
        public string FlourType
        {
            get { return flourType; }
            set{
                if (value != "White" && value != "Wholegrain") 
                    throw new ArgumentException("Invalid type of dough.");
                flourType = value; 
            }
        }
        public string BakingTechnique
        {
            get { return bakingTechnique; }
            set {
                if (value != "Crispy" && value != "Chewy" && value != "Homemade")
                    throw new ArgumentException("Invalid type of dough.");
                bakingTechnique = value; 
            }
        }
        public int Weight
        {
            get { return weight; }
            set {
                if (value <1 || value > 200)
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                weight = value; 
            }
        }
        public Dough(string flourType, string bakingTechnique, int weight)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }
        public double totalCalories()
        {
            double modifier1=1;
            double modifier2=1;

            if (this.flourType == "White")
            {
                modifier1 = 1.5;
            } else if (this.flourType == "Wholegrain")
            {
                modifier1 = 1;
            }

            if (this.bakingTechnique == "Crispy")
            {
                modifier2 = 0.9;
            } else if (this.bakingTechnique == "Chewy")
            {
                modifier2 = 1.1;
            } else if (this.bakingTechnique == "Homemade")
            {
                modifier2 = 1;
            }
            return (2*this.weight) * modifier1* modifier2;
        }
    }
}
