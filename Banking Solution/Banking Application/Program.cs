using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_Application
{
    class Program
    {
        static void Main(string[] args)
        {
           // Account acct1 = new Account(); // we could have a custom constructor in the class to help us fill out the properties in the new account
           // acct1.Id = 1;
           // acct1.Description = "My fist Account";
           // acct1.Balance = 0.0;
           // acct1.Owner = new Customer(100, "Steven Bruce");
            

           // acct1.Deposit(5.00);
           // //Console.WriteLine("The Balance is: {0}", acct1.GetBalance());
           // Console.WriteLine(acct1.ToPrint());
           //// Console.ReadLine();

           // acct1.Deposit(-5.00);
           // Console.WriteLine("The Balance is: {0}", acct1.GetBalance());
           //// Console.ReadLine();

           // acct1.Withdraw(5000.00);
           // Console.WriteLine("The Balance is: {0}", acct1.GetBalance());
           //// Console.ReadLine();

           // acct1.Withdraw(-5000.00);
           // Console.WriteLine("The Balance is: {0}", acct1.GetBalance());
           //// Console.ReadLine();

           // Savings sav2 = new Savings();
           // sav2.Id = 2;
           // sav2.Description = "My first Savings Account";
           // sav2.Balance = 0;
           // sav2.Owner = new Customer(101, "Lisa S.");
           // sav2.InterestRate = 0.12;

           // sav2.Deposit(1000.00);
           // Console.WriteLine(sav2.ToPrint());
           // //Console.ReadLine();

           // Checking che3 = new Checking();
           // che3.Id = 3;
           // che3.Description = "My first Checking Account";
           // che3.Balance = 0.0;
           // che3.Owner = new Customer(102, "Bill T");
           // che3.Deposit(300);

           //Console.WriteLine(che3.ToPrint());

            Checking che4 = new Checking();
            che4.Id = 3;
            che4.Description = "My first Checking Account";
            che4.Balance = 0.0;
            che4.Owner = new Customer(103, "Kim P.");
            che4.Deposit(300);

            Checking che5 = new Checking();
            che5.Id = 3;
            che5.Description = "My second Checking Account";
            che5.Balance = 0.0;
            che5.Owner = new Customer(103, "Kim P.");
            che5.Deposit(300);

            Savings sav5 = new Savings();
            sav5.Id = 3;
            sav5.Description = "My first Savings Account";
            sav5.Balance = 0;
            sav5.Owner = new Customer(103, "Kim P.");
            sav5.InterestRate = 0.12;

            sav5.Deposit(1000.00);

            Investment inv1 = new Investment();
            inv1.Deposit(500.00);
            Console.WriteLine(inv1.ToPrint());


            Account[] accounts = { che4, che5, sav5 }; // we found the common account that would accept savings and checking

            double grandTotal = 0;
            foreach (Account acct in accounts) // foreach item in the collection (accounts) do whats {in here} then stuff it into the variable acct of type Account
            {
                double acctBalance = acct.GetBalance();
                grandTotal += acctBalance;
                Console.WriteLine(acct.ToPrint());
            }
            Console.WriteLine("Grand total is " + grandTotal.ToString());

            






            Console.ReadLine();


        }

    }
}
