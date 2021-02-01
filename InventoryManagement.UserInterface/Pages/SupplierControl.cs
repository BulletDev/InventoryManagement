using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using InventoryManagement.BusinessLogic;
using InventoryManagement.Pages.Supplier;

namespace InventoryManagement.Pages
{
    public partial class SupplierControl : UserControl
    {
        private RadContextMenu _supplierContextMenu = new RadContextMenu();
        SupplierLogic _supplierLogic = new SupplierLogic();
        public SupplierControl()
        {
            InitializeComponent();
            LoadDataGrid();
        }
        private void SupplierControl_Load(object sender, EventArgs e)
        {
            RadMenuItem supplierContextItem1 = new RadMenuItem("Edit");
            supplierContextItem1.Click += new EventHandler(supplierContextItem1_Click);
            RadMenuItem supplierContextItem2 = new RadMenuItem("Delete");
            supplierContextItem2.Click += new EventHandler(supplierContextItem2_Click);
            _supplierContextMenu.Items.Add(supplierContextItem1);
            _supplierContextMenu.Items.Add(supplierContextItem2);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void supplierContextItem1_Click(object sender, EventArgs e)
        {
            Edit();
        }
        private void supplierContextItem2_Click(object sender, EventArgs e)
        {
            Delete();
        }
        public void LoadDataGrid()
        {
            supplierGridView.DataSource = _supplierLogic.GetSupplier();
            if (supplierGridView.Columns.Count > 0)
            {
                supplierGridView.Columns[0].IsVisible = false;
                supplierGridView.Columns[7].IsVisible = false;
                supplierGridView.Columns[8].IsVisible = false;
                supplierGridView.Columns[9].IsVisible = false;
                supplierGridView.Columns[10].IsVisible = false;
                supplierGridView.Columns[1].HeaderText = "Supplier ID";
                supplierGridView.Columns[2].HeaderText = "Company";
                supplierGridView.Columns[3].HeaderText = "Address";
                supplierGridView.Columns[4].HeaderText = "Contact Person";
                supplierGridView.Columns[5].HeaderText = "Contact Number";
                supplierGridView.Columns[6].HeaderText = "Email Address";
                supplierGridView.Refresh();
            }
        }
        public void Add()
        {
            SupplierAdd supplierAdd = new SupplierAdd();
            supplierAdd._refreshDataGridView += new SupplierAdd.DoEvent(LoadDataGrid);
            supplierAdd.ShowDialog();
        }
        public void Edit()
        {
            int supplierId = (int)supplierGridView.SelectedRows[0].Cells[0].Value;
            var supplerEdit = new SupplierEdit(supplierId);
            supplerEdit._refreshDataGridView += new SupplierEdit.DoEvent(LoadDataGrid);
            supplerEdit.ShowDialog();
        }
        public void Delete()
        {
            if (MessageBox.Show("Are you sure you want to delete this supplier?", "Delete Supplier", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int supplierId = (int)supplierGridView.SelectedRows[0].Cells[0].Value;
                _supplierLogic.DeleteSupplier(supplierId);
                supplierGridView.DataSource = "";
                LoadDataGrid();
            }
        }

        private void supplierGridView_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            e.ContextMenu = _supplierContextMenu.DropDown;
        }
    }
}
