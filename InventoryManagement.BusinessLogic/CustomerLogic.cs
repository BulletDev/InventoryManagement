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
        DataTable customerDataTable = new DataTable();

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
                Type t = obj.GetType();
                PropertyInfo[] pis = t.GetProperties();
                
                if (customerDataTable.Columns.Count == 0)
                {
                    foreach (PropertyInfo pi in pis)
                    {
                        customerDataTable.Columns.Add(pi.Name, pi.PropertyType);
                    }
                }

                DataRow dr = customerDataTable.NewRow();
                foreach (PropertyInfo pi in pis)
                {
                    object value = pi.GetValue(obj, null);
                    dr[pi.Name] = value;
                }
                customerDataTable.Rows.Add(dr);
            }
            return customerDataTable;
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
