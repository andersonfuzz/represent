using Microsoft.AspNetCore.Mvc;
using represent.Dtos;
using represent.Services;

namespace represent.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    private readonly CustomerService _service;
    public CustomerController(CustomerService service)
    {
        _service = service;
    }

    [HttpPost]
    public ActionResult<CustomerResponseDto> Create(CreateCustomerDto dto)
    {
        var customer = _service.Create(dto);




        var response = new CustomerResponseDto(
            customer.Id,
            customer.CreatedAt,
            customer.UpdatedAt,
            customer.CompanyName,
            customer.Fantasy,
            customer.Cnpj,
            customer.StateRegistration,
            new ContactDto(
                customer.Contact.Phone,
                customer.Contact.Email
            ),
            new AddressDto(
                customer.Address.Street,
                customer.Address.Number,
                customer.Address.District,
                customer.Address.City,
                customer.Address.State,
                customer.Address.ZipCode
            )
            );

        return CreatedAtAction(nameof(Create), response);
    }
}