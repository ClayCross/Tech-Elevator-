using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountHolderName, string accountNumber, decimal balance)
            : base(accountHolderName, accountNumber, balance)
        {
        }

        public SavingsAccount(string accountHolderName, string accountNumber)
            : base(accountHolderName, accountNumber)
        { 
        }

        public override decimal Withdraw(decimal amountToWithdraw)
        {
            decimal serviceCharge = (Balance - amountToWithdraw) <= 150 ? 2.00M : 0;

            if (Balance >= (amountToWithdraw + serviceCharge))
            {
                return base.Withdraw(amountToWithdraw + serviceCharge);
                
            }
            else
            {
                return Balance;
            }

        }
    }
}
