namespace ProjectAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Abdo", 1000);
            CheckingAccount account2 = new CheckingAccount(" Os", 500);
            SavingAccount account3 = new SavingAccount("said", 2000, 0.02);
            TrustAccount account4 = new TrustAccount("noah", 10000, 0.05);

            List<Account> accounts = new List<Account> { account1, account2, account3, account4 };

            AccountUtil.Display(accounts);

            AccountUtil.Deposit(accounts,7000);

            
            account3.ApplyInterest(); //Applying interest to a savings account
            account4.ApplyInterest(); //A trust account is an interest rate savings account


            AccountUtil.Display(accounts); //display accounts after deposit and apply interest

            AccountUtil.Withdraw(accounts, 500); //Withdraw an amount from all accounts

            AccountUtil.Withdraw(accounts,5000 ); 
            AccountUtil.Withdraw(accounts, 5000);
            
            AccountUtil.Withdraw(accounts, 4000);
            


            account4.ResetWithdrawals(); //Resetting withdrawals to a trust account

            AccountUtil.Display(accounts);

            Account mergedAccount = account1 + account2;
            Console.WriteLine($"\nMerged Account: {mergedAccount}");
        }
    }
}
