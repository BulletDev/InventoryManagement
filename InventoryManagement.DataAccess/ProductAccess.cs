using System.Collections.Generic;
using Dapper;
using System.Data;
using InventoryManagement.Models;
using System.Data.SqlClient;

namespace InventoryManagement.DataAccess
{
    public class ProductAccess : IProductAccess
    {
        public IEnumerable<ProductModel> GetProduct()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.GetConnectionString("Inventory")))
            {
                var result = connection.Query<ProductModel>("dbo.uspGetProduct", commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public void InsertProduct(ProductModel product)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.GetConnectionString("Inventory")))
            {
                connection.Execute("dbo.uspInsertProduct @PartNumber, @Name, @Description, @Price, @Class, @CreatedAt, @CreatedBy", product);
            }
        }

        public void UpdateProduct(ProductModel product)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.GetConnectionString("Inventory")))
            {
                connection.Execute("dbo.uspUpdateProduct @Id, @PartNumber, @Name, @Description, @Price, @Class, @UpdatedAt, @UpdatedBy", product);
            }
        }

        public void DeleteProduct(int id)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.GetConnectionString("Inventory")))
            {
                connection.Execute("dbo.uspDeleteProduct @Id", new { Id = id });
            }
        }
    }
}
