using System;
using System.Data;
using System.Reflection;
using InventoryManagement.DataAccess;

namespace InventoryManagement.BusinessLogic
{
    public class PurchaseOrderLogic
    {
        PurchaseOrderAccess _purchaseOrderAccess = new PurchaseOrderAccess();
        DataTable _purchaseOrderDataTable = new DataTable();
        public DataTable GetPurchaseOrder()
        {
            foreach (object obj in _purchaseOrderAccess.GetPurchaseOrder())
            {
                Type objetType = obj.GetType();
                PropertyInfo[] obectProperty = objetType.GetProperties();
                if (_purchaseOrderDataTable.Columns.Count == 0)
                {
                    foreach (PropertyInfo property in obectProperty)
                    {
                        _purchaseOrderDataTable.Columns.Add(property.Name, property.PropertyType);
                    }
                }
                DataRow row = _purchaseOrderDataTable.NewRow();
                foreach (PropertyInfo property in obectProperty)
                {
                    object value = property.GetValue(obj, null);
                    row[property.Name] = value;
                }
                _purchaseOrderDataTable.Rows.Add(row);
            }
            return _purchaseOrderDataTable;
        }
    }
}
