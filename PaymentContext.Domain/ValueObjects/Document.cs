using PaymentContext.Domain.Enums;

namespace PaymentContext.Domain.ValueObjects
{
  public class Document
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