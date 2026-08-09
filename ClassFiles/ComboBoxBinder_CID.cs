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
        public static void BindComboBox( ComboBox CMB, string Query, string DisplayMember, string ValueMember)
        {
            var DT = DB_Helper_CID.CIDExecuteSelect(Query);
            CMB.DataSource = DT;
            CMB.DisplayMember = DisplayMember;
            CMB.ValueMember = ValueMember;

            CMB.SelectedIndex = -1;
        }
    }
}
