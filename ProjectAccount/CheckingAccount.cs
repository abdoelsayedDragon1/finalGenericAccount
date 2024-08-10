using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccount
{
    internal class CheckingAccount:Account
    {
        private const double WithdrawalFee = 1.50;
        public CheckingAccount(string name, double balance): base(name, balance) 
        {
        }
        public override bool Withdraw(double amount)
        {
            amount += WithdrawalFee;
            return base.Withdraw(amount);
        }
    }
}
