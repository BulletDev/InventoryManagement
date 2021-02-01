namespace InventoryManagement
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.dashBoardPages = new Telerik.WinControls.UI.RadPageView();
            this.dashboardPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.customerPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.productsPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.supplierPage = new Telerik.WinControls.UI.RadPageViewPage();
            this.purchasingPage = new Telerik.WinControls.UI.RadPageViewPage();
            ((System.ComponentModel.ISupportInitialize)(this.dashBoardPages)).BeginInit();
            this.dashBoardPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dashBoardPages
            // 
            this.dashBoardPages.Controls.Add(this.dashboardPage);
            this.dashBoardPages.Controls.Add(this.customerPage);
            this.dashBoardPages.Controls.Add(this.productsPage);
            this.dashBoardPages.Controls.Add(this.supplierPage);
            this.dashBoardPages.Controls.Add(this.purchasingPage);
            this.dashBoardPages.DefaultPage = this.dashboardPage;
            this.dashBoardPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashBoardPages.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBoardPages.Location = new System.Drawing.Point(0, 0);
            this.dashBoardPages.Name = "dashBoardPages";
            this.dashBoardPages.SelectedPage = this.dashboardPage;
            this.dashBoardPages.Size = new System.Drawing.Size(952, 439);
            this.dashBoardPages.TabIndex = 0;
            this.dashBoardPages.ThemeName = "VisualStudio2012Dark";
            this.dashBoardPages.ViewMode = Telerik.WinControls.UI.PageViewMode.NavigationView;
            this.dashBoardPages.SelectedPageChanged += new System.EventHandler(this.dashBoardPages_SelectedPageChanged);
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.dashBoardPages.GetChildAt(0))).DisplayMode = Telerik.WinControls.UI.NavigationViewDisplayModes.Expanded;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.dashBoardPages.GetChildAt(0))).ExpandedPaneWidth = 200;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.dashBoardPages.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.Auto;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.dashBoardPages.GetChildAt(0))).ItemAlignment = Telerik.WinControls.UI.StripViewItemAlignment.Near;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.dashBoardPages.GetChildAt(0))).ShowItemCloseButton = false;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.dashBoardPages.GetChildAt(0))).ItemSpacing = 0;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.dashBoardPages.GetChildAt(0))).ItemSizeMode = Telerik.WinControls.UI.PageViewItemSizeMode.EqualHeight;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.dashBoardPages.GetChildAt(0))).ItemContentOrientation = Telerik.WinControls.UI.PageViewContentOrientation.Horizontal;
            // 
            // dashboardPage
            // 
            this.dashboardPage.Image = global::InventoryManagement.Properties.Resources._002_home;
            this.dashboardPage.ItemSize = new System.Drawing.SizeF(34F, 34F);
            this.dashboardPage.Location = new System.Drawing.Point(41, 25);
            this.dashboardPage.Name = "dashboardPage";
            this.dashboardPage.Size = new System.Drawing.Size(910, 413);
            this.dashboardPage.Text = "Dashboard";
            // 
            // customerPage
            // 
            this.customerPage.Image = global::InventoryManagement.Properties.Resources._036_customer;
            this.customerPage.ItemSize = new System.Drawing.SizeF(34F, 34F);
            this.customerPage.Location = new System.Drawing.Point(41, 25);
            this.customerPage.Name = "customerPage";
            this.customerPage.Size = new System.Drawing.Size(910, 413);
            this.customerPage.Text = "Customers";
            // 
            // productsPage
            // 
            this.productsPage.Image = global::InventoryManagement.Properties.Resources._025_basket;
            this.productsPage.ItemSize = new System.Drawing.SizeF(34F, 34F);
            this.productsPage.Location = new System.Drawing.Point(281, 25);
            this.productsPage.Name = "productsPage";
            this.productsPage.Size = new System.Drawing.Size(670, 413);
            this.productsPage.Text = "Products";
            // 
            // supplierPage
            // 
            this.supplierPage.Image = global::InventoryManagement.Properties.Resources._003_delivery;
            this.supplierPage.ItemSize = new System.Drawing.SizeF(34F, 34F);
            this.supplierPage.Location = new System.Drawing.Point(281, 25);
            this.supplierPage.Name = "supplierPage";
            this.supplierPage.Size = new System.Drawing.Size(670, 413);
            this.supplierPage.Text = "Suppliers";
            // 
            // purchasingPage
            // 
            this.purchasingPage.Image = global::InventoryManagement.Properties.Resources._004_shopping_cart;
            this.purchasingPage.ItemSize = new System.Drawing.SizeF(34F, 34F);
            this.purchasingPage.Location = new System.Drawing.Point(0, 0);
            this.purchasingPage.Name = "purchasingPage";
            this.purchasingPage.Size = new System.Drawing.Size(200, 100);
            this.purchasingPage.Text = "Purchasing";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 439);
            this.Controls.Add(this.dashBoardPages);
            this.Name = "Dashboard";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.Text = "Inventory Management";
            this.ThemeName = "VisualStudio2012Dark";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dashBoardPages)).EndInit();
            this.dashBoardPages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadPageView dashBoardPages;
        private Telerik.WinControls.UI.RadPageViewPage customerPage;
        private Telerik.WinControls.UI.RadPageViewPage productsPage;
        private Telerik.WinControls.UI.RadPageViewPage dashboardPage;
        private Telerik.WinControls.UI.RadPageViewPage supplierPage;
        private Telerik.WinControls.UI.RadPageViewPage purchasingPage;
    }
}
