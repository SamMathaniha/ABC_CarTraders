using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTraders
{
    class Cars
    {
        // Properties
        public string Reg_ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }
        public string Codition { get; set; }
        public decimal Price { get; set; }
        public string Transmission { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }

        // Property to store the image name
        public string ImageName { get; set; }

        // Constructor
        public Cars(string reg_ID, string brand, string model, int year, string color, string codition, decimal price, string trans, string descrip, int stock, string imageName)
        {
            this.Reg_ID = reg_ID;
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Colour = color;
            this.Codition = codition;
            this.Price = price;
            this.Transmission = trans;
            this.Description = descrip;
            this.Stock = stock;
            this.ImageName = imageName;
        }
    }
}
