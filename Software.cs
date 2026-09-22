using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace Lab03
{
    public class Software : Product
    {
        public Software() { }
        public Software(string code, string description, decimal price, string company) : base(code, description, price)
        {
            this.Company = company;
        }
        public string Company {  get; set; }
        public override string GetDisplayText(string sep)
        {
            return base.GetDisplayText(sep) + sep + Company;
        }

    }
}
