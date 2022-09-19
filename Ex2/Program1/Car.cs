using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Car
    {
        private string model;
        private string engine;
        private int weight;
        private string color;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Engine
        {
            get { return engine; }
            set { engine = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Car()
        {

        }
        public Car(string model, string engine, int weight, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = color;
        }
        public Car(string model, string engine)
        {
            this.model = model;
            this.engine = engine;
            this.weight = -1;
            this.color = "n/a";
        }
        public Car(string model, string engine, int weight)
        {
            this.model = model;
            this.engine = engine;
            this.weight = weight;
            this.color = "n/a";
        }
        public Car(string model, string engine, string color)
        {
            this.model = model;
            this.engine = engine;
            this.weight = -1;
            this.color = color;
        }
    }
}
