using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTraders
{
	class Register()
	{
		public string Name { get; set; }
	 
	    public string NIC { get; set; }

	    public string PhoneNo { get; set; }

	    public string Address { get; set; }
	  
	    public string password { get; set; }
	 
	    public string userType { get; set; }


       public Register(string name, string nic, string phnNo, string Ads, string pwd, string type)
       {

           this.Name = name;
	       this.NIC = nic;
		   this.PhoneNo = phnNo;
		   this.Address = Ads;
		   this.password = pwd;
	   	   this.userType = type;

       }

     }  
}
