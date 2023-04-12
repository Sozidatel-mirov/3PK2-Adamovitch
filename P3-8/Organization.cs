using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_8
{
    internal class Organization : ContactCLass
    {
        public string INN { get; set; }
        public override void GetInfo()
        {
            Console.WriteLine($"Наименование: {name} Номер телефона: {Phone} INN:{INN}");
        }
    }
}
