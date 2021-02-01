namespace InventoryManagement.Pages
{
    partial class SupplierControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.visualStudio2012DarkTheme1 = new Telerik.WinControls.Themes.VisualStudio2012DarkTheme();
            this.supplierGridView = new Telerik.WinControls.UI.RadGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridView.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(666, 35);
            this.panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.Location = new System.Drawing.Point(561, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 25);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Supplier";
            this.btnAdd.ThemeName = "VisualStudio2012Dark";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // supplierGridView
            // 
            this.supplierGridView.AutoSizeRows = true;
            this.supplierGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.supplierGridView.Location = new System.Drawing.Point(0, 35);
            // 
            // 
            // 
            this.supplierGridView.MasterTemplate.AllowAddNewRow = false;
            this.supplierGridView.MasterTemplate.AllowColumnReorder = false;
            this.supplierGridView.MasterTemplate.AllowDragToGroup = false;
            this.supplierGridView.MasterTemplate.AllowSearchRow = true;
            this.supplierGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.supplierGridView.MasterTemplate.ShowRowHeaderColumn = false;
            this.supplierGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.supplierGridView.Name = "supplierGridView";
            this.supplierGridView.Padding = new System.Windows.Forms.Padding(5);
            this.supplierGridView.ReadOnly = true;
            this.supplierGridView.Size = new System.Drawing.Size(666, 416);
            this.supplierGridView.TabIndex = 1;
            this.supplierGridView.ThemeName = "VisualStudio2012Dark";
            this.supplierGridView.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.supplierGridView_ContextMenuOpening);
            // 
            // SupplierControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.supplierGridView);
            this.Controls.Add(this.panel1);
            this.Name = "SupplierControl";
            this.Size = new System.Drawing.Size(666, 451);
            this.Load += new System.EventHandler(this.SupplierControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private Telerik.WinControls.UI.RadGridView supplierGridView;
    }
}
