namespace InventoryManagement
{
    partial class CustomerControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.customerGridView = new Telerik.WinControls.UI.RadGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(520, 35);
            this.panel1.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.Location = new System.Drawing.Point(415, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 25);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Customer";
            this.btnAdd.ThemeName = "VisualStudio2012Dark";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // customerGridView
            // 
            this.customerGridView.AutoSizeRows = true;
            this.customerGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerGridView.Location = new System.Drawing.Point(0, 35);
            // 
            // 
            // 
            this.customerGridView.MasterTemplate.AllowAddNewRow = false;
            this.customerGridView.MasterTemplate.AllowColumnHeaderContextMenu = false;
            this.customerGridView.MasterTemplate.AllowColumnReorder = false;
            this.customerGridView.MasterTemplate.AllowDeleteRow = false;
            this.customerGridView.MasterTemplate.AllowDragToGroup = false;
            this.customerGridView.MasterTemplate.AllowEditRow = false;
            this.customerGridView.MasterTemplate.AllowRowHeaderContextMenu = false;
            this.customerGridView.MasterTemplate.AllowSearchRow = true;
            this.customerGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            this.customerGridView.MasterTemplate.Caption = "Customers";
            this.customerGridView.MasterTemplate.ClipboardCopyMode = Telerik.WinControls.UI.GridViewClipboardCopyMode.Disable;
            this.customerGridView.MasterTemplate.ClipboardCutMode = Telerik.WinControls.UI.GridViewClipboardCutMode.Disable;
            this.customerGridView.MasterTemplate.ClipboardPasteMode = Telerik.WinControls.UI.GridViewClipboardPasteMode.Disable;
            this.customerGridView.MasterTemplate.ShowRowHeaderColumn = false;
            this.customerGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.customerGridView.Name = "customerGridView";
            this.customerGridView.Padding = new System.Windows.Forms.Padding(5);
            this.customerGridView.Size = new System.Drawing.Size(520, 432);
            this.customerGridView.TabIndex = 5;
            this.customerGridView.ThemeName = "VisualStudio2012Dark";
            this.customerGridView.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.customerGridView_ContextMenuOpening);
            // 
            // CustomerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customerGridView);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerControl";
            this.Size = new System.Drawing.Size(520, 467);
            this.Load += new System.EventHandler(this.CustomerControl_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.Themes.VisualStudio2012DarkTheme visualStudio2012DarkTheme1;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadGridView customerGridView;
        private Telerik.WinControls.UI.RadButton btnAdd;
    }
}
