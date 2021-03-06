using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Entities;

namespace PaymentContext.Domain.Entities
{
  public class Student : Entity
  {
    private readonly IList<Subscription> _subscriptions;

    public Name Name { get; set; }

    public Document Document { get; set; }

    public Email Email { get; set; }

#pragma warning disable S2365 // Properties should not make collection or array copies
    public IReadOnlyCollection<Subscription> Subscriptions => _subscriptions.ToList();
#pragma warning restore S2365 // Properties should not make collection or array copies

    public Student(Name name, Document document, Email email)
    {
      Name = name;
      Document = document;
      Email = email;
      _subscriptions = new List<Subscription>();

      AddNotifications(name, document, email);
    }

    public void AddSubscription(Subscription subscription)
    {
      foreach (var sub in Subscriptions)
      {
        sub.Inactivate();
      }

      _subscriptions.Add(subscription);
    }
  }
}