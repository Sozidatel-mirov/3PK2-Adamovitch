using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_5
{
    internal class Garage
    {
        public int num { get; set; }
        public Garage(int num)
        {
            this.num = num;
        }
        public override string ToString()
        {
            return $"{num}";
        }
    }
}
