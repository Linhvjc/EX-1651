namespace Program2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<Engine> engines = new List<Engine>();
            int n = int.Parse(Console.ReadLine());
            for (int i =0; i< n; i++)
            {
                var cmdEngine = Console.ReadLine();
                var arrEngine = cmdEngine.Split(" ");
                if(arrEngine.Length == 4)
                {
                    Engine engine = new Engine(arrEngine[0], arrEngine[1], int.Parse(arrEngine[2]), arrEngine[3]);
                    engines.Add(engine);
                } else if(arrEngine.Length == 3)
                {
                    if (int.Parse(arrEngine[2]) >= '0' & int.Parse(arrEngine[2]) <= '9')
                    {
                        Engine engine = new Engine(arrEngine[0], arrEngine[1], int.Parse(arrEngine[2]));
                        engines.Add(engine);
                    } else
                    {
                        Engine engine = new Engine(arrEngine[0], arrEngine[1], arrEngine[2]);
                        engines.Add(engine);
                    }
                } else if(arrEngine.Length == 2)
                {
                    Engine engine = new Engine(arrEngine[0], arrEngine[1]);
                    engines.Add(engine);
                }
                
            }
            int m = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();
            for (int i = 0; i<m; i++)
            {
                var cmdCar = Console.ReadLine();
                var arrCar = cmdCar.Split(" ");
                if(arrCar.Length == 4)
                {
                    Car car = new Car(arrCar[0], arrCar[1], int.Parse(arrCar[2]), arrCar[3]);
                    cars.Add(car);
                } else if(arrCar.Length == 3)
                {
                    if (int.Parse(arrCar[2]) >= '0' & int.Parse(arrCar[2]) <= '9')
                    {
                        Car car = new Car(arrCar[0], arrCar[1], int.Parse(arrCar[2]));
                        cars.Add(car);
                    } else
                    {
                        Car car = new Car(arrCar[0], arrCar[1], arrCar[2]);
                        cars.Add(car);
                    }
                } else if (arrCar.Length == 2)
                {
                    Car car = new Car(arrCar[0], arrCar[1]);
                    cars.Add(car);
                }
            }

            Engine check(string nameEngine)
            {
                foreach (var engine in engines)
                {
                    if(engine.Model == nameEngine)
                    {
                        return engine;
                    }
                }
                return new Engine();
            }

            foreach(var car in cars)
            {
                Console.WriteLine(car.Model+":");
                Engine engine = check(car.Engine);
                Console.WriteLine("  "+"Power: "+ engine.Model+":");
                Console.WriteLine("    " + "Displacement: " + engine.Power);
                Console.WriteLine("    "+ "Efficiency: " + engine.Displacement);
                Console.WriteLine("    "+ engine.Efficiency);
                Console.WriteLine("  " + "Weight: " + car.Weight);
                Console.WriteLine("  "+ "Color: " +  car.Color);
            }


        }

        
    }
}