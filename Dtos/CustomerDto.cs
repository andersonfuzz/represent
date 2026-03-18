//using represent.Dtos.Shared;
namespace represent.Dtos;

public record CreateCustomerDto(string CompanyName, string Fantasy, string Cnpj, string StateRegistration, ContactDto Contact, AddressDto Address);
public record UpdateCustomerDto(string CompanyName, string Fantasy, string Cnpj, string StateRegistration, ContactDto Contact, AddressDto Address);
public record CustomerResponseDto(Guid Id,DateTime CreatedAt,DateTime UpdatedAt, string CompanyName, string Fantasy, string Cnpj, string StateRegistration, ContactDto Contact, AddressDto Address);