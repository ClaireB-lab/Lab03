using System;
using System.Collections.Generic;
using System.Text;

namespace Lab03
{
    public class Book : Product
    {
        public string Author { get; set; }
        public Book() { }
        public Book(string code, string description, decimal price, string author) : base(code, description, price)
        {
            Author = author;
        }
        public override string GetDisplayText(string sep)  
        {
            return base.GetDisplayText(sep) + sep + Author;
        }
    }
}
