using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccount
{
    internal class SavingAccount:Account
    {
        public double interestRate { get; set; }
        public SavingAccount(string name, double balance ,double InterestRate): base(name,balance)
        {
           this.InterestRate = InterestRate;
        }

        public double InterestRate { get; set; }
        public void ApplyInterest()
        {
            balance += balance * InterestRate;
        }
    }
}
