using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7
{
    internal class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionFor1km { get; set; }
        public double distanceTraveled { get; set; }

        public Car()
        {
            distanceTraveled = 0;
        }
        public Car(string model, double fuelAmount, double fuelConsumptionFor1km)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionFor1km = fuelConsumptionFor1km;
            distanceTraveled = 0;
        }

        

        
    }
}
