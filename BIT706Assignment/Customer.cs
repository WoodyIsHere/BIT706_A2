using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BIT706Assignment
{
    public class Customer
    {
        static int nextCustomerID = 1;
        private int customerID;
        private string firstName;
        private string lastName;
        private string phNumber;
        private string address;
        private bool staff;
        private List<Account> userAccounts;

        public Customer()
        {
            customerID = nextCustomerID;
            nextCustomerID++;
            staff = false;
        }

        public Customer(string newFirstName, string newLastName, string newPhNumber, string newAddress, bool newStaff) : this()
        {
            FirstName = newFirstName;
            LastName = newLastName;
            PhNumber = newPhNumber;
            Address = newAddress;
            Staff = newStaff;
        }

        public override string ToString()
        {
            return Info();
        }

        public virtual string Info()
        {
            return CustomerID + ": " + FirstName + " " + LastName;
        }

        public int CustomerID
        {
            get { return customerID; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string PhNumber
        {
            get { return phNumber; }
            set
            {
                string sanitizePhone = Regex.Match(value, @"\d+").Value;
                phNumber = sanitizePhone;
            }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public bool Staff
        {
            get { return staff; }
            set
            {
                if (value == true || value == false) { staff = value; }
            }
        }

        public List<Account> Accounts
        {
            get { return userAccounts; }
            set { userAccounts = value; }
        }
    }
}
