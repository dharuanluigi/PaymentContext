using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
  public class Document : ValueObject
  {
    public string Number { get; }

    public EDocumentType Type { get; }

    public Document(string number, EDocumentType type)
    {
      Number = number;
      Type = type;
    }
  }
}