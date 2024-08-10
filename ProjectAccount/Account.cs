using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccount
{
    internal class Account
    {
        public Account(string name, double balance)
        {
            this.name = name;
            this.balance = balance;
        }

        public string name { get; set; }
        public double balance { get; set; }
        public virtual bool Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                return true;
            }
            else
            {
                return false;
            }

        }
        public virtual bool Withdraw(double amount)
        {
            if(amount > 0 && amount <= balance)
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
            return $"Name: {name}, Balance: {balance:C}";
        }
        public static Account operator +(Account lhs, Account rhs)
        {

            return new Account (lhs.name + rhs.name, lhs.balance + rhs.balance);
        }
    }
}
