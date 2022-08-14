using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL_azhans;
using BE_azhans;

namespace BLL_azhans
{
    public class CRUDtransfers_BLL
    {
        CRUDtransfers_DAL DLL = new CRUDtransfers_DAL();

        public string Create(transfer t)
        {
            return DLL.Create(t);
        }

        public List<transfer> Read()
        {
            return DLL.Read();
        }

        public transfer Read(int id)
        {
            return DLL.Read(id);
        }
        public List<transfer> Read(transfer.transferttype transferttype)
        {
            return DLL.Read(transferttype);
        }
        public List<transfer> Read(transfer.transferttype transferttype, bool ActiveOrNot)
        {
            return DLL.Read(transferttype, ActiveOrNot);
        }
        public List<transfer> Read(transfer.transferttype transferttype, transfer.passengertype passengertype)
        {
            return DLL.Read(transferttype, passengertype);
        }

        public List<transfer> Read(transfer.transferttype transferttype, transfer.internationalflytype internationalflytype)
        {
            return DLL.Read(transferttype, internationalflytype);
        }

        public List<transfer> Read(transfer.transferttype transferttype, bool GoingAndBackOrNot,
                                    string SourceCity, string DestinationCity, DateTime Goingdate,
                                    DateTime BackingDate, transfer.passengertype passengertype,
                                    transfer.internationalflytype internationalflytype)
        {
            return DLL.Read(transferttype, GoingAndBackOrNot, SourceCity, DestinationCity, Goingdate
                            , BackingDate, passengertype, internationalflytype);
        }
        public List<transfer> ReadInternational(bool goingAndBackOrNot, string sourceContry, string destinationCountry,
                                                DateTime goingdate, DateTime backingDate, transfer.passengertype passengertype,
                                                transfer.internationalflytype internationalflytype)
        {
            return DLL.ReadInternational(goingAndBackOrNot, sourceContry, destinationCountry, goingdate 
                                         , backingDate, passengertype, internationalflytype);
        }

        public List<transfer> ReadByGoAndBack(transfer.transferttype transferttype, bool GoAndBackOrNot)
        {
            return DLL.ReadByGoAndBack(transferttype, GoAndBackOrNot);
        }

        public string Update(int id, transfer tnew)
        {
            return DLL.Update(id, tnew);
        }

        public string Delete(int id)
        {
            return DLL.Delete(id);
        }
        public string ActiveDeActive(int id, bool abool)
        {
            return DLL.ActiveDeActive(id, abool);
        }

    }
}
