using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_azhans;

namespace DLL_azhans
{
  public class CRUDpassengers_DAL
    {
        DB_azhans db = new DB_azhans();

        public string Create(passengers p)
        {
            if (!Read(p))
            {
                    db.Passengers.Add(p);
                    db.SaveChanges();
                    return "ثبت اطلاعات با موفقیت انجام شد";
            }
            else
            {
                return "اطلاعات وارد شده تکراری است.";
            }
        }
        public bool Read(passengers p)
        {
            return db.Passengers.Any(i => i.Name == p.Name && i.Phone == p.Phone);
        }
        public List<passengers> Read()
        {
            return db.Passengers.ToList();
        }

        public List<passengers> Read(string name , int personelId)
        {
            return db.Passengers.Where(i => i.Name.Contains(name) && i.personelsId == personelId && i.IsActive == true).ToList();
        }
        public List<passengers> Readcode(int age, int personelId)
        {
            return db.Passengers.Where(i => i.Age == age && i.personelsId == personelId && i.IsActive == true).ToList();
        }

        public List<passengers> Readcode(string phone, int personelId)
        {
            return db.Passengers.Where(i => i.Phone.Contains(phone) && i.personelsId == personelId && i.IsActive == true).ToList();
        }

        public List<passengers> ReadbypersonelsId(int personelid)
        {
            DB_azhans db1 = new DB_azhans();
            return db1.Passengers.Where(i => i.personelsId == personelid && i.IsActive == true).ToList();
        }

        public passengers Read(int id)
        {
            return db.Passengers.Where(i => i.id == id).Single();
        }

        public string Update(int id, passengers pnew)
        {
            passengers p = new passengers();
            p = Read(id);
            p.Name = pnew.Name;
            p.Phone = pnew.Phone;
            p.Age = pnew.Age;
            db.SaveChanges();
            return "ویرایش اطلاعات با موفقیت انجام شد";
        }

        public string Delete(int id)
        {
            passengers p = Read(id);
            db.Passengers.Remove(p);
            db.SaveChanges();
            return "حذف اطلاعات با موفقیت انجام شد";
        }
        public string ActiveDeActive(int id, bool abool)
        {
            passengers p = new passengers();
            p = Read(id);
            p.IsActive = abool;
            db.SaveChanges();
            return "انجام شد";
        }
    }
}

