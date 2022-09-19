using static System.Net.Mime.MediaTypeNames;

namespace Program5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int storage = int.Parse(Console.ReadLine());
            string cmd = Console.ReadLine();
            var cmdArr = cmd.Split(" ");
            int store = 0;
            Dictionary<int, string> gold = new Dictionary<int, string>();
            Dictionary<int, string> gem = new Dictionary<int, string>();
            Dictionary<int, string> cash = new Dictionary<int, string>();
            for (int i = 0; i <= cmdArr.Length-2; i += 2)
            {
                if (cmdArr[i] == "Gold")
                {
                    gold.Add(int.Parse(cmdArr[i + 1]), cmdArr[i]);
                } else if(cmdArr[i].Contains("gem"))
                {
                    gem.Add(int.Parse(cmdArr[i + 1]), cmdArr[i]);
                } else
                {
                    int check = 0;
                    for (int j = 0; j < cmdArr[i].Length; j++)
                    {
                        if (cmdArr[i][j] >= 'A' && cmdArr[i][j] <= 'Z') continue;
                        else
                        {
                            check = 1;
                            break;
                        }
                    }
                    if (check == 1) continue;
                    cash.Add(int.Parse(cmdArr[i + 1]), cmdArr[i]);
                }
            }
            gold = gold.OrderByDescending(u => u.Key).ToDictionary(z => z.Key, y => y.Value);
            gem = gem.OrderByDescending(u => u.Key).ToDictionary(z => z.Key, y => y.Value);
            cash = cash.OrderByDescending(u => u.Key).ToDictionary(z => z.Key, y => y.Value);

            int tempGold = 0;
            int tempGem = 0;
            int tempCash = 0;
            Dictionary<int, string> listGem = new Dictionary<int, string>();
            Dictionary<int, string> listCash = new Dictionary<int, string>();
            foreach (KeyValuePair<int, string> item in gold)
            {
                if(store + item.Key <= storage)
                {
                    store += item.Key;
                    tempGold += item.Key;
                }
            }
            if (storage > store)
            {
                foreach (KeyValuePair<int, string> item in gem)
                {
                    if (store + item.Key <= storage)
                    {
                        store += item.Key;
                        tempGem += item.Key;
                        listGem.Add(item.Key, item.Value);
                    }
                }
            }
            if (storage > store)
            {
                foreach (KeyValuePair<int, string> item in cash)
                {
                    if (store + item.Key <= storage)
                    {
                        store += item.Key;
                        tempCash += item.Key;
                        listCash.Add(item.Key, item.Value);
                    }
                }
            }

            Console.WriteLine($"<Gold> ${tempGold}");
            Console.WriteLine($"##Gold - {tempGold}");
            if (tempGem > 0)
            {
                Console.WriteLine($"<Gem> ${tempGem}");
                foreach (KeyValuePair<int, string> item in listGem)
                {
                    Console.WriteLine($"##{item.Value} - {item.Key}");
                }
            }
            if (tempCash > 0)
            {
                Console.WriteLine($"<Cash> ${tempCash}");
                foreach (KeyValuePair<int, string> item in listCash)
                {
                    Console.WriteLine($"##{item.Value} - {item.Key}");
                }
            }
            
        }
    }
}