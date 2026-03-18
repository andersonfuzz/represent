using represent.Dtos;
using represent.Entities;
using represent.Entities.Shared;

namespace represent.Services;

public class CustomerService
{
    public Customer Create(CreateCustomerDto dto)
    {
        ArgumentNullException.ThrowIfNull(dto);
        ArgumentNullException.ThrowIfNull(dto.Contact);
        ArgumentNullException.ThrowIfNull(dto.Address);
        
        var contact = new Contact(dto.Contact.Phone, dto.Contact.Email);
        var address = new Address(dto.Address.Street, dto.Address.Number, dto.Address.District, dto.Address.City, dto.Address.State, dto.Address.ZipCode);
        var customer = new Customer(dto.CompanyName, dto.Fantasy, dto.Cnpj, dto.StateRegistration, contact, address);
        return customer;
    }
}