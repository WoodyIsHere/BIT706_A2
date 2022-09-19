using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT706Assignment
{
    public partial class FormEditCustomer : FormParent
    {
        public FormEditCustomer(CustomerController customerControl)
        {
            this.customerControl = customerControl;
            InitializeComponent();
        }

        private CustomerController customerControl;
        static Customer selectedCustomer;

        public void SetSelectedCustomer(Customer selectedCustomerValue)
        {
            selectedCustomer = selectedCustomerValue;
        }

        public void FillFields(string fName, string lName, string phNo, string address, bool employee)
        {
            textBoxFirstName.Text = fName;
            textBoxLastName.Text = lName;
            textBoxPhone.Text = phNo;
            textBoxAddress.Text = address;
            checkBoxEmployee.Checked = employee;
        }

        private void ButtonCancelAddCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonEditCustomer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxFirstName.Text) || String.IsNullOrEmpty(textBoxLastName.Text))
            {
                MessageBox.Show("Please enter first and last name.");
            }
            else
            {
                customerControl.EditCustomer(selectedCustomer, textBoxFirstName.Text, textBoxLastName.Text, textBoxPhone.Text, textBoxAddress.Text, checkBoxEmployee.Checked);
                MessageBox.Show("Customer updated.");
                this.Close();
            }
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Customer selectedCustomer = customerControl.FindCustomerByID(selectedCustomerID);
    }
}
