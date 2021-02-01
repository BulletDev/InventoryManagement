namespace InventoryManagement.Pages
{
    partial class PurchasingControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGeneratePurchaseOrder = new Telerik.WinControls.UI.RadButton();
            this.purchaseOrderGridView = new Telerik.WinControls.UI.RadGridView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeneratePurchaseOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radLabel1);
            this.panel2.Controls.Add(this.btnGeneratePurchaseOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(679, 35);
            this.panel2.TabIndex = 1;
            // 
            // btnGeneratePurchaseOrder
            // 
            this.btnGeneratePurchaseOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGeneratePurchaseOrder.Location = new System.Drawing.Point(574, 5);
            this.btnGeneratePurchaseOrder.Name = "btnGeneratePurchaseOrder";
            this.btnGeneratePurchaseOrder.Size = new System.Drawing.Size(100, 25);
            this.btnGeneratePurchaseOrder.TabIndex = 0;
            this.btnGeneratePurchaseOrder.Text = "Gererate P.O.";
            this.btnGeneratePurchaseOrder.ThemeName = "VisualStudio2012Dark";
            this.btnGeneratePurchaseOrder.Click += new System.EventHandler(this.btnGeneratePurchaseOrder_Click);
            // 
            // purchaseOrderGridView
            // 
            this.purchaseOrderGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseOrderGridView.Location = new System.Drawing.Point(0, 35);
            // 
            // 
            // 
            this.purchaseOrderGridView.MasterTemplate.AllowAddNewRow = false;
            this.purchaseOrderGridView.MasterTemplate.AllowColumnReorder = false;
            this.purchaseOrderGridView.MasterTemplate.ShowRowHeaderColumn = false;
            this.purchaseOrderGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.purchaseOrderGridView.Name = "purchaseOrderGridView";
            this.purchaseOrderGridView.Padding = new System.Windows.Forms.Padding(5);
            this.purchaseOrderGridView.ReadOnly = true;
            this.purchaseOrderGridView.Size = new System.Drawing.Size(679, 370);
            this.purchaseOrderGridView.TabIndex = 2;
            this.purchaseOrderGridView.ThemeName = "VisualStudio2012Dark";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(8, 9);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(98, 21);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Purchase Order";
            this.radLabel1.ThemeName = "VisualStudio2012Dark";
            // 
            // PurchasingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.purchaseOrderGridView);
            this.Controls.Add(this.panel2);
            this.Name = "PurchasingControl";
            this.Size = new System.Drawing.Size(679, 405);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnGeneratePurchaseOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseOrderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private System.Windows.Forms.Panel panel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnGeneratePurchaseOrder;
        private Telerik.WinControls.UI.RadGridView purchaseOrderGridView;
    }
}
