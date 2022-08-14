using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_azhans;
using DLL_azhans;

namespace BLL_azhans
{
  public class personelslogin_BLL
    {
        personelslogin_DAL dal = new personelslogin_DAL();

        public byte Login(string username, string password)
        {
            return dal.login(username, password);
        }

        public bool firstLogin()
        {
            return dal.firstLogin();
        }
        public void firstUser(personels p)
        {
            dal.firstUser(p);
        }

        public personels Read(string username, string password)
        {
            return dal.Read(username, password);
        }

        //public void Register(personeslslogin p)
        //{
        //    dal.Register(p);
        //}
    }
}
