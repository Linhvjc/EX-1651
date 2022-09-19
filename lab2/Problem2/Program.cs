namespace Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var commandArr = command.Split(" ");
            Rectangle rectangle = new Rectangle();
            rectangle.TopLeft = new Point(int.Parse(commandArr[0]), int.Parse(commandArr[1]));
            rectangle.BottomRight = new Point(int.Parse(commandArr[2]), int.Parse(commandArr[3]));

            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                var pointCmd = Console.ReadLine();
                var pointArr = pointCmd.Split(" ");
                bool result = 
                    rectangle.Contains(new Point(int.Parse(pointArr[0]), int.Parse(pointArr[1])));
                Console.WriteLine(result);
            }
        }
    }
}