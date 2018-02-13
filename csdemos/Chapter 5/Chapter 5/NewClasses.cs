using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5
{
    class Intern : Employee
    {
        public int MentorID { get; set; } // mentor is an EmployeeID
        public string School { get; set; }

    }
    class Customer : Person
    {
        public int CustomerID { get; set; }

        //TODO should this be a GUID?
        public int SalesRep { get; set; } // made this an int because its an FK to another table later on
        public decimal CreditLimit { get; set; }

        //TODO finish this!
        // GetOrders()

        public decimal GetRemainingCredit()
        {
            //TODO complete this!
            return 0m;
        }


    }
    class Employee : Person // : Person is how we inherited the properties from Person to Employee
    {
        public int EmployeeID { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }
        public decimal HourlyRate { get; set; }
        public bool Manager { get; set; }
        public DateTime BirthDate { get; set; }

        public string GetBirtday()
        {
            // code goes here
            return "January 15th";

        }
    }

    class Person
    {
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        // public string Status { get; set; }

        private string myStatus;

        public string Status
        {
            get { return myStatus; }
            set {
                if (value.Length > 2)
                {
                    throw new Exception("Bad User!");

                }
                myStatus = value; }
        }
        public string Phone { get; set; }
        public string Cell { get; set; }

        public string GetFullName()
        {
            return LastName + ", " + FirstName;
           // return string.Format("{0}, {1}", LastName, FirstName);
        }

    }
}
