//Aplikacja Kontakty 

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
                Console.WriteLine("2. Edytuj kontakt");
                Console.WriteLine("3. Usuń kontakt");
                Console.WriteLine("4. Wyszukaj kontakt");
                Console.WriteLine("5. Wyświetl wszystkie kontakty");
                Console.WriteLine("6. Wyjście");
                Console.Write("Wybierz opcję: ");

                string option = Console.ReadLine();

                
             }
        }
    }
}
