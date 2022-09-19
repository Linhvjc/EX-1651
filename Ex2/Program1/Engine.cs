using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    internal class Engine
    {
        // model, power, displacement and efficiency
        public string Model { get; set; }
        public string Power { get; set; }
        public int Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine()
        {

        }

        public Engine(string model, string power, int displacement, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public Engine(string model, string power, int displacement)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = "n/a";
        }
        public Engine(string model, string power, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = -1;
            Efficiency = efficiency;
        }

        public Engine(string model, string power)
        {
            Model = model;
            Power = power;
            Displacement = -1;
            Efficiency = "n/a";
        }
    }
}
