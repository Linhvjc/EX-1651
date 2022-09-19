using static System.Formats.Asn1.AsnWriter;

namespace problem7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * 	1   “FirstName LastName - FirstName LastName”
                2	“FirstName LastName - day/month/year”
                3	“day/month/year - FirstName LastName”
                4	“day/month/year - day/month/year”
                5	“FirstName LastName day/month/year” ---> done
             */
            Dictionary<string, string> format1 = new Dictionary<string, string>();
            Dictionary<string, string> format2 = new Dictionary<string, string>();
            Dictionary<string, string> format3 = new Dictionary<string, string>();
            Dictionary<string, string> format4 = new Dictionary<string, string>();
            Dictionary<string, string> format5 = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while(true)
            {
                string line = Console.ReadLine();
                if (line=="End") break;
                if(!(line.Contains("-")))   // ---> format 5
                {
                    var lineArr = line.Split(" ");
                    format5.Add($"{lineArr[0]} {lineArr[1]}", lineArr[2]);
                } else
                {
                    var lineArr = line.Split(" - ");
                    if (lineArr[0].Contains("/"))  //----> format 3,4
                    {
                        if(lineArr[1].Contains("/")) //----> format 4
                        {
                            format4.Add(lineArr[0], lineArr[1]);
                        } else  //-----> format 3
                        {
                            format3.Add(lineArr[0], lineArr[1]);
                        }
                    } else  //-----> format 1.2
                    {
                        if (lineArr[1].Contains("/")) //----> format 2
                        {
                            format2.Add(lineArr[0], lineArr[1]);
                        }
                        else  //-----> format 1
                        {
                            format1.Add(lineArr[0], lineArr[1]);
                        }
                    }
                }
            }

            // find DOB
            string actorName = "";
            string actorDoB = "";
            if (input.Contains('/'))
            {
                actorDoB = input;
                foreach (KeyValuePair<string, string> item in format5)
                {
                    if (item.Value == actorDoB)
                    {
                        actorName = item.Key;
                    }
                }
            } else
            {
                actorName = input;
                foreach (KeyValuePair<string, string> item in format5)
                {
                    if (item.Key == actorName)
                    {
                        actorDoB = item.Value;
                    }
                }
            }
            // find parent
            string parentName1 = "";
            string parentDoB1 = "";
            foreach (KeyValuePair<string, string> item in format4)
            {
                if (item.Value == actorDoB)
                {
                    parentDoB1 = item.Key;
                }
            }
            foreach (KeyValuePair<string, string> item in format5)
            {
                if (item.Value == parentDoB1)
                {
                    parentName1 = item.Key;
                }
            }
            string parentName2 = "";
            string parentDoB2 = "";
            foreach (KeyValuePair<string, string> item in format2)
            {
                if (item.Value == actorDoB)
                {
                    parentName2 = item.Key;
                }
            }
            foreach (KeyValuePair<string, string> item in format5)
            {
                if (item.Key == parentName2)
                {
                    parentDoB2 = item.Value;
                }
            }
            string parentName3 = "";
            string parentDoB3 = "";
            foreach (KeyValuePair<string, string> item in format3)
            {
                if (item.Value == actorName)
                {
                    parentDoB3 = item.Key;
                }
            }
            foreach (KeyValuePair<string, string> item in format5)
            {
                if (item.Value == parentDoB3)
                {
                    parentName3 = item.Key;
                }
            }
            // find children
            string childName = "";
            string childDoB = "";
            foreach (KeyValuePair<string, string> item in format1)
            {
                if (item.Key == actorName)
                {
                    childName = item.Value;
                }
            }
            foreach (KeyValuePair<string, string> item in format5)
            {
                if (item.Key == childName)
                {
                    childDoB = item.Value;
                }
            }

            // Print information
            Console.WriteLine();
            Console.WriteLine($"{actorName} {actorDoB}");
            Console.WriteLine("Parents:");
            if (parentName1 != "")
            {
                Console.WriteLine($"{parentName1} {parentDoB1}");
            }
            if (parentName2 != "")
            {
                Console.WriteLine($"{parentName2} {parentDoB2}");
            }
            if (parentName3 != "")
            {
                Console.WriteLine($"{parentName3} {parentDoB3}");
            }
            Console.WriteLine("Children:");
            if (childName != "")
            {
                Console.WriteLine($"{childName} {childDoB}");
            }
        }
    }
}