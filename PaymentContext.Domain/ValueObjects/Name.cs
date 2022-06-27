using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
  public class Name : ValueObject
  {
    public string FirstName { get; }

    public string LastName { get; }

    public Name(string firstName, string lastName)
    {
      FirstName = firstName;
      LastName = lastName;
    }
  }
}