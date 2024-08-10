using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAccount
{
    internal class TrustAccount:SavingAccount
    {

        public const double DepositBonusThreshold = 5000.00;
        public const double DepositBonusAmount = 50.00;
        private const int MaxWithdrawalsPerYear = 3;
        private const double WithdrawalLimitPercentage = 0.20;
        private int WithdrawalCount=0;

        public TrustAccount(string name, double balance, double interestRate)
            :base(name, balance, interestRate)
        {
           
        }
        public override bool Deposit(double amount)
        {
        bool result = base.Deposit(amount);
            if (amount >= DepositBonusThreshold)
            {
                balance += DepositBonusAmount;
            }
            return result;
        }
        public override bool Withdraw(double amount)
        {
            double maxWithdrawalAmount = balance * WithdrawalLimitPercentage;
                
                    if (WithdrawalCount >= MaxWithdrawalsPerYear)
                    {
                        Console.WriteLine($"The Maximum Withdrawal limit reached for the year in {name} account");
                        return false;
                    }
                    if (amount > maxWithdrawalAmount)
                    {
                        Console.WriteLine($"Withdrawal amount exceeds the 20% limit of {maxWithdrawalAmount:C} in {name} account");
                        return false;
                    }
            
            bool result = base.Withdraw(amount);
            if (result)
            {
                WithdrawalCount++;
            }

            return result;

        }
        public void ResetWithdrawals()
        {
            WithdrawalCount = 0;
        }
    }
}
