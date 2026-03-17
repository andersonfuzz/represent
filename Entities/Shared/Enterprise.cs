namespace represent.Entities.Shared;

public abstract class Enterprise
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string CompanyName { get; private set; } = string.Empty;
    public string Fantasy { get; private set; } = string.Empty;
    public string Cnpj { get; private set; } = string.Empty;
    public string StateRegistration { get; private set; } = string.Empty;
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; private set; } = DateTime.UtcNow;
    public bool IsActive { get; private set; } = true;
    public Contact Contact { get; private set; } = new Contact();
    public Address Address { get; private set; } = new Address();


 public Enterprise(string companyName, string fantasy, string cnpj, string stateRegistration, Contact contact, Address address)
    {
        CompanyName = companyName;
        Fantasy = fantasy;
        Cnpj = cnpj;
        StateRegistration = stateRegistration;
        Contact = contact;
        Address = address;
    }

    public void Update(string companyName, string fantasy, string cnpj, string stateRegistration, Contact contact, Address address)
    {
        CompanyName = companyName;
        Fantasy = fantasy;
        Cnpj = cnpj;
        StateRegistration = stateRegistration;
        Contact = contact;
        Address = address;
        UpdatedAt = DateTime.UtcNow;
    }

    public void Deactivate()
    {
        IsActive = false;
        UpdatedAt = DateTime.UtcNow;
    }
}