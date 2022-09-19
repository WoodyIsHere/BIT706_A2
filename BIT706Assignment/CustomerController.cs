using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT706Assignment
{
    public class CustomerController
    {
        public List<Customer> AllCustomers = new List<Customer>();

        public void CreateCustomer(string fName, string lName, string phNumber, string address, bool staff)
        {
            AllCustomers.Add(new Customer(fName, lName, phNumber, address, staff));
        }

        public void EditCustomer(Customer selectedCustomer, string fName, string lName, string phNo, string address, bool employee)
        {
            selectedCustomer.FirstName = fName;
            selectedCustomer.LastName = lName;
            selectedCustomer.PhNumber = phNo;
            selectedCustomer.Address = address;
            selectedCustomer.Staff = employee;
        }

        public void DeleteCustomer(Customer selectedCustomer)
        {
            AllCustomers.Remove(selectedCustomer);
        }

        //public Customer FindCustomerByID(int ID)
        //{
            //foreach(Customer c in AllCustomers)
            //{
                //if (c.CustomerID == ID)
                //{
                    //return c;
                //}
            //}
            //return null;
        //}
    }
}
