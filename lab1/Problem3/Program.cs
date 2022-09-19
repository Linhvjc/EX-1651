using Problem3;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        Family family = new Family();
        int quantity = int.Parse(Console.ReadLine());
        for (int i =0; i < quantity; i++)
        {
            var newPerson = Console.ReadLine();
            var newPersonArr = newPerson.Split(" ");
            var name = newPersonArr[0];
            var age = int.Parse(newPersonArr[1]);
            family.AddMember(new Person(name, age));
        }
        Console.WriteLine();
        Console.Write("Oldest Member: ");
        Console.WriteLine(family.GetOldestMember().Name + " " + family.GetOldestMember().Age);
    }
}