using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace InventoryManagement
{
    public partial class Dashboard : Telerik.WinControls.UI.RadForm
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void dashBoardPages_SelectedPageChanged(object sender, EventArgs e)
        {
            if (dashBoardPages.SelectedPage == customerPage)
            {
                CustomerControl cc = new CustomerControl();
                cc.Dock = DockStyle.Fill;
                customerPage.Controls.Add(cc);
            }
            else if (dashBoardPages.SelectedPage == productsPage)
            {
                ProductsControl pc = new ProductsControl();
                pc.Dock = DockStyle.Fill;
                productsPage.Controls.Add(pc);
            }
        }
    }
}
