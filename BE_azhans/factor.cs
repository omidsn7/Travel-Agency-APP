using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_azhans
{
    public class factor
    {
        public int id { get; set; }

        public int FactorNum { get; set; }

        public DateTime MakeFactorDate { get; set; }

        public int? personelsid { get; set; }
        public personels personels { get; set; }

        public string personelname { get; set; }

        public int? passengersid { get; set; }
        public passengers passengers { get; set; }
        public string passengername { get; set; }

        public int? transferid { get; set; }
        public transfer transfer { get; set; }

        public bool IsActive { get; set; }

    }
}
