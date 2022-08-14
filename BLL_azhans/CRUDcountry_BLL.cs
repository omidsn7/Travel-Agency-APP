using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_azhans;
using DLL_azhans;

namespace BLL_azhans
{
    public class CRUDcountry_BLL
    {
        CRUDcountry_DLL dLL = new CRUDcountry_DLL();

        public List<Countrys> Read()
        {
            return dLL.Read();
        }
    }
}
