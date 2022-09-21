namespace Problem4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line1 = Console.ReadLine();
            var people = line1.Split(";");
            string line2 = Console.ReadLine();
            var products = line2.Split(";");
            List<Person> listPerson = new List<Person>();
            List<Product> listProduct = new List<Product>();
            for (int i = 0; i< people.Length; i++)
            {
                var info = people[i].Split("=");
                try
                {
                    Person person = new Person(info[0], int.Parse(info[1]));
                    listPerson.Add(person);
                } catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            for (int i = 0; i < products.Length; i++)
            {
                var info = products[i].Split("=");
                try
                {
                    Product product = new Product(info[0], int.Parse(info[1]));
                    listProduct.Add(product);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Person FindPersonByName(string name)
            {
                foreach(var person in listPerson)
                {
                    if(name == person.Name)
                    {
                        return person;
                    }
                }
                return new Person();
            }
            Product FindProductByName(string name)
            {
                foreach(var product in listProduct)
                {
                    if(name == product.Name)
                    {
                        return product;
                    }
                }
                return new Product();
            }
            List<string> listAction = new List<string>();
            while(true)
            {
                var action  = Console.ReadLine();
                if (action == "END") break;
                var actionArr = action.Split();
                var personAction = FindPersonByName(actionArr[0]);
                var productAction = FindProductByName(actionArr[1]);
                if(personAction.Money < productAction.Cost)
                {
                    listAction.Add($"{personAction.Name} can't afford {productAction.Name}");
                } else
                {
                    listAction.Add($"{personAction.Name} bought {productAction.Name}");
                    personAction.caculateWallet(productAction.Cost);
                    personAction.AddToBag(productAction.Name);
                }
            }

            foreach(var action in listAction)
            {
                Console.WriteLine(action);
            }
            foreach(var person in listPerson)
            {
                Console.Write($"{person.Name} - ");
                if(person.BagOfProducts.Count > 0)
                {
                    foreach (var product in person.BagOfProducts)
                    {
                        Console.Write(product + ";");
                    }
                } else
                {
                    Console.Write("Nothing bought");
                }
                
                Console.WriteLine();
            }
        }
    }
}