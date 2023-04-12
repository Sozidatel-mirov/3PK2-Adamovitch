using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_8
{
    abstract class ContactCLass
    {
        public string name { get; set; }
        public string Phone { get; set; }
        public abstract void GetInfo();
    }
}
