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
         
        }

        public override string ToString()
        {
            return "";
        }
    }

}
