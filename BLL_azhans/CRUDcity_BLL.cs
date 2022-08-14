using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_azhans;
using DLL_azhans;

namespace BLL_azhans
{
    public class CRUDcity_BLL
    {
        CRUDcity_DLL dLL = new CRUDcity_DLL();

        public List<Citys> Read()
        {
            return dLL.Read();
        }

    }
}
