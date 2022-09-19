using Problem4;

internal class Program
{
    private static void Main(string[] args)
    {
        List people = new List();
        int quantity = int.Parse(Console.ReadLine());
        for (int i = 0; i < quantity; i++)
        {
            var newPerson = Console.ReadLine();
            var newPersonArr = newPerson.Split(" ");
            var name = newPersonArr[0];
            var age = int.Parse(newPersonArr[1]);
            people.AddMember(new Person(name, age));
        }

        Console.WriteLine();
        var newArr = people.Over30();
        foreach(var person in newArr)
        {
            Console.WriteLine(person.Name + " - " + person.Age);
        }
    }
}