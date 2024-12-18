using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_kontakty
{
    public class Contact : IContact
    {
        public int Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; }
        public DateTime UpdatedAt { get; set; }

        public Contact(int id, string firstName, string lastName, string phoneNumber, string email)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Imię: {FirstName}, Nazwisko: {LastName}, Telefon: {PhoneNumber}, Email: {Email}, " +
                   $"Data utworzenia: {CreatedAt}, Data edycji: {UpdatedAt}";
        }
    }

}
