using Dapper;
using InventoryManagement.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagement.DataAccess
{
    public class SupplierAccess : ISupplierAccess
    {
        public IEnumerable<SupplierModel> GetSupplier()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.GetConnectionString("Inventory")))
            {
                var result = connection.Query<SupplierModel>("dbo.uspGetSupplier", commandType: CommandType.StoredProcedure);
                return result;
            }
        }
        public void InsertSupplier(SupplierModel supplier)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.GetConnectionString("Inventory")))
            {
                connection.Execute("dbo.uspInsertSupplier @SupplierId, @Company, @Address, @ContactPerson, @ContactNumber, @EmailAddress, @CreatedAt, @CreatedBy", supplier);
            }
        }
        public void UpdateSupplier(SupplierModel supplier)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.GetConnectionString("Inventory")))
            {
                connection.Execute("dbo.uspUpdateSupplier @Id, @SupplierId, @Company, @Address, @ContactPerson, @ContactNumber, @EmailAddress,  @UpdatedAt, @UpdatedBy", supplier);
            }
        }
        public void DeleteSupplier(int id)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.GetConnectionString("Inventory")))
            {
                connection.Execute("dbo.uspDeleteSupplier @Id", new { Id = id });
            }
        }
    }
}
