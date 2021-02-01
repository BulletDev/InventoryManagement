using System;
using System.Windows.Forms;
using InventoryManagement.BusinessLogic;
using InventoryManagement.Pages.Product;
using Telerik.WinControls.UI;

namespace InventoryManagement
{
    public partial class ProductControl : UserControl
    {
        private RadContextMenu _productContextMenu = new RadContextMenu();
        ProductLogic _productLogic = new ProductLogic();
        public ProductControl()
        {
            InitializeComponent();
            LoadDataGrid();
        }
        private void ProductControl_Load(object sender, EventArgs e)
        {
            RadMenuItem productContextItem2 = new RadMenuItem("Edit");
            productContextItem2.Click += new EventHandler(productContextItem2_Click);
            RadMenuItem productContextItem3 = new RadMenuItem("Delete");
            productContextItem3.Click += new EventHandler(productContextItem3_Click);
            _productContextMenu.Items.Add(productContextItem2);
            _productContextMenu.Items.Add(productContextItem3);
        }
        private void productContextItem2_Click(object sender, EventArgs e)
        {
            Edit();
        }
        private void productContextItem3_Click(object sender, EventArgs e)
        {
            Delete();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }
        public void LoadDataGrid()
        {
            productGridView.DataSource = _productLogic.GetProduct();
            if (productGridView.Columns.Count > 0)
            {
                productGridView.Columns[0].IsVisible = false;
                productGridView.Columns[6].IsVisible = false;
                productGridView.Columns[7].IsVisible = false;
                productGridView.Columns[8].IsVisible = false;
                productGridView.Columns[9].IsVisible = false;
                productGridView.Columns[1].HeaderText = "Part Number";
                productGridView.Columns[2].HeaderText = "Name";
                productGridView.Columns[3].HeaderText = "Description";
                productGridView.Columns[4].HeaderText = "Price";
                productGridView.Columns[5].HeaderText = "Class";
                productGridView.Refresh();
            }
        }
        public void Add()
        {
            ProductAdd productAdd = new ProductAdd();
            productAdd._refreshDataGridView += new ProductAdd.DoEvent(LoadDataGrid);
            productAdd.ShowDialog();
        }
        public void Edit()
        {
            int productId = (int)productGridView.SelectedRows[0].Cells[0].Value;
            var productEdit = new ProductEdit(productId);
            productEdit._refreshDataGridView += new ProductEdit.DoEvent(LoadDataGrid);
            productEdit.ShowDialog();
        }
        public void Delete()
        {
            if (MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int productId = (int)productGridView.SelectedRows[0].Cells[0].Value;
                _productLogic.DeleteProduct(productId);
                productGridView.DataSource = "";
                LoadDataGrid();
            }
        }
        private void productGridView_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            e.ContextMenu = _productContextMenu.DropDown;
        }
    }
}
