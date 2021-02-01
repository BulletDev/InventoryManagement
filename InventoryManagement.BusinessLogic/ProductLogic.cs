using InventoryManagement.DataAccess;
using InventoryManagement.Models;
using System;
using System.Data;
using System.Linq;
using System.Reflection;

namespace InventoryManagement.BusinessLogic
{
    public class ProductLogic
    {
        IProductAccess _productAccess = new ProductAccess();
        DataTable _productDataTable = new DataTable();

        public ProductModel GetProductById(int id)
        {
            var products = _productAccess.GetProduct();
            var product = products.Where(x => x.Id == id).FirstOrDefault();
            return product;
        }
        public void InsertProduct(ProductModel product)
        {
            _productAccess.InsertProduct(product);
        }

        public DataTable GetProduct()
        {
            foreach (object obj in _productAccess.GetProduct())
            {
                Type objetType = obj.GetType();
                PropertyInfo[] obectProperty = objetType.GetProperties();
                if(_productDataTable.Columns.Count == 0)
                {
                    foreach (PropertyInfo property in obectProperty)
                    {
                        _productDataTable.Columns.Add(property.Name, property.PropertyType);
                    }
                }
                DataRow row = _productDataTable.NewRow();
                foreach (PropertyInfo property in obectProperty)
                {
                    object value = property.GetValue(obj, null);
                    row[property.Name] = value;
                }
                _productDataTable.Rows.Add(row);
            }
            return _productDataTable;
        }

        public void UpdateProduct(ProductModel product)
        {
            _productAccess.UpdateProduct(product);
        }

        public void DeleteProduct(int id)
        {
            _productAccess.DeleteProduct(id);
        }

    }
}
