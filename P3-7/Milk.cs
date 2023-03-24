using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P3_7
{
    internal class Milk : Product
    {
        public string freshness { get; set; }
        public override double GetDiscount(Client client)
        {
            if (client.AllPurshares > 1000 && client.AllPurshares < 5000) return Price * 0.85;
            else if (client.AllPurshares < 1000) return Price;
            else return Price * 0.65;
        }
        public override string ToString()
        {
            return $"{Name} freshness: {freshness}";
        }
    }
}
