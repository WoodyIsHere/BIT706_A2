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
    public partial class FormManageCustomers : FormParent
    {

        public FormManageCustomers(CustomerController customerControl)
        {
            this.customerControl = customerControl;
            InitializeComponent();
            DisplayAccounts();
        }

        private CustomerController customerControl;

        private void DisplayAccounts()
        {
            listBoxCustomers.Items.Clear();

            foreach (Customer customer in customerControl.AllCustomers)
            {
                listBoxCustomers.Items.Add(customer);
            }
            if (listBoxCustomers.Items.Count >= 1)
            {
                listBoxCustomers.SelectedIndex = 0;
            }
        }

        private void ButtonAddCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new FormAddCustomer(customerControl);
            newForm.ShowDialog();
            newForm = null;
            this.Show();
            DisplayAccounts();
        }

        private void ButtonEditCustomerForm_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = (Customer)listBoxCustomers.SelectedItem;
            this.Hide();
            var newForm = new FormEditCustomer(customerControl);
            newForm.SetSelectedCustomer(selectedCustomer);
            newForm.FillFields(selectedCustomer.FirstName, selectedCustomer.LastName, selectedCustomer.PhNumber, selectedCustomer.Address, selectedCustomer.Staff);
            newForm.ShowDialog();
            newForm = null;
            this.Show();
            DisplayAccounts();
        }

        private void ButtonDeleteCustomer_Click(object sender, EventArgs e)
        {
            Customer selectedCustomer = (Customer)listBoxCustomers.SelectedItem;
            if (selectedCustomer != null)
            {
                switch (MessageBox.Show("Are you sure you want to delete " + selectedCustomer + "?", "Delete Customer", MessageBoxButtons.YesNo))
                {
                    case DialogResult.Yes:
                        MessageBox.Show("Customer deleted."); customerControl.DeleteCustomer(selectedCustomer); break;
                    case DialogResult.No: break;
                }
                DisplayAccounts();
            }
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
