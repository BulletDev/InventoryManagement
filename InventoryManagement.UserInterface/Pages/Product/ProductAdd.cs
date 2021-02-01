using System;
using InventoryManagement.BusinessLogic;
using InventoryManagement.Models;
using System.Windows.Forms;

namespace InventoryManagement.Pages.Product
{
    public partial class ProductAdd : Telerik.WinControls.UI.RadForm
    {
        public delegate void DoEvent();
        public event DoEvent _refreshDataGridView;
        ProductLogic _productLogic = new ProductLogic();
        public ProductAdd()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateProduct())
            {
                try
                {
                    ProductModel product = new ProductModel {
                        PartNumber = txtPartNumber.Text,
                        Name = txtName.Text,
                        Description = txtDescription.Text,
                        Price = Convert.ToDecimal(txtPrice.Text),
                        Class = Convert.ToChar(optionClass.SelectedItem.Text),
                        CreatedAt = DateTime.Now,
                        CreatedBy = Globals.GetCurrentUser()
                    };
                    _productLogic.InsertProduct(product);
                    DialogResult dr = MessageBox.Show("Product successfully added", "", MessageBoxButtons.OK);
                    if (dr == DialogResult.OK)
                    {
                        _refreshDataGridView();
                        Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private bool ValidateProduct()
        {
            if (txtName.Text == "")
            {
                txtName.Focus();
                return true;
            }
            return false;
        }
    }
}
