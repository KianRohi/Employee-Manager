using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1.Data
{
    class clsGlobal
    {
        public static DataSet mySet;
        public static SqlConnection myCon;
        public static SqlDataAdapter adpBranches, adpEmployees, adpClients, adpHouses, adpHouseFeatures;
        public static SqlCommand myCmd;
        public static DataRow currentUser;
        public static DataTable myTable;
    }
}
