namespace Problem7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                var cmd = Console.ReadLine();
                var cmdField = cmd.Split(' ');
                Car car = new Car(cmdField[0], double.Parse(cmdField[1]), double.Parse(cmdField[2]));
                cars.Add(car);
            }
            while(true)
            {
                var action = Console.ReadLine();
                if (action == "End") break;
                var actionArr = action.Split(" ");
                Caculator(cars, double.Parse(actionArr[2]), actionArr[1]);
            }
            foreach(var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount} {car.distanceTraveled}");
            }
        }
        public static void Caculator(List<Car> cars, double km, string model)
        {
            if (CheckCar(cars, model).FuelAmount < CheckCar(cars, model).FuelConsumptionFor1km * km)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            } else
            {
                CheckCar(cars, model).distanceTraveled += km;
                CheckCar(cars, model).FuelAmount -= CheckCar(cars, model).FuelConsumptionFor1km * km;
            }
        }
        public static Car CheckCar(List<Car> cars, string model)
        {
            foreach (var car in cars)
            {
                if (car.Model == model)
                {
                    return car;
                }
            }
            return new Car();
        }
    }
}