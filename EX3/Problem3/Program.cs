namespace Problem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());
                Chicken chicken = new Chicken(name, age);
                chicken.ProductPerDay();
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}