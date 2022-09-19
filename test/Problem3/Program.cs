using Problem3;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        var command = Console.ReadLine();
        var cmdArgs = command.Split();
        var cmdType = cmdArgs[0];

        while (cmdType != "End")
        {
            switch (cmdType)
            {
                case "Create":
                    Create(cmdArgs, accounts);
                    break;
                case "Deposit":
                    Deposit(cmdArgs, accounts);
                    break;
                case "Withdraw":
                    Withdraw(cmdArgs, accounts);
                    break;
                case "Print":
                    Print(cmdArgs, accounts);
                    break;
            }
            command = Console.ReadLine();
            cmdArgs = command.Split();
            cmdType = cmdArgs[0];
        }
        

    }
    public static void Create(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine("Account already exists");
        } else
        {
            var acc = new BankAccount();
            acc.Id = id;
            accounts.Add(id, acc);
        }
    }

    public static void Deposit(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            var acc = accounts[id];
            var amount = int.Parse(cmdArgs[2]);
            acc.Deposit(amount);
        }
    }

    public static void Withdraw(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            var amount = int.Parse(cmdArgs[2]);
            var acc = accounts[id];
            if (amount > acc.Balance)
            {
                Console.WriteLine("Insufficient balance");
            } else
            {
                acc.Withdraw(amount);
            }

        }
    }

    public static void Print(string[] cmdArgs, Dictionary<int, BankAccount> accounts)
    {
        var id = int.Parse(cmdArgs[1]);
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine("Account does not exist");
        }
        else
        {
            var acc = accounts[id];
            Console.WriteLine($"Account ID {acc.Id}, Balance {acc.Balance}");
        }
    }
}