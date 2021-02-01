using Dapper;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagement.DataAccess
{
    public class PurchaseOrderAccess
    {
        public IEnumerable GetPurchaseOrder()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString.GetConnectionString("Inventory")))
            {
                var result = connection.Query("dbo.uspGetPurchaseOrder", commandType: CommandType.StoredProcedure);
                return result;
            }
        }
    }
}
