internal class Program
{
    private static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        for(int i =1; i<= size; i++ )
        {
            PrintRow(i, size);
        }

        for(int i = size-1; i>=1; i--)
        {
            PrintRow(i,size);
        }


    }

    public static void PrintRow(int index, int size)
    {
        for (int i =0; i< size -index; i++)
        {
            Console.Write(" ");
        }
        for (int i =1; i< index; i++)
        {
            Console.Write("* ");
        }

        Console.WriteLine("*");
    }
}