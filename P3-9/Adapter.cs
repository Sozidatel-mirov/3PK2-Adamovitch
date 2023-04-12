using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_9
{
    internal class Adapter : Origin
    {
        public void ClientDouble(double x)
        {
            base.OriginDouble(x);
        }
        public void ClientInt(int x)
        {
            base.OriginInt(x * 2);
        }
        public void ClientChar(char x)
        {
            for (int i = 0; i < 5; i++) base.OriginChar(x);
        }
    }
}
