using System;
using System.Windows.Forms;
using InventoryManagement.Pages.Purchasing;
using InventoryManagement.BusinessLogic;

namespace InventoryManagement.Pages
{
    public partial class PurchasingControl : UserControl
    {
        PurchaseOrderLogic _purchaseOrderLogic = new PurchaseOrderLogic();
        public PurchasingControl()
        {
            InitializeComponent();
            LoadDataGrid();
        }
        private void btnGeneratePurchaseOrder_Click(object sender, EventArgs e)
        {
            PurchaseOrder po = new PurchaseOrder();
            po.ShowDialog();
        }
        public void LoadDataGrid()
        {
            purchaseOrderGridView.DataSource = _purchaseOrderLogic.GetPurchaseOrder();
            purchaseOrderGridView.Refresh();
        }
    }
}
