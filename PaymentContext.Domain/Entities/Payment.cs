using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
  public abstract class Payment
  {
    public string Number { get; set; }

    public DateTime PaidDate { get; set; }

    public DateTime ExpireDate { get; set; }

    public decimal Total { get; set; }

    public decimal TotalPaid { get; set; }

    public string OwnerPayer { get; set; }

    public Document Document { get; set; }

    public Address Address { get; set; }

    public Email Email { get; set; }

    protected Payment(DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string ownerPayer, Document document, Address address, Email email)
    {
      Number = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 10).ToUpper();
      PaidDate = paidDate;
      ExpireDate = expireDate;
      Total = total;
      TotalPaid = totalPaid;
      OwnerPayer = ownerPayer;
      Document = document;
      Address = address;
      Email = email;
    }
  }
}