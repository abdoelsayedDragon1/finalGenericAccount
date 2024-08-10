﻿namespace finalTaskOop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Accounts
            var accounts = new List<Account>();
            accounts.Add(new Account());
            accounts.Add(new Account("Larry"));
            accounts.Add(new Account("Moe", 2000));
            accounts.Add(new Account("Curly", 5000));

            AccountUtil.Display(accounts);
            AccountUtil.Deposit(accounts, 1000);
            AccountUtil.Withdraw(accounts, 2000);

            // Savings
            var savAccounts = new List<Account>();
           savAccounts.Add(new Account());
            savAccounts.Add(new Account("Superman"));
            savAccounts.Add(new Account("Batman", 2000));
            savAccounts.Add(new Account("Wonderwoman", 5000));

            AccountUtil.Display(savAccounts);
            AccountUtil.Deposit(savAccounts, 1000);
            AccountUtil.Withdraw(savAccounts, 2000);

            // Checking
            var checAccounts = new List<Account>();
            checAccounts.Add(new Account());
            checAccounts.Add(new Account("Larry2"));
            checAccounts.Add(new Account("Moe2", 2000));
            checAccounts.Add(new Account("Curly2", 5000));

            AccountUtil.Display(checAccounts);
            AccountUtil.Deposit(checAccounts, 1000);
            AccountUtil.Withdraw(checAccounts, 2000);
            AccountUtil.Withdraw(checAccounts, 2000);

            //// Trust
            var trustAccounts = new List<Account>();
            trustAccounts.Add(new Account());
            trustAccounts.Add(new Account("Superman2"));
            trustAccounts.Add(new Account("Batman2", 2000));
            trustAccounts.Add(new Account("Wonderwoman2", 5000));

            AccountUtil.Display(trustAccounts);
            AccountUtil.Deposit(trustAccounts, 1000);
            AccountUtil.Deposit(trustAccounts, 6000);
            AccountUtil.Withdraw(trustAccounts, 2000);
            AccountUtil.Withdraw(trustAccounts, 3000);
            AccountUtil.Withdraw(trustAccounts, 500);

            Console.WriteLine();



        }
    }
}
