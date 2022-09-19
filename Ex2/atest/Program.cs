using System.Collections.Generic;

namespace atest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> test = new Dictionary<int, string>();
            test.Add(5, "linh");
            test.Add(1, "linh2");
            test.Add(4, "linh3");
            test = test.OrderByDescending(u => u.Key).ToDictionary(z => z.Key, y => y.Value);
            foreach (KeyValuePair<int, string> item in test)
            {
                Console.WriteLine(item.Key);
            }
            /*
            SortedDictionary<int, string > sortedGold = new SortedDictionary<int, string>(test);
            foreach (KeyValuePair<int, string> item in sortedGold)
            {
                Console.WriteLine(item.Key);
            }*/
            string a = "linhha";
            Console.WriteLine(a.Contains("ha"));
        }
    }
}