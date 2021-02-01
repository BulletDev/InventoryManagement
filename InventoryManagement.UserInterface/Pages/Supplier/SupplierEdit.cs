using InventoryManagement.BusinessLogic;
using InventoryManagement.Models;
using System;
using System.Windows.Forms;

namespace InventoryManagement.Pages.Supplier
{
    public partial class SupplierEdit : Telerik.WinControls.UI.RadForm
    {
        public delegate void DoEvent();
        public event DoEvent _refreshDataGridView;
        SupplierLogic _supplierLogic = new SupplierLogic();
        public int Id { get; set; }
        public SupplierEdit(int id)
        {
            Id = id;
            InitializeComponent();
        }

        private void SupplierEdit_Load(object sender, EventArgs e)
        {
            var supplier = _supplierLogic.GetSupplierById(Id);
            txtSupplierId.Text = supplier.SupplierId;
            txtCompany.Text = supplier.Company;
            txtAddress.Text = supplier.Address;
            txtContactPerson.Text = supplier.ContactPerson;
            txtContactNumber.Text = supplier.ContactNumber;
            txtEmailAddress.Text = supplier.EmailAddress;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateSupplier())
            {
                var supplier = new SupplierModel()
                {
                    Id = Id,
                    SupplierId = txtSupplierId.Text,
                    Company = txtCompany.Text,
                    Address = txtAddress.Text,
                    ContactPerson = txtContactPerson.Text,
                    ContactNumber = txtContactNumber.Text,
                    EmailAddress = txtEmailAddress.Text,
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = Globals.GetCurrentUser()
                };
                _supplierLogic.UpdateSupplier(supplier);
                DialogResult dr = MessageBox.Show("Supplier information successfully updated", "", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    _refreshDataGridView();
                    Close();
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
