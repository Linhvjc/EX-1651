namespace Problem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> exception = new List<string>();
            Pizza pizza = new Pizza();
            string pizzaCmd = Console.ReadLine();
            string pizzaName = pizzaCmd.Split()[1];
            try
            {
            pizza.Name = pizzaName;
            } catch (Exception e)
            {
                exception.Add(e.Message);
            }

            string doughCmd = Console.ReadLine();
            var doughCmdArr = doughCmd.Split();
            try
            {
                Dough dough = new Dough(doughCmdArr[1], doughCmdArr[2], int.Parse(doughCmdArr[3]));
                pizza.Dough = dough;
            }
            catch (Exception e)
            {
                exception.Add(e.Message);
            }

            while (true)
            {
                string toppingCmd = Console.ReadLine();
                if (toppingCmd == "END") break;
                var toppingCmdArr = toppingCmd.Split();
                try
                {
                Topping topping = new Topping(toppingCmdArr[1], int.Parse(toppingCmdArr[2]));
                pizza.AddTopping(topping);
                }
                catch (Exception e)
                {
                    exception.Add(e.Message);
                }
            }
            
            Console.WriteLine();
            if (exception.Count ==0) { 
                Console.WriteLine(pizza); 
            } else
            {
                foreach(string e in exception)
                {
                    Console.WriteLine(e);
                }
            }


        }
    }
}