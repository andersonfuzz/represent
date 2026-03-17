namespace represent.Entities.Shared;
public class Address
{
     public string Street { get; private set; } =null!;
    public string Number { get; private set; } = null!;
    public string District { get; private set; } = null!;
    public string City { get; private set; } = null!;
    public string State { get; private set; } = null!;
    public string ZipCode { get; private set; } = null!;

    protected Address() { }

    public Address(string street, string number, string district, string city, string state, string zipCode)
    {
        Street = street;
        Number = number;
        District = district;
        City = city;
        State = state;
        ZipCode = zipCode;
    }
    public void Update(string street, string number, string district, string city, string state, string zipCode)
    {
        Street = street;
        Number = number;
        District = district;
        City = city;
        State = state;
        ZipCode = zipCode;
        }
}
