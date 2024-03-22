using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTraders
{
    class Orders
    {
        // Properties
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string RegID { get; set; }
        public string Item { get; set; }
        public string Type { get; set; }
        public Decimal Price { get; set; }
        public string ImageName { get; set; }
        public string PaymentStatus { get; set; }
        public string DeliveryStatus { get; set; }

        // Constructor
        public Orders(int orderID, DateTime orderDate, string regID, string item, string type, Decimal price, string imageName, string paymentStatus, string deliveryStatus)
        {
            this.OrderID = orderID;
            this.OrderDate = orderDate;
            this.RegID = regID;
            this.Item = item;
            this.Type = type;
            this.Price = price;
            this.ImageName = imageName;
            this.PaymentStatus = paymentStatus;
            this.DeliveryStatus = deliveryStatus;
        }
    }

}