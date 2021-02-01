using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using InventoryManagement.BusinessLogic;
using InventoryManagement.Models;

namespace InventoryManagement.Pages.Customer
{
    public partial class CustomerEdit : Telerik.WinControls.UI.RadForm
    {
        public delegate void DoEvent();
        public event DoEvent _refreshDataGridView;
        CustomerLogic _customerLogic = new CustomerLogic();
        public int Id{ get; set; }
        public CustomerEdit(int id)
        {
            Id = id;
            InitializeComponent();
        }

        private void CustomerEdit_Load(object sender, EventArgs e)
        {
            var customer = _customerLogic.GetCustomerById(Id);
            txtCustomerId.Text = customer.CustomerId;
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtAddress.Text = customer.Address;
            txtContactNumber.Text = customer.ContactNumber;
            txtEmailAddress.Text = customer.EmailAddress;
        }

        private void btnSaveCustomer_Click(object sender, EventArgs e)
        {
            if (!validateCustomer())
            {
                var customer = new CustomerModel()
                {
                    Id = this.Id,
                    CustomerId = txtCustomerId.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Address = txtAddress.Text,
                    ContactNumber = txtContactNumber.Text,
                    EmailAddress = txtEmailAddress.Text,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = Globals.GetCurrentUser()
                };
                _customerLogic.UpdateCustomer(customer);
                DialogResult dr = MessageBox.Show("Customer information successfully updated", "", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    this._refreshDataGridView();
                    this.Close();
                }
            }
        }

        private bool validateCustomer()
        {
            if (txtFirstName.Text == "")
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
