namespace represent.Entities.Shared;

public class Contact
{
    public string Phone { get; private set; } = null!;
    public string Email { get; private set; } = null!;

    protected Contact() { }

    public Contact(string phone, string email)
    {
        Validate(phone, email);
        Phone = phone;
        Email = email;

    }
    public void Update(string phone, string email)
    {
        Validate(phone, email);
        Phone = phone;
        Email = email;
    }

    private void Validate(string phone, string email)
    {
        if (string.IsNullOrWhiteSpace(phone))
        {
            throw new ArgumentException("Phone number cannot be empty.", nameof(phone));
        }

        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentException("Email cannot be empty.", nameof(email));
        }
    }
}