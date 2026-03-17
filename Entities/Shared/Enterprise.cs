namespace represent.Entities.Shared;

public abstract class Enterprise
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string CompanyName { get; private set; }
    public string Fantasy { get; private set; } 
    public string Cnpj { get; private set; } 
    public string StateRegistration { get; private set; }
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; private set; } = DateTime.UtcNow;
    public bool IsActive { get; private set; } = true;
    public Contact Contact { get; private set; } 
    public Address Address { get; private set; } 


 public Enterprise(string companyName, string fantasy, string cnpj, string stateRegistration, Contact contact, Address address)
    {
        CompanyName = companyName;
        Fantasy = fantasy;
        Cnpj = cnpj;
        StateRegistration = stateRegistration;
        Contact = contact;
        Address = address;
    }

    public void UpdateCompanyData(string companyName, string fantasy, string cnpj, string stateRegistration)
    {
        CompanyName = companyName;
        Fantasy = fantasy;
        Cnpj = cnpj;
        StateRegistration = stateRegistration;
        UpdatedAt = DateTime.UtcNow;
    }
    public void UpdateContact(Contact contact)
    {
        Contact = contact;
        UpdatedAt = DateTime.UtcNow;
    }
    public void UpdateAddress(Address address)
    {
        Address = address;
        UpdatedAt = DateTime.UtcNow;
    }
   
    public void Deactivate()
    {
        if (IsActive)
        {
            IsActive = false;
            UpdatedAt = DateTime.UtcNow;
        }
    }
    public void Activate()
    {
        if (!IsActive)
        {
            IsActive = true;
            UpdatedAt = DateTime.UtcNow;
        }
    }
}