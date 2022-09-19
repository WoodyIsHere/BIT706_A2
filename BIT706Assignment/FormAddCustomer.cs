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
    public partial class FormAddCustomer : FormParent
    {
        

        public FormAddCustomer(CustomerController customerControl)
        {
            this.customerControl = customerControl;
            InitializeComponent();
        }

        private CustomerController customerControl;

        private void ButtonCancelAddCustomer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAddCustomer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxFirstName.Text) || String.IsNullOrEmpty(textBoxLastName.Text)) {
                MessageBox.Show("Please enter first and last name.");
            }
            else
            {
                customerControl.CreateCustomer(textBoxFirstName.Text, textBoxLastName.Text, textBoxPhone.Text, textBoxAddress.Text, checkBoxEmployee.Checked);
                MessageBox.Show("Customer added.");
                this.Close();
            }
        }

        private void ButtonReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void labelPhone_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLastName_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
