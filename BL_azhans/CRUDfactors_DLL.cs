using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_azhans;

namespace DLL_azhans
{
    public class CRUDfactors_DLL
    {
        DB_azhans db = new DB_azhans();

        public string Create(factor f)
        {
            if (!Read(f))
            {
                db.Factors.Add(f);
                db.SaveChanges();
                return "ثبت اطلاعات با موفقیت انجام شد";

            }
            else
            {
                return "اطلاعات وارد شده تکراری است.";
            }
        }
        public bool Read(factor f)
        {
            return db.Factors.Any(i => i.passengersid == f.passengersid && i.transferid == f.transferid);
        }
        public List<factor> Read(int factornum)
        {
            return db.Factors.Where(i => i.FactorNum == factornum).ToList();
        }
        public int Read(int PersonelsID, DateTime StartDate, DateTime EndDate)
        {
            return db.Factors.Where(i => i.personelsid == PersonelsID
                                    && EntityFunctions.TruncateTime(i.MakeFactorDate) >= StartDate
                                    && EntityFunctions.TruncateTime(i.MakeFactorDate) <= EndDate).ToList().Count;
        }

        public List<factor> Read()
        {
            return db.Factors.ToList();
        }

        public List<factor> Read(string passengername)
        {
            return db.Factors.Where(i => i.passengers.Name.Contains(passengername)).ToList();
        }

        public List<factor> Read(bool IsActive)
        {
            return db.Factors.Where(i => i.IsActive == IsActive).ToList();
        }
        public factor ReadId(int id)
        {
            return db.Factors.Where(i => i.id == id).Single();
        }

        public string ActiveDeActive(int id, bool abool)
        {
            factor f = new factor();
            f = ReadId(id);
            f.IsActive = abool;
            db.SaveChanges();
            return "انجام شد";
        }
    }
}
