namespace Aplikacja_kontakty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactManager contactManager = new ContactManager();

            while (true)
            {
                Console.WriteLine("\n--- Aplikacja do Zarządzania Kontaktami ---");
                Console.WriteLine("1. Dodaj kontakt");
                Console.WriteLine("6. Wyjście");
                Console.Write("Wybierz opcję: ");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Write("Imię: ");
                        string firstName = Console.ReadLine();
                        Console.Write("Nazwisko: ");
                        string lastName = Console.ReadLine();
                        Console.Write("Numer telefonu: ");
                        string phoneNumber = Console.ReadLine();
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        contactManager.AddContact(firstName, lastName, phoneNumber, email);
                        break;

                    case "2":
                        Console.Write("Podaj ID kontaktu do edycji: ");
                        int editId = int.Parse(Console.ReadLine());
                        Console.Write("Nowe imię: ");
                        string newFirstName = Console.ReadLine();
                        Console.Write("Nowe nazwisko: ");
                        string newLastName = Console.ReadLine();
                        Console.Write("Nowy numer telefonu: ");
                        string newPhoneNumber = Console.ReadLine();
                        Console.Write("Nowy email: ");
                        string newEmail = Console.ReadLine();
                        contactManager.EditContact(editId, newFirstName, newLastName, newPhoneNumber, newEmail);
                        break;

                    case "3":
                        Console.Write("Podaj ID kontaktu do usunięcia: ");
                        int deleteId = int.Parse(Console.ReadLine());
                        contactManager.DeleteContact(deleteId);
                        break;

                    case "4":
                        Console.Write("Wprowadź frazę wyszukiwania: ");
                        string query = Console.ReadLine();
                        contactManager.SearchContacts(query);
                        break;

                    case "5":
                        contactManager.DisplayAllContacts();
                        break;

                    case "6":
                        Console.WriteLine("Dziękujemy za korzystanie z aplikacji!");
                        return;

                    default:
                        Console.WriteLine("Nieprawidłowa opcja. Spróbuj ponownie.");
                        break;
                }
            }
        }
    }
}
