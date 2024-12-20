using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_kontakty
{
    public static class ContactFactory
    {
        private static int nextId = 1;

        public static IContact CreateContact(string firstName, string lastName, string phoneNumber, string email)
        {
            return new Contact(nextId++, firstName, lastName, phoneNumber, email);
        }
    }
}