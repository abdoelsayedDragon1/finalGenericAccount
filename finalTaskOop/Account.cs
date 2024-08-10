namespace finalTaskOop
{
    public class Account
    {
        public string name { get; set; }
        public double balance { get; set; }

        public Account(string name = "Unnamed Account", double balance = 0.0)
        {
            this.name = name;
            this.balance = balance;
        }

        public bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else
            {
                balance += amount;
                return true;
            }
        }

        public bool Withdraw(double amount)
        {
            if (balance - amount >= 0)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }


        public override string ToString()
        {
            return $"[Account: {name}: {balance}]";
        }
    }
}
