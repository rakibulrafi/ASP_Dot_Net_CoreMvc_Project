using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementWithADO.Utility
{
    public class ConnectionString
    {
        private static string cName = "Data Source=DESKTOP-VTPQ9MQ;Initial Catalog=StudentManagement;User ID=rakibul;Password=123456";
        public static string CName { get => cName; }
    }
}
