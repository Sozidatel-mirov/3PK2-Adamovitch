using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_8
{
    internal class ContactCreator
    {
        public static ContactCLass CreateContact(string cont)
        {
            switch (cont)
            {
                case "Man":
                    return new Man();
                case "Organization":
                    return new Organization();
                case "Hotel":
                    return new Hotel();
                default:
                    throw new ArgumentException($"Неизвестный контакт {cont}");
            }
        }
    }
}
