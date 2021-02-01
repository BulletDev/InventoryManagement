using InventoryManagement.BusinessLogic;
using InventoryManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace InventoryManagement.Pages.Supplier
{
    public partial class SupplierAdd : Telerik.WinControls.UI.RadForm
    {
        public delegate void DoEvent();
        public event DoEvent _refreshDataGridView;
        SupplierLogic _supplierLogic = new SupplierLogic();

        public SupplierAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateSupplier())
            {
                try
                {
                    SupplierModel supplier = new SupplierModel
                    {
                        SupplierId = txtSupplierId.Text,
                        Company = txtCompany.Text,
                        Address = txtAddress.Text,
                        ContactPerson = txtContactPerson.Text,
                        ContactNumber = txtContactNumber.Text,
                        EmailAddress = txtEmailAddress.Text,
                        CreatedAt = DateTime.Now,
                        CreatedBy = Globals.GetCurrentUser()
                    };
                    _supplierLogic.InserSupplier(supplier);
                    DialogResult dr = MessageBox.Show("Supplier successfully added", "", MessageBoxButtons.OK);
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
        }
        private bool ValidateSupplier()
        {
            if (txtSupplierId.Text == "")
            {
                txtSupplierId.Focus();
                return true;
            }
            else if (txtCompany.Text == "")
            {
                txtCompany.Focus();
                return true;
            }
            else if (txtAddress.Text == "")
            {
                txtAddress.Focus();
                return true;
            }
            return false;
        }
    }
}
