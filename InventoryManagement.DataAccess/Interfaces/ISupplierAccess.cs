using System.Collections.Generic;
using InventoryManagement.Models;

namespace InventoryManagement.DataAccess
{
    public interface ISupplierAccess
    {
        void DeleteSupplier(int id);
        IEnumerable<SupplierModel> GetSupplier();
        void InsertSupplier(SupplierModel supplier);
        void UpdateSupplier(SupplierModel supplier);
    }
}