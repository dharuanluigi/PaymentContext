namespace PaymentContext.Domain.Entities
{
  public class Subscription
  {
    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

    public DateTime? ExpireDate { get; set; }

    public bool IsActive { get; set; }

    public IList<Payment> Payments { get; set; }
  }
}