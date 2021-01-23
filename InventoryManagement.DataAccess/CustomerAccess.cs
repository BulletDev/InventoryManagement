using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using InventoryManagement.Models;

namespace InventoryManagement.DataAccess
{
    public class CustomerAccess : ICustomerAccess
    { 
        public IEnumerable<CustomerModel> GetCustomer()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.GetConnectionString("Inventory")))
            {
                var result = connection.Query<CustomerModel>("dbo.uspGetCustomer", commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public void InsertCustomer(CustomerModel customer)
        {
            //string CustomerId, string FirstName, string LastName, string Address, string ContactNumber, string EmailAddress, DateTime CreatedAt, int CreatedBy
            using (IDbConnection connection = new SqlConnection(ConnectionString.GetConnectionString("Inventory")))
            {
                //connection.Execute("dbo.uspInsertCustomer @CustomerId, @FirstName, @LastName, @Address, @ContactNumber, @EmailAddress, @CreatedAt, @CreatedBy", new {CustomerId, FirstName, LastName, Address, ContactNumber, EmailAddress, CreatedAt, CreatedBy});
                connection.Execute("dbo.uspInsertCustomer", customer);
            }
        }

        public void UpdateCustomer(CustomerModel customer)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.GetConnectionString("Inventory")))
            {
                connection.Execute("dbo.uspUpdateCustomer @Id, @CustomerId, @FirstName, @LastName, @Address, @ContactNumber, @EmailAddress, @UpdatedAt, @UpdatedBy", customer);
            }
        }

        public void DeleteCustomer(int id)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.GetConnectionString("Inventory")))
            {
                connection.Execute("dbo.uspDeleteCustomer @Id", new { Id = id });
            }
        }

        public int CountCustomer()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.GetConnectionString("Inventory")))
            {
                var count = connection.ExecuteScalar<int>("SELECT COUNT(*) AS CustomerCount FROM dbo.Customer");
                return count;
            }
        }
    }
}
