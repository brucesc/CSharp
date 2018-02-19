using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Application
{
   public class Account : IAccountStatement
    {
        public virtual string ToPrint() // virtual we want special processing at runtime. Appears only in the base class
        {
            return "Acct Name = " + Owner.FullName + ", Id = " + Id.ToString() + ", Desc = " + Description + ", Balance = " + Balance.ToString(); //+ ", Owner = " Owner
           // return String.Format("Acct Id = {0}, Desc = {1}, Balance = {2}", Id, Description, Balance);

        }

        // The Properties
        public int Id { get; set; }
        public string Description { get; set; }
        public double Balance { get; set; }
        public Customer Owner { get; set; }

        // The Methods
        public void Deposit(double amount) // increases the balance
        {
            //if (amount <= 0)
            //{
            //    Console.WriteLine("Amount cannot be negative");
            //    return;
            //}
            if (!IsAmountNegative(amount))
            {
                Balance += amount;
            } // assignment statement (Balance = Balance + amount) do what it says on right side of equal, come up with one value and store in the variable on the left side of equal
        }
        public void Withdraw(double amount)
        {
            //if (amount <= 0)
            //{
            //    Console.WriteLine("Amount cannot be negative");
            //    return;
            //}

            // adding in the logic for insufficient funds

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient funds.");
                return; // ends the call
            }
            if (!IsAmountNegative(amount))
            {
                Balance -= amount;
            }

        }
        public double GetBalance() // get and set are the way to retrieve or change data
        {
            return Balance; 
        }

      private bool IsAmountNegative(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Amount cannot be negative");
                return true;
            }
            return false;
        }
    }
}
