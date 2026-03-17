namespace represent.Entities.Shared;
public class Contact
{
    public string Phone { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;

    public Contact() { }

    public Contact(string phone, string email)
    {
        Phone = phone;
        Email = email;
    }
}