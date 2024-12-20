using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_kontakty
{
    public class ContactManager
    {
        private List<IContact> contacts = new List<IContact>();

        public void AddContact(string firstName, string lastName, string phoneNumber, string email)
        {
            var contact = ContactFactory.CreateContact(firstName, lastName, phoneNumber, email);
            contacts.Add(contact);
            Console.WriteLine("Kontakt został dodany pomyślnie.");
        }

        public void EditContact(int id, string firstName, string lastName, string phoneNumber, string email)
        {
            var contact = contacts.FirstOrDefault(c => c.Id == id);
            if (contact != null)
            {
                contact.FirstName = firstName;
                contact.LastName = lastName;
                contact.PhoneNumber = phoneNumber;
                contact.Email = email;
                contact.UpdatedAt = DateTime.Now;
                Console.WriteLine("Kontakt został zaktualizowany pomyślnie.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono kontaktu o podanym ID.");
            }
        }

        public void DeleteContact(int id)
        {
            var contact = contacts.FirstOrDefault(c => c.Id == id);
            if (contact != null)
            {
                contacts.Remove(contact);
                Console.WriteLine("Kontakt został usunięty pomyślnie.");
            }
            else
            {
                Console.WriteLine("Nie znaleziono kontaktu o podanym ID.");
            }
        }

        public void SearchContacts(string query)
        {
            var results = contacts.Where(c =>
                c.FirstName.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                c.LastName.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                c.PhoneNumber.Contains(query) ||
                c.Email.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();

            if (results.Any())
            {
                Console.WriteLine("Znalezione kontakty:");
                results.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("Brak kontaktów pasujących do wyszukiwania.");
            }
        }

        public void DisplayAllContacts()
        {
            if (contacts.Any())
            {
                Console.WriteLine("Lista wszystkich kontaktów:");
                contacts.ForEach(Console.WriteLine);
            }
            else
            {
                Console.WriteLine("Brak zapisanych kontaktów.");
            }
        }

        public List<IContact> GetContacts() => contacts;
    }

}