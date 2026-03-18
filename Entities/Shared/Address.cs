namespace represent.Entities.Shared;

public class Address
{
    public string Street { get; private set; } = null!;
    public string Number { get; private set; } = null!;
    public string District { get; private set; } = null!;
    public string City { get; private set; } = null!;
    public string State { get; private set; } = null!;
    public string ZipCode { get; private set; } = null!;

    protected Address() { }

    public Address(string street, string number, string district, string city, string state, string zipCode)
    {
        Validate(street, number, district, city, state, zipCode);
        Street = street;
        Number = number;
        District = district;
        City = city;
        State = state;
        ZipCode = zipCode;
    }
    public void Update(string street, string number, string district, string city, string state, string zipCode)
    {
        Validate(street, number, district, city, state, zipCode);
        Street = street;
        Number = number;
        District = district;
        City = city;
        State = state;
        ZipCode = zipCode;
    }
    private void Validate(string street, string number, string district, string city, string state, string zipCode)
    {
        if (string.IsNullOrWhiteSpace(street))
        {
            throw new ArgumentException("Street cannot be empty.", nameof(street));
        }

        if (string.IsNullOrWhiteSpace(number))
        {
            throw new ArgumentException("Number cannot be empty.", nameof(number));
        }

        if (string.IsNullOrWhiteSpace(district))
        {
            throw new ArgumentException("District cannot be empty.", nameof(district));
        }

        if (string.IsNullOrWhiteSpace(city))
        {
            throw new ArgumentException("City cannot be empty.", nameof(city));
        }

        if (string.IsNullOrWhiteSpace(state))
        {
            throw new ArgumentException("State cannot be empty.", nameof(state));
        }

        if (string.IsNullOrWhiteSpace(zipCode))
        {
            throw new ArgumentException("Zip code cannot be empty.", nameof(zipCode));
        }
    }
}
