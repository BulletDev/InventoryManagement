using InventoryManagement.DataAccess;
using System.Data;
using System;
using System.Reflection;
using InventoryManagement.Models;
using System.Linq;

namespace InventoryManagement.BusinessLogic
{
    public class CustomerLogic
    {
        ICustomerAccess _customerAccess = new CustomerAccess();
        DataTable _customerDataTable = new DataTable();

        public void InsertCustomer(CustomerModel customer)
        {
            _customerAccess.InsertCustomer(customer);
        }

        public CustomerModel GetCustomerById(int id)
        {
            var customers = _customerAccess.GetCustomer();
            var customer = customers.Where(x => x.Id == id).FirstOrDefault();
            return customer;
        }

        public DataTable GetCustomer()
        {
            foreach (object obj in _customerAccess.GetCustomer())
            {
                Type objectType = obj.GetType();
                PropertyInfo[] objectProperty = objectType.GetProperties();
                if (_customerDataTable.Columns.Count == 0)
                {
                    foreach (PropertyInfo property in objectProperty)
                    {
                        _customerDataTable.Columns.Add(property.Name, property.PropertyType);
                    }
                }
                DataRow row = _customerDataTable.NewRow();
                foreach (PropertyInfo property in objectProperty)
                {
                    object value = property.GetValue(obj, null);
                    row[property.Name] = value;
                }
                _customerDataTable.Rows.Add(row);
            }
            return _customerDataTable;
        }

        public void UpdateCustomer(CustomerModel customer)
        {
            _customerAccess.UpdateCustomer(customer);
        }

        public void DeleteCustomer(int Id) {
            _customerAccess.DeleteCustomer(Id);
        }

        public string GenerateCustomerId()
        {
            string customerId = "CUST-000000";
            int customerCount = _customerAccess.CountCustomer() + 1;
            customerId = string.Format("CUST-{0}", customerCount.ToString("D6"));
            return customerId;
        }

    }
}   
