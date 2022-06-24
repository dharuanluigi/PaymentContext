namespace PaymentContext.Domain.Entities
{
  public class Subscription
  {
    private readonly IList<Payment> _payments;

    public DateTime CreatedDate { get; }

    public DateTime UpdatedDate { get; private set; }

    public DateTime? ExpireDate { get; private set; }

    public bool IsActive { get; private set; }

#pragma warning disable S2365 // Properties should not make collection or array copies
    public IReadOnlyCollection<Payment> Payments => _payments.ToList();
#pragma warning restore S2365 // Properties should not make collection or array copies

    public Subscription(DateTime? expireDate)
    {
      CreatedDate = DateTime.UtcNow;
      UpdatedDate = DateTime.UtcNow;
      ExpireDate = expireDate;
      IsActive = true;
      _payments = new List<Payment>();
    }

    public void AddPayment(Payment payment)
    {
      _payments.Add(payment);
    }

    public void Activate()
    {
      IsActive = true;
      UpdatedDate = DateTime.UtcNow;
    }

    public void Inactivate()
    {
      IsActive = false;
      UpdatedDate = DateTime.UtcNow;
    }
  }
}