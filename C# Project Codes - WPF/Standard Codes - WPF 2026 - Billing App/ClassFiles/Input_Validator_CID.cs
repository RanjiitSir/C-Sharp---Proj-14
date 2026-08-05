using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CID_Billing_App.ClassFiles
{
    public static class Input_Validator_CID
    {
        public static void AllowOnlyNumeric(KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        public static void AllowOnlyText(KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) &&
                        !char.IsLetter(e.KeyChar) &&
                        e.KeyChar != ' ';
        }

        public static void AllowAlphaNumeric(KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) &&
                        !char.IsLetterOrDigit(e.KeyChar) &&
                        e.KeyChar != ' ';
        }
    }
}
