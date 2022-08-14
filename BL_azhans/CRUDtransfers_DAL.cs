using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_azhans;

namespace DLL_azhans
{
    public class CRUDtransfers_DAL
    {
        DB_azhans db = new DB_azhans();
        public string Create(transfer t)
        {
            db.Transfers.Add(t);
            db.SaveChanges();
            return "ثبت اطلاعات با موفقیت انجام شد";
        }

        public List<transfer> Read()
        {
            return db.Transfers.ToList();
        }

        public transfer Read(int id)
        {
            return db.Transfers.Where(i => i.id == id).Single();
        }
        public List<transfer> Read(transfer.transferttype transferttype)
        {
            return db.Transfers.Where(i => i.Transferttype == transferttype
                                        && i.IsActive == true).ToList();
        }
        public List<transfer> Read(transfer.transferttype transferttype, bool ActiveOrNot)
        {
            return db.Transfers.Where(i => i.IsActive == ActiveOrNot
                                        && i.Transferttype == transferttype).ToList();
        }
        public List<transfer> Read(transfer.transferttype transferttype, transfer.passengertype passengertype)
        {
            return db.Transfers.Where(i => i.Transferttype == transferttype
                                        && i.IsActive == true
                                        && i.Passengertype == passengertype).ToList();
        }

        public List<transfer> Read(transfer.transferttype transferttype, transfer.internationalflytype internationalflytype)
        {
            return db.Transfers.Where(i => i.Transferttype == transferttype
                                        && i.IsActive == true
                                        && i.Internationalflytype == internationalflytype).ToList();
        }

        public List<transfer> ReadByGoAndBack(transfer.transferttype transferttype, bool GoAndBackOrNot)
        {
            return db.Transfers.Where(i => i.Transferttype == transferttype
                                        && i.IsActive == true
                                        && i.Goingbackandforthornot == GoAndBackOrNot).ToList();
        }
        public List<transfer> Read(transfer.transferttype transferttype, bool goingAndBackOrNot, string sourceCity,
                                   string destinationCity, DateTime goingdate, DateTime backingDate,
                                   transfer.passengertype passengertype, transfer.internationalflytype internationalflytype)
        {
            return db.Transfers.Where(i => i.Transferttype == transferttype
                                        && i.IsActive == true
                                        && i.Goingbackandforthornot == goingAndBackOrNot
                                        && i.sorcecity.Contains(sourceCity)
                                        && i.destinationcity.Contains(destinationCity)
                                        && i.Goingdatetime == goingdate
                                        && i.Backingdatetime == backingDate
                                        && i.Passengertype == passengertype
                                        && i.Internationalflytype == internationalflytype).ToList();
        }
        public List<transfer> ReadInternational(bool goingAndBackOrNot, string sourceContry, string destinationCountry,
                                                 DateTime goingdate, DateTime backingDate, transfer.passengertype passengertype, 
                                                 transfer.internationalflytype internationalflytype)
        {
            return db.Transfers.Where(i => i.Transferttype == transfer.transferttype.internationalfly
                                        && i.IsActive == true
                                        && i.Goingbackandforthornot == goingAndBackOrNot
                                        && i.sorcecity.Contains(sourceContry)
                                        && i.destinationcity.Contains(destinationCountry)
                                        && i.Goingdatetime == goingdate
                                        && i.Backingdatetime == backingDate
                                        && i.Passengertype == passengertype
                                        && i.Internationalflytype == internationalflytype).ToList();
        }

        public string Update(int id, transfer tnew)
        {
            transfer t = new transfer();
            t = Read(id);
            t.Transferttype = tnew.Transferttype;
            t.Internationalflytype = tnew.Internationalflytype;
            t.Internationalflytypefarsi = tnew.Internationalflytypefarsi;
            t.Goingbackandforthornot = tnew.Goingbackandforthornot;
            t.Passengertype = tnew.Passengertype;
            t.Passengertypefarsi = tnew.Passengertypefarsi;
            t.sorcecity = tnew.sorcecity;
            t.sorcecountry = tnew.sorcecountry;
            t.destinationcity = tnew.destinationcity;
            t.destinationcountry = tnew.destinationcountry;
            t.Goingdatetime = tnew.Goingdatetime;
            t.Backingdatetime = tnew.Backingdatetime;
            t.price = tnew.price;
            db.SaveChanges();
            return "ویرایش اطلاعات با موفقیت انجام شد";
        }

        public string Delete(int id)
        {
            transfer t = Read(id);
            db.Transfers.Remove(t);
            db.SaveChanges();
            return "حذف اطلاعات با موفقیت انجام شد";
        }
        public string ActiveDeActive(int id, bool abool)
        {
            transfer t = new transfer();
            t = Read(id);
            t.IsActive = abool;
            db.SaveChanges();
            return "انجام شد";
        }
    }
}
