using System;
using System.Windows.Forms;
using InventoryManagement.BusinessLogic;
using InventoryManagement.Models;

namespace InventoryManagement.Pages.Customer
{
    public partial class CustomerAdd : Telerik.WinControls.UI.RadForm
    {
        public delegate void DoEvent();
        public event DoEvent _refreshDataGridView;
        CustomerLogic _customer = new CustomerLogic();
        public CustomerAdd()
        {
            InitializeComponent();
            txtCustomerId.Text = _customer.GenerateCustomerId();
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            if (!validateCustomer())
            {
                try
                {
                    CustomerModel customer = new CustomerModel {
                        CustomerId = txtCustomerId.Text,
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Address = txtAddress.Text,
                        ContactNumber = txtContactNumber.Text,
                        EmailAddress = txtEmailAddress.Text,
                        CreatedAt = DateTime.Now,
                        CreatedBy = Globals.GetCurrentUser()
                    };
                    _customer.InsertCustomer(customer);
                    DialogResult dr = MessageBox.Show("Customer successfully added", "", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {
                        this._refreshDataGridView();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please complete the fields. If not available, please input none");
            }
        }

        private bool validateCustomer()
        {
            if(txtFirstName.Text == "")
            {
                txtFirstName.Focus();
                return true;
            }
            else if (txtLastName.Text == "")
            {
                txtLastName.Focus();
                return true;
            }
            return false;
        }
    }
}
