using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_azhans
{
   public class transfer
    {
        public int id { get; set; }

        public enum transferttype
        {
            internalfly = 0,
            internationalfly = 1,
            train = 2,
            bus = 3
        }
        public transferttype Transferttype { get; set; }

        public enum internationalflytype
        {
            echonomic = 0,
            bussiness = 1,
            firstclass = 2
        }
        public internationalflytype? Internationalflytype { get; set; }
        public string Internationalflytypefarsi { get; set; }

        public bool Goingbackandforthornot { get; set; }

        public enum passengertype
        {
            adult = 0,
            kid = 1,
            baby = 2 
        }
        public passengertype Passengertype { get; set; }
        public string Passengertypefarsi { get; set; }

        public DateTime Goingdatetime { get; set; }
        public DateTime? Backingdatetime { get; set; }

        public bool IsActive { get; set; }
        public decimal price { get; set; }
        public string sorcecity { get; set; }
        public string destinationcity { get; set; }
        public string sorcecountry { get; set; }
        public string destinationcountry { get; set; }

        public int personelsId { get; set; }
        public personels personels { get; set; }

        public List<factor> factors { get; set; }
    }
}
