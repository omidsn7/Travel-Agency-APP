using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_azhans;

namespace DLL_azhans
{
   public class personelslogin_DAL
    {
        DB_azhans db = new DB_azhans();

        public byte login(string username, string password)
        {
            if (db.Personels.Count() == 0)
            {
                return 0;
            }
            else
            {
                if (db.Personels.Any(i => i.Username == username && i.Password == password && i.IsActive == true))
                {
                    
                    return 1;
                }
                else if (db.Personels.Any(i => i.Username == username && i.Password == password && i.IsActive == false))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        public void firstUser(personels p)
        {
            db.Personels.Add(p);
        }

        public bool firstLogin()
        {
            if (db.Personels.Count() == 0)
            {
                return true;
            }
            else
                return false;
        }

        public personels Read(string username, string password)
        {
            return db.Personels.Where(i => i.Username == username && i.Password == password).Single();
        }


        //public void Register(personeslslogin p)
        //{
        //    db.Personels.Add(p);
        //    db.SaveChanges();
        //}
    }
}
