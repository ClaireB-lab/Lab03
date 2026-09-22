using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    public class Product
    {
        public Product() { }
        public Product(string code, string description, decimal price)
        {
            Code = code;
            Description = description;
            Price = price;
        }
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public  virtual string GetDisplayText(string sep)
        {
            return $"{Code}{sep}{Description}{sep}{Price}";
        }
    }
}
