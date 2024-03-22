using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTraders
{
     class Payments
    {
       // Properties
        public string NIC { get; set; }
        public string OrderID { get; set; }
        public string RegID { get; set; }
        public string Item { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime PaymentDate { get; set; }
        public Decimal Amount { get; set; }


        // Constructor
        public Payments(string NIC, string OrderID, string RegID, string Item, DateTime OrderDate, Decimal Amount)
        {
            this.NIC = NIC;
            this.OrderID = OrderID;
            this.RegID = RegID;
            this.Item = Item;
            this.OrderDate = OrderDate;
            this.Amount = Amount;


        }
    }

}
    