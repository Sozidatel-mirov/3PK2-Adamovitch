using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_8
{
    internal class ContactBook
    {
        private List<ContactCLass> contacts = new List<ContactCLass>();

        public void AddContact(string cont, string name, string phone, string p)
        {
            ContactCLass contact = ContactCreator.CreateContact(cont);
            contact.name = name;
            contact.Phone = phone;

            switch (cont)
            {
                case "Man":
                    ((dynamic)contact).Sname = p;
                    break;
                case "Organization":
                    ((dynamic)contact).INN = p;
                    break;
                case "Hotel":
                    ((dynamic)contact).adress = p;
                    break;
                default:
                    throw new ArgumentException($"Неизвестный контакт {cont}");
            }

            contacts.Add(contact);
        }

        public void ShowContacts()
        {
            foreach (ContactCLass contact in contacts)
            {
                contact.GetInfo();
                Console.WriteLine();
            }
        }
    }
}
