namespace Problem8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //“<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType> <Tire1Pressure> <Tire1Age>
            //<Tire2Pressure> <Tire2Age> <Tire3Pressure> <Tire3Age> <Tire4Pressure> <Tire4Age>”

            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for(int i =0; i < n; i++)
            {
                var cmd = Console.ReadLine();
                var cmdArr = cmd.Split();
                Car car = new Car(cmdArr[0], int.Parse(cmdArr[1]), int.Parse(cmdArr[2]),
                    int.Parse(cmdArr[3]), cmdArr[4], double.Parse(cmdArr[5]), cmdArr[6],
                    double.Parse(cmdArr[7]), cmdArr[8], double.Parse(cmdArr[9]), 
                    cmdArr[10], double.Parse(cmdArr[11]), cmdArr[12]);
                cars.Add(car);
            }
            
            string choice = Console.ReadLine();
            Console.WriteLine();
            foreach(Car car in cars)
            {
                if(choice == car.CargoType && car.AveragePressure() <1)
                {
                    Console.WriteLine(car.Model);
                } 
                else if (choice == car.CargoType && car.EnginePower >250)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}