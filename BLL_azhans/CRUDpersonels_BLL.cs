using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_azhans;
using DLL_azhans;

namespace BLL_azhans
{
    public class CRUDpersonels_BLL
    {
        CRUDpersonels_DLL dal = new CRUDpersonels_DLL();
        public string Create(personels p)
        {
            return dal.Create(p);
        }
        public List<personels> Read(string name)
        {
            return dal.Read(name);
        }
        public List<personels> Readcode(string code)
        {
            return dal.Readcode(code);
        }

        public List<personels> Read()
        {
            return dal.Read();
        }

        public List<personels> Read(bool IsActive)
        {
            return dal.Read(IsActive);
        }

        public personels Read(int id)
        {
            return dal.Read(id);
        }


        public string Update(int id, personels pnew)
        {
            return dal.Update(id, pnew);
        }
        public string ActiveDeActive(int id , bool abool)
        {
            return dal.ActiveDeActive(id, abool);
        }
        public string Delete(int id)
        {
            return dal.Delete(id);
        }
    }
}
