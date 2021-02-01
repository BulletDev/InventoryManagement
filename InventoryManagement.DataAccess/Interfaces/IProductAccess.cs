using System.Collections.Generic;
using InventoryManagement.Models;

namespace InventoryManagement.DataAccess
{
    public interface IProductAccess
    {
        void DeleteProduct(int id);
        IEnumerable<ProductModel> GetProduct();
        void InsertProduct(ProductModel product);
        void UpdateProduct(ProductModel product);
    }
}