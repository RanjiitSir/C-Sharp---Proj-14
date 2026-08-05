using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace CID_Billing_App.ClassFiles
{
    public static class DB_Helper_CID
    {
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["AutoMobile_Stores_Inventory_App_DB"].ConnectionString;

        public static SqlConnection FCon = new SqlConnection(ConnectionString);
        public static void FCon_Start()
        {
            if (FCon.State != System.Data.ConnectionState.Open)
            {
                FCon.Open();
            }
        }

        public static void FCon_Stop()
        {
            if (FCon.State != System.Data.ConnectionState.Closed)
            {
                FCon.Close();
            }
        }

        public static DataTable CIDExecuteSelect(string Query, SqlParameter[] Parameters = null)
        {            
            SqlCommand cmd = new SqlCommand(Query, FCon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            if (Parameters != null)
                cmd.Parameters.AddRange(Parameters);

            DataTable dt = new DataTable();

            FCon_Start();
            da.Fill(dt);
            FCon_Stop();
            return dt;
        }

        public static object CIDExecuteScalar(string Query, SqlParameter[] Parameters = null)
        {
            SqlCommand cmd = new SqlCommand(Query, FCon);

            if (Parameters != null)
                cmd.Parameters.AddRange(Parameters);

            FCon_Start();
            return cmd.ExecuteScalar();
        }

        public static int CIDExecuteNonQuery(string Query, SqlParameter[] Parameters = null)
        {
            using (SqlCommand cmd = new SqlCommand(Query, FCon))
            {
                if (Parameters != null)
                    cmd.Parameters.AddRange(Parameters);

                FCon_Start();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
