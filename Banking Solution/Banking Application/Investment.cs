using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Application
{
   public class Investment : IAccountStatement //Composition (the 4th pillar)
    {
        public Account account { get; set; }

        public Investment()
        {
            account = new Account();
            account.Id = 1000;
            account.Description = "My First Investment Account";
            account.Balance = 0.0;
            account.Owner = new Customer(111, "Dave D.");

        }

        public string ToPrint()
        {
            string message = account.ToPrint();
            return message + ", Investment account";
        }

        public void Deposit(double amount)
        {
            account.Deposit(amount);
        }

        public void Sell(double amount)
        {
            account.Withdraw(amount);
        }

        public double GetBalance()
        {
            return account.GetBalance();
        }
    }
}
