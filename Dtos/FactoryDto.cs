namespace represent.Dtos;

public record CreateFactoryDto(string CompanyName,string Fantasy,string Cnpj,string StateRegistration,ContactDto Contact,AddressDto Address);
public record UpdateFactoryDto(string CompanyName,string Fantasy,string Cnpj,string StateRegistration,ContactDto Contact,AddressDto Address);
public record FactoryResponseDto(Guid Id,DateTime CreatedAt,DateTime UpdatedAt, string CompanyName, string Fantasy, string Cnpj, string StateRegistration, ContactDto Contact, AddressDto Address);
