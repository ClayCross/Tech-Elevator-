using System;
using System.Collections.Generic;
using System.Text;

namespace BankTellerExercise
{
    class BankCustomer
    {

        List<IAccountable> accountables = new List<IAccountable> { };
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsVip
        {
            get
            {
                int sum = 0;
                foreach (IAccountable account in accountables)
                {
                    sum += account.Balance;
                }
                return (sum >= 25000);
            }
        }

        public void AddAccount(IAccountable newAccount)
        {
            accountables.Add(newAccount);
        }

        public IAccountable[] GetAccounts()
        {
            return accountables.ToArray();
        }
    }
}
