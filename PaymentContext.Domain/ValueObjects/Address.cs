namespace PaymentContext.Domain.ValueObjects
{
  public class Address
  {
    public string Country { get; }
    public string State { get; }
    public string City { get; }
    public string Neighborhood { get; }
    public string Street { get; }
    public string Number { get; }

    public Address(string country, string state, string city, string neighborhood, string street, string number)
    {
      Country = country;
      State = state;
      City = city;
      Neighborhood = neighborhood;
      Street = street;
      Number = number;
    }
  }
}