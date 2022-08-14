using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_azhans;
using DLL_azhans;

namespace BLL_azhans
{
   public class CRUDpassengers_BLL
    {
        CRUDpassengers_DAL dal = new CRUDpassengers_DAL();
        public string Create(passengers p)
        {
            return dal.Create(p);
        }
        public List<passengers> Read(string name , int personelsId)
        {
            return dal.Read(name, personelsId);
        }
        public List<passengers> Readcode(int age, int personelsId)
        {
            return dal.Readcode(age , personelsId);
        }
        public List<passengers> Readcode(string phone, int personelsId)
        {
            return dal.Readcode(phone, personelsId);
        }

        public List<passengers> ReadbypersonelsId(int personelId)
        {
            return dal.ReadbypersonelsId(personelId);
        }

        public passengers Read(int id)
        {
            return dal.Read(id);
        }

        public string Update(int id, passengers pnew)
        {
            return dal.Update(id, pnew);
        }
        public string Delete(int id)
        {
            return dal.Delete(id);
        }
        public string ActiveDeActive(int id, bool abool)
        {
            return dal.ActiveDeActive(id, abool);
        }

    }
}

