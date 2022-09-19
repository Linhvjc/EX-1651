using Problem6;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Employee> list = new List<Employee>();
        int n = int.Parse(Console.ReadLine());
        for (int i =0;i <n;i++)
        {
            var line = Console.ReadLine();
            var field = line.Split(' ');
            var length = field.Length;
            
            if (length ==6)
            {
                list.Add(new Employee(
                        field[0], Double.Parse(field[1]), field[2], field[3], field[4], int.Parse(field[5]))
                    );
            } else if (length == 5)
            {
                if (field[4].Contains("@"))
                {
                    list.Add(new Employee(
                        field[0], Double.Parse(field[1]), field[2], field[3], field[4])
                    );
                } else
                {
                    list.Add(new Employee(
                        field[0], Double.Parse(field[1]), field[2], field[3], int.Parse(field[4]))
                    );
                }

            } else if (length == 4)
            {
                list.Add(new Employee(
                        field[0], Double.Parse(field[1]), field[2], field[3])
                    );
            }
            
        }

        Console.WriteLine();

        var best = list.GroupBy(g => g.department)
                .Select(g => new
                {
                    Average = g.Average(e => e.salary),
                    Department = g.Key
                }).OrderByDescending(d => d.Average).First();
        Console.WriteLine("Highest Average Salary:" + best.Department);
        list = list.FindAll(g => g.department == best.Department).OrderByDescending(g => g.salary).ToList();
        foreach (Employee employee in list)
        {
            if (employee.department == best.Department)
                Console.WriteLine(employee);
        }



    }
}