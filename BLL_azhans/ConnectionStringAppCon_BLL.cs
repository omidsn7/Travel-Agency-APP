using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL_azhans;

namespace BLL_azhans
{
    public class ConnectionStringAppCon_BLL
    {
        ConnectionStringInAppCon ConAppCon;

        public ConnectionStringAppCon_BLL()
        {
            ConAppCon = new ConnectionStringInAppCon();
        }

        public string GetConnectionString(string key)
        {
            return ConAppCon.GetConnectionString(key);
        }
        public void SaveConnectionString(string key, string value)
        {
            ConAppCon.SaveConnectionString(key , value);
        }
    }
}
