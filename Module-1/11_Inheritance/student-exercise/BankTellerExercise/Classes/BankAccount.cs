using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTellerExercise.Classes
{
    public class BankAccount
    {
        public string accountHolderName  { get; private set; }

        public string accountNumber {get; set;}

        public decimal Balance { get; private set; }

        public BankAccount(string accountHolderName, string accountNumber)
        {
            this.accountHolderName = accountHolderName;
            this.accountNumber = accountNumber;
            this.Balance = 0M;
        }

        public BankAccount(string accountHolderName, string accountNumber, decimal balance)
        {
            this.accountHolderName = accountHolderName;
            this.accountNumber = accountNumber;
            this.Balance = balance;
        }
        public decimal Deposit(decimal amountToDeposit)
        {
            Balance = Balance + amountToDeposit;
            return Balance;
        }
        public virtual decimal Withdraw(decimal amountToWithdraw)
        {
            Balance = Balance - amountToWithdraw;
            return Balance;
        }

    }
}
