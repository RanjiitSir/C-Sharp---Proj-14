using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CID_Billing_App.ClassFiles
{
    public static class GridBinder_CID
    {
        public static void BindGrid(DataGridView dgv, string query)
        {
            dgv.DataSource = DB_Helper_CID.CIDExecuteSelect(query);
        }
    }
}
