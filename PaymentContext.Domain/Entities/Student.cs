namespace PaymentContext.Domain.Entities
{
  public class Student
  {
    private readonly IList<Subscription> _subscriptions;

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string Document { get; set; }

    public string Email { get; set; }

#pragma warning disable S2365 // Properties should not make collection or array copies
    public IReadOnlyCollection<Subscription> Subscriptions => _subscriptions.ToList();
#pragma warning restore S2365 // Properties should not make collection or array copies

    public Student(string firstName, string lastName, string document, string email)
    {
      FirstName = firstName;
      LastName = lastName;
      Document = document;
      Email = email;
      _subscriptions = new List<Subscription>();
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