using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DLL_azhans
{
    public class SqlHelper
    {
        SqlConnection azhans;

        public SqlHelper(string Connectionstring)
        {
            azhans = new SqlConnection(Connectionstring);
        }

        public bool IsConnection
        {
            get
            {
                if (azhans.State == System.Data.ConnectionState.Closed)
                    azhans.Open();
                return true;
            }
        }
    }
}
