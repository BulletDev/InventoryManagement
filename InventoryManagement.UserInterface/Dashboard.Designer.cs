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
            this.dashBoardPages.DefaultPage = this.dashboardPage;
            this.dashBoardPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashBoardPages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashBoardPages.Location = new System.Drawing.Point(0, 0);
            this.dashBoardPages.Name = "dashBoardPages";
            this.dashBoardPages.SelectedPage = this.dashboardPage;
            this.dashBoardPages.Size = new System.Drawing.Size(544, 305);
            this.dashBoardPages.TabIndex = 0;
            this.dashBoardPages.ThemeName = "VisualStudio2012Dark";
            this.dashBoardPages.ViewMode = Telerik.WinControls.UI.PageViewMode.NavigationView;
            this.dashBoardPages.SelectedPageChanged += new System.EventHandler(this.dashBoardPages_SelectedPageChanged);
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.dashBoardPages.GetChildAt(0))).DisplayMode = Telerik.WinControls.UI.NavigationViewDisplayModes.Expanded;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.dashBoardPages.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.Auto;
            ((Telerik.WinControls.UI.RadPageViewNavigationViewElement)(this.dashBoardPages.GetChildAt(0))).ShowItemCloseButton = false;
            // 
            // dashboardPage
            // 
            this.dashboardPage.Image = global::InventoryManagement.Properties.Resources._002_home;
            this.dashboardPage.ItemSize = new System.Drawing.SizeF(119F, 37F);
            this.dashboardPage.Location = new System.Drawing.Point(281, 25);
            this.dashboardPage.Name = "dashboardPage";
            this.dashboardPage.Size = new System.Drawing.Size(262, 279);
            this.dashboardPage.Text = "Dashboard";
            // 
            // customerPage
            // 
            this.customerPage.Image = global::InventoryManagement.Properties.Resources._036_customer;
            this.customerPage.ItemSize = new System.Drawing.SizeF(117F, 37F);
            this.customerPage.Location = new System.Drawing.Point(610, 25);
            this.customerPage.Name = "customerPage";
            this.customerPage.Size = new System.Drawing.Size(0, 279);
            this.customerPage.Text = "Customers";
            // 
            // productsPage
            // 
            this.productsPage.Image = global::InventoryManagement.Properties.Resources._025_basket;
            this.productsPage.ItemSize = new System.Drawing.SizeF(119F, 37F);
            this.productsPage.Location = new System.Drawing.Point(610, 25);
            this.productsPage.Name = "productsPage";
            this.productsPage.Size = new System.Drawing.Size(0, 279);
            this.productsPage.Text = "Products";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 305);
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
    }
}
