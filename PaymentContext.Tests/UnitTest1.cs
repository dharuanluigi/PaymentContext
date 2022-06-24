using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests;

[TestClass]
public class UnitTest1
{
  [TestMethod]
  public void TestMethod1()
  {
    var subscription = new Subscription(null);
    var student = new Student("Dharuan", "Emina", "1234567890", "email@email.com");
    student.AddSubscription(subscription);
  }
}