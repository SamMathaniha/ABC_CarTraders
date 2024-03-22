using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTraders
{
     class SystemUsers
    {
        //Properties
        public long NIC { get; set; }
        public string Name { get; set; }
        public int PhoneNo { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }


        // Creating Constructor
        public SystemUsers(long nic, string name, int phnNo, string ads, string pwd)
        {
            this.NIC = nic;
            this.Name = name;
            this.PhoneNo = phnNo;
            this.Address = ads;
            this.Password = pwd;
         
        }
    }
}
