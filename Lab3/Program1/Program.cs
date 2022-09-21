namespace Program1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();
            for(int i =0; i<lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                people.Add(new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2])));
            }
            people.OrderBy(p=> p.FirstName)
                .ThenBy(p=>p.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}