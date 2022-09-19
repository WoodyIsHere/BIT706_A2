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
    public partial class FormHome : FormParent
    {
        CustomerController customerControl = new CustomerController();

        public FormHome()
        {
            InitializeComponent();
            CreateAccounts(); //For test data
        }

        //For test data
        private void CreateAccounts()
        {
            customerControl.CreateCustomer("Jackson", "Day", "0276859711", "7 Wildberry Street", false);
            customerControl.CreateCustomer("Ron", "Write", "02187654436", "11 Colenso Avenue", true);
        }

        private void ButtonManageCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            var newForm = new FormManageCustomers(customerControl);
            newForm.ShowDialog();
            newForm = null;
            this.Show();
        }
    }
}
