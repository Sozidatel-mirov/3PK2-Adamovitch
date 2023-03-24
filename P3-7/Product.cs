using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_7
{
    internal abstract class Product
    {
        public string Name = "";
        public double Price = 0;
        public abstract double GetDiscount(Client client);
    }
}
