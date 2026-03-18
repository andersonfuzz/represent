using represent.Entities.Shared;

namespace represent.Entities;

public class Customer : Enterprise
{
    public Customer(string companyName, string fantasy, string cnpj, string stateRegistration, Contact contact, Address address) : base(companyName, fantasy, cnpj, stateRegistration, contact, address)
    {
    }
}