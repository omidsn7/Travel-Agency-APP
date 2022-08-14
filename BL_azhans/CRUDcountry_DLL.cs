using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_azhans;

namespace DLL_azhans
{
    public class CRUDcountry_DLL
    {
        DB_azhans db = new DB_azhans();

        public List<Countrys> Read()
        {
            return db.Countrys.ToList();
        }
    }
}
