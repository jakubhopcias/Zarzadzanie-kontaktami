namespace Aplikacja_kontakty
{
    public interface IContact
    {
        int Id { get; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string Email { get; set; }
        DateTime CreatedAt { get; }
        DateTime UpdatedAt { get; set; }
    }
}