using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BE_azhans;

namespace DLL_azhans
{
    public class DB_azhans : DbContext
    {
        public DB_azhans() : base("name=azhans") { }

        public DbSet<personels> Personels { get; set; }
        public DbSet<transfer> Transfers { get; set; }
        public DbSet<passengers> Passengers { get; set; }
        public DbSet<factor> Factors { get; set; }
        public DbSet<Citys> Citys { get; set; }
        public DbSet<Countrys> Countrys { get; set; }

    }
}
