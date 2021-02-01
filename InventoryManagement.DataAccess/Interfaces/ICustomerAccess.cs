using System.Collections.Generic;
using InventoryManagement.Models;

namespace InventoryManagement.DataAccess
{
    public interface ICustomerAccess
    {
        int CountCustomer();
        void DeleteCustomer(int id);
        IEnumerable<CustomerModel> GetCustomer();
        void InsertCustomer(CustomerModel customer);
        //void InsertCustomer(string CustomerId, string FirstName, string LastName, string Address, string ContactNumber, string EmailAddress, DateTime CreatedAt, int CreatedBy);
        void UpdateCustomer(CustomerModel customer);
    }
}