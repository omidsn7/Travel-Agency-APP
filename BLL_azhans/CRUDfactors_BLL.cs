using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_azhans;
using DLL_azhans;

namespace BLL_azhans
{
    public class CRUDfactors_BLL
    {
        CRUDfactors_DLL DLL = new CRUDfactors_DLL();
        public string Create(factor f)
        {
            return DLL.Create(f);
        }
        public bool Read(factor f)
        {
            return DLL.Read(f);
        }
        public List<factor> Read(int factornum)
        {
            return DLL.Read(factornum);
        }
        public int Read(int PersonelID, DateTime StartDate, DateTime EndDate)
        {
            return DLL.Read(PersonelID, StartDate, EndDate);
        }

        public List<factor> Read()
        {
            return DLL.Read();
        }

        public List<factor> Read(string passengername)
        {
            return DLL.Read(passengername);
        }

        public List<factor> Read(bool IsActive)
        {
            return DLL.Read(IsActive);
        }

        public factor ReadId(int id)
        {
            return DLL.ReadId(id);
        }

        public string ActiveDeActive(int id, bool abool)
        {
            return DLL.ActiveDeActive(id, abool);
        }
    }
}
