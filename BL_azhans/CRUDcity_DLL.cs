using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_azhans;

namespace DLL_azhans
{
    public class CRUDcity_DLL
    {
        DB_azhans db = new DB_azhans();

        public List<Citys> Read()
        {
            return db.Citys.ToList();
        }
    }
}
