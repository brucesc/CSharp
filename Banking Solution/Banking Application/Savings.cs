using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Application
{
    public class Savings : Account //Savings now inherits all the properties and methods from Account that are public
    {
        public double InterestRate { get; set; }

        public void CalcAndDepositInterest(int months)
        {
            // Calculate Interest
            double interest = Balance * (InterestRate / 12) * months;
            Deposit(interest);
        }

        public override string ToPrint() //override - override the base behavior, only when its derived from another class that's marked virtual
        {
            // base. is a call to the parent class
            string message = base.ToPrint();
            return message + ", Interest Rate = " + InterestRate.ToString();
        }
    }
}
