using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CID_Billing_App.ClassFiles
{
    /// <summary>
    /// GetNextTableID from DB Table for frond end use or display only
    /// </summary>
    public static class AutoIncr_CID
    {
        private static readonly string[] AllowedTables =
        {
            "Category_Details",
            "SubCategory_Details",
            "Customer_Details",
            "Dealer_Details",
            "Order_Details",
            "Order_Payments",
            "Product_Details"
        };
        public static int Auto_Incr(string Table_Name, string ID_Field_Name, int Start_Point)
        {
            int Cnt = 0;

            if (!AllowedTables.Contains(Table_Name))
                throw new ArgumentException("Invalid table name.");

            string query = $"SELECT COUNT(*) FROM [{Table_Name}]";

            object result = DB_Helper_CID.CIDExecuteScalar(query);

            Cnt = (result != DBNull.Value) ? Convert.ToInt32(result) : 0;

            if (Cnt > 0)
            {
                if (!AllowedTables.Contains(Table_Name))
                    throw new ArgumentException("Invalid table name.");

                query = $"SELECT Max([{ID_Field_Name}]) FROM [{Table_Name}]";

                result = DB_Helper_CID.CIDExecuteScalar(query);

                Cnt = (result != DBNull.Value) ? Convert.ToInt32(result) : 0;

                Cnt += 1;
            }
            else
            {
                Cnt = Start_Point;
            }

            return Cnt;
        }
    }
}
