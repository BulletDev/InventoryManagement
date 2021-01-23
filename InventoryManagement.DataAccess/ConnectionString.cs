using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.DataAccess
{
    class ConnectionString
    {
        public static string GetConnectionString(string name = "Inventory")
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
