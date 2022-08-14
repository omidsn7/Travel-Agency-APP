using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_azhans
{
    public class personels
    {
        public int id { get; set; }

        public string Username { get; set; }

        public string name { get; set; }

        public string code { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        public List<passengers> passengers { get; set; }

        public List<transfer> transfers { get; set; }

        public List<factor> factors { get; set; }

        public enum personelstype
        {
            Admin = 0,
            Manager = 1,
            Employee = 2
        }

        public personelstype Personelstype { get; set; }

    }
}
