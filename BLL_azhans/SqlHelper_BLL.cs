using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL_azhans;

namespace BLL_azhans
{
    public class SqlHelper_BLL
    {
        SqlHelper sqlHelper;
        public SqlHelper_BLL(string ConnectionString)
        {
            sqlHelper = new SqlHelper(ConnectionString);
        }

        public bool IsConnection()
        {
            if (sqlHelper.IsConnection)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
