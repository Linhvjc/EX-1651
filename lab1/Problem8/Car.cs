using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem8
{
    internal class Car
    {
        

        public string Model { get; set; }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
        public double Tire1Pressure { get; set; }
        public string Tire1Age { get; set; }
        public double Tire2Pressure { get; set; }
        public string Tire2Age { get; set; }
        public double Tire3Pressure { get; set; }
        public string Tire3Age { get; set; }
        public double Tire4Pressure { get; set; }
        public string Tire4Age { get; set; }

        public Car() { }

        public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType, double tire1Pressure,
            string tire1Age, double tire2Pressure, string tire2Age, double tire3Pressure, string tire3Age, double tire4Pressure, string tire4Age)
        {
            Model = model;
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
            CargoWeight = cargoWeight;
            CargoType = cargoType;
            Tire1Pressure = tire1Pressure;
            Tire1Age = tire1Age;
            Tire2Pressure = tire2Pressure;
            Tire2Age = tire2Age;
            Tire3Pressure = tire3Pressure;
            Tire3Age = tire3Age;
            Tire4Pressure = tire4Pressure;
            Tire4Age = tire4Age;
        }

        public double AveragePressure()
        {
            return (this.Tire1Pressure + this.Tire2Pressure + this.Tire3Pressure + this.Tire4Pressure) / 4;
        }
    }
}
