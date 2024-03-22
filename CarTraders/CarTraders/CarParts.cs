using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTraders
{
     class CarParts
    {
        // Properties
        public string Reg_ID { get; set; }
        public string Product { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public string Compatibility { get; set; }
        public string Condition { get; set; }
        public int Stock { get; set; }
        // Property to store the image name
        public string ImageName { get; set; }

        // Constructor
        public CarParts(string reg_ID, string product, string Cate, string brand, decimal price, string compati, string Condi, int stock, string imageName)
        {
            this.Reg_ID = reg_ID;
            this.Product = product;
            this.Category = Cate;
            this.Brand = brand;
            this.Price = price;
            this.Compatibility = compati;
            this.Condition = Condi;
            this.Stock = stock;
            this.ImageName = imageName;


        }
    }
}
