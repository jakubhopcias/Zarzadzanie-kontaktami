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
                
            }
        }
    }
}
