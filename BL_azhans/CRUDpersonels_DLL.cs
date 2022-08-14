using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_azhans;

namespace DLL_azhans
{
    public class CRUDpersonels_DLL
    {
        DB_azhans db = new DB_azhans();

        public string Create(personels p)
        {
            if (!Read(p))
            {
                if (p.code.Length == 10)
                {
                    db.Personels.Add(p);
                    db.SaveChanges();
                    return "ثبت اطلاعات با موفقیت انجام شد";
                }
                else
                {
                    return "کد ملی نامعتبر است";
                }

            }
            else
            {
                return "اطلاعات وارد شده تکراری است.";
            }
        }
        public bool Read(personels p)
        {
            return db.Personels.Any(i => i.name == p.name && i.code == p.code);
        }

        public List<personels> Read(string name)
        {
            return db.Personels.Where(i => i.name.Contains(name)).ToList();
        }

        public List<personels> Readcode(string code)
        {
            return db.Personels.Where(i => i.code.Contains(code)).ToList();
        }

        public List<personels> Read()
        {
            DB_azhans db1 = new DB_azhans();
            return db1.Personels.ToList();
        }
        public List<personels> Read(bool IsActive)
        {
            DB_azhans db1 = new DB_azhans();
            return db1.Personels.Where(i => i.IsActive == IsActive).ToList();
        }


        public personels Read(int id)
        {
            return db.Personels.Where(i => i.id == id).Single();
        }

        public string Update(int id, personels pnew)
        {
            personels p = new personels();
            p = Read(id);
            p.Username = pnew.Username;
            p.name = pnew.name;
            p.code = pnew.code;
            p.Password = pnew.Password;
            p.Personelstype = pnew.Personelstype;
            db.SaveChanges();
            return "ویرایش اطلاعات با موفقیت انجام شد";
        }

        public string ActiveDeActive(int id, bool abool)
        {
            personels p = new personels();
            p = Read(id);
            p.IsActive = abool;
            db.SaveChanges();
            return "انجام شد";
        }

        public string Delete(int id)
        {
            personels p = Read(id);
            db.Personels.Remove(p);
            db.SaveChanges();
            return "حذف اطلاعات با موفقیت انجام شد";
        }
    }
}
