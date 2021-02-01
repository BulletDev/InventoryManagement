using InventoryManagement.Pages;
using System;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace InventoryManagement
{
    public partial class Dashboard : Telerik.WinControls.UI.RadForm
    {
        public Dashboard()
        {
            InitializeComponent();
            DashboardControl dashboardControl = new DashboardControl();
            dashboardControl.Dock = DockStyle.Fill;
            dashboardPage.Controls.Add(dashboardControl);
        }

        private void dashBoardPages_SelectedPageChanged(object sender, EventArgs e)
        {
            if (dashBoardPages.SelectedPage == dashboardPage)
            {
                DashboardControl dashboardControl = new DashboardControl();
                dashboardControl.Dock = DockStyle.Fill;
                dashboardPage.Controls.Add(dashboardControl);
            }
            else if (dashBoardPages.SelectedPage == customerPage)
            {
                CustomerControl customerControl = new CustomerControl();
                customerControl.Dock = DockStyle.Fill;
                customerPage.Controls.Add(customerControl);
            }
            else if (dashBoardPages.SelectedPage == productsPage)
            {
                ProductControl productControl = new ProductControl();
                productControl.Dock = DockStyle.Fill;
                productsPage.Controls.Add(productControl);
            }
            else if (dashBoardPages.SelectedPage == supplierPage)
            {
                SupplierControl supplierControl = new SupplierControl();
                supplierControl.Dock = DockStyle.Fill;
                supplierPage.Controls.Add(supplierControl);
            }
            else if (dashBoardPages.SelectedPage == purchasingPage)
            {
                PurchasingControl purchasingControl = new PurchasingControl();
                purchasingControl.Dock = DockStyle.Fill;
                purchasingPage.Controls.Add(purchasingControl);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            var navigationElement = dashBoardPages.ViewElement as RadPageViewNavigationViewElement;
            if (navigationElement.IsCollapsed)
            {
                //navigationElement.DisplayMode = NavigationViewDisplayModes.Expanded;
                //navigationElement.ExpandedPaneWidth = 200;
                navigationElement.Expand();
            }
        }
    }
}
