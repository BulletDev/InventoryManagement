using System;
using System.Windows.Forms;
using InventoryManagement.BusinessLogic;
using InventoryManagement.Pages.Customer;
using Telerik.WinControls.UI;

namespace InventoryManagement
{
    public partial class CustomerControl : UserControl
    {
        private RadContextMenu _customerContextMenu = new RadContextMenu();
        CustomerLogic _customerLogic = new CustomerLogic();
        public CustomerControl()
        {
            InitializeComponent();
            LoadDataGrid();
        }
        private void CustomerControl_Load(object sender, EventArgs e)
        {
            RadMenuItem customerContextItem2 = new RadMenuItem("Edit");
            customerContextItem2.Click += new EventHandler(customerContextItem2_Click);
            RadMenuItem customerContextItem3 = new RadMenuItem("Delete");
            customerContextItem3.Click += new EventHandler(customerContextItem3_Click);
            _customerContextMenu.Items.Add(customerContextItem2);
            _customerContextMenu.Items.Add(customerContextItem3);
        }
        private void customerContextItem2_Click(object sender, EventArgs e)
        {
            Edit();
        }
        private void customerContextItem3_Click(object sender, EventArgs e)
        {
            Delete();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }
        public void LoadDataGrid()
        {
            customerGridView.DataSource = _customerLogic.GetCustomer();
            if (customerGridView.Columns.Count > 0)
            {
                customerGridView.Columns[0].IsVisible = false;
                customerGridView.Columns[7].IsVisible = false;
                customerGridView.Columns[8].IsVisible = false;
                customerGridView.Columns[9].IsVisible = false;
                customerGridView.Columns[10].IsVisible = false;
                customerGridView.Columns[1].HeaderText = "Customer ID";
                customerGridView.Columns[2].HeaderText = "First Name";
                customerGridView.Columns[3].HeaderText = "Last Name";
                customerGridView.Columns[4].HeaderText = "Address";
                customerGridView.Columns[5].HeaderText = "Contact Number";
                customerGridView.Columns[6].HeaderText = "Email Address";
                customerGridView.Refresh(); 
            }
        }
        public void Add()
        {
            CustomerAdd customerAdd = new CustomerAdd();
            customerAdd._refreshDataGridView += new CustomerAdd.DoEvent(LoadDataGrid);
            customerAdd.ShowDialog();
        }
        public void Edit()
        {
            int customerId = (int)customerGridView.SelectedRows[0].Cells[0].Value;
            var customerEdit = new CustomerEdit(customerId);
            customerEdit._refreshDataGridView += new CustomerEdit.DoEvent(LoadDataGrid);
            customerEdit.Show();
        }
        public void Delete()
        {
            if (MessageBox.Show("Are you sure you want to delete this customer?", "Delete Customer", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int customerId = (int)customerGridView.SelectedRows[0].Cells[0].Value;
                _customerLogic.DeleteCustomer(customerId);
                customerGridView.DataSource = "";
                LoadDataGrid();
            }
        }
        private void customerGridView_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            e.ContextMenu = _customerContextMenu.DropDown;
        }
    }
}
