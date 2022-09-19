namespace Problem3
{
    internal class BankAccount
    {
        private int id;
        private decimal balance;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public void Print(int Id)
        {
            Console.WriteLine($"Account ID{id}, balance {balance}");
        }

    }
}
