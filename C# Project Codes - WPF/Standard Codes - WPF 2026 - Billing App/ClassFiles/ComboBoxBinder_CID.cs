using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CID_Billing_App.ClassFiles
{
    public static class ComboBoxBinder_CID
    {
        public static void BindComboBox( ComboBox comboBox, string query, string displayMember, string valueMember)
        {
            var dt = DB_Helper_CID.CIDExecuteSelect(query);
            comboBox.DataSource = dt;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }
    }
}
