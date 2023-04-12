using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_9
{
    internal class Client
    {
        Adapter adapter = new Adapter();

        public void Show(char x)
        {
            adapter.ClientChar(x);
        }
        public void Show(double x)
        {
            adapter.ClientDouble(x);
        }
        public void Show(int x)
        {
            adapter.ClientInt(x);
        }
    }
}
