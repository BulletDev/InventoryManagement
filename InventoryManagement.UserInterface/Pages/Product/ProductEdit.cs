using InventoryManagement.BusinessLogic;
using InventoryManagement.Models;
using System;
using System.Windows.Forms;

namespace InventoryManagement.Pages.Product
{
    public partial class ProductEdit : Telerik.WinControls.UI.RadForm
    {
        public delegate void DoEvent();
        public event DoEvent _refreshDataGridView;
        ProductLogic _productLogic = new ProductLogic();
        public int Id { get; set; }
        public ProductEdit(int id)
        {
            Id = id;
            InitializeComponent();
        }

        private void ProductEdit_Load(object sender, EventArgs e)
        {
            var product = _productLogic.GetProductById(Id);
            txtPartNumber.Text = product.PartNumber;
            txtName.Text = product.Name;
            txtDescription.Text = product.Description;
            txtPrice.Text = Convert.ToString(product.Price);
            optionClass.SelectedItem.Text = Convert.ToString(product.Class);
        }

        private bool ValidateProduct()
        {
            if (txtPartNumber.Text == "")
            {
                txtPartNumber.Focus();
                return true;
            }
            else if (txtName.Text == "")
            {
                txtName.Focus();
                return true;
            }
            else if (txtPrice.Text == "")
            {
                txtPrice.Focus();
                return true;
            }
            else if (optionClass.SelectedItem.Text == "")
            {
                optionClass.Focus();
                return true;
            }
            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateProduct())
            {
                var product = new ProductModel()
                {
                    Id = this.Id,
                    PartNumber = txtPartNumber.Text,
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    Price = Convert.ToDecimal(txtPrice.Text),
                    Class = Convert.ToChar(optionClass.SelectedItem.Text),
                    UpdatedAt = DateTime.Now,
                    UpdatedBy = Globals.GetCurrentUser()
                };
                _productLogic.UpdateProduct(product);
                DialogResult dr = MessageBox.Show("Product information successfully updated", "", MessageBoxButtons.OK);
                if (dr == DialogResult.OK)
                {
                    _refreshDataGridView();
                    Close();
                }
            }
        }
    }
}
