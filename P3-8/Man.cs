using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P3_8
{
    internal class Man : ContactCLass
    {
        public string Sname { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine($"Наименование: {name} Номер телефона: {Phone} Фамилия:{Sname}");
        }
    }
}
