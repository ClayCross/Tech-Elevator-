using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class CreditCardAccount : IAccountable
    {
        public int Balance { get; set; }
        public int Debt { get { return -1 * Balance; } }
        public string AccountHolderName { get; }
        public string AccountNumber { get; }

        public CreditCardAccount(string accountHolderName, string accountNumber)
        {
            this.AccountHolderName = accountHolderName;
            this.AccountNumber = accountNumber;
        }

        public int Pay(int amountToPay)
        {
            Balance += amountToPay;
            return Debt;
        }

        public int Charge(int amountToCharge)
        {
            Balance -= amountToCharge;
            return Balance;
        }
    }
}
