using Flunt.Notifications;

namespace PaymentContext.Shared.Entities
{
  public abstract class Entity : Notifiable<Notification>
  {
    public Guid Id { get; }

    protected Entity()
    {
      Id = Guid.NewGuid();
    }
  }
}