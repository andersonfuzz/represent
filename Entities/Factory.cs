using represent.Entities.Shared;

namespace represent.Entities;

public class Factory : Enterprise
{
    public Factory(string companyName, string fantasy, string cnpj, string stateRegistration, Contact contact, Address address) : base(companyName, fantasy, cnpj, stateRegistration, contact, address)
    {
    }
}