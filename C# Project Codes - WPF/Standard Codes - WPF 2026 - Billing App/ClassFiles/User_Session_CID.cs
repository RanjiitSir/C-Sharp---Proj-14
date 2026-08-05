using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CID_Billing_App.ClassFiles
{
    public static class User_Session_CID
    {
        public static int MobNo { get; set; }
        public static int UserRole { get; set; }
        public static int OrderID { get; set; }
        public static int Cust_Bill_ID { get; set; }
        public static string LoggedInUName { get; set; } = string.Empty;
    }
}
