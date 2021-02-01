using System;
using System.Data;
using System.Linq;
using System.Reflection;
using InventoryManagement.Models;
using InventoryManagement.DataAccess;

namespace InventoryManagement.BusinessLogic
{
    public class SupplierLogic
    {
        ISupplierAccess _supplierAcess = new SupplierAccess();
        DataTable _supplierDataTable = new DataTable();

        public SupplierModel GetSupplierById(int id)
        {
            var suppliers = _supplierAcess.GetSupplier();
            var supplier = suppliers.Where(x => x.Id == id).FirstOrDefault();
            return supplier;
        }
        public void InserSupplier(SupplierModel supplier)
        {
            _supplierAcess.InsertSupplier(supplier);
        }

        public DataTable GetSupplier()
        {
            foreach (object obj in _supplierAcess.GetSupplier())
            {
                Type objetType = obj.GetType();
                PropertyInfo[] obectProperty = objetType.GetProperties();
                if (_supplierDataTable.Columns.Count == 0)
                {
                    foreach (PropertyInfo property in obectProperty)
                    {
                        _supplierDataTable.Columns.Add(property.Name, property.PropertyType);
                    }
                }
                DataRow row = _supplierDataTable.NewRow();
                foreach (PropertyInfo property in obectProperty)
                {
                    object value = property.GetValue(obj, null);
                    row[property.Name] = value;
                }
                _supplierDataTable.Rows.Add(row);
            }
            return _supplierDataTable;
        }

        public void UpdateSupplier(SupplierModel supplier)
        {
            _supplierAcess.UpdateSupplier(supplier);
        }

        public void DeleteSupplier(int id)
        {
            _supplierAcess.DeleteSupplier(id);
        }
    }
}
