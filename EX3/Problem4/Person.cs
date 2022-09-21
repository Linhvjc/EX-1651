using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    internal class Person
    {
        private string name;
        private int money;
        private List<string> bagOfProducts = new List<string>();

        public string Name
        {
            get { return name; }
            set
            {
                value = value.Trim();
                if (value.Length == 0) throw new ArgumentException("Name cannot be an empty string");
                name = value;
            }
        }
        public int Money
        {
            get { return money; }
            set {
                if (value < 0) throw new ArgumentException("Money cannot be a negative number.");
                money = value; 
            }
        }
        public List<string> BagOfProducts
        {
            get { return bagOfProducts; }
            set { bagOfProducts = value; }
        }
        public Person()
        {
        }

        public Person(string name, int money)
        {
            Name = name;
            Money = money;
            BagOfProducts = new List<string>();
        }

        public void caculateWallet(int cost)
        {
            money -= cost;
        }

        public void AddToBag(string product)
        {
            bagOfProducts.Add(product);
        }
    }
}
